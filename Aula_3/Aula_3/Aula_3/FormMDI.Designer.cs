namespace Aula_3
{
    partial class FormMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMDI));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsMenuCadastro = new System.Windows.Forms.ToolStripSplitButton();
            this.tsCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGenero = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFilme = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMenuProcesso = new System.Windows.Forms.ToolStripSplitButton();
            this.tsLocacao = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMenuSobre = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMenuArquivo = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuCadastro,
            this.toolStripSeparator1,
            this.tsMenuProcesso,
            this.toolStripSeparator2,
            this.tsMenuSobre,
            this.toolStripSeparator3,
            this.tsMenuArquivo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsMenuCadastro
            // 
            this.tsMenuCadastro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsMenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCliente,
            this.tsGenero,
            this.tsFilme});
            this.tsMenuCadastro.Image = ((System.Drawing.Image)(resources.GetObject("tsMenuCadastro.Image")));
            this.tsMenuCadastro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMenuCadastro.Name = "tsMenuCadastro";
            this.tsMenuCadastro.Size = new System.Drawing.Size(70, 22);
            this.tsMenuCadastro.Text = "Cadastro";
            // 
            // tsCliente
            // 
            this.tsCliente.Name = "tsCliente";
            this.tsCliente.Size = new System.Drawing.Size(180, 22);
            this.tsCliente.Text = "Cliente";
            this.tsCliente.Click += new System.EventHandler(this.tsCliente_Click);
            // 
            // tsGenero
            // 
            this.tsGenero.Name = "tsGenero";
            this.tsGenero.Size = new System.Drawing.Size(180, 22);
            this.tsGenero.Text = "Gênero";
            this.tsGenero.Click += new System.EventHandler(this.tsGenero_Click);
            // 
            // tsFilme
            // 
            this.tsFilme.Name = "tsFilme";
            this.tsFilme.Size = new System.Drawing.Size(180, 22);
            this.tsFilme.Text = "Filme";
            this.tsFilme.Click += new System.EventHandler(this.tsFilme_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsMenuProcesso
            // 
            this.tsMenuProcesso.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsMenuProcesso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLocacao});
            this.tsMenuProcesso.Image = ((System.Drawing.Image)(resources.GetObject("tsMenuProcesso.Image")));
            this.tsMenuProcesso.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMenuProcesso.Name = "tsMenuProcesso";
            this.tsMenuProcesso.Size = new System.Drawing.Size(70, 22);
            this.tsMenuProcesso.Text = "Processo";
            // 
            // tsLocacao
            // 
            this.tsLocacao.Name = "tsLocacao";
            this.tsLocacao.Size = new System.Drawing.Size(180, 22);
            this.tsLocacao.Text = "Locação";
            this.tsLocacao.Click += new System.EventHandler(this.tsLocacao_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsMenuSobre
            // 
            this.tsMenuSobre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsMenuSobre.Image = ((System.Drawing.Image)(resources.GetObject("tsMenuSobre.Image")));
            this.tsMenuSobre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMenuSobre.Name = "tsMenuSobre";
            this.tsMenuSobre.Size = new System.Drawing.Size(50, 22);
            this.tsMenuSobre.Text = "Sobre";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsMenuArquivo
            // 
            this.tsMenuArquivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsMenuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSair});
            this.tsMenuArquivo.Image = ((System.Drawing.Image)(resources.GetObject("tsMenuArquivo.Image")));
            this.tsMenuArquivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMenuArquivo.Name = "tsMenuArquivo";
            this.tsMenuArquivo.Size = new System.Drawing.Size(62, 22);
            this.tsMenuArquivo.Text = "Arquivo";
            // 
            // tsSair
            // 
            this.tsSair.Name = "tsSair";
            this.tsSair.Size = new System.Drawing.Size(180, 22);
            this.tsSair.Text = "Sair";
            this.tsSair.Click += new System.EventHandler(this.tsSair_Click);
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "FormMDI";
            this.Text = "Sistema de Locadora";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton tsMenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem tsCliente;
        private System.Windows.Forms.ToolStripMenuItem tsGenero;
        private System.Windows.Forms.ToolStripMenuItem tsFilme;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton tsMenuProcesso;
        private System.Windows.Forms.ToolStripMenuItem tsLocacao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton tsMenuSobre;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton tsMenuArquivo;
        private System.Windows.Forms.ToolStripMenuItem tsSair;
    }
}

