using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using BoletoGml.Classes;

namespace BoletoGml.Security
{
    public partial class menu_boleto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["IsLogado"]) == false)
            {
                Response.Redirect("../Security/admin.aspx");

            }
            
            lblUsuarioLogado.Text = Usuario.NomeMorador;

           
        }

        protected void btnVerificarBoletos_Click(object sender, EventArgs e)
        {
            CarregarGridLateral();
        }

        protected void btnUsuario_Click(object sender, EventArgs e)
        {
            Boolean Ativo = Usuario.DeslogarUsuario();
            if (Ativo == true)
            {
                Response.Redirect("../Security/admin.aspx");
                Session.Add("Islogado", false);
            }
            else
            {

            }
        }

        protected void btnGerarBoleto_Click(object sender, EventArgs e)
        {
            //Response.Redirect("../Security/boletogerado.aspx");
            ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "Mensagem", "javascript:window.open('boletogerado.aspx', null,'width=500,height=500,menubar=no,status=1');", true);
            //ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "Mensagem", "document.getElementById('posiciona').style.display = 'none'", true);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CarregarGridListarBoletos();
        }

        protected void btnGerarSegVia_Click(object sender, EventArgs e)
        {
            int Pago = BoletoDAL.VerificarPagos();

            if (Pago == 0)
            {

                Response.Redirect("../Security/boletohtmlsegundavia.aspx");


            }
            if(Pago == 1)
            {
                //ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "mensagem", "javascript:windoalert('voce ja tem uma fatura em aberto, Clique em no botão 'Gerar Boleto' para imprimir novamente')", true);
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "mensagem", "javascript:alert('VOCÊ JA TEM UMA FATURA EM ABERTO, DENTRO DO PRAZO DE VENCIMENTO, POR FAVOR CLIQUE EM , GERAR BOLETO, PARA IMPRIMIR NOVAMENTE',width=100)", true);
            }
            if (Pago == 2)
            {
                Response.Redirect("../Security/boletohtmlsegundavia.aspx");
            
            }
        }

        protected void GridLateral_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridLateral.SelectedRow;

            int Indice = row.RowIndex;

           Usuario.NumDocumento = row.Cells[0].Text;
           Usuario.EmissaoBoleto = row.Cells[1].Text;
           Usuario.VencimentoBoleto = row.Cells[2].Text;

           //Response.Redirect("../Security/boletohtmlgridview.aspx");

           string script = "<script LANGUAGE='JavaScript'> "; script += "window.open('../Security/boletohtmlgridview.aspx');"; script += "</SCRIPT>";
           ClientScript.RegisterClientScriptBlock(GetType(), "ClientScript", script); 
            

          
                   

           
        }

        protected void GridViewListarBoletos_PageIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        protected void GridLateral_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
           
            GridLateral.PageIndex = e.NewPageIndex;

            CarregarGridLateral();
        }

        protected void GridViewListarBoletos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
           

            GridViewListarBoletos.PageIndex = e.NewPageIndex;

            CarregarGridListarBoletos();
        }

        public void CarregarGridListarBoletos()
        {
            PanelLateral.Visible = false;
            PainelLateralBlt.Visible = true;

            MySqlConnection Con;
            MySqlDataReader Dr;
            MySqlCommand Cmd;
            DataTable Dt = new DataTable();

            Con = Conexao.GetConnection();
            Conexao.AbrirConexao(Con);
            String Sql = "SELECT NumDocumento, Concat(Replace(Replace(Replace(Format(ValorBoleto, 2), '.', '|'), ',', '.'), '|', ',')) As ValorBoleto, DATE_FORMAT( VencimentoBoleto,  '%d/%m/%y' ) AS  'VencimentoBoleto',DATE_FORMAT( DataPagamento,  '%d/%m/%y' ) AS  'DataPagamento' From TbFatura where CodMorador=@v1 and Pago=1 ORDER BY VencimentoBoleto";

            Cmd = new MySqlCommand(Sql, Con);
            Cmd.Parameters.AddWithValue("@v1", Usuario.CodMorador);

            Dr = Cmd.ExecuteReader();
            Dt.Load(Dr);



            GridViewListarBoletos.DataSource = null;
            GridViewListarBoletos.DataSource = Dt;
            GridViewListarBoletos.DataBind();


            Dr.Close();
        }

        public void CarregarGridLateral()
        {

            PainelLateralBlt.Visible = false;
            PanelLateral.Visible = true;

            MySqlConnection Con;
            MySqlDataReader Dr;
            MySqlCommand Cmd;
            DataTable Dt = new DataTable();

            Con = Conexao.GetConnection();
            Conexao.AbrirConexao(Con);
            //"ORDER BY coluna DESC"
            String Sql = "SELECT NumDocumento, Concat(Replace (Replace(Replace(Format(ValorBoleto, 2), '.', '|'), ',', '.'), '|', ',')) As ValorBoleto, DATE_FORMAT( VencimentoBoleto,  '%d/%m/%y' ) AS  'VencimentoBoleto' From TbFatura where Pago=0 and CodMorador=@v1 ORDER BY VencimentoBoleto";

            Cmd = new MySqlCommand(Sql, Con);
            Cmd.Parameters.AddWithValue("@v1", Usuario.CodMorador);

            Dr = Cmd.ExecuteReader();
            Dt.Load(Dr);


            GridLateral.DataSource = null;
            GridLateral.DataSource = Dt;
            GridLateral.DataBind();


            Dr.Close();

        }
    }
}