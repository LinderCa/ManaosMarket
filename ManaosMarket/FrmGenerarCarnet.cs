using CapaDatos;
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
    public partial class FrmGenerarCarnet : Form
    {
        public FrmGenerarCarnet()
        {
            InitializeComponent();
        }

        public void PresentarDatos(string nombresCompletos)
        {
            this.lblNombre.Text = nombresCompletos;
        }

        public clsCarnet Agregar(string nombresCompletos)
        {
            this.PresentarDatos(nombresCompletos);
            this.ShowDialog();
            RNCarnet rn = new RNCarnet();
            clsCarnet nuevo=this.CrearEntidad(nombresCompletos);
            rn.Registrar(nuevo);

            return nuevo;
        }

        public clsCarnet CrearEntidad(string nombres)
        {
            clsCarnet nuevo = new clsCarnet()
            {
                Codigo = 8,
                FechaEntrega = this.dtpFechaCarnet.Value,
                Vigente = true,
             };

            return nuevo;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
