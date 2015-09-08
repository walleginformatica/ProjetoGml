<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dicas.aspx.cs" Inherits="BoletoGml.dicas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>GML | ADMINISTRADORA</title>
	
	
    <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/font-awesome.min.css" rel="stylesheet" />
    <link href="css/animate.min.css" rel="stylesheet" />
    <link href="css/prettyPhoto.css" rel="stylesheet" />
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/responsive.css" rel="stylesheet" />
    <link href="css/estilo.css" type="text/css" rel="stylesheet" />
    <!--[if lt IE 9]>
    <script src="js/html5shiv.js"></script>
    <script src="js/respond.min.js"></script>
    <![endif]-->       
    <link rel="shortcut icon" href="images/ico/favicon.ico" />
    <link rel="apple-touch-icon-precomposed" sizes="144x144" href="images/ico/apple-touch-icon-144-precomposed.png" />
    <link rel="apple-touch-icon-precomposed" sizes="114x114" href="images/ico/apple-touch-icon-114-precomposed.png" />
    <link rel="apple-touch-icon-precomposed" sizes="72x72" href="images/ico/apple-touch-icon-72-precomposed.png" />
    <link rel="apple-touch-icon-precomposed" href="images/ico/apple-touch-icon-57-precomposed.png" />
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
                           <!--
                            <div class="search">
                                <form role="form">
                                    <input type="text" class="search-form" autocomplete="off" placeholder="Search">
                                    <i class="fa fa-search"></i>
                                </form>
                           </div>
                           -->
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
                    <a class="navbar-brand" href="Default.aspx"><img src="images/logo.png" alt="logo"></a>
                </div>
                
                <div class="collapse navbar-collapse navbar-right">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="Default.aspx">Home</a></li>
                       <!-- <li><a href="about-us.html">About Us</a></li>-->
                        <li><a href="servicos.aspx">Serviços</a></li>
                        <li><a href="dicas.aspx">Dicas</a></li>
                        <li><a href="contato.aspx">Contato</a></li>
                        <li><a href="Security/admin.aspx">Portal</a></li>               
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
        <!--
        <div class="gmap-area">
            -->
            <div class="container">
                <div class="row">
                   
                    <!-- CONTEUDO -->

                   
                
                </div>
            </div>
       <!-- </div> -->
    </section>  <!--/gmap_area -->

    <section id="contact-page">
        <div class="container">
             <div id="texto-pag-dicas">
                <ul>
                    <li>
                        Solicitar, semestralmente, as certidões negativas à  Previdência Social e à  Receita Federal, a fim de verificar
                        se os encargos sociais estão sendo devidamente recolhidos.<br />
                    </li>
                    
                    <li>
                        Verificar se as autenticações lançadas nos comprovantes de pagamento, constantes das pastas de prestação de contas
                        são compatíveis com aquelas lançadas pelas máquinas dos bancos  ( autenticações pontilhadas).<br />
                    </li>
                    
                    <li>
                        A aplicação de multa ao condômino infrator às  normas do Regulamento Interno deve ser a última providência, sendo
                        aconselhável, antes de sua aplicação, levar o caso concreto à  apreciação do Conselho Consultivo, para que esse apresente
                        seu parecer, avaliando a aplicação das sanções previstas, tais como, advertência verbal, escrita e o grau da infração ( leve, grave, gravíssima),
                        bem como, o valor da multa, se for o caso. Levando-se sempre em consideração os termos da Convenção Condominial e do Regulamento Interno.<br />
                    </li>

                    <li>
                       O condômino inadimplente não deve ser exposto ou ridicularizado diante dos demais condôminos, pois o
                       condomínio possui de meios próprios e legais para o recebimento de seu crédito.<br />
                    </li>

                    <li>
                        O diálogo e a cordialidade devem prevalecer na relação entre os condôminos, o síndico e seu conselho de administração.<br />
                    </li>

                    <li>
                        É aconselhável que os membros do conselho de administração sejam convocados para as reuniões com o síndico,
                        por escrito e mediante protocolo.<br />
                    </li>

                    <li>
                        Abrir oportunidades aos condôminos para que concorram em igualdade de condições, com empresas / profissionais liberais,
                        que estão sendo cotados para prestarem serviços ao condomínio.<br />
                    </li>

                    <li>
                        Solicitar aos membros do conselho de administração, que também participem das cotações para a aquisição de
                        bens ou serviços ao condomínio.<br />
                    </li>

                    <li>
                       Prestar contas mensalmente de todas as despesas pagas pelo condomínio, bem como, de toda a arrecadação.<br />
                    </li>

                    <li>
                        Os funcionários contratados pelas empresas terceirizadas de portaria, limpeza e segurança não devem receber
                        ordens do síndico, mas este devem reportar-se aos supervisores, que tomarão as providências necessárias, evitando-se a subordinação.<br />
                    </li>
                
                </ul>
                </div><!-- fim -->

            <!--- repetição -->

             <div id="image-esquerda">
                <img src="images/dicas.jpg" width="20%"  />
                </div><!-- fim -->
          
                
          
            
        </div><!--/.container-->
        
        
        
    </section><!--/#contact-page-->

   

    <footer id="footer" class="midnight-blue">
        <div class="container">
            <div class="row">
                <div class="col-sm-6">
                    &copy; 2013 <a target="_blank" href="http://www.walleginformatica.com.br" title="Free Twitter Bootstrap WordPress Themes and HTML templates">Walleg informatica</a>. All Rights Reserved.
                </div>
                
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
