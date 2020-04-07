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
        //metodo salvar
        public void salvar(PessoaModel pessoa)
        {
            try
            {
                pessoaDao.salvar(pessoa);

            }
            catch (Exception erro)
            {


                throw erro;
            }
        }
        //metodo listar
        public DataTable listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = pessoaDao.listar();
                return dt;

            }catch(Exception erro)
            {
                throw erro;
            }
        }
        //Metodo pesquisar por nome
        public DataTable Pesquisar(PessoaModel pessoa)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = pessoaDao.Pesquisar(pessoa);
                return dt;


            }
            catch (Exception error)
            {
                throw error;
            }

        }



        //metodo editar os dados da pessoa
        public void editar(PessoaModel pessoa)
        {
            try
            {
                pessoaDao.editar(pessoa);

            }catch(Exception erro)
            {
                throw erro;
            }
        }
        //metodo excluir

        public void excluir(PessoaModel pessoa)
        {
            try
            {
                pessoaDao.excluir(pessoa);

            }catch(Exception erro)
            {
                throw erro;
            }
        }

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

    }
}
