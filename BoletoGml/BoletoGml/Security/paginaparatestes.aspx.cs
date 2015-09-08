using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BoletoGml.Classes;

namespace BoletoGml.Security
{
    public partial class paginaparatestes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String Senha = txtSenha.Text;

            String Criptrografada = Autenticar.getMD5Hash(Senha);

            txtSenha.Text = "";

            txtSenha.Text = Criptrografada;
        }
    }
}