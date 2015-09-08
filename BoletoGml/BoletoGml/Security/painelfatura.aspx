<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="painelfatura.aspx.cs" Inherits="BoletoGml.Security.painelfatura" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <b>CodUsuario</b><asp:TextBox ID="txtCodMorador" runat="server" /><asp:Button ID="btnBuscaUsuario" Text="Busca Usuario" runat="server" OnClick="btnBuscaUsuario_Click"  />
    <br />
    <asp:Label ID="lblResultado" runat="server" />
    <br />
     <asp:Panel ID="PanelMostarUsuario" runat="server">
        <b>Codigo Condominio</b><asp:TextBox ID="txtCodCondominio" runat="server" /><br />
        <b>Bloco</b><asp:TextBox ID="txtBloco" runat="server" /><br />
        <b>Apartamento</b><asp:TextBox ID="txtApartamento" runat="server" /><br />
        <b>Nome Morador</b><asp:TextBox ID="txtNomeMorador" runat="server" /><br />
        <b>Emissão</b><asp:TextBox ID="txtEmissao" runat="server" /><br />
        <b>Vencimento</b><asp:TextBox ID="txtVencimento" runat="server" /><br />
        <b>Valor Boleto</b><asp:TextBox ID="txtValorBoleto" runat="server" /><br />
        <b>Senha</b><asp:TextBox ID="txtSenha" runat="server" /><br />
        <b>Numero Documento</b><asp:TextBox ID="txtNumDocumento" runat="server" /><br />
        <b>Pago</b><asp:TextBox ID="txtPago" runat="server" />
        <asp:Button ID="btnGravarFatura" runat="server" Text="Gravar Fatura" OnClick="btnGravarFatura_Click" />
     </asp:Panel>
    </div>
    </form>
</body>
</html>
