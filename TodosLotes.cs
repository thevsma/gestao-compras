using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoComprasMVP
{
    public partial class TodosLotes : Form
    {
        private static TodosLotes instance;
        public TodosLotes()
        {
            InitializeComponent();

            dtgTodos.DataSource = BDSimulado.Lotes;

            ConfigTabelaTodos();
        }

        public static TodosLotes GetInstance()
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new TodosLotes();
            }
            return instance;
        }

        public void ConfigTabelaTodos()
        {
            dtgTodos.Columns[1].Visible = false;
            dtgTodos.AllowUserToAddRows = false;
            dtgTodos.Columns[0].Width = 30;
            dtgTodos.Columns[2].Width = 80;
            dtgTodos.Columns[3].HeaderText = "Quant.";
            dtgTodos.Columns[3].Width = 40;
            dtgTodos.Columns[5].Width = 50;
        }
    }
}