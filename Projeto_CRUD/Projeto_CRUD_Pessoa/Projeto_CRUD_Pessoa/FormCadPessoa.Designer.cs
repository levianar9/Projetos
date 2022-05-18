namespace Projeto_CRUD_Pessoa
{
    partial class FormCadPessoa
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
            this.gbCadPessoa = new System.Windows.Forms.GroupBox();
            this.btExcluir = new System.Windows.Forms.Button();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.tbCPF = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgPessoa = new System.Windows.Forms.DataGridView();
            this.tbSeqPessoa = new System.Windows.Forms.TextBox();
            this.gbCadPessoa.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCadPessoa
            // 
            this.gbCadPessoa.Controls.Add(this.btExcluir);
            this.gbCadPessoa.Controls.Add(this.gbSexo);
            this.gbCadPessoa.Controls.Add(this.tbCPF);
            this.gbCadPessoa.Controls.Add(this.label1);
            this.gbCadPessoa.Controls.Add(this.label3);
            this.gbCadPessoa.Controls.Add(this.tbEmail);
            this.gbCadPessoa.Controls.Add(this.Nome);
            this.gbCadPessoa.Controls.Add(this.tbNome);
            this.gbCadPessoa.Controls.Add(this.btSair);
            this.gbCadPessoa.Controls.Add(this.btLimpar);
            this.gbCadPessoa.Controls.Add(this.btSalvar);
            this.gbCadPessoa.Location = new System.Drawing.Point(12, 12);
            this.gbCadPessoa.Name = "gbCadPessoa";
            this.gbCadPessoa.Size = new System.Drawing.Size(451, 216);
            this.gbCadPessoa.TabIndex = 1;
            this.gbCadPessoa.TabStop = false;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(96, 172);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 33);
            this.btExcluir.TabIndex = 12;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbFeminino);
            this.gbSexo.Controls.Add(this.rbMasculino);
            this.gbSexo.Location = new System.Drawing.Point(16, 107);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(387, 47);
            this.gbSexo.TabIndex = 8;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(205, 19);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbFeminino.TabIndex = 10;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Checked = true;
            this.rbMasculino.Location = new System.Drawing.Point(82, 19);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 9;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(16, 77);
            this.tbCPF.Mask = "000.000.000-00";
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(96, 20);
            this.tbCPF.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-mail";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(118, 77);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(285, 20);
            this.tbEmail.TabIndex = 7;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(13, 12);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 2;
            this.Nome.Text = "Nome";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(16, 28);
            this.tbNome.MaxLength = 100;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(387, 20);
            this.tbNome.TabIndex = 3;
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(328, 172);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 33);
            this.btSair.TabIndex = 14;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(247, 172);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 33);
            this.btLimpar.TabIndex = 13;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(16, 172);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 33);
            this.btSalvar.TabIndex = 11;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgPessoa);
            this.groupBox2.Location = new System.Drawing.Point(12, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 193);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // dgPessoa
            // 
            this.dgPessoa.AllowUserToAddRows = false;
            this.dgPessoa.AllowUserToDeleteRows = false;
            this.dgPessoa.AllowUserToResizeColumns = false;
            this.dgPessoa.AllowUserToResizeRows = false;
            this.dgPessoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPessoa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgPessoa.Location = new System.Drawing.Point(6, 16);
            this.dgPessoa.MultiSelect = false;
            this.dgPessoa.Name = "dgPessoa";
            this.dgPessoa.ReadOnly = true;
            this.dgPessoa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgPessoa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgPessoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPessoa.Size = new System.Drawing.Size(437, 171);
            this.dgPessoa.TabIndex = 15;
            this.dgPessoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPessoa_CellClick);
            // 
            // tbSeqPessoa
            // 
            this.tbSeqPessoa.Location = new System.Drawing.Point(12, 541);
            this.tbSeqPessoa.Name = "tbSeqPessoa";
            this.tbSeqPessoa.Size = new System.Drawing.Size(77, 20);
            this.tbSeqPessoa.TabIndex = 14;
            this.tbSeqPessoa.Visible = false;
            // 
            // FormCadPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 448);
            this.Controls.Add(this.tbSeqPessoa);
            this.Controls.Add(this.gbCadPessoa);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormCadPessoa";
            this.Text = "Cadastro de Pessoa";
            this.gbCadPessoa.ResumeLayout(false);
            this.gbCadPessoa.PerformLayout();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCadPessoa;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.MaskedTextBox tbCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgPessoa;
        private System.Windows.Forms.TextBox tbSeqPessoa;
        private System.Windows.Forms.Button btExcluir;
    }
}

