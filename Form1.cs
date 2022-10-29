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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuSobre_Click(object sender, EventArgs e)
        {
            SobreMim s = SobreMim.GetInstance();
            s.MdiParent = this;
            s.Show();
        }

        private void mnuLote_Click(object sender, EventArgs e)
        {
            NovoLote n = NovoLote.GetInstance();
            n.MdiParent = this;
            n.Show();
        }

        private void mnuTodos_Click(object sender, EventArgs e)
        {
            TodosLotes t = TodosLotes.GetInstance();
            t.MdiParent = this;
            t.Show();
        }

        private void mnuUmDia_Click(object sender, EventArgs e)
        {
            LotesUmDia l = LotesUmDia.GetInstance();
            l.MdiParent = this;
            l.Show();
        }

        private void mnuCincoDias_Click(object sender, EventArgs e)
        {
            LotesCincoDias l5 = LotesCincoDias.GetInstance();
            l5.MdiParent = this;
            l5.Show();
        }

        private void mnuPersonalizado_Click(object sender, EventArgs e)
        {
            LotePersonalizado lp = LotePersonalizado.GetInstance();
            lp.MdiParent = this;
            lp.Show();
        }
    }
}
