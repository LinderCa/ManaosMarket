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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public void ActivarMenuPrivadoPrincipal(bool estado)
        {
            if (estado == true)
            {
                this.menuPrivado.Visible = true;
                this.menuPublico.Enabled = false;
            }
        }

        private void menuControlAsistencia_Click(object sender, EventArgs e)
        {
            FrmControlAsistencia ventana = new FrmControlAsistencia();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void MenuCancelarContrato_Click(object sender, EventArgs e)
        {
            FrmCancelarContrato ventana = new FrmCancelarContrato();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void menuImpresionBoleta_Click(object sender, EventArgs e)
        {
            FrmImpresionBoleta ventana = new FrmImpresionBoleta();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void menuGestionarEmpleado_Click(object sender, EventArgs e)
        {
            FrmGestionarEmpleado ventana = new FrmGestionarEmpleado();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void menuJustificarTardanzas_Click(object sender, EventArgs e)
        {
            FrmJustificarTardanza ventana = new FrmJustificarTardanza();
            ventana.MdiParent = this;
            ventana.Show();

        }

        private void menuJustificarPermisos_Click(object sender, EventArgs e)
        {
            FrmGestionarPermisos ventana = new FrmGestionarPermisos();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void menuVacaciones_Click(object sender, EventArgs e)
        {
            FrmGestionarVacaciones ventana = new FrmGestionarVacaciones();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void menuGestionarContrato_Click(object sender, EventArgs e)
        {
            FrmGestionamientoContrato ventana = new FrmGestionamientoContrato();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void menuSesion_Click(object sender, EventArgs e)
        {
            frmIniciarSesion ventana = new frmIniciarSesion();
            ventana.MdiParent = this;
            ventana.Show();

           
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.menuPrivado.Visible = false;
        }

        private void menuAsistencia_Click(object sender, EventArgs e)
        {
            FrmControlAsistencia ventana = new FrmControlAsistencia();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void menuSesionAdministracion_Click(object sender, EventArgs e)
        {
            frmIniciarSesionAdministrador ventana = new frmIniciarSesionAdministrador();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void menuCerrar_Click(object sender, EventArgs e)
        {
            this.menuPublico.Enabled = true;
            this.menuPrivado.Visible = false;
        }
    }
}
