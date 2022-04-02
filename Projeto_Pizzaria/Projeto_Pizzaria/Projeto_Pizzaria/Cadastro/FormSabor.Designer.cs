namespace Projeto_Pizzaria.Cadastro
{
    partial class FormSabor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSabor));
            this.btEdita = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clbSabores = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btEdita
            // 
            this.btEdita.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEdita.BackgroundImage")));
            this.btEdita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEdita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdita.Location = new System.Drawing.Point(123, 225);
            this.btEdita.Name = "btEdita";
            this.btEdita.Size = new System.Drawing.Size(49, 41);
            this.btEdita.TabIndex = 22;
            this.btEdita.UseVisualStyleBackColor = true;
            // 
            // btBuscar
            // 
            this.btBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBuscar.BackgroundImage")));
            this.btBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Location = new System.Drawing.Point(178, 225);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(45, 41);
            this.btBuscar.TabIndex = 21;
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btExcluir.BackgroundImage")));
            this.btExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Location = new System.Drawing.Point(65, 225);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(52, 41);
            this.btExcluir.TabIndex = 18;
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSalvar.BackgroundImage")));
            this.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Location = new System.Drawing.Point(14, 225);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(45, 41);
            this.btSalvar.TabIndex = 17;
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // btLimpar
            // 
            this.btLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btLimpar.BackgroundImage")));
            this.btLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Location = new System.Drawing.Point(263, 225);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(48, 41);
            this.btLimpar.TabIndex = 19;
            this.btLimpar.UseVisualStyleBackColor = true;
            // 
            // btSair
            // 
            this.btSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSair.BackgroundImage")));
            this.btSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Location = new System.Drawing.Point(317, 225);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(51, 41);
            this.btSair.TabIndex = 20;
            this.btSair.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clbSabores);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 207);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sabores";
            // 
            // clbSabores
            // 
            this.clbSabores.FormattingEnabled = true;
            this.clbSabores.Items.AddRange(new object[] {
            "Calabresa",
            "Mussarela ",
            "Queijo",
            "Atum ",
            "Presunto",
            "Portuguesa",
            "California"});
            this.clbSabores.Location = new System.Drawing.Point(6, 19);
            this.clbSabores.Name = "clbSabores";
            this.clbSabores.Size = new System.Drawing.Size(131, 169);
            this.clbSabores.TabIndex = 0;
            // 
            // FormSabor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 280);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btEdita);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btSair);
            this.Name = "FormSabor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CadastroSabor";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btEdita;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox clbSabores;
    }
}