<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="servicos.aspx.cs" Inherits="BoletoGml.servicos" %>

<!DOCTYPE html lang="pt-br">

<html lang="pt-br">
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
       
            <div class="container">

                
                <script type="text/javascript">
                    function mostraum() {
                        document.getElementById('conteudo-um').style.display = 'block';
                    }
                    function escondeum() {
                        document.getElementById('conteudo-um').style.display = 'none';
                    }


                    function mostradois() {
                        document.getElementById('conteudo-dois').style.display = 'block';
                    }
                    function escondedois() {
                        document.getElementById('conteudo-dois').style.display = 'none';
                    }

                    function mostratres() {
                        document.getElementById('conteudo-tres').style.display = 'block';
                    }
                    function escondetres() {
                        document.getElementById('conteudo-tres').style.display = 'none';
                    }
                
                    </script>

                
                <div id="menu-botao">
                    
                    
                    <a href="#" onmouseover="javascript:mostraum();" onmouseout="escondeum();"><div class="button">ADMINISTRAÇÃO DE CONDOMÍNIOS</div></a><br />
                    <a href="#" onmouseover="javascript:mostradois();" onmouseout="escondedois();"><div class="button">DO DEPARTAMENTO JURÍDICO</div></a><br />
                    <a href="#" onmouseover="javascript:mostratres();" onmouseout="escondetres();"><div class="button">AUTOGESTÃO CONDOMINIAL</div></a>

                </div>

                <div id="menu-conteudo">

                 <div id="conteudo-um"> A GML oferece ao síndico todos os serviços inerentes à administração, tais como a contabilização de todas as despesas
                 e receitas do condomínio, com a elaboração da pasta de prestação de contas; emissão de balancetes mensais; geração e
                 emissão de boletos bancários para o pagamentos das cotas condominiais; emissão de relação mensal de devedores e de
                 acordos realizados; previsão orçamentária, prestação de contas anual; aplicação de advertências e multas, por infração
                 às normas do condomínio ( conforme determinação do síndico); elaboração de editais e atas de assembléias; folha de pagamento,
                 dentre outros. A organização e a participação nas assembléias gerais realizadas pelo condomínio, não serão cobradas à parte.
                 <br />
                 O diferencial da GML estão em manter contato pessoal e direto com o síndico e seu conselho de administração, atendendo às suas
                 necessidades reais, tornando a gestão condominial eficiente e satisfatória a todos os condôminos.
                 As visitas semanais por profissionais da GML ao síndico do condomínio, a participação em reuniões com o conselho de administração,
                 isto é, a interatividade no processo administrativo, são ótimas oportunidades para obter informações, orientações, sanar dúvidas,
                 desenvolver e implementar projetos úteis e aplicáveis ao condomínio.
                </div>
                
                <div id="conteudo-dois"> A GML conta com departamento jurídico próprio, responsável pela cobrança extrajudicial e judicial de despesas condominiais em atraso,
                objetivando sempre a conciliação, com ótimos resultados; e em casos extremos, a propositura de ações judiciais de cobrança, rigorosamente acompanhadas.
                A prestação de contas de toda a cobrança realizada, seja judicial ou extrajudicial é mensal, inclusive todos os andamentos processuais, a fim de que o
                síndico e seu conselho acompanhem mãos a mãos, o resultado dos trabalhos realizados.
                O departamento jurídico da GML oferece ao condomínio, serviços de consultoria jurídica na análise de contratos com fornecedores, empresas contratadas e prestadores de serviços, sem cobrar mais por isso.
               </div>
                
               <div id="conteudo-tres">Aos condomínios que optaram pelo sistema da autogestão, a GML oferece os serviços de assessoria-jurídico administrativa ao síndico, que terá todo o respaldo necessário para uma gestão tranquila e eficiente.
                Cada condomínio tem o atendimento personalizado, de modo a atender as suas necessidades, seja na Área administrativa, contábil ou jurídica.
                A organização de participação nas assembléias gerais, não tem nenhum custo a mais para o condomínio, que pagará somente a taxa mensal pela prestação da assessoria-administrativa</div>
               </div>
            
        </div>
       <!-- </div> -->
    </section>  

    <section id="contact-page">
        
        <!--<div class="container"> -->
            
            
        <!--</div>--><!--/.container-->
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
