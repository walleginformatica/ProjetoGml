<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="paginaparatestes.aspx.cs" Inherits="BoletoGml.Security.paginaparatestes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="txtSenha" runat="server" Width="937px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" Text="Button" OnClick="Button1_Click" runat="server"  />
    
    </div>
    </form>
    
</body>
</html>
