using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BoletoGml.Classes;
using BoletoNet;

namespace BoletoGml.Security
{
    public partial class boletohtmlsegundavia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BoletoBancario boleto = new BoletoBancario();

            boleto = CriarBoleto.VisualizarBoleto();

            if (boleto != null)
            {
                PainelBoleto.Controls.Add(boleto);
            }
            else
            { 
                


            }
        }
    }
}