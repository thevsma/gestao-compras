namespace GestaoComprasMVP
{
    partial class NovoLote
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTeste = new System.Windows.Forms.Label();
            this.grpCompra = new System.Windows.Forms.GroupBox();
            this.dtpCompra = new System.Windows.Forms.DateTimePicker();
            this.btnCriar = new System.Windows.Forms.Button();
            this.grpVenc = new System.Windows.Forms.GroupBox();
            this.dtpVenc = new System.Windows.Forms.DateTimePicker();
            this.lblQuant = new System.Windows.Forms.Label();
            this.numQuant = new System.Windows.Forms.NumericUpDown();
            this.lstProdutos = new System.Windows.Forms.ListBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.grpUltimo = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.grpCompra.SuspendLayout();
            this.grpVenc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuant)).BeginInit();
            this.grpUltimo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpUltimo);
            this.panel1.Controls.Add(this.grpCompra);
            this.panel1.Controls.Add(this.btnCriar);
            this.panel1.Controls.Add(this.grpVenc);
            this.panel1.Controls.Add(this.lblQuant);
            this.panel1.Controls.Add(this.numQuant);
            this.panel1.Controls.Add(this.lstProdutos);
            this.panel1.Controls.Add(this.lblCod);
            this.panel1.Controls.Add(this.txtCod);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 273);
            this.panel1.TabIndex = 0;
            // 
            // lblTeste
            // 
            this.lblTeste.AutoSize = true;
            this.lblTeste.Location = new System.Drawing.Point(6, 18);
            this.lblTeste.Name = "lblTeste";
            this.lblTeste.Size = new System.Drawing.Size(16, 13);
            this.lblTeste.TabIndex = 12;
            this.lblTeste.Text = "...";
            // 
            // grpCompra
            // 
            this.grpCompra.Controls.Add(this.dtpCompra);
            this.grpCompra.Location = new System.Drawing.Point(15, 109);
            this.grpCompra.Name = "grpCompra";
            this.grpCompra.Size = new System.Drawing.Size(205, 40);
            this.grpCompra.TabIndex = 11;
            this.grpCompra.TabStop = false;
            this.grpCompra.Text = "Data compra:";
            // 
            // dtpCompra
            // 
            this.dtpCompra.Location = new System.Drawing.Point(0, 19);
            this.dtpCompra.Name = "dtpCompra";
            this.dtpCompra.Size = new System.Drawing.Size(201, 20);
            this.dtpCompra.TabIndex = 0;
            // 
            // btnCriar
            // 
            this.btnCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCriar.Location = new System.Drawing.Point(226, 222);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(139, 39);
            this.btnCriar.TabIndex = 10;
            this.btnCriar.Text = "Criar Lote";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // grpVenc
            // 
            this.grpVenc.Controls.Add(this.dtpVenc);
            this.grpVenc.Location = new System.Drawing.Point(15, 155);
            this.grpVenc.Name = "grpVenc";
            this.grpVenc.Size = new System.Drawing.Size(204, 43);
            this.grpVenc.TabIndex = 9;
            this.grpVenc.TabStop = false;
            this.grpVenc.Text = "Data vencimento:";
            // 
            // dtpVenc
            // 
            this.dtpVenc.Location = new System.Drawing.Point(0, 19);
            this.dtpVenc.Name = "dtpVenc";
            this.dtpVenc.Size = new System.Drawing.Size(200, 20);
            this.dtpVenc.TabIndex = 0;
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(11, 78);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(39, 13);
            this.lblQuant.TabIndex = 6;
            this.lblQuant.Text = "Quant:";
            // 
            // numQuant
            // 
            this.numQuant.Location = new System.Drawing.Point(56, 76);
            this.numQuant.Name = "numQuant";
            this.numQuant.Size = new System.Drawing.Size(100, 20);
            this.numQuant.TabIndex = 5;
            this.numQuant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lstProdutos
            // 
            this.lstProdutos.FormattingEnabled = true;
            this.lstProdutos.Location = new System.Drawing.Point(162, 12);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(200, 95);
            this.lstProdutos.TabIndex = 4;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(7, 53);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 3;
            this.lblCod.Text = "Código:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(56, 50);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 2;
            this.txtCod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCod_KeyUp);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(56, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // grpUltimo
            // 
            this.grpUltimo.Controls.Add(this.lblTeste);
            this.grpUltimo.Location = new System.Drawing.Point(14, 204);
            this.grpUltimo.Name = "grpUltimo";
            this.grpUltimo.Size = new System.Drawing.Size(205, 57);
            this.grpUltimo.TabIndex = 13;
            this.grpUltimo.TabStop = false;
            this.grpUltimo.Text = "Último lote criado:";
            // 
            // NovoLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 273);
            this.Controls.Add(this.panel1);
            this.Name = "NovoLote";
            this.Text = "NovoLote";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpCompra.ResumeLayout(false);
            this.grpVenc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numQuant)).EndInit();
            this.grpUltimo.ResumeLayout(false);
            this.grpUltimo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstProdutos;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox grpCompra;
        private System.Windows.Forms.DateTimePicker dtpCompra;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.GroupBox grpVenc;
        private System.Windows.Forms.DateTimePicker dtpVenc;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.NumericUpDown numQuant;
        private System.Windows.Forms.Label lblTeste;
        private System.Windows.Forms.GroupBox grpUltimo;
    }
}