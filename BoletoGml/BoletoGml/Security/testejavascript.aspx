<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testejavascript.aspx.cs" Inherits="BoletoGml.Security.testejavascript" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TESTE JAVASCRIPT</title>
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.9.2/themes/base/jquery-ui.css" />
    <script src="http://code.jquery.com/jquery-1.8.3.js"></script>
    <script src="http://code.jquery.com/ui/1.9.2/jquery-ui.js"></script>         
</head>
<body>
    <form id="form1" runat="server">
    <!--
        <div>
        <input type="text" name="txthtml"  id="txtid" />
        <input type="text" name="txthtml2" id="txttid" />
        <input type="button" name="btnhtml" id="btntid" runat="server" onserverclick="btntid_ServerClick" onclick=Validar/>
        <asp:TextBox ID="txtSenha" runat="server" />
        <asp:TextBox ID="txtConfirmaSenha" runat="server" />
    
        <div id="dialog" title="Titulo da Caixa">
    <p>Ut a placerat diam. Suspendisse euismod nulla ac quam tristique eleifend iaculis dolor luctus. Aliquam tristique rhoncus placerat. Ut adipiscing lorem pharetra tortor viverra quis ornare mi pharetra. Maecenas a massa ante, a accumsan leo. Donec ac turpis et arcu tincidunt tincidunt. Etiam sed nunc nulla. Mauris posuere augue sapien.</p>
</div>
        <script>
            $("#dialog").dialog();
        </script>

        <script type="text/javascript">
            var text1 = form1.txtid;
            var text2 = form1.txttid;

            function Validar()
            {
                if (text1 = "")
                {
                    alert('preencha um campo');
                }
            }
        </script>
-->         <b>coloque a senha para a criptografia</b>
        <asp:TextBox ID="txtStringConnectionCript0" runat="server" Visible="true"></asp:TextBox>
        
         <b>SenhaCriptografada</b>
        <asp:TextBox ID="txtStringConnectionCript1" runat="server" Width="726px"></asp:TextBox>
        <asp:Button ID="btnCriptgrafar" runat="server" Text="CRIPTOGRAFAR" OnClick="btnCriptgrafar_Click" />
        <br />
       
        <asp:TextBox ID="txtDescripto" runat="server" Visible="false"/>
        <asp:Button ID="btnDescriptografar" runat="server" Text="DESCRIPTOGRAFAR" OnClick="btnDescriptografar_Click"  Visible="false"/>
        
    </div>
    </form>
</body>
</html>
