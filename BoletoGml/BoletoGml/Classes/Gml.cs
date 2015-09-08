using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mail;

namespace BoletoGml.Classes
{
    public class Gml
    {
        public static String FoneCel;
        public static String FoneFixo;
        public static String EmailGml;
        public static String FoneNextel;
        public static String smtpGml;

        public static void EnviarEmail(String Nome, String Email, String Telefone, String Condominio, String Assunto, String Menssagem)
        {
            /*
            
            MailMessage ClassMail = new MailMessage();

            ClassMail.From = Gml.EmailGml;
            ClassMail.To = Email;
            ClassMail.Subject = "ASDAS";

            ClassMail.BodyFormat = MailFormat.Text;
            ClassMail.Body = Menssagem;
            SmtpMail.SmtpServer = Gml.smtpGml;
            SmtpMail.Send(ClassMail);
            
            
            */
        
            
        }


    }
}