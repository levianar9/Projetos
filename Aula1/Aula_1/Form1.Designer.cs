namespace Aula_1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgPessoa = new System.Windows.Forms.DataGridView();
            this.tbBuscar = new System.Windows.Forms.Button();
            this.tbExcluir = new System.Windows.Forms.Button();
            this.tbEditar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tbBuscar);
            this.groupBox1.Controls.Add(this.tbExcluir);
            this.groupBox1.Controls.Add(this.tbEditar);
            this.groupBox1.Controls.Add(this.btSair);
            this.groupBox1.Controls.Add(this.btLimpar);
            this.groupBox1.Controls.Add(this.btSalvar);
            this.groupBox1.Controls.Add(this.tbTelefone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 433);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgPessoa);
            this.groupBox2.Location = new System.Drawing.Point(6, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 188);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pessoa";
            // 
            // dgPessoa
            // 
            this.dgPessoa.AllowUserToAddRows = false;
            this.dgPessoa.AllowUserToDeleteRows = false;
            this.dgPessoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPessoa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgPessoa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPessoa.Location = new System.Drawing.Point(6, 19);
            this.dgPessoa.Name = "dgPessoa";
            this.dgPessoa.ReadOnly = true;
            this.dgPessoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPessoa.Size = new System.Drawing.Size(535, 189);
            this.dgPessoa.TabIndex = 0;
            this.dgPessoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPessoa_CellClick);
            // 
            // tbBuscar
            // 
            this.tbBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbBuscar.Location = new System.Drawing.Point(254, 198);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbBuscar.Size = new System.Drawing.Size(63, 35);
            this.tbBuscar.TabIndex = 11;
            this.tbBuscar.Text = "Buscar";
            this.tbBuscar.UseVisualStyleBackColor = true;
            this.tbBuscar.Click += new System.EventHandler(this.tbBuscar_Click);
            // 
            // tbExcluir
            // 
            this.tbExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.tbExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tbExcluir.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tbExcluir.ImageKey = "(none)";
            this.tbExcluir.Location = new System.Drawing.Point(93, 198);
            this.tbExcluir.Name = "tbExcluir";
            this.tbExcluir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbExcluir.Size = new System.Drawing.Size(63, 35);
            this.tbExcluir.TabIndex = 9;
            this.tbExcluir.Text = "Excluir";
            this.tbExcluir.UseVisualStyleBackColor = true;
            this.tbExcluir.Click += new System.EventHandler(this.tbExcluir_Click);
            // 
            // tbEditar
            // 
            this.tbEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tbEditar.Location = new System.Drawing.Point(175, 198);
            this.tbEditar.Name = "tbEditar";
            this.tbEditar.Size = new System.Drawing.Size(63, 35);
            this.tbEditar.TabIndex = 10;
            this.tbEditar.Text = "Editar";
            this.tbEditar.UseMnemonic = false;
            this.tbEditar.UseVisualStyleBackColor = true;
            this.tbEditar.Click += new System.EventHandler(this.tbEditar_Click);
            // 
            // btSair
            // 
            this.btSair.Cursor = System.Windows.Forms.Cursors.Default;
            this.btSair.Location = new System.Drawing.Point(484, 198);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(63, 35);
            this.btSair.TabIndex = 13;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click_1);
            // 
            // btLimpar
            // 
            this.btLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLimpar.Location = new System.Drawing.Point(415, 198);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(63, 35);
            this.btLimpar.TabIndex = 12;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSalvar.Location = new System.Drawing.Point(12, 198);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(63, 35);
            this.btSalvar.TabIndex = 8;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(12, 149);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(100, 20);
            this.tbTelefone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(12, 110);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(305, 20);
            this.tbEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(12, 71);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(305, 20);
            this.tbNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(12, 32);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 457);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Cadastro Pessoa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPessoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button tbEditar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button tbExcluir;
        private System.Windows.Forms.Button tbBuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgPessoa;
    }
}

