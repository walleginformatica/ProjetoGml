<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="boletohtml.aspx.cs" Inherits="BoletoGml.Security.boletohtml" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="PanelBoletoHtml" runat="server" />
    </div>
        <asp:Panel ID="PanelBoletoNull" runat="server">
            <b>VOCE NAO POSSUI BOLETOS EM ABERTO</b>
        </asp:Panel>
    </form>
</body>
</html>
