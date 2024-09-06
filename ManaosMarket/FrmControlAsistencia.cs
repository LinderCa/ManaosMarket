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
    public partial class FrmControlAsistencia : Form
    {
        public FrmControlAsistencia()
        {
            InitializeComponent();
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            LblFecha.Text = DateTime.Now.ToString("dddd MMMM yyyy");
        }

        private void horaFecha2_Tick(object sender, EventArgs e)
        {
            lblHora1.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha2.Text = DateTime.Now.ToString("dddd MMMM yyyy");
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lblFecha2_Click(object sender, EventArgs e)
        {

        }
    }
}
