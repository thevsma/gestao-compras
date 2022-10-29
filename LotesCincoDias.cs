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
    public partial class LotesCincoDias : Form
    {
        private static LotesCincoDias instance;
        public LotesCincoDias()
        {
            InitializeComponent();

            dtgCinco.DataSource = BDSimulado.Vencimento(5);

            ConfigTabelaCinco();
        }

        public static LotesCincoDias GetInstance()
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new LotesCincoDias();
            }
            return instance;
        }

        public void ConfigTabelaCinco()
        {
            dtgCinco.Columns[1].Visible = false;
            dtgCinco.AllowUserToAddRows = false;
            dtgCinco.Columns[0].Width = 30;
            dtgCinco.Columns[2].Width = 80;
            dtgCinco.Columns[3].HeaderText = "Quant.";
            dtgCinco.Columns[3].Width = 40;
            dtgCinco.Columns[5].Width = 50;
        }
    }
}
