namespace Aula3.Processo
{
    partial class FormLocacao
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
            this.tbSair = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.gbFilme = new System.Windows.Forms.GroupBox();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSair
            // 
            this.tbSair.Location = new System.Drawing.Point(584, 372);
            this.tbSair.Name = "tbSair";
            this.tbSair.Size = new System.Drawing.Size(81, 36);
            this.tbSair.TabIndex = 21;
            this.tbSair.Text = "Sair";
            this.tbSair.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(185, 372);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(81, 36);
            this.btExcluir.TabIndex = 20;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(98, 372);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(81, 36);
            this.btAtualizar.TabIndex = 19;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            // 
            // btIncluir
            // 
            this.btIncluir.Location = new System.Drawing.Point(11, 372);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(81, 36);
            this.btIncluir.TabIndex = 18;
            this.btIncluir.Text = "Inserir";
            this.btIncluir.UseVisualStyleBackColor = true;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.maskedTextBox1);
            this.gbCliente.Controls.Add(this.tbName);
            this.gbCliente.Controls.Add(this.Nome);
            this.gbCliente.Controls.Add(this.tbCPF);
            this.gbCliente.Controls.Add(this.label1);
            this.gbCliente.Location = new System.Drawing.Point(13, 12);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(667, 77);
            this.gbCliente.TabIndex = 22;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF";
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(10, 36);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(172, 20);
            this.tbCPF.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(188, 36);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(352, 20);
            this.tbName.TabIndex = 3;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(185, 20);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 2;
            this.Nome.Text = "Nome";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(547, 36);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(105, 20);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // gbFilme
            // 
            this.gbFilme.Location = new System.Drawing.Point(13, 105);
            this.gbFilme.Name = "gbFilme";
            this.gbFilme.Size = new System.Drawing.Size(652, 252);
            this.gbFilme.TabIndex = 23;
            this.gbFilme.TabStop = false;
            this.gbFilme.Text = "Filmes(s)";
            // 
            // FormLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 416);
            this.Controls.Add(this.gbFilme);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.tbSair);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btIncluir);
            this.Name = "FormLocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Locação de Filme";
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tbSair;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbFilme;
    }
}