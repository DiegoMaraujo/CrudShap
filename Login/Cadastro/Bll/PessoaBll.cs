using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro.Model;
using Cadastro.Dao;
using System.Data;

namespace Cadastro.Bll
{
    public class PessoaBll
    {
        
        PessoaDAO  pessoaDao = new PessoaDAO();
       
      

        //Metodo login
        public bool tem;
        public bool login(String login, String senha)
        {
            PessoaDAO loginDao = new PessoaDAO();
           
            try
            {
                tem = loginDao.Verificar(login, senha);
            }
            catch(Exception erro)
            {
                throw erro;
            }

            return tem;
        
        
        }

        //salvar
        public void salvar(PessoaModel pesso)
        {
            try
            {
                pessoaDao.salvar(pesso);

            }catch(Exception erro)
            {
                throw erro;
            }
        }
        //listar
        public DataTable listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = pessoaDao.listar();
                return dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        //editar
        public void editar(PessoaModel pessoa)
        {
            try
            {
                pessoaDao.edita(pessoa);

            }catch(Exception erro)
            {
                throw erro;
            }
        }
        //excluir
        public void excluir(PessoaModel pessoa)
        {
            try
            {
                pessoaDao.exclui(pessoa);

            }catch(Exception erro)
            {
                throw erro;
            }
        }

    }
}
