using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BoletoGml.Paginas;
using BoletoGml.Classes;
using MySql.Data.MySqlClient;
using System.Web.Security;

namespace BoletoGml.Classes
{
    public class Autenticar
    {
        //objeto para acesso o atributo da paglogin


       
        private MySqlConnection Con;
        private MySqlCommand Cmd;
        private MySqlDataReader Dr;
        private String Sql = null;

        public Boolean AutenticarUsuario(String Bloco, String Apartamento, String Senha)
        {
           
            try
            {

                Con = Conexao.GetConnection();
                Conexao.AbrirConexao(Con);
                Sql = "Select * from TbMorador where Bloco=@v1 and Apartamento=@v2 and Senha=@v3";
                Cmd = new MySqlCommand(Sql,Con);

                Cmd.Parameters.AddWithValue("@v1", Bloco);
                Cmd.Parameters.AddWithValue("@v2", Apartamento);
                Cmd.Parameters.AddWithValue("@v3", Senha);
                
                Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    Usuario.NomeMorador = Convert.ToString(Dr["NomeMorador"]).Trim();
                    Usuario.NivelAcesso = Convert.ToInt32(Dr["NiveldeAcesso"]);
                    Usuario.CodMorador = Convert.ToInt32(Dr["CodMorador"]);
                    Usuario.CodCondominio = Convert.ToString(Dr["CodCondominio"]);
                    
                    
                    Dr.Close();

                    Sql = null;
                    Sql = "update TbMorador set Ativo=1 where CodMorador="+Usuario.CodMorador+"";
                    Cmd.CommandText = Sql;
                    Cmd.ExecuteNonQuery();

                    Sql = null;
                    Sql = "Select * From TbCondominio where CodCondominio = " + Usuario.CodCondominio + "";
                    Cmd.CommandText = Sql;

                    Dr = Cmd.ExecuteReader();
                    if (Dr.Read())
                    {
                        Usuario.NomeCondominio = Convert.ToString(Dr["Nome"]);
                        Usuario.DocumentoDiversos = Convert.ToString(Dr["DocumentoDiversos"]).Trim();
                        Usuario.Balancetes = Convert.ToString(Dr["Balancetes"]).Trim();
                        Usuario.Formularios = Convert.ToString(Dr["Formularios"]).Trim();
                        Dr.Close();
                    }
                    else
                    {
                        Usuario.NomeCondominio = "Não encontrado nome de condominio para esse usuario. favor verificar";   
                    }

                    
                    
                    return true;

                }
                else
                {
                    return false;
                }

                
            
            
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Autenticar Usuario :" + ex.Message);
            }
        }

        public static String getMD5Hash(string input)
            {
                System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hash = md5.ComputeHash(inputBytes);
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                
            for (int i = 0; i < hash.Length; i++)
                {
                sb.Append(hash[i].ToString("X2"));
                }
                return sb.ToString();
                }

            }
    }
