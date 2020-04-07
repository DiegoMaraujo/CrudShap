using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Cadastro.Model;
using System.Data;

namespace Cadastro.Dao
{
    public class PessoaDAO : Conexao
    {
        MySqlCommand comando = null;
      
        //Metodo login
        public bool tem = false;
        MySqlDataReader dr;
        public bool Verificar(String login, String senha)
        {
            try
            {                    
                AbrirConexao();
           
                comando = new MySqlCommand("SELECT * FROM login1 WHERE login = @login AND senha = @senha", conexao);
                comando.Parameters.AddWithValue("@login", login);
                comando.Parameters.AddWithValue("@senha", senha);
  
                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    tem = true;
                }
                return tem;

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
