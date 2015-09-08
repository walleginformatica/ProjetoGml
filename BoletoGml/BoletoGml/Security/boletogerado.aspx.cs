using System;

namespace BoletoGml.Security
{
    public partial class boletogerado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCaptcha_Click(object sender, EventArgs e)
        {
            if (txtCaptchar.Text == Session["CaptchaValue"].ToString())

                {

                    lblCaptchar.Text = "Valor digitado está OK";

                    Response.Redirect("../Security/boletohtml.aspx");

                }

            else

                {

                lblCaptchar.Text = "<b>Valor digitado está errado";

                }
        }
    }
}