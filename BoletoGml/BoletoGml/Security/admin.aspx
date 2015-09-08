<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="BoletoGml.Security.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>GML | ADMINISTRADORA</title>
	
	<!-- core CSS -->
    <link rel="stylesheet" type="text/css" href="../css/bootstrap.min.css" />
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../css/font-awesome.min.css" rel="stylesheet" />
    <link href="../css/animate.min.css" rel="stylesheet" />
    <link href="../css/prettyPhoto.css" rel="stylesheet" />
    <link href="../css/main.css" rel="stylesheet" />
    <link href="../css/responsive.css" rel="stylesheet" />
    <!--[if lt IE 9]>
    <script src="../js/html5shiv.js"></script>
    <script src="../js/respond.min.js"></script>
    <![endif]-->       
    <link rel="shortcut icon" href="../images/ico/favicon.ico" />
    <link rel="apple-touch-icon-precomposed" sizes="144x144" href="../images/ico/apple-touch-icon-144-precomposed.png" />
    <link rel="apple-touch-icon-precomposed" sizes="114x114" href="../images/ico/apple-touch-icon-114-precomposed.png" />
    <link rel="apple-touch-icon-precomposed" sizes="72x72" href="../images/ico/apple-touch-icon-72-precomposed.png" />
    <link rel="apple-touch-icon-precomposed" href="../images/ico/apple-touch-icon-57-precomposed.png" />
</head>
<body>
    <form id="form1" runat="server">
    <header id="header">
        <!--
      
        /.top-bar-->

        <nav class="navbar navbar-inverse" role="banner">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="../Default.aspx"><img src="../images/logo.png" alt="logo"></a>
                </div>
                <!-- ############## MENU DE BOTOES
           
           -->
              </div>      <!--/.container-->
        </nav><!--/nav-->
    </header><!--/header-->

        <!--

    
        
         -->

    <script type="text/javascript">
        
        function Validar() {

            if (document.getElementById("<%=txtBloco.ClientID%>").value == "") {
                alert("bloco deve conter 2 digitos, caso seu bloco for entre 1-9, coloque o zero a esquerda");
                document.getElementById("<%=txtBloco.ClientID%>").focus();
                return false;
            }
            else
            {
                return true;
            }
        }

    </script>
        
        
        
        
        <section id="contact-page">
        <div class="container">
            <div class="center">        
                <h2><!-- --></h2>
                <p class="lead"><!--  aqui dentro vai conteudo  --></p>
            </div> 
            <div class="row contact-wrap"> 
                <div class="status alert alert-success" style="display: none"></div>
                <form id="main-contact-form" class="contact-form" name="contact-form" method="post" action="sendemail.php">
                    <div class="col-sm-5 col-sm-offset-1">
                        <div class="form-group">
                            <label>Bloco</label>
                            <!--<input type="text" name="name" class="form-control" required="required">-->
                            <asp:TextBox ID="txtBloco" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Apartamento</label>
                            <!--<input type="email" name="email" class="form-control" required="required">-->
                            <asp:TextBox ID="txtApartamento" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
        
                        <div class="form-group">
                            <label>Senha</label>
                            <!--<input type="number" class="form-control">-->
                            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                           <!--<button type="submit" name="submit" class="btn btn-primary btn-lg" required="required">Entrar</button> -->
                            <asp:Button ID="btnEntrar" runat="server" Text="Entrar" CssClass="btn btn-primary" OnClientClick="return Validar()" OnClick="btnEntrar_Click"/>
                            <a href="../Default.aspx"><div class="btn btn-primary">Voltar</div></a>
                            <br />
                            <asp:Label ID="lblMensagem" runat="server" />
                        </div>
                        
                        <!--
                       
                        -->                      
                    </div>
                    <div class="col-sm-5">
                        <!--
                    
                         -->   
                    </div>
                </form> 
            </div><!--/.row-->
        </div><!--/.container-->
    </section><!--/#contact-page-->

         <!--/
    
        
       #bottom-->

    <footer id="footer" class="midnight-blue">
        <div class="container">
            <div class="row">
                <div class="col-sm-6">
                    &copy; 2015 <a target="_blank" href="http://www.walleginformatica.com.br" title="Free Twitter Bootstrap WordPress Themes and HTML templates">Walleg Informatica</a>. All Rights Reserved.
                </div>
                <!--
                
                -->
            </div>
        </div>
    </footer><!--/#footer-->

    <script src="../js/jquery.js"></script>
    <script src="../js/bootstrap.min.js"></script>
    <script src="../js/jquery.prettyPhoto.js"></script>
    <script src="../js/jquery.isotope.min.js"></script>
    <script src="../js/main.js"></script>
    <script src="../js/wow.min.js"></script>
    
    </form>
</body>
</html>
