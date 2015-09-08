using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BoletoGml.Classes;
using MySql.Data.MySqlClient;

namespace BoletoGml
{
    public partial class servicos : System.Web.UI.Page
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



                    lblTelHeader.Text = "(11) 2225.0507/ Fone/Fax (11) 2225.0040";


                }
                else
                {

                    lblTelHeader.Text = "(11) 2225.0507/ Fone/Fax (11) 2225.0040";
                   
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}