<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="boletohtmlgridview.aspx.cs" Inherits="BoletoGml.Security.boletohtmlgridview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <script language="javascript" type="text/jscript">
            function imprimePanel()
            {
                var printContent = document.getElementById("<%=PanelBoleto.ClientID%>");
                var windowUrl = 'about:blank';
                var uniqueName = new Date();
                var windowName = 'Print' + uniqueName.getTime();
                var printWindow = window.open(windowUrl, windowName, 'left=50000,top=50000,width=50000,height=50000');

                printWindow.document.write(printContent.innerHTML);
                printWindow.document.close();
                printWindow.focus();
                printWindow.print();
                printWindow.close();

            }
            
            function imprimir()
            {
                window.titulo.style.display="none";
                window.print();
                window.titulo.style.display="";
            }
</script>

        <center><asp:Button ID="btnImprimir" Text="Imprimir" runat="server" OnClientClick="javascript:imprimir()" OnClick="btnImprimir_Click" Width="150px" Height="50px" /></center>



    <asp:Panel ID="PanelBoleto" runat="server">

    </asp:Panel>
        
    </div>
    </form>
</body>
</html>
