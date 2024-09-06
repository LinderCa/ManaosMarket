using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManaosMarket
{
    public partial class FrmJustificarTardanza : Form
    {
        public FrmJustificarTardanza()
        {
            InitializeComponent();
        }

        private void Fecha_Tick(object sender, EventArgs e)
        {
            lblFecha2.Text = DateTime.Now.ToString("dddd MMMM yyyy");
        }

        private void BtnCerrrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
