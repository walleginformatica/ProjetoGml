using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BoletoGml.Classes;
namespace BoletoGml.Security
{
    public partial class painelfatura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["IsLogado"]) == false)
            {
                Response.Redirect("../Security/admin.aspx");

            }

            PanelMostarUsuario.Visible = false;


        }

        protected void btnGravarFatura_Click(object sender, EventArgs e)
        {
            
            BoletoDAL.CarregarTextFaturaAdm(txtCodMorador.Text, txtValorBoleto.Text, txtNumDocumento.Text, txtEmissao.Text, txtVencimento.Text, txtCodCondominio.Text, txtNomeMorador.Text, txtBloco.Text, txtApartamento.Text, txtPago.Text, txtSenha.Text);
            BoletoDAL.GravarTbFaturaAdm();
                    
        }

        protected void btnBuscaUsuario_Click(object sender, EventArgs e)
        {
            Atributos Morador = new Atributos();
            Morador = BoletoDAL.BuscaUsuario(Convert.ToInt32(txtCodMorador.Text));


            PanelMostarUsuario.Visible = true;

            txtApartamento.Text = Morador.Apartamento.Trim();
            txtBloco.Text = Morador.Bloco.Trim();
            txtCodCondominio.Text = Convert.ToString(Morador.CodCondominio).Trim();
            txtEmissao.Text = "".Trim();
            txtNomeMorador.Text = Morador.NomeMorador.Trim();
            txtSenha.Text = Morador.Senha.Trim();
            txtValorBoleto.Text = "".Trim();
            txtVencimento.Text = "".Trim();
          
        }

        
    }
}