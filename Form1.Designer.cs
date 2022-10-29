namespace GestaoComprasMVP
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLote = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTodos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUmDia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCincoDias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPersonalizado = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSobre,
            this.mnuSair});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // mnuSobre
            // 
            this.mnuSobre.Name = "mnuSobre";
            this.mnuSobre.Size = new System.Drawing.Size(104, 22);
            this.mnuSobre.Text = "Sobre";
            this.mnuSobre.Click += new System.EventHandler(this.mnuSobre_Click);
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(104, 22);
            this.mnuSair.Text = "Sair";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLote});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // mnuLote
            // 
            this.mnuLote.Name = "mnuLote";
            this.mnuLote.Size = new System.Drawing.Size(126, 22);
            this.mnuLote.Text = "Novo lote";
            this.mnuLote.Click += new System.EventHandler(this.mnuLote_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTodos,
            this.mnuUmDia,
            this.mnuCincoDias,
            this.mnuPersonalizado});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // mnuTodos
            // 
            this.mnuTodos.Name = "mnuTodos";
            this.mnuTodos.Size = new System.Drawing.Size(213, 22);
            this.mnuTodos.Text = "Todos os lotes";
            this.mnuTodos.Click += new System.EventHandler(this.mnuTodos_Click);
            // 
            // mnuUmDia
            // 
            this.mnuUmDia.Name = "mnuUmDia";
            this.mnuUmDia.Size = new System.Drawing.Size(213, 22);
            this.mnuUmDia.Text = "A vencer em até 1 dia";
            this.mnuUmDia.Click += new System.EventHandler(this.mnuUmDia_Click);
            // 
            // mnuCincoDias
            // 
            this.mnuCincoDias.Name = "mnuCincoDias";
            this.mnuCincoDias.Size = new System.Drawing.Size(213, 22);
            this.mnuCincoDias.Text = "A vencer em até 5 dias";
            this.mnuCincoDias.Click += new System.EventHandler(this.mnuCincoDias_Click);
            // 
            // mnuPersonalizado
            // 
            this.mnuPersonalizado.Name = "mnuPersonalizado";
            this.mnuPersonalizado.Size = new System.Drawing.Size(213, 22);
            this.mnuPersonalizado.Text = "Vencimento personalizado";
            this.mnuPersonalizado.Click += new System.EventHandler(this.mnuPersonalizado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSobre;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLote;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuTodos;
        private System.Windows.Forms.ToolStripMenuItem mnuUmDia;
        private System.Windows.Forms.ToolStripMenuItem mnuCincoDias;
        private System.Windows.Forms.ToolStripMenuItem mnuPersonalizado;
    }
}

