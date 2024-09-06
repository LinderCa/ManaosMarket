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
    public partial class FrmCodigoGenerado : Form
    {
        public FrmCodigoGenerado()
        {
            InitializeComponent();
        }

        internal void MostrarCodigo(string codigo)
        {
            this.txtCodigo.Texts = codigo;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
