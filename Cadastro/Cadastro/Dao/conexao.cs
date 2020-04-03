using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
   

namespace Cadastro.Dao
{
     public class Conexao
    {
        string conecta = "DATABASE=cadastro1; SERVER=localhost; UID=root; PWD= ";
       protected MySqlConnection conexao = null;
       
        
        //Metodo para conectar ao banco
        public void AbrirConexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Open();

            }catch(Exception erro)
            {
                throw erro;
            }

        }
        //Metodo para fechar a conexao ao banco
        public void FecharConexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Close();

            }catch(Exception erro)
   
            {
                throw erro;
            }

        }
    }
}
