namespace Aula3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsArquivo = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGenero = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFilme = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsProcesso = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsLocacao = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSobre = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.tsMenu,
            this.toolStripSeparator1,
            this.tsProcesso,
            this.toolStripSeparator2,
            this.tsSobre,
            this.tsArquivo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsArquivo
            // 
            this.tsArquivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSair});
            this.tsArquivo.Image = ((System.Drawing.Image)(resources.GetObject("tsArquivo.Image")));
            this.tsArquivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsArquivo.Name = "tsArquivo";
            this.tsArquivo.Size = new System.Drawing.Size(62, 22);
            this.tsArquivo.Text = "Arquivo";
            // 
            // tsSair
            // 
            this.tsSair.Name = "tsSair";
            this.tsSair.Size = new System.Drawing.Size(180, 22);
            this.tsSair.Text = "Sair";
            this.tsSair.Click += new System.EventHandler(this.tsSair_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsMenu
            // 
            this.tsMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCliente,
            this.tsGenero,
            this.tsFilme});
            this.tsMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsMenu.Image")));
            this.tsMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(67, 22);
            this.tsMenu.Text = "Cadastro";
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
            this.tsGenero.Text = "Genero";
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
            // tsProcesso
            // 
            this.tsProcesso.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsProcesso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLocacao});
            this.tsProcesso.Image = ((System.Drawing.Image)(resources.GetObject("tsProcesso.Image")));
            this.tsProcesso.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsProcesso.Name = "tsProcesso";
            this.tsProcesso.Size = new System.Drawing.Size(67, 22);
            this.tsProcesso.Text = "Processo";
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
            // tsSobre
            // 
            this.tsSobre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsSobre.Image = ((System.Drawing.Image)(resources.GetObject("tsSobre.Image")));
            this.tsSobre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSobre.Name = "tsSobre";
            this.tsSobre.Size = new System.Drawing.Size(50, 22);
            this.tsSobre.Text = "Sobre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Sistema de Locadora";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsCliente;
        private System.Windows.Forms.ToolStripMenuItem tsGenero;
        private System.Windows.Forms.ToolStripMenuItem tsFilme;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsProcesso;
        private System.Windows.Forms.ToolStripMenuItem tsLocacao;
        private System.Windows.Forms.ToolStripDropDownButton tsArquivo;
        private System.Windows.Forms.ToolStripMenuItem tsSair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton tsSobre;
    }
}

