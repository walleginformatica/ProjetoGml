using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using BoletoGml.Classes;
using BoletoGml.Paginas;
using BoletoNet;

using System.Web.UI;
using System.Web.UI.WebControls;

namespace BoletoGml.Classes
{
    public class CriarBoleto
    {
        //objeto usado para armazenar os dados do banco
        private static Atributos Morador = new Atributos();

        //Classe para gerar novo boleto
        public static BoletoBancario VisualizarBoleto()
        {

                Atributos Acessando = BoletoDAL.CarregarDadosBoleto(Usuario.Bloco, Usuario.Apartamento, Usuario.CodMorador);
            
          
                Acessando.Pago = 0;
                Acessando.VenciBoleto = DateTime.Now.Date.AddDays(15);
                Acessando.EmissaoBoleto = DateTime.Now.Date;


                String DataBlt = Convert.ToString(DateTime.Now.ToShortDateString());
                Random aleatorio = new Random();

                //int oi = aleatorio.Next(9);
                //int digito = 
                int digito = DigitoVerificador.DigitoModulo11(aleatorio.Next(9));
                Acessando.NumeroDocumento = DataBlt.Replace("/", "") + Usuario.Apartamento + Usuario.Bloco + digito;

                //###############################################

                //Informa os dados do cedente
                Cedente DadosCedente;


                //DadosCedente = new Cedente(txtCPFCNPJ.Text, txtNomeCedente.Text, txtAgenciaCendente.Text, txtContaCedente.Text);
                DadosCedente = new Cedente(Acessando.CnpjCondominio, Acessando.NomeCondominio, Acessando.AgenciaCondominio, Acessando.ContaCondominio);

                //Dependendo da carteira, é necessário informar o código do cedente (o banco que fornece)
                DadosCedente.Codigo = Convert.ToString(Acessando.CodCondominio);

                //'Dados para preenchimento do boleto (data de vencimento, valor, carteira e nosso número)
                Boleto boleto;
                boleto = new BoletoNet.Boleto(Convert.ToDateTime(Acessando.VenciBoleto), Convert.ToDecimal(Acessando.ValorBoleto), "09", Acessando.NossoNumero, DadosCedente);

                // 'Dependendo da carteira, é necessário o número do documento
                boleto.NumeroDocumento = Acessando.NumeroDocumento;

                //Informa os dados do sacado
                boleto.Sacado = new Sacado(Acessando.CpfMorador, Acessando.NomeMorador);
                boleto.Sacado.Endereco.End = Acessando.EndMorador;
                boleto.Sacado.Endereco.Bairro = Acessando.BairroMorador;
                boleto.Sacado.Endereco.Cidade = Acessando.CidadeMorador;
                boleto.Sacado.Endereco.CEP = Acessando.CepMorador;
                boleto.Sacado.Endereco.UF = Acessando.UfMorador;

                /*  
                 Dim i As New Instrucao_Bradesco()
                i.Descricao = "Não Receber após o vencimento"
                b.Instrucoes.Add(i)
                 */

                Instrucao_Bradesco insBoleto;
                insBoleto = new Instrucao_Bradesco();

                insBoleto.Descricao = Acessando.Instrucao1 + "<br />" + Acessando.Instrucao2 + "<br />" + Acessando.Instrucao3 + "<br />" + Acessando.Instrucao4 + "<br />" + Acessando.Instrucao5 + "<br/>";

                boleto.Instrucoes.Add(insBoleto);

                /* 
                  'Espécie do Documento - [R] Recibo
                   b.EspecieDocumento = New EspecieDocumento_Bradesco(17)

                  Dim bb As New BoletoBancario()
                  bb.CodigoBanco = 237 '-> Referente ao código do Santander
                  bb.Boleto = b
                ' bb.GeraImagemCodigoBarras(b) 
                */

                boleto.EspecieDocumento = new EspecieDocumento_Bradesco("17");

                BoletoBancario boletob;

                boletob = new BoletoBancario();

                boletob.CodigoBanco = 237; // CODIGO DO BANCO 

                boletob.Boleto = boleto;

                boletob.GeraImagemCodigoBarras(boleto);

                //bb.Boleto.Valida()

                boletob.Boleto.Valida();






                BoletoDAL.GravarTbFatura();





                //true -> Mostra o compravante de entrega
                //false -> Oculta o comprovante de entrega

                //teste.testandopanel.Visible = true;
                //teste.testandopanel.Controls.Add(boletob);

                return boletob;
                //boletob.MostrarComprovanteEntrega = true;

                //b.panelBoleto.Visible = true;



                //if (panelBoleto.Controls.Count == 0)
                //{
                //b.panelBoleto.Controls.Add(boletob);
                //};

            }

        //classe para gerar boleto a partir da grid
        public static BoletoBancario VisualizarBoletoGrid()
        {
            //carregando os dados do banco para geração do boleto
            Morador = BoletoDAL.GerarBoletoGrid(Usuario.NumDocumento,/*Usuario.EmissaoBoleto,Usuario.VencimentoBoleto,*/ Usuario.Bloco, Usuario.Apartamento, Usuario.CodMorador);
            
            if (Morador != null)
            {
                DateTime DataAtual = DateTime.Today;
                
                if (DataAtual > Convert.ToDateTime(Morador.VenciBoleto))
                {
                    
                   int diascorridos = BoletoDAL.GetDiasCorridos(Morador.VenciBoleto, DataAtual);
                    
                    //passando os dados do banco para o objeto cedente para criação do boleto
                    Cedente DadosCedente;
                    DadosCedente = new Cedente(Morador.CnpjCondominio, Morador.NomeCondominio, Morador.AgenciaCondominio, Morador.ContaCondominio);
                    DadosCedente.Codigo = Convert.ToString(Morador.CodCondominio);
                    
                    Boleto boleto;
                    //removendo o digito verificado do numerodocumento
                    String NossoNumero = Morador.NumeroDocumento;
                    if (NossoNumero.Length != 8)
                    {
                        NossoNumero = NossoNumero.Remove(8);
                    }
                    
                    //calculando data do novo vencimento . data atual+15dias
                    //String DataVencimento = DateTime.Today.AddDays(15).ToString("dd/MM/yyyy");

                    String DataVencimento = DateTime.Today.ToString("dd/MM/yyyy");
                    //passando os dados do banco para o objeto boleto
                    boleto = new BoletoNet.Boleto(Convert.ToDateTime(DataVencimento), Convert.ToDecimal(Morador.ValorBoleto), "09", NossoNumero, DadosCedente);
                    
                    //correção monetaria + multa + juros
                    Double Correção = BoletoDAL.CorreçãoMonetaria(Morador.ValorBoleto, Morador.VenciBoleto);
                    Morador.ValorBoleto = Morador.ValorBoleto + Correção;
                    int mesescorridos = BoletoDAL.CalcularMesesPassados(DateTime.Today, Morador.VenciBoleto);
                    Decimal JurosMora = Convert.ToDecimal(Morador.ValorBoleto) * 1 / 100;// 1% do valor , divido por 30;
                    Decimal juros = JurosMora / 30 * diascorridos;
                    Decimal juroMultacorrigido = Convert.ToDecimal(Morador.ValorBoleto) * 2 / 100;

                    boleto.ValorBoleto = Convert.ToDecimal(Morador.ValorBoleto) + Convert.ToDecimal(juroMultacorrigido) + Convert.ToDecimal(juros);
                    
                    boleto.Carteira = "175";
                    boleto.Especie = "R$";
                    boleto.NumeroDocumento = NossoNumero;
                    
                    //passando dados sacado para o objeto boleto
                    boleto.Sacado = new Sacado(Morador.CpfMorador, Morador.NomeMorador);
                    boleto.Sacado.Endereco.End = Morador.EndMorador;
                    boleto.Sacado.Endereco.Bairro = Morador.BairroMorador;
                    boleto.Sacado.Endereco.Cidade = Morador.CidadeMorador;
                    boleto.Sacado.Endereco.CEP = Morador.CepMorador;
                    boleto.Sacado.Endereco.UF = Morador.UfMorador;

                    Instrucao_Itau InsBoleto = new Instrucao_Itau();
                    InsBoleto.Descricao = "APÓS O VENCIMENTO COBRAR MULTA DE 2% + 1% DE JUROS AO MÊS." + "<BR>" + "NÃO RECEBER 15 DIAS APOS O VENCIMENTO"; 
                    boleto.Instrucoes.Add(InsBoleto);
                    
                    //parametros do objeto boleto banco
                    boleto.EspecieDocumento = new EspecieDocumento_Itau("DM");
                    BoletoBancario boletob;
                    boletob = new BoletoBancario();
                    boletob.CodigoBanco = 341;
                    boletob.Boleto = boleto;
                    boletob.GeraImagemCodigoBarras(boleto);
                    boletob.Boleto.Valida();

                    Usuario.NumDocumento = null;
                    Usuario.EmissaoBoleto = null;
                    Usuario.VencimentoBoleto = null;

                    return boletob;

                }
                else
                {
                    

                    //passando os dados do banco para o objeto cedente para criação do boleto
                    Cedente DadosCedente;
                    DadosCedente = new Cedente(Morador.CnpjCondominio, Morador.NomeCondominio, Morador.AgenciaCondominio, Morador.ContaCondominio);
                    DadosCedente.Codigo = Convert.ToString(Morador.CodCondominio);

                    Boleto boleto;
                    //removendo o digito verificado do numerodocumento
                    String NossoNumero = Morador.NumeroDocumento;
                    if (NossoNumero.Length != 8)
                    {
                        NossoNumero = NossoNumero.Remove(8);
                    }

                    //passando os dados do banco para o objeto boleto
                    boleto = new BoletoNet.Boleto(Convert.ToDateTime(Morador.VenciBoleto), Convert.ToDecimal(Morador.ValorBoleto), "09", NossoNumero, DadosCedente);

                    boleto.ValorBoleto = Convert.ToDecimal(Morador.ValorBoleto);
                    boleto.Carteira = "175";
                    boleto.Especie = "R$";
                    boleto.NumeroDocumento = NossoNumero;

                    //passando dados sacado para o objeto boleto
                    boleto.Sacado = new Sacado(Morador.CpfMorador, Morador.NomeMorador);
                    boleto.Sacado.Endereco.End = Morador.EndMorador;
                    boleto.Sacado.Endereco.Bairro = Morador.BairroMorador;
                    boleto.Sacado.Endereco.Cidade = Morador.CidadeMorador;
                    boleto.Sacado.Endereco.CEP = Morador.CepMorador;
                    boleto.Sacado.Endereco.UF = Morador.UfMorador;

                    Instrucao_Itau InsBoleto = new Instrucao_Itau();

                    String DataVencimento = Morador.VenciBoleto.ToString("dd/MM/yyyy");
                    string mensagem = "";

                    if (Morador.DescontoCondominio != 0)
                    {
                        mensagem = "APÓS O VENCIMENTO COBRAR MULTA DE 2% + 1% DE JUROS AO MÊS. <br /> NÃO RECEBER APOS 15 DIAS DO VENCIMENTO.  <br /> ATÉ A DATA DO VENCIMENTO CONCEDER DESCONTO DE " + Morador.DescontoCondominio + " R$ "; /* "<br>" + Morador.Instrucao1 + "<br />" + Morador.Instrucao2 + "<br />" + Morador.Instrucao3 + "<br />" + Morador.Instrucao4 + "<br />" + Morador.Instrucao5 + "<br/>"; */
                    }
                    else
                    {
                        mensagem = "APÓS O VENCIMENTO COBRAR MULTA DE 2% + 1% DE JUROS AO MÊS." + "<br /> NÃO RECEBER APOS 15 DIAS DO VENCIMENTO.";
                    }




                    InsBoleto.Descricao = mensagem;
                    
                    boleto.Instrucoes.Add(InsBoleto);

                    //parametros do objeto boleto banco
                    boleto.EspecieDocumento = new EspecieDocumento_Itau("DM");
                    BoletoBancario boletob;
                    boletob = new BoletoBancario();
                    boletob.CodigoBanco = 341;
                    boletob.Boleto = boleto;
                    boletob.GeraImagemCodigoBarras(boleto);
                    boletob.Boleto.Valida();

                    Usuario.NumDocumento = null;
                    Usuario.EmissaoBoleto = null;
                    Usuario.VencimentoBoleto = null;

                    return boletob;
                }
            
            }
            else
            {
                return null;
            } 
 
        }
        
        
    }
}