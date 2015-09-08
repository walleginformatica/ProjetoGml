using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoletoGml.Classes
{
    public class Atributos
    {
        //ATRIBUTOS TBMORADOR

        public int CodMorador { get; set; }
        public String NomeMorador{get; set;}
        public String Idade{get; set;}
        public String CpfMorador{get; set;}
        public String EndMorador{get; set;}
        public String BairroMorador{get; set;}
        public String CidadeMorador{get; set;}
        public String CepMorador{get; set;}
        public String UfMorador{get; set;}
        public String EmailMorador{get; set;}
        public String ObsMorador{get; set;}
        public Double DescontoMorador{get; set;}
        public Double  AcrescimoMorador{get; set;}
        public Boolean Ativo{get; set;}
        public String Senha{get; set;}
        public Double  ValorBoleto{get; set;}
        public String Bloco{get; set;}
        public String Apartamento{get; set;}
        public String NiveldeAcesso{get; set;}
        public decimal DescontoCondominio { get; set; }

        //ATRIBUTOS TBCONDOMINIO

        public int CodCondominio { get; set; }
        public String NomeCondominio{get; set;}
        public String NossoNumero{get; set;}
        public String CnpjCondominio{get; set;}
        public String AgenciaCondominio{get; set;}
        public String CodCarteira{get; set;}
        public String ContaCondominio { get; set; }
        public DateTime VenciBoleto { get; set; }
        public DateTime EmissaoBoleto { get; set; }
        public String NumeroDocumento { get; set; }
        public int Pago { get; set; }
        public String Instrucao1 { get; set; }
        public String Instrucao2 { get; set; }
        public String Instrucao3 { get; set; }
        public String Instrucao4 { get; set; }
        public String Instrucao5 { get; set; }
        public String DataPagamento { get; set; }
       






    }
}