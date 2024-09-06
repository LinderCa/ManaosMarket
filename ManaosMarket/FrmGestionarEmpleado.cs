using CapaDatos;
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

namespace ManaosMarket
{
    public partial class FrmGestionarEmpleado : Form
    {
        private clsEmpleado Actual = null;

        private clsCarnet Referencia = null;

        public clsEmpleado ActualBaja = null;

        public FrmGestionarEmpleado()
        {
            InitializeComponent();
        }

        private void FrmGestionarEmpleado_Load(object sender, EventArgs e)
        {
            //Funcion para Listar los Empleados en el DataGriew
           this.ListarEmpleados();

            //NECESITAMOS CARGAR LAS AREAS EN EL COMBO BOX
            this.ListarAreasVigentes();
            this.ListarAreasCmbVigentes();
            this.ListarEncargaturasVigentes();
        }

        private void ListarEncargaturasVigentes()
        {
            RNEncargatura rn = new RNEncargatura();
            List<clsEncargatura> encargaturas = rn.ListarVigentes();
            try
            {
                this.cmbEncargatura.DataSource = null;
                if(encargaturas!= null && encargaturas.Count > 0)
                {
                    this.cmbEncargatura.ValueMember = "Codigo";
                    this.cmbEncargatura.DisplayMember = "Nombre";
                    this.cmbEncargatura.DataSource = encargaturas;
                }
                else
                {
                    MessageBox.Show("No se pudo listar las Encargaturas");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("No se pudo realizar la Operacion");
            }
        }

        private void ListarAreasCmbVigentes()
        {
            RNArea rnArea = new RNArea();
            List<clsArea> areas = rnArea.ListarAreasVigentes();
            try
            {
                this.cmbAreaEmpleado.DataSource = null;
                if (areas != null && areas.Count > 0)
                {
                    this.cmbAreaEmpleado.ValueMember = "Codigo";
                    this.cmbAreaEmpleado.DisplayMember = "Nombre";
                    this.cmbAreaEmpleado.DataSource = areas;
                }
                else
                {
                    MessageBox.Show("No se pudo listar las Areas");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede realizar la operacion", "ERROR");
            }
        }

        private void ListarEmpleados()
        {
            RNEmpleado rnEmpleado = new RNEmpleado();
            List<clsEmpleado> empleados = rnEmpleado.Listar();
            try
            {
                this.DgvLstEmpleados.DataSource = null;
                if(empleados!=null && empleados.Count > 0)
                {
                    this.DgvLstEmpleados.AutoGenerateColumns = false;
                    this.DgvLstEmpleados.DataSource = empleados;
                }

            }catch(Exception ex)
            {
                MessageBox.Show("No se puede realizar la operacion");
            }
        }

        private void ListarAreasVigentes()
        {
            RNArea rnArea = new RNArea();
            List<clsArea> areas = rnArea.ListarAreasVigentes();
            try
            {
                this.cmbArea.DataSource = null;
                if (areas!=null && areas.Count > 0)
                {
                    this.cmbArea.ValueMember = "Codigo";
                    this.cmbArea.DisplayMember = "Nombre";
                    this.cmbArea.DataSource = areas;
                }
                else
                {
                    MessageBox.Show("No se pudo listar las areas");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("No se puede realizar la operacion","ERROR");
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ActivarControles(true);
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
            this.LimpiarControles();
        }

        private void LimpiarControles()
        {
            this.txtCodigo.Texts = "";
            this.txtNombres.Texts = "";
            this.txtApellPaterno.Texts = "";
            this.txtApellMaterno.Texts = "";
            this.cmbArea.SelectedIndex = -1;
            this.txtDNI.Texts = "";
            this.cmbGenero.SelectedIndex = -1;
            this.txtTelefono.Texts = "";
            this.txtDireccion.Texts = "";
            this.txtDireccion.Texts="";
            this.txtCorreo.Texts = "";
            this.cmbEncargatura.SelectedIndex = -1;
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            //GENERAMOS UN CODIGO
            string Codigo = this.GenerarCodigo();
            FrmCodigoGenerado ventana = new FrmCodigoGenerado();
            ventana.Show();
            ventana.MostrarCodigo(Codigo);
            this.txtCodigoEmpleado.Texts = Codigo;
        }

        private string GenerarCodigo()
        {
            string Codigo = "";
            int numero;
            int nl1;
            int nl2;
            char l1;
            char l2;
            Random rnd = new Random();
            numero = rnd.Next(0, 999);
            nl1 = rnd.Next(65, 91);
            nl2 = rnd.Next(65, 91);

            //Converciones
            l1 = Convert.ToChar(nl1);
            l2 = Convert.ToChar(nl2);

            Codigo = l1 + (numero + "") + l2;
            return Codigo;
        }

        private void btnCarnet_Click(object sender, EventArgs e)
        {
            FrmGenerarCarnet ventana = new FrmGenerarCarnet();
            string nombresCompletos="";
            nombresCompletos = this.txtNombres.Texts + " " + this.txtApellPaterno.Texts + " " + this.txtApellMaterno.Texts;

            if (nombresCompletos.Length > 5)
            {
                Referencia=ventana.Agregar(nombresCompletos);
            }
            else
            {
                MessageBox.Show("Tiene que completar los datos del Empleado");
            }
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RNEmpleado rn = null;
            clsEmpleado empleado = null;

            if (this.ValidateChildren() == true)
            {
                try
                {
                    empleado = this.CrearEntidad();
                    rn = new RNEmpleado();
                    if (Actual == null)
                    {
                        //Se trata de registrar un nuevo Empleado
                        rn.Registrar(empleado);
                    }
                    else
                    {
                        rn.Actualizar(empleado);
                    }
                    this.ActivarControles(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo realizar la operacion", this.Text);
                }
            }
        }

        private clsEmpleado CrearEntidad()
        {
            clsEmpleado empleado = new clsEmpleado()
            {
                Nombres = this.txtNombres.Texts,
                ApellPaterno = this.txtApellPaterno.Texts,
                ApellMaterno = this.txtApellMaterno.Texts,
                FechaNacimiento = this.dtpFechaNacimiento.Value,
                Correo = this.txtCorreo.Texts,
                Telefono = this.txtTelefono.Texts,
                Genero = this.cmbGenero.Texts.Substring(0, 1),
                DNI = this.txtDNI.Texts,
                Direccion = this.txtDireccion.Texts,
                Vigencia = this.chkVigencia.Checked,
                Codigo = this.txtCodigo.Texts,

                Area = (clsArea)this.cmbArea.SelectedItem,
                Encargatura = (clsEncargatura)this.cmbEncargatura.SelectedItem,
                Carnet = this.Referencia,
            };

            if (this.Actual != null)
            {
                empleado.CodigoSistema = this.Actual.CodigoSistema;
            }
            return empleado;
    }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RNEmpleado rn = new RNEmpleado();
            List<clsEmpleado> empleados = new List<clsEmpleado>();

            empleados = rn.ListarEmpleados(this.txtCodigo.Texts);

            try
            {
                this.DgvLstEmpleados.DataSource = null;
                if(empleados!= null && empleados.Count > 0)
                {
                    this.DgvLstEmpleados.AutoGenerateColumns = false;
                    this.DgvLstEmpleados.DataSource = empleados;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("No se pudo listar los Empleados");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.DgvLstEmpleados.CurrentRow != null)
            {
                this.Actual = (clsEmpleado)this.DgvLstEmpleados.CurrentRow.DataBoundItem;
                this.PresentarDatos();
                this.ActivarControles(true);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Empleado de la Lista");
            }
        }

        private void ActivarControles(bool v)
        {
            this.panel2.Enabled = !v;
            this.gbEmpleado.Enabled = v;
            this.gbEncargatura.Enabled =v;
            this.btnDarDeBaja.Enabled = !v;
            this.btnNuevo.Enabled = v;
            this.btnCodigo.Enabled = v;
            this.btnCarnet.Enabled = v;

        }

        private void PresentarDatos()
        {
            RNEmpleado rn = new RNEmpleado();
            try
            {
                this.Actual = rn.Leer(this.Actual.CodigoSistema);
                if (Actual != null)
                {
                    this.txtCodigoEmpleado.Texts = this.Actual.Codigo;
                    this.txtNombres.Texts = Actual.Nombres;
                    this.txtApellPaterno.Texts = Actual.ApellPaterno;
                    this.txtApellMaterno.Texts = Actual.ApellMaterno;
                    this.cmbAreaEmpleado.SelectedIndex = this.Actual.Area.Codigo;
                    this.txtDNI.Texts = Actual.DNI;
                    this.cmbGenero.SelectedIndex = "MF".IndexOf(this.Actual.Genero);
                    this.dtpFechaNacimiento.Value = this.Actual.FechaNacimiento;
                    this.txtTelefono.Texts = this.Actual.Telefono;
                    this.txtDireccion.Texts = this.Actual.Direccion;
                    this.txtCorreo.Texts = this.Actual.Correo;
                    this.chkVigencia.Checked = this.Actual.Vigencia;
                    this.cmbEncargatura.SelectedIndex = this.Actual.Encargatura.Codigo;

                }
                else
                {
                    MessageBox.Show("No se encontraron los datos solicitados");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("No se puede obtener los datos solicitados");
            }
        }

        private void btnDarDeBaja_Click(object sender, EventArgs e)
        {
            if (this.DgvLstEmpleados.CurrentRow != null)
            {
                this.ActualBaja = (clsEmpleado)this.DgvLstEmpleados.CurrentRow.DataBoundItem;
                this.DarDeBajar(ActualBaja);
                MessageBox.Show("EMPLEADO DADO DE BAJA",this.Text);
            }
            else
            {
                MessageBox.Show("Debe selecionar un Empleado para daro de baja", this.Text);
            }
        }

        private void DarDeBajar(clsEmpleado empleado)
        {
            RNEmpleado rn = new RNEmpleado();
            rn.DarDeBaja(empleado);
        }
    }
}
