using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BoletoGml.Classes;
using System.IO;
using System.Data;
using System.Web.Services;
using System.Web.UI;

namespace BoletoGml.Security
{
    public partial class admin_menu : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["IsLogado"]) == false)
            {
                Response.Redirect("../Security/admin.aspx");

            }

            lblUsuarioLogado.Text = Usuario.NomeMorador;

            
            

            lblLinkata.Text = "";


            if (!IsPostBack)
            {
                //loadFolder(GridDownload, Server.MapPath("~/Security/arquivos/_condominiomorada"));
                loadFolderDocu(GridDocumentos, Server.MapPath(Usuario.DocumentoDiversos));
                loadFolderForm(GridFormulario, Server.MapPath(Usuario.Formularios));
                loadFolderBala(GridBalancetes, Server.MapPath(Usuario.Balancetes));
            }

           
            
              
            



            
        
            
        }

        protected void btnUsuario_Click(object sender, EventArgs e)
        {
            Boolean Ativo = Usuario.DeslogarUsuario();
            if (Ativo == true)
            {
                Response.Redirect("../Security/admin.aspx");
                Session.Add("Islogado", false);
            }
            else 
            {
                
            }
        }

        protected void lkBaixar_Click(object sender, EventArgs e)
        {
            LinkButton lk = (LinkButton)sender;
            string nomeArquivo = lk.CommandArgument;

            //Pegando caminho fisico aonde se encontra arquivos e falando qual o arquivo a ser baixado
            //pelo nome
            //string caminhoArquivo = Server.MapPath("~/Security/arquivos/_condominiomorada/" + nomeArquivo);
            string caminhoArquivo = Server.MapPath(Usuario.DocumentoDiversos + nomeArquivo);

            //criando uma instancia do FileInfo para recuperar informações sobre o arquivo
            FileInfo file = new FileInfo(caminhoArquivo);

            //Verificando se o arquivo realmente existe
            if (file.Exists)
            {
                //Limpando o clear content
                Response.ClearContent();

                //Adicionando o nome do arquivo e forçando a caixa de dialago abrir/salvar/cancelar
                Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);

                //Adicionando o tamnho do arquivo no response headerr
                Response.AddHeader("Content-Length", file.Length.ToString());

                //Espeficino o contet type do arquivo
                Response.ContentType = ReturnExtension(file.Extension.ToLower());

                //tramistindo arquivo
                Response.TransmitFile(file.FullName);

                //Fim do Response
                Response.End();
            }
        }

        private string ReturnExtension(string fileExtension)
        {
            switch (fileExtension)
            {
                case ".htm":
                case ".html":
                case ".log":
                    return "text/HTML";
                case ".txt":
                    return "text/plain";
                case ".doc":
                    return "application/ms-word";
                case ".tiff":
                case ".tif":
                    return "image/tiff";
                case ".asf":
                    return "video/x-ms-asf";
                case ".avi":
                    return "video/avi";
                case ".zip":
                    return "application/zip";
                case ".xls":
                case ".csv":
                    return "application/vnd.ms-excel";
                case ".gif":
                    return "image/gif";
                case ".jpg":
                case "jpeg":
                    return "image/jpeg";
                case ".bmp":
                    return "image/bmp";
                case ".wav":
                    return "audio/wav";
                case ".mp3":
                    return "audio/mpeg3";
                case ".mpg":
                case "mpeg":
                    return "video/mpeg";
                case ".rtf":
                    return "application/rtf";
                case ".asp":
                    return "text/asp";
                case ".pdf":
                    return "application/pdf";
                case ".fdf":
                    return "application/vnd.fdf";
                case ".ppt":
                    return "application/mspowerpoint";
                case ".dwg":
                    return "image/vnd.dwg";
                case ".msg":
                    return "application/msoutlook";
                case ".xml":
                case ".sdxl":
                    return "application/xml";
                case ".xdp":
                    return "application/vnd.adobe.xdp+xml";
                default:
                    return "application/octet-stream";
            }
        }

        public void loadFolderDocu(GridView gv_arquivos, String folder)
        {
            DirectoryInfo pasta = new DirectoryInfo(folder);
            //DirectoryInfo[] subPastas = pasta.GetDirectories();
            FileInfo[] arquivos = pasta.GetFiles();

            DataTable dt = new DataTable();

            dt.Columns.Add("Nome");
            
            dt.Columns.Add("Baixar");

            /*
            if (folder != "")
            {
                DataRow dr1 = dt.NewRow();
                dr1["Nome"] = "";
                dr1["Tamanho"] = "";
                dr1["Tipo"] = "";
                dr1["Modificado"] = "";
                dr1["Baixar"] = "";

                dt.Rows.Add(dr1);
            }
             */

            /*
                foreach (DirectoryInfo dir in subPastas)
                    {
                        DataRow dr = dt.NewRow();
                        dr["Nome"] = ">>" + dir.Name;
                        dr["Tamanho"] = "-";
                        dr["Tipo"] = "Diretório";
                        dr["Modificado"] = dir.LastWriteTime.ToString("dd/MM/yyyy");
                        dr["Baixar"] = "";

                        dt.Rows.Add(dr);
                    }
             */

            foreach (FileInfo file in arquivos)
            {
                DataRow dr = dt.NewRow();
                dr["Nome"] = file.Name;
                
                dr["Baixar"] = new LinkButton() { Text = "Baixar" };

                dt.Rows.Add(dr);
            }

            gv_arquivos.DataSource = dt;
            gv_arquivos.DataBind();
        }

        public void loadFolderForm(GridView gv_arquivos, String folder)
        {
            DirectoryInfo pasta = new DirectoryInfo(folder);
            //DirectoryInfo[] subPastas = pasta.GetDirectories();
            FileInfo[] arquivos = pasta.GetFiles();

            DataTable dt = new DataTable();

            dt.Columns.Add("Nome");
            dt.Columns.Add("Baixar");

            /*
            if (folder != "")
            {
                DataRow dr1 = dt.NewRow();
                dr1["Nome"] = "";
                dr1["Tamanho"] = "";
                dr1["Tipo"] = "";
                dr1["Modificado"] = "";
                dr1["Baixar"] = "";

                dt.Rows.Add(dr1);
            }
             */

            /*
                foreach (DirectoryInfo dir in subPastas)
                    {
                        DataRow dr = dt.NewRow();
                        dr["Nome"] = ">>" + dir.Name;
                        dr["Tamanho"] = "-";
                        dr["Tipo"] = "Diretório";
                        dr["Modificado"] = dir.LastWriteTime.ToString("dd/MM/yyyy");
                        dr["Baixar"] = "";

                        dt.Rows.Add(dr);
                    }
             */

            foreach (FileInfo file in arquivos)
            {
                DataRow dr = dt.NewRow();
                dr["Nome"] = file.Name;
                dr["Baixar"] = new LinkButton() { Text = "Baixar" };

                dt.Rows.Add(dr);
            }

            gv_arquivos.DataSource = dt;
            gv_arquivos.DataBind();
        }

        public void loadFolderBala(GridView gv_arquivos, String folder)
        {
            DirectoryInfo pasta = new DirectoryInfo(folder);
            //DirectoryInfo[] subPastas = pasta.GetDirectories();
            FileInfo[] arquivos = pasta.GetFiles();

            DataTable dt = new DataTable();

            dt.Columns.Add("Nome");
            dt.Columns.Add("Baixar");

            /*
            if (folder != "")
            {
                DataRow dr1 = dt.NewRow();
                dr1["Nome"] = "";
                dr1["Tamanho"] = "";
                dr1["Tipo"] = "";
                dr1["Modificado"] = "";
                dr1["Baixar"] = "";

                dt.Rows.Add(dr1);
            }
             */

            /*
                foreach (DirectoryInfo dir in subPastas)
                    {
                        DataRow dr = dt.NewRow();
                        dr["Nome"] = ">>" + dir.Name;
                        dr["Tamanho"] = "-";
                        dr["Tipo"] = "Diretório";
                        dr["Modificado"] = dir.LastWriteTime.ToString("dd/MM/yyyy");
                        dr["Baixar"] = "";

                        dt.Rows.Add(dr);
                    }
             */

            foreach (FileInfo file in arquivos)
            {
                DataRow dr = dt.NewRow();
                dr["Nome"] = file.Name;
                dr["Baixar"] = new LinkButton() { Text = "Baixar" };

                dt.Rows.Add(dr);
            }

            gv_arquivos.DataSource = dt;
            gv_arquivos.DataBind();
        }

        [WebMethod]
        public static void AbandonSession()
        {
            
            

           

        }

        protected void lkFormularioBaixar_Click(object sender, EventArgs e)
        {
            LinkButton lk = (LinkButton)sender;
            string nomeArquivo = lk.CommandArgument;

            //Pegando caminho fisico aonde se encontra arquivos e falando qual o arquivo a ser baixado
            //pelo nome
            //string caminhoArquivo = Server.MapPath("~/Security/arquivos/_condominiomorada/" + nomeArquivo);
            string caminhoArquivo = Server.MapPath(Usuario.Balancetes + nomeArquivo);

            //criando uma instancia do FileInfo para recuperar informações sobre o arquivo
            FileInfo file = new FileInfo(caminhoArquivo);

            //Verificando se o arquivo realmente existe
            if (file.Exists)
            {
                //Limpando o clear content
                Response.ClearContent();

                //Adicionando o nome do arquivo e forçando a caixa de dialago abrir/salvar/cancelar
                Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);

                //Adicionando o tamnho do arquivo no response headerr
                Response.AddHeader("Content-Length", file.Length.ToString());

                //Espeficino o contet type do arquivo
                Response.ContentType = ReturnExtension(file.Extension.ToLower());

                //tramistindo arquivo
                Response.TransmitFile(file.FullName);

                //Fim do Response
                Response.End();
            }
        }

        protected void lkBalancetes_Click(object sender, EventArgs e)
        {

        }
    }
}