namespace GestaoComprasMVP
{
    partial class LotesUmDia
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
            this.dtgUm = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUm)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgUm
            // 
            this.dtgUm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgUm.Location = new System.Drawing.Point(0, 0);
            this.dtgUm.Name = "dtgUm";
            this.dtgUm.Size = new System.Drawing.Size(484, 311);
            this.dtgUm.TabIndex = 0;
            // 
            // LotesUmDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.dtgUm);
            this.Name = "LotesUmDia";
            this.Text = "LotesUmDia";
            ((System.ComponentModel.ISupportInitialize)(this.dtgUm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgUm;
    }
}