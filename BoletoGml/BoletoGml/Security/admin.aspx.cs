using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using BoletoGml.Classes;
using MySql.Data.MySqlClient;
using MySql.Data.Common;
using System.Data;



namespace BoletoGml.Security
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache); //Indica como a página deverá ser armazenada no cache. Para suprimir o cache devemos usar: HttpCacheability.NoCache

            

            Response.Cache.SetExpires(DateTime.Now.AddSeconds(15)); //Especifica quando o cache da página expira. Usar Now().AddSeconds(-1) para marcar a página como já expirada.
            Response.Cache.SetNoStore(); //Define que o navegador não utilize o cache.
            Response.AppendHeader("Pragma", "no-cache"); //Inclui um cabeçalho no objeto response HTTP. Especificando "Pragma" para a chave e "no-cache" para o valor desabilita o cache.
            //ADICIONANDO UMA SESSÃO COM O VALOR FALSE
            Session.Add("IsLogado", false);

          
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario.Apartamento = txtApartamento.Text;
            Usuario.Bloco = txtBloco.Text;

            Usuario.Bloco = BoletoDAL.ValidarFormularioBloco(Usuario.Bloco);
            Usuario.Apartamento = BoletoDAL.ValidarFormularioApartamento(Usuario.Apartamento);

            String SenhaCriptgrafada = txtSenha.Text;
            Usuario.Senha = Autenticar.getMD5Hash(SenhaCriptgrafada);

            
            Autenticar Verificar = new Autenticar();
            Boolean Autenticado = false;
            MySqlConnection Con;

            //String Bloco = txtBloco.Text;
            //String Apartamento = txtApartamento.Text;
            //String Senha = txtSenha.Text;
            String url = "../Security/admin-menu.aspx";


            try
            {
                Con = Conexao.GetConnection();
                Conexao.AbrirConexao(Con);

                Autenticado = Verificar.AutenticarUsuario(Usuario.Bloco, Usuario.Apartamento, Usuario.Senha);

                if (Autenticado == true)
                {
                    if (Usuario.NivelAcesso >= 5)
                    {
                        Response.Redirect(url, false);
                        Session.Add("Islogado", true);
                    }
                    else
                    {
                        Response.Redirect("https:\\www.google.com.br",false);
                    }

                }
                else
                {
                    lblMensagem.Text = "USUARIO INVALIDO";
                }


            }
            catch (Exception ex)
            {

                
                throw new Exception("ERRO AO CONECTAR NO BANCO DE DADOS :" + ex.Message);
            }
        }
    }
}