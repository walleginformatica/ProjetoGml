using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BoletoGml.Classes;
using MySql.Data.MySqlClient;

namespace BoletoGml.Paginas
{
    public partial class index : System.Web.UI.Page
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

                        Gml.FoneFixo = Convert.ToString(Dr["fonefixo"]);
                        Gml.FoneCel = Convert.ToString(Dr["fonecel"]);
                        Dr.Close();

                        lbltelefones.Text = Gml.FoneCel + " / " + Gml.FoneFixo + "";
                        lbltelefoneheader.Text = "(11) 2225.0507/ Fone/Fax (11) 2225.0040";
                        
                    }
                    else
                    {
                        lbltelefones.Text = "(11) 2225.0507/ Fone/Fax (11) 2225.0040";

                        

                    }
	            }
	            catch (Exception)
	            {
		
		        throw;
	            }
            
            
            

        }
    }
}