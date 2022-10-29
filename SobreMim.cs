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
    public partial class SobreMim : Form
    {
        private static SobreMim instance;
        public SobreMim()
        {
            InitializeComponent();
        }

        public static SobreMim GetInstance()
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new SobreMim();
            }
            return instance;
        }

        private void lnkGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/thevsma");
        }
    }
}
