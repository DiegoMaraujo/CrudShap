namespace Cadastro.views
{
    partial class tela
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastar = new System.Windows.Forms.Button();
            this.textLo = new System.Windows.Forms.TextBox();
            this.tblLo = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.textSe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textIdLo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblLo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "login";
            // 
            // btnCadastar
            // 
            this.btnCadastar.Location = new System.Drawing.Point(21, 324);
            this.btnCadastar.Name = "btnCadastar";
            this.btnCadastar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastar.TabIndex = 2;
            this.btnCadastar.Text = "cadastrar";
            this.btnCadastar.UseVisualStyleBackColor = true;
            this.btnCadastar.Click += new System.EventHandler(this.btnCadastar_Click);
            // 
            // textLo
            // 
            this.textLo.Location = new System.Drawing.Point(86, 67);
            this.textLo.Name = "textLo";
            this.textLo.Size = new System.Drawing.Size(100, 20);
            this.textLo.TabIndex = 3;
            // 
            // tblLo
            // 
            this.tblLo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblLo.Location = new System.Drawing.Point(38, 141);
            this.tblLo.Name = "tblLo";
            this.tblLo.Size = new System.Drawing.Size(369, 150);
            this.tblLo.TabIndex = 4;
            this.tblLo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblLo_CellContentClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(126, 324);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(220, 324);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // textSe
            // 
            this.textSe.Location = new System.Drawing.Point(269, 67);
            this.textSe.Name = "textSe";
            this.textSe.Size = new System.Drawing.Size(100, 20);
            this.textSe.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "senha";
            // 
            // textIdLo
            // 
            this.textIdLo.Location = new System.Drawing.Point(413, 25);
            this.textIdLo.Name = "textIdLo";
            this.textIdLo.Size = new System.Drawing.Size(100, 20);
            this.textIdLo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "id login";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(328, 324);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 11;
            this.btnListar.Text = "listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textIdLo);
            this.Controls.Add(this.textSe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.tblLo);
            this.Controls.Add(this.textLo);
            this.Controls.Add(this.btnCadastar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "tela";
            this.Text = "Tela";
            this.Load += new System.EventHandler(this.tela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblLo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastar;
        private System.Windows.Forms.TextBox textLo;
        private System.Windows.Forms.DataGridView tblLo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox textSe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textIdLo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnListar;
    }
}