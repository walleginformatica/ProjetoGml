using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;
using BoletoGml.Classes;
using BoletoGml.Paginas;
using System.Data;
namespace BoletoGml.Classes
{
    public class BoletosPendente
    {
        private MySqlConnection Con;
        private MySqlCommand Cmd;
        private MySqlDataReader Dr;
        //public DataTable Dt;
        
        private String Sql = null;

        public DataTable CarregarTabela(String Bloco, String Apartamento, String Senha)
        {
            try
            {
                DataTable dt = new DataTable();

                Con = Conexao.GetConnection();
                Conexao.AbrirConexao(Con);

               /* 
                * Sql = "Select * from TbFatura where Bloco=@v1 and Apartamento=@v2 and Senha=@v3";

                Cmd = new SqlCommand(Sql, Con);

               
                Cmd.Parameters.AddWithValue("@v1", Bloco);
                Cmd.Parameters.AddWithValue("@v2",Apartamento);
                Cmd.Parameters.AddWithValue("@v3",Senha);
                */
                //Cmd.ExecuteReader();
                
                Sql = "Select NumDocumento As Numero Documento, EmissaoDocumento As Emissão, VencimentoBoleto As Vencimento, Pago from TbFatura where Bloco='"+Bloco+"' and Apartamento='"+Apartamento+"' and Senha='"+Senha+"'";
                Cmd = new MySqlCommand(Sql, Con);
                Dr = Cmd.ExecuteReader();

                //Dr.Close();
                
                if (Dr.Read())
                {


                    dt.Load(Dr);
                    

                    return dt;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception)
            {
                
                throw;
            }
        
        }
        
    }
}