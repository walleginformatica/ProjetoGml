using System;
using MySql.Data.MySqlClient;
using BoletoGml.Security;

namespace BoletoGml.Classes
{
    public class BoletoDAL
    {
        private static MySqlConnection Con;
        private static MySqlCommand Cmd;
        private static MySqlDataReader Dr;
        private static String Sql = null;
        private static Atributos Morador = new Atributos();
        private static painelfatura admfatura = new painelfatura();
        
        
        public static void ExcluirBoleto()  //METODO EXCLUIR BOLETO
        {

            try
            {
                Con = Conexao.GetConnection();
                Conexao.AbrirConexao(Con);
                Sql = "delete from TbMorador where Bloco=@v1 and Apartamento=@v2 and Senha=@v3";
                Cmd = new MySqlCommand(Sql, Con);
                Cmd.Parameters.AddWithValue("@v1", Usuario.Bloco);
                Cmd.Parameters.AddWithValue("@v2", Usuario.Apartamento);
                Cmd.Parameters.AddWithValue("@v3", Usuario.Senha);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXCLUIR USUARIO :" + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao(Con);
            }


        }

        public static Atributos CarregarDadosBoleto(string Bloco, string Apartamento,int CodMorador)
        {
           

            try
            {
                Con = Conexao.GetConnection();
                Conexao.AbrirConexao(Con);
                Sql = "Select NomeMorador, CpfMorador, EndMorador, BairroMorador, CidadeMorador, CepMorador, UfMorador, CodMorador, CodCondominio from TbMorador where Bloco='"+Bloco+"' and Apartamento='"+Apartamento+"' and CodMorador='"+CodMorador+"'";

                Cmd = new MySqlCommand(Sql, Con);

                Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    Morador.NomeMorador = Dr["NomeMorador"].ToString().Trim();
                    Morador.CpfMorador  = Dr["CpfMorador"].ToString().Trim();
                    Morador.EndMorador  = Dr["EndMorador"].ToString().Trim();
                    Morador.BairroMorador  = Dr["BairroMorador"].ToString().Trim();
                    Morador.CidadeMorador = Dr["CidadeMorador"].ToString().Trim();
                    Morador.CepMorador  = Dr["CepMorador"].ToString().Trim();
                    Morador.UfMorador  = Dr["UfMorador"].ToString().Trim();
                    Morador.CodMorador = Convert.ToInt32(Dr["CodMorador"]);
                    Morador.CodCondominio = Convert.ToInt32(Dr["CodCondominio"]);

                    Dr.Close();

                    Sql = null;
                    Sql = "Select * from TbCondominio where CodCondominio = " + Morador.CodCondominio + "";

                    Cmd.CommandText = Sql;

                    Dr = Cmd.ExecuteReader();

                    if (Dr.Read())
                    {
                        
                        Morador.ValorBoleto = Convert.ToDouble(Dr["ValorBoleto"]);
                        //Morador.CodMorador = Convert.ToInt32(Dr["CodCondominio"]);
                        Morador.NomeCondominio = Convert.ToString(Dr["NomeCondominio"]).Trim();
                        Morador.NossoNumero = Convert.ToString(Dr["NossoNumero"]).Trim();
                        Morador.CnpjCondominio = Convert.ToString(Dr["CnpjCondominio"]).Trim();
                        Morador.AgenciaCondominio = Convert.ToString(Dr["AgenciaCondominio"]).Trim();
                        Morador.CodCarteira = Convert.ToString(Dr["CodCarteira"]).Trim();
                        Morador.ContaCondominio = Convert.ToString(Dr["ContaCondominio"]).Trim();
                        Morador.Instrucao1 = Convert.ToString(Dr["Instrução1"]).Trim();
                        Morador.Instrucao2 = Convert.ToString(Dr["Instrução2"]).Trim();
                        Morador.Instrucao3 = Convert.ToString(Dr["Instrução3"]).Trim();
                        Morador.Instrucao4 = Convert.ToString(Dr["Instrução4"]).Trim();
                        Morador.Instrucao5 = Convert.ToString(Dr["Instrução5"]).Trim();

                        Dr.Close();
     
                    }

                    return Morador;
                    
                }
                else
                {
                    return null;
                }

            }

            catch (Exception ex)
            {

                throw new Exception("ERRO AO GERAR BOLETO :" + ex.Message);
            }
        
        } //METODO PARA CARREGAR OS DADOS P/ GERAR BOLETO

        public static Boolean GravarTbFatura()
        {
            try
            {
                

                Con = Conexao.GetConnection();

                Conexao.AbrirConexao(Con);
                
                BoletoDAL.CarregarDadosBoleto(Usuario.Bloco, Usuario.Apartamento, Usuario.CodMorador);

                Sql = "Insert into TbFatura (CodMorador,ValorBoleto,NumDocumento,EmissaoBoleto,VencimentoBoleto,CodCondominio,NomeMorador,Bloco,Apartamento,Pago) values (@CodMorador,@ValorBoleto,@NumDocumento,@EmissaoBoleto,@VencimentoBoleto,@CodCondominio,@NomeMorador,@Bloco,@Apartamento,@Pago)";

                Cmd = new MySqlCommand(Sql, Con);

                Cmd.Parameters.AddWithValue("@CodMorador", Convert.ToInt32(Morador.CodMorador));
                Cmd.Parameters.AddWithValue("@ValorBoleto", Convert.ToDouble(Morador.ValorBoleto));
                Cmd.Parameters.AddWithValue("@NumDocumento", Morador.NumeroDocumento);
                Cmd.Parameters.AddWithValue("@EmissaoBoleto",Convert.ToString(Morador.EmissaoBoleto));
                Cmd.Parameters.AddWithValue("@VencimentoBoleto", Convert.ToString(Morador.VenciBoleto));
                Cmd.Parameters.AddWithValue("@CodCondominio", Morador.CodCondominio);
                Cmd.Parameters.AddWithValue("@NomeMorador", Morador.NomeMorador);
                Cmd.Parameters.AddWithValue("@Bloco", Usuario.Bloco);
                Cmd.Parameters.AddWithValue("@Apartamento", Usuario.Apartamento);
                Cmd.Parameters.AddWithValue("@Pago",1);
                

                
                Cmd.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO GRAVAR BOLETO :" + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao(Con);
            }
        }  //METODO GRAVAR BOLETO EM FATURA

        public static Atributos CarregarDadosBoletoFatura(string Bloco, string Apartamento,int CodMorador)
        {
            try
            {
                Con = Conexao.GetConnection();
                Conexao.AbrirConexao(Con);

                Sql = "select CodMorador , ValorBoleto, NumDocumento, EmissaoBoleto, VencimentoBoleto, CodCondominio, NomeMorador,Bloco,Apartamento,Pago from TbFatura where Bloco = '" + Bloco + "' and Apartamento = '" + Apartamento + "' and CodMorador = '" + CodMorador + "'"+" and Pago=1";
                
                Cmd = new MySqlCommand(Sql, Con);

                Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {

                    Morador.CodMorador = Convert.ToInt32(Dr["CodMorador"]);
                    Morador.ValorBoleto = Convert.ToDouble(Dr["ValorBoleto"]);
                    Morador.NumeroDocumento = Convert.ToString(Dr["NumDocumento"]).Trim();
                    Morador.EmissaoBoleto = Convert.ToDateTime(Dr["EmissaoBoleto"]);
                    Morador.VenciBoleto = Convert.ToDateTime(Dr["VencimentoBoleto"]);
                    Morador.CodCondominio = Convert.ToInt32(Dr["CodCondominio"]);
                    Morador.NomeMorador = Convert.ToString(Dr["NomeMorador"]).Trim();
                    Morador.Pago = Convert.ToInt32(Dr["Pago"]);
                    
                    Dr.Close();

                    Sql = null;
                    Sql = "Select * from TbMorador where Bloco= '" + Bloco + "' and Apartamento ='" + Apartamento + "' and CodMorador = '" + CodMorador + "'";
                    
                    Cmd.CommandText = Sql;
                    Dr = Cmd.ExecuteReader();

                    if (Dr.Read())
                    {
                        
                        Morador.CpfMorador = Dr["CpfMorador"].ToString().Trim();
                        Morador.EndMorador = Dr["EndMorador"].ToString().Trim();
                        Morador.BairroMorador = Dr["BairroMorador"].ToString().Trim();
                        Morador.CidadeMorador = Dr["CidadeMorador"].ToString().Trim();
                        Morador.CepMorador = Dr["CepMorador"].ToString().Trim();
                        Morador.UfMorador = Dr["UfMorador"].ToString().Trim();

                        Dr.Close();
                        
                        Sql = null;
                        Sql = "Select * from TbCondominio where CodCondominio = " + Morador.CodCondominio + "";

                        
                        Cmd.CommandText = Sql;
                        Dr = Cmd.ExecuteReader();

                        if (Dr.Read())
                        {

                            Morador.NossoNumero = Convert.ToString(Dr["NossoNumero"]).Trim();
                            Morador.CnpjCondominio = Convert.ToString(Dr["CnpjCondominio"]).Trim();
                            Morador.AgenciaCondominio = Convert.ToString(Dr["AgenciaCondominio"]).Trim();
                            Morador.CodCarteira = Convert.ToString(Dr["CodCarteira"]).Trim();
                            Morador.ContaCondominio = Convert.ToString(Dr["ContaCondominio"]).Trim();
                            Morador.Instrucao1 = Convert.ToString(Dr["Instrução1"]);
                            Morador.Instrucao2 = Convert.ToString(Dr["Instrução2"]);
                            Morador.Instrucao3 = Convert.ToString(Dr["Instrução3"]);
                            Morador.Instrucao4 = Convert.ToString(Dr["Instrução4"]);
                            Morador.Instrucao5 = Convert.ToString(Dr["Instrução5"]);
     
     
     
     
                        }
   
                    }

                    return Morador;
                }
                else 
                {
                    return null;
                }
             }
            catch (Exception ex)
            {

                throw new Exception("ERRO GERANDO BOLETO DA FATURA :" + ex.Message);
            }
            
            
        }

        public static Atributos BuscaUsuario(int BuscaUsuario)
        {
            try
            {
                Con = Conexao.GetConnection();
                Conexao.AbrirConexao(Con);
                Sql = "Select * From TbMorador where CodMorador = " + BuscaUsuario + "";
                Cmd = new MySqlCommand(Sql, Con);
                Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    Morador.NomeMorador = Convert.ToString(Dr["NomeMorador"]).Trim();
                    Morador.Bloco = Convert.ToString(Dr["Bloco"]).Trim();
                    Morador.Apartamento = Convert.ToString(Dr["Apartamento"]).Trim();
                    Morador.Senha = Convert.ToString(Dr["Senha"]).Trim();

                    
                    return Morador;
                    

                }
                else
                {
                    return null;
                }

                



            }
            catch (Exception ex)
            {

                throw new Exception("Erro Ao Busca Usuario :" + ex);
            }
            
           
            
        } //METODO BUSCA USUARIO POR ID
       
        public static Atributos CarregarTextFaturaAdm(string CodMorador, string txtValorBoleto, string txtNumDocumento, string txtEmissao, string txtVencimento, string txtCodCondominio, string txtNomeMorador, string txtBloco, string txtApartamento, string txtPago, string txtSenha)
        {
            Morador.CodMorador = Convert.ToInt32(CodMorador);
            Morador.ValorBoleto = Convert.ToDouble(txtValorBoleto);
            Morador.NumeroDocumento = Convert.ToString(txtNumDocumento);
            Morador.EmissaoBoleto = Convert.ToDateTime(txtEmissao);
            Morador.VenciBoleto = Convert.ToDateTime(txtVencimento);
            Morador.CodCondominio = Convert.ToInt32(txtCodCondominio);
            Morador.NomeMorador = Convert.ToString(txtNomeMorador);
            Morador.Bloco = Convert.ToString(txtBloco);
            Morador.Apartamento = Convert.ToString(txtApartamento);
            Morador.Pago = Convert.ToInt32(txtPago);
            Morador.Senha = Convert.ToString(txtSenha);

            return Morador;

        }
        
        public static Atributos GravarTbFaturaAdm()
         {
            try
            {
           
                Con = Conexao.GetConnection();

                Conexao.AbrirConexao(Con);
                
                

                Sql = "Insert into TbFatura (CodMorador,ValorBoleto,NumDocumento,EmissaoBoleto,VencimentoBoleto,CodCondominio,NomeMorador,Bloco,Apartamento,Pago) values (@CodMorador,@ValorBoleto,@NumDocumento,@EmissaoBoleto,@VencimentoBoleto,@CodCondominio,@NomeMorador,@Bloco,@Apartamento,@Pago)";

                Cmd = new MySqlCommand(Sql, Con);

                Cmd.Parameters.AddWithValue("@CodMorador", Convert.ToInt32(Morador.CodMorador));
                Cmd.Parameters.AddWithValue("@ValorBoleto", Convert.ToDouble(Morador.ValorBoleto));
                Cmd.Parameters.AddWithValue("@NumDocumento", Convert.ToInt32(Morador.NumeroDocumento));
                Cmd.Parameters.AddWithValue("@EmissaoBoleto",Convert.ToString(Morador.EmissaoBoleto));
                Cmd.Parameters.AddWithValue("@VencimentoBoleto", Convert.ToString(Morador.VenciBoleto));
                Cmd.Parameters.AddWithValue("@CodCondominio", Convert.ToInt32(Morador.CodCondominio));
                Cmd.Parameters.AddWithValue("@NomeMorador", Convert.ToString(Morador.NomeMorador.Trim()));
                Cmd.Parameters.AddWithValue("@Bloco", Convert.ToString(Morador.Bloco.Trim()));
                Cmd.Parameters.AddWithValue("@Apartamento", Convert.ToString(Morador.Apartamento.Trim()));
                Cmd.Parameters.AddWithValue("@Pago", Convert.ToInt32(Morador.Pago));
                

                
                Cmd.ExecuteNonQuery();

                return Morador;

            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO GRAVAR BOLETO :" + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao(Con);
            }
           
        }

        public static MySqlDataReader CarregarGridView()
        {
            try 
	        {	        
		        Con = Conexao.GetConnection();
                Conexao.AbrirConexao(Con);
                Sql = "Select NumDocumento As Documento, EmissaoBoleto As Emissão, VencimentoBoleto As Vencimento, Pago from TbFatura where Bloco='" + Usuario.Bloco + "' and Apartamento='" + Usuario.Apartamento + "' and CodMorador='" + Usuario.CodMorador + "'";
                Cmd = new MySqlCommand(Sql, Con);

                Dr = Cmd.ExecuteReader();
                return Dr;
	        }
	        catch (Exception ex)
	        {

                throw new Exception("ERRO AO CARREGAR AO GRIDVIEW :"+ex.Message);
	            
            }
        }

        public static int GetDiasCorridos(DateTime initialDate, DateTime finalDate)
        {
            int days = 0;
            int daysCount = 0;
            days = initialDate.Subtract(finalDate).Days;

            //Módulo 
            if (days < 0)
                days = days * -1;

            for (int i = 1; i <= days; i++)
            {
                initialDate = initialDate.AddDays(1);
                //Conta apenas dias da semana.
                if (initialDate.DayOfWeek != DayOfWeek.Sunday &&
                    initialDate.DayOfWeek != DayOfWeek.Saturday)
                    daysCount++;
            }
            return daysCount;
        }

        public static int VerificarPagos()
        {

            Morador.Pago = 0;
            Con = Conexao.GetConnection();
            Conexao.AbrirConexao(Con);
            Sql = "Select * From TbFatura where CodMorador=@v1";
            Cmd = new MySqlCommand(Sql, Con);
            Cmd.Parameters.AddWithValue("@v1", Usuario.CodMorador);
            Dr = Cmd.ExecuteReader();

            if (Dr.Read())
            {
                Morador.Pago = Convert.ToInt32(Dr["Pago"]);

            }

            if (Morador.Pago == 0)
            {
                return Morador.Pago;

            }
            if (Morador.Pago == 1)
            {
                return Morador.Pago;
            }
            if (Morador.Pago == 2)
            {
                return Morador.Pago;
            }
            else
            {
                return Morador.Pago;
            }

           

        }

        public static Atributos GerarBoletoGrid(string NumDocumento, /*String EmissaoBoleto,String VencimentoBoleto, */ string Bloco,String Apartamento,int CodMorador)
        {
            try
            {
                Con = Conexao.GetConnection();
                Conexao.AbrirConexao(Con);

                //Sql = "select * from TbFatura where NumDocumento = '" + NumDocumento + "'and EmissaoBoleto = '" + EmissaoBoleto + "' and VencimentoBoleto = '" + VencimentoBoleto + "' and Bloco = '" + Bloco + "' and Apartamento = '" + Apartamento + "' and CodMorador=" + CodMorador + " and pago=0";
                Sql = "select * from TbFatura where NumDocumento = '" + NumDocumento + "' and Bloco = '" + Bloco + "' and Apartamento = '" + Apartamento + "' and CodMorador=" + CodMorador + " and pago=0";

                Cmd = new MySqlCommand(Sql, Con);

                Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {

                    Morador.CodMorador = Convert.ToInt32(Dr["CodMorador"]);
                    Morador.ValorBoleto = Convert.ToDouble(Dr["ValorBoleto"]);
                    Morador.NumeroDocumento = Convert.ToString(Dr["NumDocumento"]).Trim();
                    //Morador.EmissaoBoleto = Convert.ToDateTime(Dr["EmissaoBoleto"]);
                    Morador.VenciBoleto = Convert.ToDateTime(Dr["VencimentoBoleto"]);
                    Morador.CodCondominio = Convert.ToInt32(Dr["CodCondominio"]);
                    Morador.NomeMorador = Convert.ToString(Dr["NomeMorador"]).Trim();
                    Morador.Pago = Convert.ToInt32(Dr["Pago"]);

                    Dr.Close();

                    Sql = null;
                    Sql = "Select * from TbMorador where Bloco= '" + Bloco + "' and Apartamento ='" + Apartamento + "' and CodMorador = '" + CodMorador + "'";

                    Cmd.CommandText = Sql;
                    Dr = Cmd.ExecuteReader();

                    if (Dr.Read())
                    {

                        Morador.CpfMorador = Dr["CpfMorador"].ToString().Trim();
                        Morador.EndMorador = Dr["EndMorador"].ToString().Trim();
                        Morador.BairroMorador = Dr["BairroMorador"].ToString().Trim();
                        Morador.CidadeMorador = Dr["CidadeMorador"].ToString().Trim();
                        Morador.CepMorador = Dr["CepMorador"].ToString().Trim();
                        Morador.UfMorador = Dr["UfMorador"].ToString().Trim();

                        Dr.Close();

                        Sql = null;
                        //Sql = "Select Concat(Replace(Replace(Replace(Format(DescontoCondominio, 2), '.', '|'), ',', '.'), '|', ',')) As DescontoCondominio, * from TbCondominio where CodCondominio = " + Morador.CodCondominio + "";
                        Sql = "Select  * , Concat(Replace(Replace(Replace(Format(DescontoCondominio, 2), '.', '|'), ',', '.'), '|', ',')) As DescontoDoCondominio from TbCondominio where CodCondominio = " + Morador.CodCondominio + "";


                        Cmd.CommandText = Sql;
                        Dr = Cmd.ExecuteReader();

                        if (Dr.Read())
                        {

                            Morador.NossoNumero = Convert.ToString(Dr["NossoNumero"]).Trim();
                            Morador.CnpjCondominio = Convert.ToString(Dr["CnpjCondominio"]).Trim();
                            Morador.AgenciaCondominio = Convert.ToString(Dr["AgenciaCondominio"]).Trim();
                            Morador.CodCarteira = Convert.ToString(Dr["CodCarteira"]).Trim();
                            Morador.ContaCondominio = Convert.ToString(Dr["ContaCondominio"]).Trim();
                            Morador.NomeCondominio = Convert.ToString(Dr["Nome"]).Trim();

                            if (DBNull.Value == ((Dr["DescontoDoCondominio"])))
                            {
                            Morador.DescontoCondominio = 0;
                            } 
                            else
                            {
                                Morador.DescontoCondominio = Convert.ToDecimal(Dr["DescontoDoCondominio"]);
                            }
                            
                            Morador.Instrucao1 = Convert.ToString(Dr["Instrucao1"]);
                            Morador.Instrucao2 = Convert.ToString(Dr["Instrucao2"]);
                            Morador.Instrucao3 = Convert.ToString(Dr["Instrucao3"]);
                            Morador.Instrucao4 = Convert.ToString(Dr["Instrucao4"]);
                            Morador.Instrucao5 = Convert.ToString(Dr["Instrucao5"]);




                        }

                    }

                    return Morador;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO GERANDO BOLETO DA FATURA :" + ex.Message);
            }
        }

        public static string ValidarFormularioBloco(String bloco)
        {


            if (bloco.Length == 1)
            {
                bloco = bloco.PadLeft(2, '0');
                return bloco;
            }
            else
            {
                return bloco;
            }
            
            

          
        }

        public static String ValidarFormularioApartamento(String Apartamento)
        {

            if (Apartamento.Length == 1)
            {
                Apartamento = Apartamento.PadLeft(3, '0');
                return Apartamento;
            }
            if (Apartamento.Length == 2)
            {
                Apartamento = "0" + Apartamento;
                    return Apartamento;
            }
            else
            {
                return Apartamento;
            }
            
        }

        public static double CorreçãoMonetaria(Double ValorBoleto , DateTime Vencimento)
        {
            Double ValorBlt = Convert.ToDouble(ValorBoleto);
            DateTime data = Convert.ToDateTime(Vencimento);
            String mes = Convert.ToString(data.Month);
            
            // adicionando zero a esquerda
            
            if (mes.Length == 1)
            {
                mes = mes.PadLeft(2, '0');
     
            }
            else 
            { 
            
            }


            String ano = Convert.ToString(data.Year);
            String Vencimentol = mes + "/" + ano;

            Con = Conexao.GetConnection();
            Conexao.AbrirConexao(Con);

            Sql = "select * from Índices where Ano = '" + ano + "' and Mês = '" + mes + "'";
            Cmd = new MySqlCommand(Sql, Con);
            Dr = Cmd.ExecuteReader();

            if (Dr.Read())
            {
                Double Correção = Convert.ToDouble(Dr[2]);
                Dr.Close();

                ValorBlt = ValorBlt / Correção;

                ano = null;
                mes = null;

                DateTime oi;
                oi = DateTime.Now;

                mes = Convert.ToString(oi.Month);

                if (mes.Length == 1)
                {
                    mes = mes.PadLeft(2, '0');
                }
                else 
                { 
                
                }

                ano = Convert.ToString(oi.Year);

                

                Cmd.CommandText = "Select * from Índices where ano = '"+ano+"' and mês = '"+mes+"'";

                Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    Double indiceAtual = Convert.ToDouble(Dr[2]);

                    ValorBlt = ValorBlt * indiceAtual;

                    string valorFormatado = ValorBlt.ToString("#,0.00", new System.Globalization.CultureInfo("pt-BR"));

                    ValorBlt = Convert.ToDouble(valorFormatado);
                }

                

                
            }
            else
            {

            }

            ValorBlt = 0;
            return ValorBlt;
            


        }

        public static int CalcularMesesPassados(DateTime DataAtual, DateTime DataVencimento)
        {
            
            DataAtual = DateTime.Today;
            
            TimeSpan dif = DataAtual.Subtract(DataVencimento); 
  
           

            int meses = dif.Days / 30;

            return meses;
          

        }
    }
}