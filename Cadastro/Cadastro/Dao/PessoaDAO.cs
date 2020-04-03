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
        public void salvar(Pessoa pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO pessoa(nome, sexo, telefone, celular, endereco, bairro, cidade, estado)VALUES(@nome, @sexo, @tel, @cel, @endereco, @bairro, @cidade, @estado)", conexao);
                
                comando.Parameters.AddWithValue("@nome", pessoa.nome);
                comando.Parameters.AddWithValue("@sexo", pessoa.sexo);
                comando.Parameters.AddWithValue("@tel", pessoa.telefone);
                comando.Parameters.AddWithValue("@cel", pessoa.celular);
                comando.Parameters.AddWithValue("@endereco", pessoa.endereco);
                comando.Parameters.AddWithValue("@bairro", pessoa.bairro);
                comando.Parameters.AddWithValue("@cidade", pessoa.cidade);
                comando.Parameters.AddWithValue("@estado", pessoa.estado);
                
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

        //metodo para listar na diviviw
        public DataTable listar()
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM pessoa ORDER BY nome", conexao);
                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;
            }catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }

        }
        //metodo editar
        public void editar(Pessoa pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("UPDATE pessoa SET nome = @nome, sexo = @sexo, telefone = @tel, celular = @cel, endereco = @endereco, bairro = @bairro, cidade = @cidade, estado = @estado WHERE id_pessoa = @idPessoa",conexao);

                comando.Parameters.AddWithValue("@idPessoa", pessoa.id_pessoa);
                comando.Parameters.AddWithValue("@nome", pessoa.nome);
                comando.Parameters.AddWithValue("@sexo", pessoa.sexo);
                comando.Parameters.AddWithValue("@tel", pessoa.telefone);
                comando.Parameters.AddWithValue("@cel", pessoa.celular);
                comando.Parameters.AddWithValue("@endereco", pessoa.endereco);
                comando.Parameters.AddWithValue("@bairro", pessoa.bairro);
                comando.Parameters.AddWithValue("@cidade", pessoa.cidade);
                comando.Parameters.AddWithValue("@estado", pessoa.estado);

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

        //metodo excluir
        public void excluir(Pessoa pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("DELETE FROM pessoa WHERE id_pessoa = @idPessoa", conexao);
                comando.Parameters.AddWithValue("@idPessoa", pessoa.id_pessoa);
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
