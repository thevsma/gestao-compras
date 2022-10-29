namespace GestaoComprasMVP
{
    partial class LotePersonalizado
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
            this.grpVenc1 = new System.Windows.Forms.GroupBox();
            this.dtpVenc1 = new System.Windows.Forms.DateTimePicker();
            this.dtgVencPers = new System.Windows.Forms.DataGridView();
            this.grpVenc2 = new System.Windows.Forms.GroupBox();
            this.dtpVenc2 = new System.Windows.Forms.DateTimePicker();
            this.grpVenc1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVencPers)).BeginInit();
            this.grpVenc2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpVenc1
            // 
            this.grpVenc1.Controls.Add(this.dtpVenc1);
            this.grpVenc1.Location = new System.Drawing.Point(12, 12);
            this.grpVenc1.Name = "grpVenc1";
            this.grpVenc1.Size = new System.Drawing.Size(232, 43);
            this.grpVenc1.TabIndex = 0;
            this.grpVenc1.TabStop = false;
            this.grpVenc1.Text = "Vencimento De:";
            // 
            // dtpVenc1
            // 
            this.dtpVenc1.Location = new System.Drawing.Point(0, 17);
            this.dtpVenc1.Name = "dtpVenc1";
            this.dtpVenc1.Size = new System.Drawing.Size(232, 20);
            this.dtpVenc1.TabIndex = 1;
            // 
            // dtgVencPers
            // 
            this.dtgVencPers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVencPers.Location = new System.Drawing.Point(12, 61);
            this.dtgVencPers.Name = "dtgVencPers";
            this.dtgVencPers.Size = new System.Drawing.Size(460, 238);
            this.dtgVencPers.TabIndex = 1;
            // 
            // grpVenc2
            // 
            this.grpVenc2.Controls.Add(this.dtpVenc2);
            this.grpVenc2.Location = new System.Drawing.Point(250, 12);
            this.grpVenc2.Name = "grpVenc2";
            this.grpVenc2.Size = new System.Drawing.Size(231, 43);
            this.grpVenc2.TabIndex = 2;
            this.grpVenc2.TabStop = false;
            this.grpVenc2.Text = "Até:";
            // 
            // dtpVenc2
            // 
            this.dtpVenc2.Location = new System.Drawing.Point(0, 17);
            this.dtpVenc2.Name = "dtpVenc2";
            this.dtpVenc2.Size = new System.Drawing.Size(231, 20);
            this.dtpVenc2.TabIndex = 0;
            this.dtpVenc2.ValueChanged += new System.EventHandler(this.dtpVenc2_ValueChanged);
            // 
            // LotePersonalizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.grpVenc2);
            this.Controls.Add(this.dtgVencPers);
            this.Controls.Add(this.grpVenc1);
            this.Name = "LotePersonalizado";
            this.Text = "LotePersonalizado";
            this.grpVenc1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVencPers)).EndInit();
            this.grpVenc2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVenc1;
        private System.Windows.Forms.DateTimePicker dtpVenc1;
        private System.Windows.Forms.DataGridView dtgVencPers;
        private System.Windows.Forms.GroupBox grpVenc2;
        private System.Windows.Forms.DateTimePicker dtpVenc2;
    }
}