using System;
using System.Net.Mail;


namespace BoletoGml.Classes
{
    public class Logs
    {
        //gera email para gml com os dados do usuario que imprimiu o boleto
        public static void GeraEmailBoleto(string NomeMorador, string Bloco, string Apartamento, string NomeCondominio)
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
            
            String DataGerado = DateTime.Now.ToString();
            string assuntoMensagem = "Boleto Gerado No Site";
            
            string conteudoMensagem = "Nome Morador: "+NomeMorador+"<br />"+"Bloco: " + Bloco + "<br />" + "Apartamento: " + Apartamento + "<br />" + "Condominio: " + NomeCondominio + "<br />" + "Gerou Boleto | Data e Hora :" + DataGerado;

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
            
           objSmtp.Send(objEmail);
                
           
           objEmail.Dispose();
                
            
        }

        //gera email para gml , informando que o morado x fez alteração nos dados.
        public static void GeraEmailDadosAlterados(string NomeMorador, string Bloco, string Apartamento, string NomeCondominio)
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

            String DataGerado = DateTime.Now.ToString();
            string assuntoMensagem = "Dados Alterados No Site";
            string conteudoMensagem = "Nome Morador: " + NomeMorador + "<br />" + "Bloco: " + Bloco + "<br />" + "Apartamento: " + Apartamento + "<br />" + "Condominio: " + NomeCondominio + "<br />" + "Alterou Dados No Site  | Data e Hora :" + DataGerado;

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

            objSmtp.Send(objEmail);


            objEmail.Dispose();
        }

        //gera email para o morador, informando que o mesmo fez alterações no site.
        public static void GeraEmailDadosMorador(string NomeMorador, string Bloco, string Apartamento, string NomeCondominio, string EmailMorador, string Impresso)
        {
            //Define os dados do e-mail
            string nomeRemetente = "GML CONDOMINIOS"; //"Seu Nome";
            string emailRemetente = "gml@gmlcondominios.com.br"; //"email@seudominio.com.br";
            string senha = "miamigml2"; //"Sua senha de email";

            //Host da porta SMTP
            string SMTP = "smtp.gmlcondominios.com.br";
            string emailDestinatario = string.Empty;

            if (EmailMorador == null)
            {
                emailDestinatario = "gml@gmlcondominios.com.br";
            }
            else
            {
                emailDestinatario = EmailMorador;
            };

            
            string emailComCopia = "gml@gmlcondominios.com.br";
            //string emailComCopiaOculta  = "email@comcopiaoculta.com.br";

            string DataGerado = DateTime.Now.ToString();
            string assuntoMensagem = "Dados Alterados No Site";
            string texto = "<br /><font size='4' color='black' face='verdana'>Identificamos alterações nos dados de seu cadastro no site GML<br />caso esta alteração não tenha sido realizada por você,<br /> favor entrar em contato com a Administradora</font>.<br /><br /><font size='4' color='red' face='verdana'>Av Prestes Maia, 241 Cjto. 2110<br />Centro – São Paulo CEP 01031-902<br />Telefones (11) 2225.0040 | (11) 2225.0507 | Nextel (11) 7912-7691 id *10347 |<br />gml@gmlcondominios.com.br </font>";
            string conteudoMensagem = "<font size='4' color='blue' face='verdana'>Nome Morador: " + NomeMorador + "<br />" + "Bloco: " + Bloco + "<br />" + "Apartamento: " + Apartamento + "<br />" + "Condominio: " + NomeCondominio + "<br />" + "BOLETO IMPRESSO: " + Impresso + "</font><br />" + texto + "<br />" + "<font size='4' color='black' face='verdana'> Data e Hora das alterações :" + DataGerado + "<br /><br /> Atenciosamente GML - Administração e Gestão de Condomínios</font>";

            //Cria objeto com dados do e-mail.
            MailMessage objEmail = new MailMessage();

            //Define o Campo From e ReplyTo do e-mail.
            objEmail.From = new System.Net.Mail.MailAddress(nomeRemetente + "<" + emailRemetente + ">");

            //Define os destinatários do e-mail.
            objEmail.To.Add(emailDestinatario);

            
            objEmail.CC.Add(emailComCopia);

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

            objSmtp.Send(objEmail);


            objEmail.Dispose();
        }
    }
}