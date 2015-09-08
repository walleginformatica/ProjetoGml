<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu-boleto.aspx.cs" Inherits="BoletoGml.Security.menu_boleto" %>

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
        
        <!--
    
        -->

    <header id="header">
        <div class="top-bar">
            <div class="container">
                <div class="row">
                    <div class="col-sm-6 col-xs-4">
                        <div class="top-number"><p><i class="fa fa-phone-square"></i>  +55(11) 2225.0507</p></div>
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
                    <a class="navbar-brand" href="../Security/admin-menu.aspx"><img src="../images/logo.png" alt="logo" /></a>
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
                <h2>Boletos</h2>
                <p class="lead">Selecione as opções abaixo :<br /></p>
            </div>

            <div class="container">
                
                <!--<div class="features">-->
                    
                <center>
                        <asp:Button ID="btnVerificarBoletos" runat="server"  CssClass="btn-danger" Text="Boletos em Aberto" OnClick="btnVerificarBoletos_Click" Width="150px"/>
                        
                        <asp:Button ID="btnGerarBoleto" runat="server" CssClass="btn-danger" Text="Gerar Boleto" Width="150px" Visible="false"  OnClick="btnGerarBoleto_Click"/>
                        
                        <asp:Button ID="btnGerarSegVia" runat="server" CssClass="btn-danger" Text="2° Via Boleto" Width="150px" Enabled="false"  Visible="false"  OnClick="btnGerarSegVia_Click"/>
                        
                        <asp:Button ID="Button1" runat="server" CssClass="btn-danger" Text="Útimos Pagamentos" Width="150px" OnClick="Button1_Click"/>
                <br />
                <br />
                </center>
                

                     <div class="table-responsive">

                              <asp:Panel ID="PanelLateral" runat="server" Visible="false">
                            
                                  
                                  <asp:GridView ID="GridLateral" runat="server" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="NumDocumento" EmptyDataText="Você não possui nenhuma fatura em aberto." OnSelectedIndexChanged="GridLateral_SelectedIndexChanged" OnPageIndexChanging="GridLateral_PageIndexChanging" AllowPaging="true" EnableModelValidation="true" PageSize="10">  
                                         <Columns>  
                                            <asp:BoundField DataField="NumDocumento" HeaderText="Numero do Documento" ReadOnly="True" SortExpression="NumDocumento" />  
                                            <asp:BoundField DataField="ValorBoleto" HeaderText="Valor Do Boleto" SortExpression="EmissaoBoleto" HeaderStyle-CssClass="visible-lg" ItemStyle-CssClass="visible-lg">  
                                             <HeaderStyle CssClass="visible-lg" />
                                             <ItemStyle CssClass="visible-lg" />
                                             </asp:BoundField>
                                            <asp:BoundField DataField="VencimentoBoleto" HeaderText="Vencimento" SortExpression="VencimentoBoleto" ItemStyle-CssClass="visible-lg" HeaderStyle-CssClass="visible-lg" >  
                                             <HeaderStyle CssClass="visible-lg" />
                                             <ItemStyle CssClass="visible-lg" />
                                             </asp:BoundField>
                                           
                                             <asp:CommandField ButtonType="Image" HeaderText="Imprimir" ShowHeader="True" ShowSelectButton="True" SelectText="Visualizar" SelectImageUrl="../images/print icon png.png" ControlStyle-Width="30px" />
                                             
                                        </Columns>
                                        <HeaderStyle Font-Size="Smaller" />
                                             <PagerStyle Font-Size="Smaller" />
                                             <RowStyle Font-Size="Smaller" />

                                           
                                
                                </asp:GridView> 
                            
                              <!-- OUTRO GRID --->
                             
                                   </asp:Panel>
                            
                               <asp:Panel ID="PainelLateralBlt" runat="server"  Visible="false">

                                       <asp:GridView ID="GridViewListarBoletos" runat="server" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="NumDocumento" EmptyDataText="Você ainda não possui nenhuma fatura" OnSelectedIndexChanged="GridLateral_SelectedIndexChanged" OnPageIndexChanged="GridViewListarBoletos_PageIndexChanged" OnPageIndexChanging="GridViewListarBoletos_PageIndexChanging"  AllowPaging="true" EnableModelValidation="true" PageSize="10">  
                                         <Columns>  
                                            <asp:BoundField DataField="NumDocumento" HeaderText="Numero do Documento" ReadOnly="True" SortExpression="NumDocumento" />  
                                            <asp:BoundField DataField="ValorBoleto" HeaderText="Valor Do Boleto" SortExpression="EmissaoBoleto" HeaderStyle-CssClass="visible-lg" ItemStyle-CssClass="visible-lg" >  
                                             <HeaderStyle CssClass="visible-lg" />
                                             <ItemStyle CssClass="visible-lg" />
                                             </asp:BoundField>
                                            <asp:BoundField DataField="VencimentoBoleto" HeaderText="Vencimento" SortExpression="VencimentoBoleto" ItemStyle-CssClass="visible-lg" HeaderStyle-CssClass="visible-lg" >  
                                             <HeaderStyle CssClass="visible-lg" />
                                             <ItemStyle CssClass="visible-lg" />
                                             </asp:BoundField>
                                            <asp:BoundField DataField="DataPagamento" HeaderText="Data Do Pagamento" SortExpression="DataPagamento" HeaderStyle-CssClass="visible-lg" ItemStyle-CssClass="visible-lg" >  
                                             <HeaderStyle CssClass="visible-lg" />
                                             <ItemStyle CssClass="visible-lg" />
                                             </asp:BoundField>
                                             </Columns> 
                                            
                                     </asp:GridView> 
                                                
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
                            <h2>Qualquer duvida entre em contato. (11) 2225.0507</div>
            </div>
        </div><!--/.container-->    
    </section><!--/#conatcat-info-->


    <footer id="footer" class="midnight-blue">
        <div class="container">
            <div class="row">
                <div class="col-sm-6">
                    &copy; 2015 <a target="_blank" href="http://www.walleg.com.br" title="Desenvolvido por Walleg Informatica">Walleg Informatica</a>. All Rights Reserved.
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
