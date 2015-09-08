using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BoletoGml.Classes;
using MySql.Data.MySqlClient;
using System.Net.Mail;

namespace BoletoGml.Paginas
{
    public partial class contato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection Con = Conexao.GetConnection();
                Conexao.AbrirConexao(Con);
                MySqlDataReader Dr;
                MySqlCommand Cmd = new MySqlCommand("Select * from TbGml", Con);
                Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {

                    Gml.FoneFixo = Convert.ToString(Dr["fonefixo"]).Trim();
                    Gml.FoneCel = Convert.ToString(Dr["fonecel"]).Trim();
                    Gml.EmailGml = Convert.ToString(Dr["emailGml"]).Trim();
                    Gml.FoneNextel = Convert.ToString(Dr["foneNextel"]).Trim();
                    Gml.smtpGml = Convert.ToString(Dr["smtpGml"]).Trim();
                    
                    Dr.Close();
                    
                    
                    lbltelefone.Text  = "Telefones " + Gml.FoneCel + "  " + Gml.FoneFixo + " "+Gml.FoneNextel +"";
                    lblEmailGml.Text = Gml.EmailGml.Trim();
                    lblTelHeader.Text = "(11) 2225.0507/ Fone/Fax (11) 2225.0040";


                }
                else
                {

                    lbltelefone.Text = "(11) 2225.0507/ Fone/Fax (11) 2225.0040 / Nextel : (11) 7912-7691 Nextel id *10347";
                    lblEmailGml.Text = "gmlcondominio@gmlcondominio.com";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            //Define os dados do e-mail
            string nomeRemetente = "GML CONDOMINIOS"; //"Seu Nome";
            string emailRemetente = "gml@gmlcondominios.com.br"; //"email@seudominio.com.br";
            string senha = "miamigml2"; //"Sua senha de email";

            //Host da porta SMTP
            string SMTP = "smtp.gmlcondominios.com.br";

            string emailDestinatario = "gml@gmlcondominios.com.br";
            //string emailComCopia        = "email@comcopia.com.br";
            //string emailComCopiaOculta  = "email@comcopiaoculta.com.br";

            string assuntoMensagem = "Assunto :"+txtAssunto.Text;
            string conteudoMensagem = "Nome : "+txtNome.Text+"<br />"+"Email :"+txtEmail.Text+"<br />"+"Telefone :"+txttelefone.Text+"<br />"+"Nome Condominio :"+txtCondominio.Text+"<br />"+"Menssgem :"+txtMenssagem.Text;

            //Cria objeto com dados do e-mail.
            MailMessage objEmail = new MailMessage();

            //Define o Campo From e ReplyTo do e-mail.
            objEmail.From = new System.Net.Mail.MailAddress(nomeRemetente + "<" + emailRemetente + ">");

            //Define os destinatários do e-mail.
            objEmail.To.Add(emailDestinatario);

            //Enviar cópia para.
            //objEmail.CC.Add(emailComCopia);

            //Enviar cópia oculta para.
            //objEmail.Bcc.Add(emailComCopiaOculta);

            //Define a prioridade do e-mail.
            objEmail.Priority = System.Net.Mail.MailPriority.Normal;

            //Define o formato do e-mail HTML (caso não queira HTML alocar valor false)
            objEmail.IsBodyHtml = true;

            //Define título do e-mail.
            objEmail.Subject = assuntoMensagem;

            //Define o corpo do e-mail.
            objEmail.Body = conteudoMensagem;


            //Para evitar problemas de caracteres "estranhos", configuramos o charset para "ISO-8859-1"
            objEmail.SubjectEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            objEmail.BodyEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");


            // Caso queira enviar um arquivo anexo
            //Caminho do arquivo a ser enviado como anexo
            //string arquivo = Server.MapPath("arquivo.jpg");

            // Ou especifique o caminho manualmente
            //string arquivo = @"e:\home\LoginFTP\Web\arquivo.jpg";

            // Cria o anexo para o e-mail
            //Attachment anexo = new Attachment(arquivo, System.Net.Mime.MediaTypeNames.Application.Octet);

            // Anexa o arquivo a mensagem
            //objEmail.Attachments.Add(anexo);

            //Cria objeto com os dados do SMTP
            System.Net.Mail.SmtpClient objSmtp = new System.Net.Mail.SmtpClient();

            //Alocamos o endereço do host para enviar os e-mails  
            objSmtp.Credentials = new System.Net.NetworkCredential(emailRemetente, senha);
            objSmtp.Host = SMTP;
            objSmtp.Port = 587;
            //Caso utilize conta de email do exchange da locaweb deve habilitar o SSL
            //objEmail.EnableSsl = true;

            //Enviamos o e-mail através do método .send()
            try
            {
                objSmtp.Send(objEmail);
                Response.Write("E-mail enviado com sucesso !");
            }
            catch (Exception ex)
            {
                Response.Write("Ocorreram problemas no envio do e-mail. Erro = " + ex.Message);
            }
            finally
            {
                //excluímos o objeto de e-mail da memória
                objEmail.Dispose();
                //anexo.Dispose();
            }
        }
    }
}