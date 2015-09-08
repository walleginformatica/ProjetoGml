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
    public partial class boletohtmlgridview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BoletoBancario boleto = new BoletoBancario();

            boleto = CriarBoleto.VisualizarBoletoGrid();

            if (boleto != null)
            {

                PanelBoleto.Controls.Add(boleto);
                btnImprimir.Visible = false;
                Response.Write("<script>window.print();</script>");

                Logs.GeraEmailBoleto(Usuario.NomeMorador, Usuario.Bloco, Usuario.Apartamento, Usuario.NomeCondominio);
            }
            else
            {

                Response.Write("<script>javascript:Alert('valor null')</script>");

            }
        }

        protected void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;
            Response.Write("<script>window.print();</script>");


        }
    }
}