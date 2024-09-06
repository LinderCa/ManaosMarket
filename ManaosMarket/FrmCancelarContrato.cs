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
    public partial class FrmCancelarContrato : Form
    {
        public FrmCancelarContrato()
        {
            InitializeComponent();
        }

        private void FechaContrato_Tick(object sender, EventArgs e)
        {
            lblFechaContrato.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
