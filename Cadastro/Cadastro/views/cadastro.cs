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
            textNome.BackColor = Color.White;
            textEnd.BackColor = Color.White;
            comboBoxSx.BackColor = Color.White;
        }

        //metodo salvar pessoa no banco
        private void salvar(PessoaModel pessoa)
        {
            if(textNome.Text.Trim() == string.Empty || comboBoxSx.Text.Trim()== string.Empty || textEnd.Text.Trim() == string.Empty){
            
                MessageBox.Show("Campos vazios","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                textNome.BackColor = Color.Red;
                textEnd.BackColor =Color.Red;
                comboBoxSx.BackColor = Color.Red;

            }else{
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

        }
        //metodo listar pessoas no banco
        private void listar()
        {
            PessoaBll pessoaBll = new PessoaBll();
            tblPessoa.DataSource = pessoaBll.listar();

            tblPessoa.Columns[0].HeaderText = "Cod";
            tblPessoa.Columns[1].HeaderText = "Nome";
            tblPessoa.Columns[2].HeaderText = "Sexo";
            tblPessoa.Columns[3].HeaderText = "Telefone";
            tblPessoa.Columns[4].HeaderText = "Celular";
            tblPessoa.Columns[5].HeaderText = "Endereço";
            tblPessoa.Columns[6].HeaderText = "Bairro";
            tblPessoa.Columns[7].HeaderText = "Cidade";
            tblPessoa.Columns[8].HeaderText = "Uf";

            tblPessoa.Columns[0].Width = 40;
            tblPessoa.Columns[1].Width = 200;
            tblPessoa.Columns[2].Width = 40;
            tblPessoa.Columns[8].Width = 40;

        }


        //Metodo pesquisar por nome
        public void Pesquisar(PessoaModel pessoa)
        {
                pessoa.nome = textPesquisa.Text.Trim();

                PessoaBll pessoaBll = new PessoaBll();
                tblPessoa.DataSource = pessoaBll.Pesquisar(pessoa);



        }
        //metodo editar pessoa
        private void editar(PessoaModel pessoa)
        {
            PessoaBll pesssoaBll = new PessoaBll();
            if (textNome.Text.Trim() == string.Empty || comboBoxSx.Text.Trim() == string.Empty || textEnd.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Campos vazios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textNome.BackColor = Color.Red;
                textEnd.BackColor = Color.Red;
                comboBoxSx.BackColor = Color.Red;
            }
            else { 
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
            PessoaModel pessoa = new PessoaModel();
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
            PessoaModel pessoa = new PessoaModel();
            editar(pessoa);
        }
        //metodo excluir
        private void excluir(PessoaModel pessoa)
        {
            PessoaBll pessoaBll = new PessoaBll();

            if (textId.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Selecine uma pessoa a ser excluida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Deseja excluir essa pessoa", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

            }
            else
                {
                    pessoa.id_pessoa = Convert.ToInt32(textId.Text);

                    pessoaBll.excluir(pessoa);

                    MessageBox.Show("Pessoa excluida com sucesso");
                    listar();
                    limparCampos();
                }

        }
        //excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            PessoaModel pessoa = new PessoaModel();
            excluir(pessoa);
        }
        //cancelar
        private void btnCancela_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        //pesquisa
        private void textPesquisa_TextChanged(object sender, EventArgs e)
        {
            if(textPesquisa.Text == ""){
                PessoaBll pessoaBll = new PessoaBll();
                tblPessoa.DataSource = pessoaBll.listar();
            }
            else
            {
                PessoaModel pessoa = new PessoaModel();
                Pesquisar(pessoa);
            }
        }
        //login
        private void btnEntar_Click(object sender, EventArgs e)
        {
            PessoaBll pessoaBll = new PessoaBll();
            pessoaBll.login(textLogin.Text, textSenha.Text);
            if (pessoaBll.tem)
            {
                MessageBox.Show("Login  com sucesso");

            }
            else
            {
                MessageBox.Show("Erro");
            }
        }
        //metodo sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
