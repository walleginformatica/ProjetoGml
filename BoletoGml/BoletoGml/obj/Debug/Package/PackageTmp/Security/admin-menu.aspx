<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin-menu.aspx.cs" Inherits="BoletoGml.Security.admin_menu" %>

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
    <link href="css/meucss.css" rel="stylesheet" />
    <link href="../css/estilo.css" rel="stylesheet" type="text/css" />
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
         
         <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true" />
           <header id="header">
                  <div class="top-bar">
            <div class="container">
                <div class="row">
                    <div class="col-sm-6 col-xs-4">
                        <div class="top-number"><p><i class="fa fa-phone-square"></i>(11) 2225.0507</p></div>
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
                    <a class="navbar-brand" href="admin-menu.aspx"><img src="../images/logo.png" alt="logo" /></a>
                </div>
				
                <div class="collapse navbar-collapse navbar-right">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="admin-menu.aspx">Informativos</a></li>
                       
                        <li><a href="../Security/menu-boleto.aspx">Boletos</a></li>
                        <li class="dropdown">
                        <a class="dropdown-toggle"
                        data-toggle="dropdown"
                        href="../Security/menu-boleto-conta.aspx">
                        Conta
                        <b class="caret"></b>
                        </a>
                        <ul class="dropdown-menu">
                        <li><a href="menu-boleto-conta-usuario.aspx">Usuario</a></li>
                        <li><a href="admin-menu-conta.aspx">Senha</a></li>
                        </ul>
                        </li>          
                    </ul>
                </div>
            </div><!--/.container-->
        </nav><!--/nav-->
		
    </header>


    <section id="feature" >
        <div class="container">
           <div class="center wow fadeInDown">
                <h2 class="informativos">INFORMATIVOS</h2>
                <p class="lead"><!-- DADOS --><br /> <!-- Conteudo --></p>
                </div>

            <div class="row">

                
                <div class="features">

                    
                   
                   
                    <asp:Label ID="lblLinkata" runat="server" />


                       
                    
                                    
                        <asp:Panel ID="PanelDocumentos" runat="server" Enable="true">

                            <br />
                            <center><h2>Balancetes</h2></center>

                            <asp:GridView ID="GridBalancetes" runat="server" Visible="true" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="false">
                                <Columns>
                                    <asp:BoundField DataField="Nome" HeaderText="Nome" />
                                        <asp:TemplateField HeaderText="Baixar">
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="lkBalancetes" OnClick="lkBalancetes_Click" runat="server" CommandArgument='<% Eval("Nome") %>'>Download</asp:LinkButton>
                                                </ItemTemplate>
                                        </asp:TemplateField>
                                </Columns>
                            </asp:GridView>



                            <center> 
                              <h2>Documentos Diversos</h2>
                            </center>
                    
                            <asp:GridView ID="GridDocumentos" runat="server" visible="true" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="false">
                                <Columns>
                                    <asp:BoundField  DataField="Nome"  HeaderText="Nome" />
                                    

                                        <asp:TemplateField HeaderText="Baixar">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lkBaixar" OnClick="lkBaixar_Click" runat="server" CommandArgument='<%# Eval("Nome") %>'>Download</asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                </Columns>
                           </asp:GridView>
                           

                            <center><h2>Formulários</h2></center>

                            <asp:GridView ID="GridFormulario" runat="server" Visible="true" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="false">
                                <Columns>
                                    <asp:BoundField DataField="Nome" HeaderText="Nome" />
                                        <asp:TemplateField HeaderText="Baixar">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lkFormularioBaixar" OnClick="lkFormularioBaixar_Click" runat="server" CommandArgument='<%# Eval("Nome") %>'>Download</asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                </Columns>
                            </asp:GridView>

                         
                    
                        </asp:Panel>
                          
                </div>
                
            </div><!--/.row-->    
        </div><!--/.container-->
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
                            <p>Entre em contato com a gente (11) 2225.0507</p>
                        </div>
                    </div>
                </div>
            </div>
        </div><!--/.container-->    
    </section><!--/#conatcat-info-->

        <!-- 
    </section>
        
        #bottom  -->

    <footer id="footer" class="midnight-blue">
        <div class="container">
            <div class="row">
                <div class="col-sm-6">
                    &copy; 2015 <a target="_blank" href="http://www.walleg.com.br/" title="Desenvolvido por Walleg Informatica">Walleg Informatica</a>. All Rights Reserved.
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
