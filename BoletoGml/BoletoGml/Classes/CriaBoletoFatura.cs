using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BoletoGml.Classes;
using BoletoGml.Paginas;
using BoletoNet;

namespace BoletoGml.Classes
{
    public class CriaBoletoFatura
    {
        private static Atributos Morador = new Atributos();

        public static BoletoBancario VisualizarBoleto()
        {

            Morador = BoletoDAL.CarregarDadosBoletoFatura(Usuario.Bloco, Usuario.Apartamento, Usuario.CodMorador);

            if (Morador != null)
            {
                int diascorridos;

                DateTime DataAtual = DateTime.Today;




                if (DataAtual > Convert.ToDateTime(Morador.VenciBoleto))
                {
                    diascorridos = BoletoDAL.GetDiasCorridos(Morador.VenciBoleto, DataAtual);

                    
                    Cedente DadosCedente;


                    
                    DadosCedente = new Cedente(Morador.CnpjCondominio, Morador.NomeCondominio, Morador.AgenciaCondominio, Morador.ContaCondominio);

                    
                    DadosCedente.Codigo = Convert.ToString(Morador.CodCondominio);

                    
                    Boleto boleto;


                    boleto = new BoletoNet.Boleto(Convert.ToDateTime(Morador.VenciBoleto), Convert.ToDecimal(Morador.ValorBoleto), "09", Morador.NossoNumero, DadosCedente);


                    BoletoDAL.CorreçãoMonetaria(Morador.ValorBoleto, Morador.VenciBoleto);

                    boleto.JurosMora = Convert.ToDecimal(Morador.ValorBoleto * 1 / 100); // 1% do valor , divido por 30;
                    boleto.ValorMulta = Convert.ToDecimal(Morador.ValorBoleto * 2 / 100);

                    boleto.ValorCobrado = Convert.ToDecimal(Morador.ValorBoleto) + diascorridos * boleto.JurosMora + boleto.ValorMulta;


                    //*******
                    boleto.Carteira = "06";
                    boleto.Especie = "R$";
                    //*******

                    // 'Dependendo da carteira, é necessário o número do documento
                    boleto.NumeroDocumento = Morador.NumeroDocumento;

                    //Informa os dados do sacado
                    boleto.Sacado = new Sacado(Morador.CpfMorador, Morador.NomeMorador);
                    boleto.Sacado.Endereco.End = Morador.EndMorador;
                    boleto.Sacado.Endereco.Bairro = Morador.BairroMorador;
                    boleto.Sacado.Endereco.Cidade = Morador.CidadeMorador;
                    boleto.Sacado.Endereco.CEP = Morador.CepMorador;
                    boleto.Sacado.Endereco.UF = Morador.UfMorador;



                    Instrucao_Bradesco insBoleto;
                    insBoleto = new Instrucao_Bradesco();

                    insBoleto.Descricao = "MULTA POR ATRASO R$ "+Convert.ToString(boleto.ValorMulta)+"<br>"+"JUROS POR DIA R$ "+Convert.ToString(boleto.JurosMora)+"<br>"+Morador.Instrucao1 + "<br />" + Morador.Instrucao2 + "<br />" + Morador.Instrucao3 + "<br />" + Morador.Instrucao4 + "<br />" + Morador.Instrucao5 + "<br/>";

                    boleto.Instrucoes.Add(insBoleto);

                    boleto.EspecieDocumento = new EspecieDocumento_Bradesco("17");

                    BoletoBancario boletob;

                    boletob = new BoletoBancario();

                    boletob.CodigoBanco = 237; // CODIGO DO BANCO 

                    boletob.Boleto = boleto;

                    boletob.GeraImagemCodigoBarras(boleto);
                    boletob.Boleto.Valida();

                    return boletob;





                }
                else
                {

                    

                    //Informa os dados do cedente
                    Cedente DadosCedente;


                    //DadosCedente = new Cedente(txtCPFCNPJ.Text, txtNomeCedente.Text, txtAgenciaCendente.Text, txtContaCedente.Text);
                    DadosCedente = new Cedente(Morador.CnpjCondominio, Morador.NomeCondominio, Morador.AgenciaCondominio, Morador.ContaCondominio);

                    //Dependendo da carteira, é necessário informar o código do cedente (o banco que fornece)
                    DadosCedente.Codigo = Convert.ToString(Morador.CodCondominio);

                    //'Dados para preenchimento do boleto (data de vencimento, valor, carteira e nosso número)
                    Boleto boleto;


                    boleto = new BoletoNet.Boleto(Convert.ToDateTime(Morador.VenciBoleto), Convert.ToDecimal(Morador.ValorBoleto), "09", Morador.NossoNumero, DadosCedente);

                    /*
                     boleto.JurosMora = Convert.ToDecimal(1.00);
                     boleto.ValorMulta = Convert.ToDecimal(2.00);
                     boleto.ValorCobrado = Convert.ToDecimal(Morador.ValorBoleto) + resultado * boleto.ValorMulta + boleto.JurosMora;
                    */

                    //*******
                    boleto.Carteira = "06";
                    boleto.Especie = "R$";
                    //*******

                    // 'Dependendo da carteira, é necessário o número do documento
                    boleto.NumeroDocumento = Morador.NumeroDocumento;

                    //Informa os dados do sacado
                    boleto.Sacado = new Sacado(Morador.CpfMorador, Morador.NomeMorador);
                    boleto.Sacado.Endereco.End = Morador.EndMorador;
                    boleto.Sacado.Endereco.Bairro = Morador.BairroMorador;
                    boleto.Sacado.Endereco.Cidade = Morador.CidadeMorador;
                    boleto.Sacado.Endereco.CEP = Morador.CepMorador;
                    boleto.Sacado.Endereco.UF = Morador.UfMorador;



                    Instrucao_Bradesco insBoleto;
                    insBoleto = new Instrucao_Bradesco();

                    insBoleto.Descricao = Morador.Instrucao1 + "<br />" + Morador.Instrucao2 + "<br />" + Morador.Instrucao3 + "<br />" + Morador.Instrucao4 + "<br />" + Morador.Instrucao5 + "<br/>";

                    boleto.Instrucoes.Add(insBoleto);

                    boleto.EspecieDocumento = new EspecieDocumento_Bradesco("17");

                    BoletoBancario boletob;

                    boletob = new BoletoBancario();

                    boletob.CodigoBanco = 237; // CODIGO DO BANCO 

                    boletob.Boleto = boleto;

                    boletob.GeraImagemCodigoBarras(boleto);
                    boletob.Boleto.Valida();

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