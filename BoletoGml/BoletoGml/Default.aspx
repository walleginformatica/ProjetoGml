<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BoletoGml.Paginas.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>GML | ADMINISTRADORA</title>
	
	<!-- core CSS -->
    <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/font-awesome.min.css" rel="stylesheet" />
    <link href="css/animate.min.css" rel="stylesheet" />
    <link href="css/prettyPhoto.css" rel="stylesheet" />
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/responsive.css" rel="stylesheet" />
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

<body class="homepage">
    <form id="form1" runat="server">

    <header id="header">
        <div class="top-bar">
            <div class="container">
                <div class="row">
                    <div class="col-sm-6 col-xs-4">
                        <div class="top-number"><p><i class="fa fa-phone-square"></i><asp:Label ID="lbltelefoneheader" runat="server"></asp:Label></p></div>
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

    <section id="main-slider" class="no-margin">
        <div class="carousel slide">
            <ol class="carousel-indicators">
                <li data-target="#main-slider" data-slide-to="0" class="active"></li>
                <li data-target="#main-slider" data-slide-to="1"></li>
                <li data-target="#main-slider" data-slide-to="2"></li>
            </ol>
            <div class="carousel-inner">

                <div class="item active" style="background-image: url(images/slider/bg1.jpg)">
                    <div class="container">
                        <div class="row slide-margin">
                            <div class="col-sm-6">
                                <div class="carousel-content">
                                    <h1 class="animation animated-item-1">SEJA BEM VINDO!</h1>
                                    <h2 class="animation animated-item-2">GML ADMINISTRAÇÃO E GESTÃO DE CONDOMÍNIOS</h2>
                                    <a class="btn-slide animation animated-item-3" href="contato.aspx">SOLICITE UMA PROPOSTA</a>
                                </div>
                            </div>

                            <div class="col-sm-6 hidden-xs animation animated-item-4">
                                <div class="slider-img">
                                    <!--<img src="images/slider/img1.png" class="img-responsive">-->
                                </div>
                            </div>

                        </div>
                    </div>
                </div><!--/.item-->

                <div class="item" style="background-image: url(images/slider/bg2.jpg)">
                    <div class="container">
                        <div class="row slide-margin">
                            <div class="col-sm-6">
                                <div class="carousel-content">
                                    <h1 class="animation animated-item-1">ESTÁ A PROCURA DE MELHORIAS PARA SEU CONDOMÍNIO?</h1>
                                    <h2 class="animation animated-item-2">VEIO AO LUGAR CERTO</h2>
                                    <a class="btn-slide animation animated-item-3" href="contato.aspx">SOLICITE UMA PROPOSTA</a>
                                </div>
                            </div>

                            <div class="col-sm-6 hidden-xs animation animated-item-4">
                                <div class="slider-img">
                                    <img src="images/slider/img2.png" class="img-responsive">
                                </div>
                            </div>

                        </div>
                    </div>
                </div><!--/.item-->

                <div class="item" style="background-image: url(images/slider/bg3.jpg)">
                    <div class="container">
                        <div class="row slide-margin">
                            <div class="col-sm-6">
                                <div class="carousel-content">
                                    <h1 class="animation animated-item-1">EQUIPE COM A DISPOSIÇÃO DE ÓTIMOS PROFISSIONAIS</h1>
                                    <h2 class="animation animated-item-2">PRONTO PARA RESOLVER O PROBLEMA NO SEU CONDOMÍNIO</h2>
                                    <a class="btn-slide animation animated-item-3" href="contato.aspx">SOLICITE UMA PROPOSTA</a>
                                </div>
                            </div>
                            <div class="col-sm-6 hidden-xs animation animated-item-4">
                                <div class="slider-img">
                                    <!--<img src="images/slider/img3.png" class="img-responsive">-->
                                </div>
                            </div>
                        </div>
                    </div>
                </div><!--/.item-->
            </div><!--/.carousel-inner-->
        </div><!--/.carousel-->
        <a class="prev hidden-xs" href="#main-slider" data-slide="prev">
            <i class="fa fa-chevron-left"></i>
        </a>
        <a class="next hidden-xs" href="#main-slider" data-slide="next">
            <i class="fa fa-chevron-right"></i>
        </a>
    </section><!--/#main-slider-->

    <section id="feature" >
        <div class="container">
           <div class="center wow fadeInDown">
                <h2>Nossa Proposta</h2>
                <p class="lead">Administração e Gestão de Condomínio em Geral<br></p>
            </div>

            <div class="row">
                <div class="features">
                    <div class="col-md-4 col-sm-6 wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                        <div class="feature-wrap">
                            <i class="fa fa-bullhorn"></i>
                            <h2>ADMINISTRAÇÃO</h2>
                            <h3>Gestão geral do setor Administrativo<br /><a href="servicos.aspx">Saber Mais..</a></h3>
                        </div>
                    </div><!--/.col-md-4-->

                    <div class="col-md-4 col-sm-6 wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                        <div class="feature-wrap">
                            <i class="fa fa-bullhorn"></i>
                            <h2>CONTABILIDADE</h2>
                            <h3>Gestão geral do setor Contabilidade<br /><a href="servicos.aspx">Saber Mais..</a></h3>
                        </div>
                    </div><!--/.col-md-4-->

                    <div class="col-md-4 col-sm-6 wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                        <div class="feature-wrap">
                            <i class="fa fa-bullhorn"></i>
                            <h2>COBRANÇA EXTRAJUDICIAL</h2>
                            <h3>Gestão geral do setor Cobrança Extrajucial<br /><a href="servicos.aspx">Saber Mais..</a></h3>
                        </div>
                    </div><!--/.col-md-4-->
                
                    <div class="col-md-4 col-sm-6 wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                        <div class="feature-wrap">
                            <i class="fa fa-bullhorn"></i>
                            <h2>COBRANÇA JUDICIAL</h2>
                            <h3>Gestão geral do setor Cobrança Judicial<br /><a href="servicos.aspx">Saber Mais..</a></h3>
                        </div>
                    </div>
                    
                   
                        
                </div><!--/.services-->
            </div><!--/.row-->    
        </div><!--/.container-->
    </section><!--/#feature-->

    <section id="recent-works">
        <div class="container">
            <div class="center wow fadeInDown">
                <h2>A Empresa</h2>
                <p class="lead">
                    A GML é uma administradora de Condomínios, que apresenta uma proposta de trabalho diferenciada no <br> 
                    mercado: a interatividade com o Síndico e membros do Conselho, nas atividades administrativas. Essa 
                    <br>interatividade que se dá, inclusive, pessoalmente, por meio de visitas ao Condomínio, 
                    <br>resulta em uma administração personalizada, transparente e eficiente a todos os Condôminos, pois aqueles que foram 
                    <br>eleitos para participarem do Conselho de Administração com o Síndico, também acompanham como funciona toda a rotina administrativa.
                    <br>Através do resultado dessa interatividade, a GML objetiva proporcionar ao Síndico e seu Conselho , maior segurança na gestão administrativa, e aos Condôminos
                    a tranquilidade de terem à  frente da Administração do Condomínio, pessoas capacitadas e preparadas para representá-los.
                    <br>Se você é um Síndico inexperiente no gerenciamento condominial, mas com disposição para adquirir o conhecimento,
                    <br> a GML é a administradora que poderá fazer a diferença em sua gestão, afinal, conhecimento é tudo!</p>

            </div>

            <!--
            
            
            row-->


        </div><!--/.container-->
    </section><!--/#recent-works-->

        <!--
   
        -->
       

    <section id="middle">
        <div class="container">
            
            <!--
           

            </div>   ######## Final -->
       
        
        </div><!--/.container-->
    </section><!--/#middle-->

    <section id="content">
        <div class="container">
            <div class="row">
                <div class="col-xs-12 col-sm-8 wow fadeInDown">
                   <div class="tab-wrap"> 
                        <div class="media">
                            <div class="parrent pull-left">
                                <ul class="nav nav-tabs nav-stacked">
                                    <li class=""><a href="#tab1" data-toggle="tab" class="analistic-01">Dicas</a></li>
                                    <li class="active"><a href="#tab2" data-toggle="tab" class="analistic-02"></a></li>
                                    <li class=""><a href="#tab3" data-toggle="tab" class="tehnical"></a></li>
                                    <li class=""><a href="#tab4" data-toggle="tab" class="tehnical"></a></li>
                                    <li class=""><a href="#tab5" data-toggle="tab" class="tehnical"></a></li>
                                </ul>
                            </div>

                            <div class="parrent media-body">
                                <div class="tab-content">
                                    <div class="tab-pane fade" id="tab1">
                                        <div class="media">
                                           <div class="pull-left">
                                                <!--<img class="img-responsive" src="images/tab2.png">-->
                                            </div>
                                            <div class="media-body">
                                                 <h2>Dicas</h2>
                                                 <p>Abrir oportunidades aos condôminos para que concorram em igualdade de condições, com empresas / profissionais liberais, que estão sendo cotados para prestarem serviços ao condomínio.</p>
                                            </div>
                                        </div>
                                    </div>

                                     <div class="tab-pane fade active in" id="tab2">
                                        <div class="media">
                                           <div class="pull-left">
                                                <!--<img class="img-responsive" src="images/tab1.png">-->
                                            </div>
                                            <div class="media-body">
                                                 <h2>Dicas</h2>
                                                 <p>O diálogo e a cordialidade devem prevalecer na relação entre os condôminos, o síndico e seu conselho de administração.
                                                 </p>
                                            </div>
                                        </div>
                                     </div>

                                     <div class="tab-pane fade" id="tab3">
                                        <p> A aplicação de multa ao condômino infrator às  normas do Regulamento Interno deve ser a última providência, sendo aconselhável, antes de sua aplicação, levar o caso concreto à  apreciação do Conselho Consultivo, para que esse apresente seu parecer, avaliando a aplicação das sanções previstas, tais como, advertência verbal, escrita e o grau da infração ( leve, grave, gravíssima), bem como, o valor da multa, se for o caso. Levando-se sempre em consideração os termos da Convenção Condomínial e do Regulamento Interno.</p>
                                     </div>
                                     
                                     <div class="tab-pane fade" id="tab4">
                                        <p>Solicitar, semestralmente, as certidões negativas à  Previdência Social e à  Receita Federal, a fim de verificar se os encargos sociais estão sendo devidamente recolhidos.</p>
                                     </div>

                                     <div class="tab-pane fade" id="tab5">
                                        <p>Os funcionários contratados pelas empresas terceirizadas de portaria, limpeza e segurança não devem receber ordens do síndico, mas este devem reportar-se aos supervisores, que tomarão as providências necessárias, evitando-se a subordinação.</p>
                                     </div>
                                </div> <!--/.tab-content-->  
                            </div> <!--/.media-body--> 
                        </div> <!--/.media-->     
                    </div><!--/.tab-wrap-->               
                </div><!--/.col-sm-6-->
                
                <!-- Depoimento moradores
                <div class="col-xs-12 col-sm-4 wow fadeInDown">
                    <div class="testimonial">
                        <h2>Depoimento dos Moradores</h2>
                         <div class="media testimonial-inner">
                            <div class="pull-left">
                                <img class="img-responsive img-circle" src="images/testimonials1.png">
                            </div>
                            <div class="media-body">
                                <p>Realmente com a GML administrando nosso Condomínio, as coisas melhoraram muito!</p>
                                <span><strong>-João/</strong>Morador</span>
                            </div>
                         </div>

                         <div class="media testimonial-inner">
                            <div class="pull-left">
                                <img class="img-responsive img-circle" src="images/testimonials2.png">
                            </div>
                            <div class="media-body">
                                <p>Realmente veio para melhorar !</p>
                                <span><strong>-Maria/</strong> Moradora</span>
                            </div>
                         </div>

                    </div>
                </div>
            -->
            </div><!--/.row-->
        </div><!--/.container-->
    </section><!--/#content-->
<!--
    
        
     #partner-->

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
                            <p>Entre em contato com a gente, e agende um orçamento.<asp:Label ID="lbltelefones" runat="server" ></asp:Label></p>
                        </div>
                    </div>
                </div>
            </div>
        </div><!--/.container-->    
    </section><!--/#conatcat-info-->

        <!-- ########### ultima sessão
   
        
        #bottom  -->

    <footer id="footer" class="midnight-blue">
        <div class="container">
            <div class="row">
                <div class="col-sm-6">
                    &copy; 2013 <a target="_blank" href="http://shapebootstrap.net/" title="Free Twitter Bootstrap WordPress Themes and HTML templates">Walleg Informatica</a>. All Rights Reserved.
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

</form> 
</body>
</html>
    
