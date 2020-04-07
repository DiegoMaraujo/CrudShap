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
using Cadastro.views;

namespace Cadastro
{
    public partial class Form1 : Form
    {
       public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    
        //login
        private void btnEntar_Click(object sender, EventArgs e)
        {
            PessoaBll pessoaBll = new PessoaBll();
            pessoaBll.login(textLogin.Text, textSenha.Text);
            if (pessoaBll.tem)
            {
                MessageBox.Show("Login  com sucesso","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Information);

                tela tel = new tela();
                tel.ShowDialog();
              

            }
            else
            {
                MessageBox.Show("Erro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //metodo sair

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
