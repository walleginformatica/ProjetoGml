using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using MySql.Data.Common;
using System.Data;


namespace BoletoGml.Classes
{
    public class Conexao
    {

        //Server=mysql01.gmlcondominios.hospedagemdesites.ws;Database=gmlcondominios;Pwd=miami3333;
        private static String ConnectionString = "U2VydmVyPW15c3FsMDEuZ21sY29uZG9taW5pb3MuaG9zcGVkYWdlbWRlc2l0ZXMud3M7RGF0YWJhc2U9Z21sY29uZG9taW5pb3M7VWlkPWdtbGNvbmRvbWluaW9zO1B3ZD1taWFtaTMzMzM7";
        //private static String ConnectionString = "U2VydmVyPW15c3FsMDEuZ21sY29uZG9taW5pb3MuaG9zcGVkYWdlbWRlc2l0ZXMud3M7RGF0YWJhc2U9Z21sY29uZG9taW5pb3M7VWlkPXdhbGxlZ2luZm9ybWF0NTtQd2Q9bWlhbWkzMzMzOw==";
        //c2VydmVyPTEyNy4wLjAuMTtVc2VyIElkPXJvb3Q7ZGF0YWJhc2U9R01MOyBwYXNzd29yZD0xMjM0NQ==
       



/*   #SQLSERVER
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

 */

        public static MySqlConnection GetConnection()
        {


            if (ConnectionString == "U2VydmVyPW15c3FsMDEuZ21sY29uZG9taW5pb3MuaG9zcGVkYWdlbWRlc2l0ZXMud3M7RGF0YWJhc2U9Z21sY29uZG9taW5pb3M7VWlkPWdtbGNvbmRvbWluaW9zO1B3ZD1taWFtaTMzMzM7")
            {
                byte[] b = Convert.FromBase64String(ConnectionString);
                String Encripted = System.Text.ASCIIEncoding.ASCII.GetString(b);
                ConnectionString = Encripted;
                return new MySqlConnection(ConnectionString);
                
            }
            else
            {
                return new MySqlConnection(ConnectionString);
            }
        }
/*
        public static void AbrirConexao(SqlConnection ConnectionString)
        {
            try
            {
                if (ConnectionString.State == ConnectionState.Closed)
                {
                    ConnectionString.Open();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO ABRIR CONEXAO" + ex.Message);
            }

        }
 */

        public static void AbrirConexao(MySqlConnection ConnectionString)
        {
            try
            {

                if (ConnectionString.State == ConnectionState.Closed)
                {
                    ConnectionString.Open();
                    
                }
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO ABRIR CONEXAO" + ex.Message);
            }

        }

        public static void FecharConexao(MySqlConnection ConnectionString)
        {
            try
            {
                if (ConnectionString.State == ConnectionState.Closed)
                {
                    ConnectionString.Close();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO ABRIR CONEXAO" + ex.Message);
            }

        }
    }
}