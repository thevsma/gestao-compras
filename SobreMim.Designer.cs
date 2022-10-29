namespace GestaoComprasMVP
{
    partial class SobreMim
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
            this.lnkGit = new System.Windows.Forms.LinkLabel();
            this.lblSobre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lnkGit);
            this.panel1.Controls.Add(this.lblSobre);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 269);
            this.panel1.TabIndex = 0;
            // 
            // lnkGit
            // 
            this.lnkGit.AutoSize = true;
            this.lnkGit.Location = new System.Drawing.Point(143, 53);
            this.lnkGit.Name = "lnkGit";
            this.lnkGit.Size = new System.Drawing.Size(64, 13);
            this.lnkGit.TabIndex = 2;
            this.lnkGit.TabStop = true;
            this.lnkGit.Text = "Meu GitHub";
            this.lnkGit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGit_LinkClicked);
            // 
            // lblSobre
            // 
            this.lblSobre.AutoSize = true;
            this.lblSobre.Location = new System.Drawing.Point(143, 16);
            this.lblSobre.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(185, 26);
            this.lblSobre.TabIndex = 1;
            this.lblSobre.Text = "Sou Matheus Vieira, tenho 18 anos e sou estudante do IFNMG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestaoComprasMVP.Properties.Resources.PXL_20220827_172513166_01;
            this.pictureBox1.Location = new System.Drawing.Point(19, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label1.Location = new System.Drawing.Point(318, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 9);
            this.label1.TabIndex = 3;
            this.label1.Text = "amo minha namorada\r\n";
            // 
            // SobreMim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 269);
            this.Controls.Add(this.panel1);
            this.Name = "SobreMim";
            this.Text = "SobreMim";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lnkGit;
        private System.Windows.Forms.Label lblSobre;
        private System.Windows.Forms.Label label1;
    }
}