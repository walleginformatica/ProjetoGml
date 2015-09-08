<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin-menu-conta.aspx.cs" Inherits="BoletoGml.Security.admin_menu_conta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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
    <link href="../css/estilo.css" rel="stylesheet" />
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
        <div class="top-bar">
            <div class="container">
                <div class="row">
                    <div class="col-sm-6 col-xs-4">
                        <div class="top-number"><p><i class="fa fa-phone-square"></i>  +55(11) 8080.7070</p></div>
                    </div>
                    <div class="col-sm-6 col-xs-8">
                       <div class="social">
                            <ul class="social-share">
                                
                                <li><a href="#"><i class="fa fa-user"></i></a></li>
                                <li><i class="icon-search icon-white"></i><asp:Label ID="lblUsuarioLogado" runat="server" /><asp:Button ID="btnUsuario" runat="server" Text="Sair" CssClass="btn-danger" OnClick="btnUsuario_Click" /></li>

                            </ul>
                           
                       </div>
                    </div>
                </div>
            </div><!--/.container-->
        </div><!--/.top-bar-->

        <nav class="navbar navbar-inverse" role="banner">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="index.html"><img src="../images/logo.png" alt="logo" /></a>
                </div>
				
                <div class="collapse navbar-collapse navbar-right">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="../Security/admin-menu.aspx">Informativos</a></li>
                       
                        <li><a href="../Security/menu-boleto.aspx">Boletos</a></li>
                        
                        <li class="dropdown">
                        <a class="dropdown-toggle"
                        data-toggle="dropdown"
                        href="../Security/menu-boleto-conta.aspx">
                        Conta
                        <b class="caret"></b>
                        </a>
                        <ul class="dropdown-menu">
                        <li><a href="menu-boleto-conta-usuario.aspx" >Usuario</a></li>
                        <li><a href="admin-menu-conta.aspx">Senha</a></li>
                        </ul>
                        </li>
            

                    </ul>
                </div>
            </div>
        </nav>
		
    </header>


    <section id="feature" >
        <div class="container">
           <div class="center wow fadeInDown">
                <h2>Painel de Controle</h2>
                <p class="lead">Altere sua Senha<br /></p>
            </div>

            <div class="container">
                
                <b>DIGITE A SENHA ANTIGA</b>
                <br />
                <asp:TextBox ID="txtSenhaAntiga" runat="server" Width="300px" TextMode="Password"  />
                <br />
                <b>DIGITE A NOVA SENHA</b>
                <br />
                <asp:TextBox ID="txtNovaSenha" runat="server" Width="300px" TextMode="Password"  />
                <br />
                <b>CONFIRME A NOVA SENHA</b>
                <br />
                <asp:TextBox ID="txtConfirmaSenhaNova" runat="server" Width="300px" TextMode="Password"  />
                <br />
                <br />
                <asp:Button ID="btnGravar" runat="server"   Text="Gravar" OnClick="btnGravar_Click"/>
                <br />
                <br />
                <br />
                <asp:Label ID="lblResultado" runat="server" />

                
                    
                
                

                     <div class="table-responsive">

                              <asp:Panel ID="PanelLateral" runat="server">
                            
                            
                              
                               
                        </asp:Panel>
                            </div>

                       
                    </div>
                    

                    
                </div><!--/.services-->
      
    </section><!--/#feature-->

    <section id="conatcat-info">
        <div class="container">
            <div class="row">
                <div class="col-sm-8">
                    <div class="media contact-info wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                        <div class="pull-left">
                            <i class="fa fa-phone"></i>
                        </div>
                        <div class="media-body">
                            <h2>Deseja saber mais sobre a nossa Empresa ?</h2>
                            <p>Entre em contato com a gente +55 (11)7070-8080</p>
                        </div>
                    </div>
                </div>
            </div>
        </div><!--/.container-->    
    </section><!--/#conatcat-info-->


    <footer id="footer" class="midnight-blue">
        <div class="container">
            <div class="row">
                <div class="col-sm-6">
                    &copy; 2013 <a target="_blank" href="http://shapebootstrap.net/" title="Free Twitter Bootstrap WordPress Themes and HTML templates">Walleg Informatica</a>. All Rights Reserved.
                </div>
               
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
