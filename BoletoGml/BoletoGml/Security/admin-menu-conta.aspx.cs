using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BoletoGml.Classes;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Web.Mail;

namespace BoletoGml.Security
{
    public partial class admin_menu_conta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Convert.ToBoolean(Session["IsLogado"]) == false)
            {
                Response.Redirect("../Security/admin.aspx");

            }

            lblUsuarioLogado.Text = Usuario.NomeMorador;
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

        protected void btnGravar_Click(object sender, EventArgs e)
        {

            MySqlCommand Cmd;
            MySqlCommand Cmd2;
            MySqlConnection Con;
            MySqlDataReader Dr;
            Con = Conexao.GetConnection();
            Conexao.AbrirConexao(Con);
            String Sql = null;
            String SenhaCripto = Autenticar.getMD5Hash(txtSenhaAntiga.Text.Trim());

            Sql = "Select * from TbMorador where CodMorador =@v1 and Senha=@v2";
            Cmd = new MySqlCommand(Sql, Con);
            Cmd.Parameters.AddWithValue("@v1", Usuario.CodMorador);
            Cmd.Parameters.AddWithValue("@v2", SenhaCripto);
            Dr = Cmd.ExecuteReader();

            if (Dr.Read())
            {
                Dr.Close();
                Conexao.FecharConexao(Con);

                if (txtNovaSenha.Text == txtConfirmaSenhaNova.Text)
                {
                    Conexao.AbrirConexao(Con);
                    SenhaCripto = null;
                    SenhaCripto = Autenticar.getMD5Hash(txtConfirmaSenhaNova.Text.Trim());
                    Sql = null;
                    Sql = "update TbMorador set Senha=@v1 where CodMorador =" + Usuario.CodMorador + "";
                    Cmd2 = new MySqlCommand(Sql, Con);
                    Cmd2.Parameters.AddWithValue("@v1", SenhaCripto);

                    Cmd2.ExecuteNonQuery();

                   
                    ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "mensagem", "<script type=\"text/javascript\"> alert('Senha Alterada com Sucesso. SERÁ ENVIADO UM E-MAIL PARA VOCÊ COM UM BACKUP DA NOVA SENHA, OBRIGADO!'); </script>", false);
                    }
                    else 
                    {
                        Response.Write("<script>alert('A nova senha e confirmação da nova senha nao corresponde!');</script>");
                    }
                    


                    




                }
                else
                {
                    lblResultado.Text = "NOVA SENHA E CONFIRMAÇÃO DA NOVA SENHA, NÃO ESTÃO IGUAIS.. FAVOR VERIFICAR";
                }

            
            
            
                
            
        }
    }
}