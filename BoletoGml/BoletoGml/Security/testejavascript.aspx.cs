using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BoletoGml.Security
{
    public partial class testejavascript : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btntid_ServerClick(object sender, EventArgs e)
        {
            
        }

        protected void btnCriptgrafar_Click(object sender, EventArgs e)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(txtStringConnectionCript0.Text);
            byte[] hash = md5.ComputeHash(inputBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            txtStringConnectionCript1.Text =  sb.ToString();
        }

        protected void btnDescriptografar_Click(object sender, EventArgs e)
        {
            byte[] b = Convert.FromBase64String(txtStringConnectionCript1.Text);
            String Encripted = System.Text.ASCIIEncoding.ASCII.GetString(b);
            txtDescripto.Text = Encripted;
        }
    }
}