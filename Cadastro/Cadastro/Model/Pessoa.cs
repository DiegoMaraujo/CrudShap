using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Model
{
    public class Pessoa
    {

        public int id_pessoa { get; set; }
        public String nome { get; set; }
        public String sexo { get; set; }
        public String telefone { get; set; }
        public String celular { get; set; }
        public String endereco { get; set; }
        public String bairro{ get; set; }
        public String cidade { get; set; }
        public String estado { get; set; }
    }
}
