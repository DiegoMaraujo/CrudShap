namespace Cadastro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textEnd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxUf = new System.Windows.Forms.ComboBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.tblPessoa = new System.Windows.Forms.DataGridView();
            this.textTel = new System.Windows.Forms.MaskedTextBox();
            this.textCel = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBairro = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.textPesquisa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(87, 33);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(85, 20);
            this.textId.TabIndex = 0;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(87, 71);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(649, 20);
            this.textNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // Tel
            // 
            this.Tel.AutoSize = true;
            this.Tel.Location = new System.Drawing.Point(55, 117);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(22, 13);
            this.Tel.TabIndex = 4;
            this.Tel.Text = "Tel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cel";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textEnd
            // 
            this.textEnd.Location = new System.Drawing.Point(105, 154);
            this.textEnd.Name = "textEnd";
            this.textEnd.Size = new System.Drawing.Size(237, 20);
            this.textEnd.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Endereço";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textCidade
            // 
            this.textCidade.Location = new System.Drawing.Point(524, 154);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(92, 20);
            this.textCidade.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cidade";
            // 
            // comboBoxSx
            // 
            this.comboBoxSx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSx.FormattingEnabled = true;
            this.comboBoxSx.Items.AddRange(new object[] {
            "F",
            "M"});
            this.comboBoxSx.Location = new System.Drawing.Point(604, 122);
            this.comboBoxSx.Name = "comboBoxSx";
            this.comboBoxSx.Size = new System.Drawing.Size(132, 21);
            this.comboBoxSx.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(550, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sexo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(622, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "UF";
            // 
            // comboBoxUf
            // 
            this.comboBoxUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUf.FormattingEnabled = true;
            this.comboBoxUf.Items.AddRange(new object[] {
            "SP",
            "MG",
            "RJ",
            "BH"});
            this.comboBoxUf.Location = new System.Drawing.Point(649, 160);
            this.comboBoxUf.Name = "comboBoxUf";
            this.comboBoxUf.Size = new System.Drawing.Size(87, 21);
            this.comboBoxUf.TabIndex = 8;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(218, 208);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.Location = new System.Drawing.Point(299, 208);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(75, 23);
            this.btnCancela.TabIndex = 12;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // tblPessoa
            // 
            this.tblPessoa.AllowUserToAddRows = false;
            this.tblPessoa.AllowUserToDeleteRows = false;
            this.tblPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPessoa.Location = new System.Drawing.Point(-1, 267);
            this.tblPessoa.Name = "tblPessoa";
            this.tblPessoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblPessoa.Size = new System.Drawing.Size(829, 171);
            this.tblPessoa.TabIndex = 21;
            this.tblPessoa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblPessoa_CellDoubleClick);
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(83, 114);
            this.textTel.Mask = "(99) 000-0000";
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(177, 20);
            this.textTel.TabIndex = 2;
            this.textTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textCel
            // 
            this.textCel.Location = new System.Drawing.Point(294, 114);
            this.textCel.Mask = "(99) 00000-0000";
            this.textCel.Name = "textCel";
            this.textCel.Size = new System.Drawing.Size(177, 20);
            this.textCel.TabIndex = 3;
            this.textCel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Bairro";
            // 
            // textBairro
            // 
            this.textBairro.Location = new System.Drawing.Point(380, 154);
            this.textBairro.Name = "textBairro";
            this.textBairro.Size = new System.Drawing.Size(92, 20);
            this.textBairro.TabIndex = 6;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(137, 208);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.Location = new System.Drawing.Point(56, 208);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.toolTip.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // textPesquisa
            // 
            this.textPesquisa.Location = new System.Drawing.Point(389, 211);
            this.textPesquisa.Name = "textPesquisa";
            this.textPesquisa.Size = new System.Drawing.Size(330, 20);
            this.textPesquisa.TabIndex = 26;
            this.textPesquisa.TextChanged += new System.EventHandler(this.textPesquisa_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(725, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Pesquisar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textPesquisa);
            this.Controls.Add(this.textBairro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCel);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.tblPessoa);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxUf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxSx);
            this.Controls.Add(this.textCidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textEnd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Tel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxUf;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.DataGridView tblPessoa;
        private System.Windows.Forms.MaskedTextBox textTel;
        private System.Windows.Forms.MaskedTextBox textCel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBairro;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox textPesquisa;
        private System.Windows.Forms.Label label9;
    }
}

