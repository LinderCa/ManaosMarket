using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace ManaosMarket
{
    public partial class frmIniciarSesionAdministrador : Form
    {
        //Instanciamos un usuario
        //clsUsuario usuario = new clsUsuario();

        public static FrmPrincipal principal;

        public frmIniciarSesionAdministrador()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RNUsuario rn = new RNUsuario();
            Program.sesionAdministrador = rn.Verificar(this.txtUsuario.Texts, this.txtContraseña.Texts);
            if(Program.sesionAdministrador==true)
            {
                //Ingreso al Sistema
                MessageBox.Show("BIENVENIDO AL SISTEMA","MENSAJE",MessageBoxButtons.OK);
                this.Close();
                Program.ActivarMenuPrivado();
                
            }
            else
            {
                MessageBox.Show("DATOS INCORRECTOS!!","MENSAJE",MessageBoxButtons.OK);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
