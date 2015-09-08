using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using BoletoGml.Classes;

namespace BoletoGml.Classes
{
    public class Usuario
    {
          public static MySqlConnection Con;
          public static MySqlCommand Cmd;
          public static MySqlDataReader Dr;
          public static String Sql = null;
          public static String Bloco;
          public static String Apartamento;
          public static String Senha;
          public static String NomeMorador;
          public static int NivelAcesso;
          public static int CodMorador;
          public static String EmailMorador;
          public static String NumDocumento;
          public static String EmissaoBoleto;
          public static String VencimentoBoleto;
          public static String NomeCondominio;
          public static String CodCondominio;
          
          public static string DocumentoDiversos;
          public static string Balancetes;
          public static string Formularios;
          
          public static Boolean DeslogarUsuario()
          {
              try
              {
                  Con = Conexao.GetConnection();
                  Conexao.AbrirConexao(Con);

                  Sql = "Update TbMorador set Ativo=0 where CodMorador =@v1";
                  Cmd = new MySqlCommand(Sql,Con);
                  Cmd.Parameters.AddWithValue("@v1", Usuario.CodMorador);
                    Cmd.ExecuteNonQuery();

                  return true;

              }
              catch (Exception ex)
              {

                  throw new Exception("ERRO AO DESLOGAR USUARIO :" + ex);
              }
          }

    }
}