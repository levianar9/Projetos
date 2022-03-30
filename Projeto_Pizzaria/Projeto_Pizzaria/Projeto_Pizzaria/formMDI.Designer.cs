namespace Projeto_Pizzaria
{
    partial class formMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMDI));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsCadastro = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTipo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSabores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsVenda = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSobre = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenu,
            this.toolStripSeparator1,
            this.tsCadastro,
            this.toolStripSeparator2,
            this.tsVenda,
            this.toolStripSeparator3,
            this.tsSobre});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsMenu
            // 
            this.tsMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSair});
            this.tsMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsMenu.Image")));
            this.tsMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(54, 22);
            this.tsMenu.Text = "MENU";
            // 
            // tsSair
            // 
            this.tsSair.Name = "tsSair";
            this.tsSair.Size = new System.Drawing.Size(180, 22);
            this.tsSair.Text = "Sair";
            this.tsSair.Click += new System.EventHandler(this.tsSair_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsCadastro
            // 
            this.tsCadastro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCliente,
            this.tsTipo,
            this.tsSabores});
            this.tsCadastro.Image = ((System.Drawing.Image)(resources.GetObject("tsCadastro.Image")));
            this.tsCadastro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCadastro.Name = "tsCadastro";
            this.tsCadastro.Size = new System.Drawing.Size(80, 22);
            this.tsCadastro.Text = "CADASTRO";
            // 
            // tsCliente
            // 
            this.tsCliente.Name = "tsCliente";
            this.tsCliente.Size = new System.Drawing.Size(180, 22);
            this.tsCliente.Text = "Cliente";
            this.tsCliente.Click += new System.EventHandler(this.tsCliente_Click);
            // 
            // tsTipo
            // 
            this.tsTipo.Name = "tsTipo";
            this.tsTipo.Size = new System.Drawing.Size(180, 22);
            this.tsTipo.Text = "Tipo";
            this.tsTipo.Click += new System.EventHandler(this.tsTipo_Click);
            // 
            // tsSabores
            // 
            this.tsSabores.Name = "tsSabores";
            this.tsSabores.Size = new System.Drawing.Size(180, 22);
            this.tsSabores.Text = "Sabores";
            this.tsSabores.Click += new System.EventHandler(this.tsSabores_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsVenda
            // 
            this.tsVenda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsVenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPedido});
            this.tsVenda.Image = ((System.Drawing.Image)(resources.GetObject("tsVenda.Image")));
            this.tsVenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsVenda.Name = "tsVenda";
            this.tsVenda.Size = new System.Drawing.Size(58, 22);
            this.tsVenda.Text = "VENDA";
            // 
            // tsPedido
            // 
            this.tsPedido.Name = "tsPedido";
            this.tsPedido.Size = new System.Drawing.Size(180, 22);
            this.tsPedido.Text = "Pedido";
            this.tsPedido.Click += new System.EventHandler(this.tsPedido_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsSobre
            // 
            this.tsSobre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsSobre.Image = ((System.Drawing.Image)(resources.GetObject("tsSobre.Image")));
            this.tsSobre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSobre.Name = "tsSobre";
            this.tsSobre.Size = new System.Drawing.Size(55, 22);
            this.tsSobre.Text = "SOBRE";
            // 
            // formMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "formMDI";
            this.Text = "Sistema de Pizzaria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsSair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsCadastro;
        private System.Windows.Forms.ToolStripMenuItem tsCliente;
        private System.Windows.Forms.ToolStripMenuItem tsTipo;
        private System.Windows.Forms.ToolStripMenuItem tsSabores;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton tsVenda;
        private System.Windows.Forms.ToolStripMenuItem tsPedido;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton tsSobre;
    }
}

