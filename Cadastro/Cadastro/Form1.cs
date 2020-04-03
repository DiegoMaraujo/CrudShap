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
using Cadastro.Bll;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
           listar();
        }

        // metodo limpar campos
        private void limparCampos()
        {
            textId.Clear();
            textNome.Clear();
            comboBoxSx.SelectedIndex = -1;
            textEnd.Clear();
            textTel.Clear();
            textCel.Clear();
            textBairro.Clear();
            textCidade.Clear();
            comboBoxUf.SelectedIndex = -1;
        }

        //metodo salvar pessoa no banco
        private void salvar(Pessoa pessoa)
        {
            PessoaBll pesssoaBll = new PessoaBll();
            pessoa.nome = textNome.Text;
            pessoa.sexo = comboBoxSx.Text;
            pessoa.telefone = textTel.Text;
            pessoa.celular = textCel.Text;
            pessoa.endereco = textEnd.Text;
            pessoa.bairro = textBairro.Text;
            pessoa.cidade = textCidade.Text;
            pessoa.estado = comboBoxUf.Text;

            pesssoaBll.salvar(pessoa);
            MessageBox.Show("Pessoa salva com sucesso");
            listar();
            limparCampos();

        }
        //metodo listar pessoas no banco
        private void listar()
        {
            PessoaBll pessoaBll = new PessoaBll();
            tblPessoa.DataSource = pessoaBll.listar();

        }
        //metodo editar pessoa
        private void editar(Pessoa pessoa)
        {
            PessoaBll pesssoaBll = new PessoaBll();
            
            pessoa.id_pessoa = Convert.ToInt32(textId.Text);
            pessoa.nome = textNome.Text;
            pessoa.sexo = comboBoxSx.Text;
            pessoa.telefone = textTel.Text;
            pessoa.celular = textCel.Text;
            pessoa.endereco = textEnd.Text;
            pessoa.bairro = textBairro.Text;
            pessoa.cidade = textCidade.Text;
            pessoa.estado = comboBoxUf.Text;

            pesssoaBll.editar(pessoa);

            MessageBox.Show("Pessoa Editada com Sucesso");
            listar();
            limparCampos();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            salvar(pessoa);
        }

        private void tblPessoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textId.Text = tblPessoa.CurrentRow.Cells[0].Value.ToString();
            textNome.Text = tblPessoa.CurrentRow.Cells[1].Value.ToString();
            comboBoxSx.Text = tblPessoa.CurrentRow.Cells[2].Value.ToString();
            textTel.Text = tblPessoa.CurrentRow.Cells[3].Value.ToString();
            textCel.Text = tblPessoa.CurrentRow.Cells[4].Value.ToString();
            textEnd.Text = tblPessoa.CurrentRow.Cells[5].Value.ToString();
            textBairro.Text = tblPessoa.CurrentRow.Cells[6].Value.ToString();
            textCidade.Text = tblPessoa.CurrentRow.Cells[7].Value.ToString();
            comboBoxUf.Text = tblPessoa.CurrentRow.Cells[8].Value.ToString();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            editar(pessoa);
        }
        //metodo excluir
        private void excluir(Pessoa pessoa)
        {
            PessoaBll pessoaBll = new PessoaBll();
            pessoa.id_pessoa = Convert.ToInt32(textId.Text);

            pessoaBll.excluir(pessoa);

            MessageBox.Show("Pessoa excluida com sucesso");
            listar();
            limparCampos();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            excluir(pessoa);
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
