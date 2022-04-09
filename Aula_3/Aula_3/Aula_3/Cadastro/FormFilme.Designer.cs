namespace Aula_3.Cadastro
{
    partial class FormFilme
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
            this.gbFilme = new System.Windows.Forms.GroupBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFilme = new System.Windows.Forms.TextBox();
            this.filme = new System.Windows.Forms.Label();
            this.gbFilme.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilme
            // 
            this.gbFilme.Controls.Add(this.btSair);
            this.gbFilme.Controls.Add(this.btExcluir);
            this.gbFilme.Controls.Add(this.btAtualizar);
            this.gbFilme.Controls.Add(this.btIncluir);
            this.gbFilme.Controls.Add(this.cbGenero);
            this.gbFilme.Controls.Add(this.label1);
            this.gbFilme.Controls.Add(this.tbFilme);
            this.gbFilme.Controls.Add(this.filme);
            this.gbFilme.Location = new System.Drawing.Point(12, 12);
            this.gbFilme.Name = "gbFilme";
            this.gbFilme.Size = new System.Drawing.Size(383, 172);
            this.gbFilme.TabIndex = 0;
            this.gbFilme.TabStop = false;
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(302, 134);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 32);
            this.btSair.TabIndex = 7;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click_1);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(171, 134);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 32);
            this.btExcluir.TabIndex = 6;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(90, 134);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(75, 32);
            this.btAtualizar.TabIndex = 5;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            // 
            // btIncluir
            // 
            this.btIncluir.Location = new System.Drawing.Point(9, 134);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(75, 32);
            this.btIncluir.TabIndex = 4;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(9, 74);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(176, 21);
            this.cbGenero.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gênero";
            // 
            // tbFilme
            // 
            this.tbFilme.Location = new System.Drawing.Point(9, 32);
            this.tbFilme.Name = "tbFilme";
            this.tbFilme.Size = new System.Drawing.Size(314, 20);
            this.tbFilme.TabIndex = 1;
            // 
            // filme
            // 
            this.filme.AutoSize = true;
            this.filme.Location = new System.Drawing.Point(6, 16);
            this.filme.Name = "filme";
            this.filme.Size = new System.Drawing.Size(31, 13);
            this.filme.TabIndex = 0;
            this.filme.Text = "Filme";
            // 
            // FormFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 196);
            this.Controls.Add(this.gbFilme);
            this.Name = "FormFilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastro Filme";
            this.gbFilme.ResumeLayout(false);
            this.gbFilme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFilme;
        private System.Windows.Forms.Label filme;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.ComboBox cbGenero;
    }
}