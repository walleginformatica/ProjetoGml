using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BoletoGml.Classes;
using BoletoGml.Security;
using BoletoNet;
namespace BoletoGml.Security
{
    public partial class boletohtml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PanelBoletoHtml.Visible = false;
            PanelBoletoNull.Visible = false;
            

            BoletoBancario boleto = new BoletoBancario();
            boleto = CriaBoletoFatura.VisualizarBoleto();

            if (boleto != null)
            {
                PanelBoletoHtml.Visible = true;
                PanelBoletoHtml.Controls.Add(boleto);
            }
            else
            {

                PanelBoletoNull.Visible = true;
                HttpContext.Current.Session.Abandon();

                
                
            }
        }
    }
}