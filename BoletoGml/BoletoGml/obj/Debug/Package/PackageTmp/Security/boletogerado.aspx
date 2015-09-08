<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="boletogerado.aspx.cs" Inherits="BoletoGml.Security.boletogerado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GML - COND</title>
    <link type="text/css" rel="stylesheet" href="../css/estilo.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
       
 
  <script>
      function fechar() {
          document.getElementById("posiciona").style.display = 'none';
      }
 </script>
 
  


 
<div id="posiciona"> 
<div id="fechar" align=right><a href="javascript:fechar();">FECHAR</a></div> 
    <img src="captcha.aspx" width="250px" />
     <br />
        <asp:Button ID="btnCaptcha" runat="server"  Text="Gerar Boleto" OnClick="btnCaptcha_Click" />
    <br />
        <asp:Label ID="lblCaptchar" runat="server" />
    <asp:TextBox ID="txtCaptchar" runat="server" ></asp:TextBox>

</div>


   
        

       
    </div>
    </form>
</body>
</html>
