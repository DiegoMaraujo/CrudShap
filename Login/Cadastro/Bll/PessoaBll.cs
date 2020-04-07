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

    }
}
