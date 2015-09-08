using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using BoletoGml.Classes;
using MySql.Data.MySqlClient;
namespace BoletoGml.Security
{
    public partial class menu_boleto_conta_usuario : System.Web.UI.Page
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
            bool Ativo = Usuario.DeslogarUsuario();
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
            try
            {
                MySqlConnection Con;
                MySqlCommand Cmd;

                MySqlDataReader Dr;

                Con = Conexao.GetConnection();
                Conexao.AbrirConexao(Con);
                String Sql = null;
                String SenhaCripto = Autenticar.getMD5Hash(txtSenha.Text.Trim());

                Sql = "Select * from TbMorador where CodMorador=@b1 and Senha=@b2";
                Cmd = new MySqlCommand(Sql, Con);
                Cmd.Parameters.AddWithValue("@b1", Usuario.CodMorador);
                Cmd.Parameters.AddWithValue("@b2", SenhaCripto);

                Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {

                    Usuario.EmailMorador = Convert.ToString(Dr["EmailMorador"]);
                    Dr.Close();



                    if (CheckBox.Checked == true)
                    {

                        Sql = null;
                        Sql = "update TbMorador set Fone=@v2, EmailMorador=@v3, Impresso=@v6 where Senha=@v4 and CodMorador=@v5";

                        Cmd.CommandText = Sql;
                        string impresso = "NÃO";
                        Cmd.Parameters.AddWithValue("@v2", txtFone.Text.Trim());
                        Cmd.Parameters.AddWithValue("@v3", txtEmail.Text.Trim());
                        Cmd.Parameters.AddWithValue("@v4", SenhaCripto);
                        Cmd.Parameters.AddWithValue("@v5", Usuario.CodMorador);
                        Cmd.Parameters.AddWithValue("@v6", impresso);
                        Cmd.ExecuteNonQuery();
                        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "mensagem", "<script type=\"text/javascript\"> alert('DADOS ALTERADOS COM SUCESSO!'); </script>", false);
                        lblResultado.Text = "Dados Alterados Com Sucesso";
                        Logs.GeraEmailDadosAlterados(Usuario.NomeMorador, Usuario.Bloco, Usuario.Apartamento, Usuario.NomeCondominio);
                        if (Usuario.EmailMorador != null)
                        {
                            Logs.GeraEmailDadosMorador(Usuario.NomeMorador, Usuario.Bloco, Usuario.Apartamento, Usuario.NomeCondominio, Usuario.EmailMorador, impresso);
                        }
                        else
                        { }
                    }
                    else
                    {
                        Sql = null;
                        Sql = "update TbMorador set Fone=@v2, EmailMorador=@v3, Impresso=@v6 where Senha=@v4 and CodMorador=@v5";
                        Cmd.CommandText = Sql;
                        string impresso = "SIM";
                        Cmd.Parameters.AddWithValue("@v2", txtFone.Text.Trim());
                        Cmd.Parameters.AddWithValue("@v3", txtEmail.Text.Trim());
                        Cmd.Parameters.AddWithValue("@v4", SenhaCripto);
                        Cmd.Parameters.AddWithValue("@v5", Usuario.CodMorador);
                        Cmd.Parameters.AddWithValue("@v6", impresso);
                        Cmd.ExecuteNonQuery();
                        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "mensagem", "<script type=\"text/javascript\"> alert('DADOS ALTERADOS COM SUCESSO!'); </script>", false);
                        //Response.Write("<script>javascript:Alert('Alterado com sucesso!)</script>");
                        lblResultado.Text = "Dados Alterados Com Sucesso";
                        Logs.GeraEmailDadosAlterados(Usuario.NomeMorador, Usuario.Bloco, Usuario.Apartamento, Usuario.NomeCondominio);
                        if (Usuario.EmailMorador != null)
                        { Logs.GeraEmailDadosMorador(Usuario.NomeMorador, Usuario.Bloco, Usuario.Apartamento, Usuario.NomeCondominio, Usuario.EmailMorador, impresso); }
                        else
                        { }
                    }
                }
                else
                {
                    lblResultado.Text = "VERIFIQUE A SENHA DIGITA, POIS NAO CORRESPONDE COM A SENHA SALVA NO BANCO DE DADOS";

                }
            }
            catch (Exception ex)
            {

                throw new Exception("erro ao gravar alteraçõs de dados" + ex);
            }
            finally
            {
                Dispose();
            }
      
        }

        protected void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}