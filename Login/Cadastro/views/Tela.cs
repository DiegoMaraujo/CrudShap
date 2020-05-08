using Cadastro.Bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadastro.Model;


namespace Cadastro.views
{
    public partial class tela : Form
    {

        public tela()
        {
            InitializeComponent();
            listar();
        }
        //limpar
        private void limpar()
        {
            
            textLo.Clear();
            textSe.Clear();
        }
        //salvar
        private void salvar(PessoaModel pessoa)
        {
            if (textLo.Text.Trim() == string.Empty || textSe.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campos vazios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PessoaBll pessoaBll = new PessoaBll();
                pessoa.login = textLo.Text;
                pessoa.senha = textSe.Text;
                pessoaBll.salvar(pessoa);
                
                MessageBox.Show("Pessoa salva com sucesso");
                
                listar();
                limpar();
            }
        }
        //listar
        private void listar()
        {
            PessoaBll pessoaBll = new PessoaBll();
            tblLo.DataSource = pessoaBll.listar();
            tblLo.Columns[0].HeaderText = "Cod";
            tblLo.Columns[1].HeaderText = "Login";
            tblLo.Columns[2].HeaderText = "Senha";

        }
        //editar
        private void editar(PessoaModel pessoa)
        {
            PessoaBll pessoaBll = new PessoaBll();
            if (textLo.Text.Trim() == string.Empty || textSe.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campos vazios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pessoa.id_login = Convert.ToInt32(textIdLo.Text);
                pessoa.login = textLo.Text;
                pessoa.senha = textSe.Text;

                pessoaBll.editar(pessoa);
                MessageBox.Show("Pessoa Editada com Sucesso");
                listar();
                limpar();
            }
        }
        //excluir
        private void excluir(PessoaModel pessoa)
        {
            PessoaBll pessoaBll = new PessoaBll();
            if(textIdLo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Selecine uma pessoa a ser excluida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Deseja excluir essa pessoa", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

            }
            else
            {
                pessoa.id_login = Convert.ToInt32(textIdLo.Text);
                pessoaBll.excluir(pessoa);
                listar();
                limpar();

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tela_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastar_Click(object sender, EventArgs e)
        {
            PessoaModel pessoa = new PessoaModel();
            salvar(pessoa);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            PessoaModel pessoa = new PessoaModel();
            excluir(pessoa);
        }
        //tabela
        private void tblLo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textIdLo.Text = tblLo.CurrentRow.Cells[0].Value.ToString();
            textLo.Text = tblLo.CurrentRow.Cells[1].Value.ToString();
            textSe.Text = tblLo.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            PessoaModel pessoa = new PessoaModel();
            editar(pessoa);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listar();
        }
    }
}
