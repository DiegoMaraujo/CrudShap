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
        // salvar
        public void salvar(PessoaModel pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO login1(login,senha)VALUES(@log,@sen)",conexao);
                comando.Parameters.AddWithValue("@log", pessoa.login);
                comando.Parameters.AddWithValue("@sen", pessoa.senha);
                comando.ExecuteNonQuery();
            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        //editar
        public DataTable listar()
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM login1 ORDER BY login",conexao);
                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;

            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        //editar
        public void edita(PessoaModel pesso)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("UPDATE login1 SET login=@log, senha=@sen WHERE id_login=@id_log", conexao);
                comando.Parameters.AddWithValue("@id_log", pesso.id_login);
                comando.Parameters.AddWithValue("@log", pesso.login);
                comando.Parameters.AddWithValue("@sen", pesso.senha);
                comando.ExecuteNonQuery();

            }catch(Exception erro)
            {
                throw erro;

            }
            finally
            {
                FecharConexao();
            }
        } 
        //excluir
        public void exclui(PessoaModel pesso)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("DELETE FROM login1 WHERE id_login=@id_log", conexao);
                comando.Parameters.AddWithValue("@id_log",pesso.id_login);
                comando.ExecuteNonQuery();
            }catch(Exception erro)
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
