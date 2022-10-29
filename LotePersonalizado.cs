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
    public partial class LotePersonalizado : Form
    {
        private static LotePersonalizado instance;
        public LotePersonalizado()
        {
            InitializeComponent();
        }

        public static LotePersonalizado GetInstance()
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new LotePersonalizado();
            }
            return instance;
        }

        public void ConfigLotePers()
        {
            dtgVencPers.Columns[1].Visible = false;
            dtgVencPers.AllowUserToAddRows = false;
            dtgVencPers.Columns[0].Width = 30;
            dtgVencPers.Columns[2].Width = 80;
            dtgVencPers.Columns[3].HeaderText = "Quant.";
            dtgVencPers.Columns[3].Width = 40;
            dtgVencPers.Columns[5].Width = 50;
        }

        private void dtpVenc2_ValueChanged(object sender, EventArgs e)
        {
            dtgVencPers.DataSource = BDSimulado.VencPers(dtpVenc1.Value, dtpVenc2.Value);

            ConfigLotePers();
        }
    }
}