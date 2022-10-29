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
    public partial class NovoLote : Form
    {
        private static NovoLote instance;
        public NovoLote()
        {
            InitializeComponent();

            lstProdutos.DataSource = null;
        }

        public static NovoLote GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new NovoLote();
            }
            return instance;
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                lstProdutos.DataSource = BDSimulado.LocalizarNome(txtNome.Text);
            }
            catch
            {
                lstProdutos.DataSource = null;
            }
        }

        private void txtCod_KeyUp(object sender, KeyEventArgs e)
        {
            List<Produto> produtos = new List<Produto>();
            try
            {
                produtos.Add(BDSimulado.LocalizarCod(Convert.ToInt64(txtCod.Text)));
                lstProdutos.DataSource = produtos;
            }
            catch
            {
                produtos.Clear();
                lstProdutos.DataSource = null;
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if(lstProdutos.SelectedIndex > -1)
            {
                Compra c = new Compra(dtpCompra.Value.Date, dtpVenc.Value.Date, Convert.ToInt16(numQuant.Value), (Produto)lstProdutos.SelectedItem);

                lblTeste.Text = Convert.ToString(c);
                BDSimulado.Lotes.Add(c);
            }
        }
    }
}