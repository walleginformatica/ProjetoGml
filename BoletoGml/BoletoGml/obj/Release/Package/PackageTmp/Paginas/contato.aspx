﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="contato.aspx.cs" Inherits="BoletoGml.Paginas.contato" %>

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
    <div>
    

    <header id="header">
        <div class="top-bar">
            <div class="container">
                <div class="row">
                    <div class="col-sm-6 col-xs-4">
                        <div class="top-number"><p><i class="fa fa-phone-square"></i><asp:Label ID="lblTelHeader" runat="server" /></p></div>
                    </div>
                    <div class="col-sm-6 col-xs-8">
                       <div class="social">
                            <ul class="social-share">
                                <li><a href="#"><i class="fa fa-facebook"></i></a></li>
                                <li><a href="#"><i class="fa fa-twitter"></i></a></li>
                                <li><a href="#"><i class="fa fa-linkedin"></i></a></li> 
                                <li><a href="#"><i class="fa fa-dribbble"></i></a></li>
                                <li><a href="#"><i class="fa fa-skype"></i></a></li>
                            </ul>
                            <div class="search">
                                <form role="form">
                                    <input type="text" class="search-form" autocomplete="off" placeholder="Search">
                                    <i class="fa fa-search"></i>
                                </form>
                           </div>
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
                    <a class="navbar-brand" href="index.html"><img src="../images/logo.png" alt="logo"></a>
                </div>
                
                <div class="collapse navbar-collapse navbar-right">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="index.aspx">Home</a></li>
                       <!-- <li><a href="about-us.html">About Us</a></li>-->
                        <li><a href="servicos.aspx">Serviços</a></li>
                        <li><a href="dicas.aspx">Dicas</a></li>
                        <li><a href="contato.aspx">Contato</a></li>
                        <li><a href="sistema.aspx">Sistema</a></li>                 
                    </ul>
                </div>
            </div><!--/.container-->
        </nav><!--/nav-->
    </header><!--/header-->

    <section id="contact-info">
        <div class="center">                
            <h2></h2>
            <p class="lead"></p>
        </div>
        <div class="gmap-area">
            <div class="container">
                <div class="row">
                    <div class="col-sm-5 text-center">
                        <div class="gmap">
                            <iframe src="https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3657.7439300093347!2d-46.6351711306885!3d-23.541710769993465!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce5856f140b5a5%3A0x78a4f52e67d9c71e!2sAv.+Prestes+Maia%2C+241+-+Rep%C3%BAblica%2C+S%C3%A3o+Paulo+-+SP%2C+01031-001!5e0!3m2!1spt-BR!2sbr!4v1432578697673" width="600" height="450" frameborder="0" style="border:0"></iframe>
                        </div>
                    </div>

                    <div class="col-sm-7 map-content">
                        <ul class="row">
                            <li class="col-sm-6">
                                <address>
                                    <h5>GML CONDOMINIO</h5>
                                    <p>Av Prestes Maia, 241  Cjto.  2110<br>
                                     Centro – São Paulo CEP 01031-902</p>
                                    <p><asp:Label ID="lbltelefone" runat="server" /><br>
                                    <asp:Label ID="lblEmailGml" runat="server" /></p>
                                </address>

                                
                            </li>


                            <li class="col-sm-6">
                                

                                
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </section>  <!--/gmap_area -->

    <section id="contact-page">
        <div class="container">
            <div class="center">        
                <h2>Entre em Contato</h2>
                <p class="lead">Agende um Orçamento!</p>
            </div> 
            <div class="row contact-wrap"> 
                <div class="status alert alert-success" style="display: none"></div>
                
                    <div class="col-sm-5 col-sm-offset-1">
                        <div class="form-group">
                            <label>Nome *</label>
                            <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" />
                        </div>
                        <div class="form-group">
                            <label>Email *</label>
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" />
                            
                        </div>
                        <div class="form-group">
                            <label>Telefone</label>
                            <asp:TextBox ID="txttelefone" runat="server" CssClass="form-control" />
                            
                        </div>
                        <div class="form-group">
                            <label>Condominio</label>
                            
                            <asp:TextBox ID="txtCondominio" runat="server" CssClass="form-control" />
                        </div>                        
                    </div>
                    <div class="col-sm-5">
                        <div class="form-group">
                            <label>Assunto *</label>
                            
                            <asp:TextBox ID="txtAssunto" runat="server" CssClass="form-control" required="required" />
                        </div>
                        <div class="form-group">
                            <label>Menssagem *</label>
                            
                            <asp:TextBox ID="txtMenssagem" runat="server" CssClass="form-control" required="required" Rows="8" TextMode="MultiLine" />
                        </div>                        
                        <div class="form-group">
                            
                            <asp:Button ID="btnEnviarEmail" Text="Enviar" runat="server" CssClass="btn btn-primary btn-lg" required="required" />
                        </div>
                    </div>
                </form> 
            </div><!--/.row-->
        </div><!--/.container-->
    </section><!--/#contact-page-->

    <!--
        <section id="bottom">
        <div class="container wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
            <div class="row">
                <div class="col-md-3 col-sm-6">
                    <div class="widget">
                        <h3>Company</h3>
                        <ul>
                            <li><a href="#">About us</a></li>
                            <li><a href="#">We are hiring</a></li>
                            <li><a href="#">Meet the team</a></li>
                            <li><a href="#">Copyright</a></li>
                            <li><a href="#">Terms of use</a></li>
                            <li><a href="#">Privacy policy</a></li>
                            <li><a href="#">Contact us</a></li>
                        </ul>
                    </div>    
                </div>

                <div class="col-md-3 col-sm-6">
                    <div class="widget">
                        <h3>Support</h3>
                        <ul>
                            <li><a href="#">Faq</a></li>
                            <li><a href="#">Blog</a></li>
                            <li><a href="#">Forum</a></li>
                            <li><a href="#">Documentation</a></li>
                            <li><a href="#">Refund policy</a></li>
                            <li><a href="#">Ticket system</a></li>
                            <li><a href="#">Billing system</a></li>
                        </ul>
                    </div>    
                </div>

                <div class="col-md-3 col-sm-6">
                    <div class="widget">
                        <h3>Developers</h3>
                        <ul>
                            <li><a href="#">Web Development</a></li>
                            <li><a href="#">SEO Marketing</a></li>
                            <li><a href="#">Theme</a></li>
                            <li><a href="#">Development</a></li>
                            <li><a href="#">Email Marketing</a></li>
                            <li><a href="#">Plugin Development</a></li>
                            <li><a href="#">Article Writing</a></li>
                        </ul>
                    </div>    
                </div>

                <div class="col-md-3 col-sm-6">
                    <div class="widget">
                        <h3>Our Partners</h3>
                        <ul>
                            <li><a href="#">Adipisicing Elit</a></li>
                            <li><a href="#">Eiusmod</a></li>
                            <li><a href="#">Tempor</a></li>
                            <li><a href="#">Veniam</a></li>
                            <li><a href="#">Exercitation</a></li>
                            <li><a href="#">Ullamco</a></li>
                            <li><a href="#">Laboris</a></li>
                        </ul>
                    </div>    
                </div>
            </div>
        </div>
    </section>

        -->

    <footer id="footer" class="midnight-blue">
        <div class="container">
            <div class="row">
                <div class="col-sm-6">
                    &copy; 2013 <a target="_blank" href="http://www.walleginformatica.com.br" title="Free Twitter Bootstrap WordPress Themes and HTML templates">Walleg informatica</a>. All Rights Reserved.
                </div>
                <!--
                <div class="col-sm-6">
                    <ul class="pull-right">
                        <li><a href="#">Home</a></li>
                        <li><a href="#">About Us</a></li>
                        <li><a href="#">Faq</a></li>
                        <li><a href="#">Contact Us</a></li>
                    </ul>
                </div>
                -->
            </div>
        </div>
    </footer><!--/#footer-->

    <script src="js/jquery.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/jquery.prettyPhoto.js"></script>
    <script src="js/jquery.isotope.min.js"></script>
    <script src="js/main.js"></script>
    <script src="js/wow.min.js"></script>

    </div>
    </form>
</body>
</html>