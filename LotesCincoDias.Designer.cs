﻿namespace GestaoComprasMVP
{
    partial class LotesCincoDias
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
            this.dtgCinco = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCinco)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCinco
            // 
            this.dtgCinco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCinco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCinco.Location = new System.Drawing.Point(0, 0);
            this.dtgCinco.Name = "dtgCinco";
            this.dtgCinco.Size = new System.Drawing.Size(484, 311);
            this.dtgCinco.TabIndex = 0;
            // 
            // LotesCincoDias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.dtgCinco);
            this.Name = "LotesCincoDias";
            this.Text = "LotesCincoDias";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCinco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCinco;
    }
}