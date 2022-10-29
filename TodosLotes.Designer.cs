namespace GestaoComprasMVP
{
    partial class TodosLotes
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
            this.dtgTodos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTodos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgTodos
            // 
            this.dtgTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTodos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgTodos.Location = new System.Drawing.Point(0, 0);
            this.dtgTodos.Name = "dtgTodos";
            this.dtgTodos.Size = new System.Drawing.Size(484, 311);
            this.dtgTodos.TabIndex = 0;
            // 
            // TodosLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.dtgTodos);
            this.Name = "TodosLotes";
            this.Text = "TodosLotes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgTodos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgTodos;
    }
}