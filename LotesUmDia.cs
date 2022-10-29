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
    public partial class LotesUmDia : Form
    {
        private static LotesUmDia instance;
        public LotesUmDia()
        {
            InitializeComponent();

            dtgUm.DataSource = BDSimulado.Vencimento(1);

            ConfigTabelaUm();
        }

        public static LotesUmDia GetInstance()
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new LotesUmDia();
            }
            return instance;
        }

        public void ConfigTabelaUm()
        {
            dtgUm.Columns[1].Visible = false;
            dtgUm.AllowUserToAddRows = false;
            dtgUm.Columns[0].Width = 30;
            dtgUm.Columns[2].Width = 80;
            dtgUm.Columns[3].HeaderText = "Quant.";
            dtgUm.Columns[3].Width = 40;
            dtgUm.Columns[5].Width = 50;
        } 
    }
}