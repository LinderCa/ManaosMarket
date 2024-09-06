namespace ManaosMarket
{
    partial class FrmGestionarEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarEmpleado));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.DgvLstEmpleados = new System.Windows.Forms.DataGridView();
            this.CdNombresCompletos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdEncargatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdVigente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbEmpleado = new System.Windows.Forms.GroupBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.chkVigencia = new System.Windows.Forms.CheckBox();
            this.lblAreaEmpleado = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblApellPaterno = new System.Windows.Forms.Label();
            this.lblApellMaterno = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblCodigoEmpleado = new System.Windows.Forms.Label();
            this.gbEncargatura = new System.Windows.Forms.GroupBox();
            this.dtpFechaFinEncar = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicioEncar = new System.Windows.Forms.DateTimePicker();
            this.lblNombreEncargatura = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.FECHA = new System.Windows.Forms.Timer(this.components);
            this.btnCodigo = new ManaosMarket.RadioButon();
            this.btnDarDeBaja = new ManaosMarket.RadioButon();
            this.btnCarnet = new ManaosMarket.RadioButon();
            this.btnCancelar = new ManaosMarket.RadioButon();
            this.btnAceptar = new ManaosMarket.RadioButon();
            this.cmbEncargatura = new ManaosMarket.RJComboBox();
            this.cmbArea = new ManaosMarket.RJComboBox();
            this.btnBuscar = new ManaosMarket.RadioButon();
            this.btnModificar = new ManaosMarket.RadioButon();
            this.btnNuevo = new ManaosMarket.RadioButon();
            this.txtCodigo = new ManaosMarket.RJTexBox();
            this.cmbAreaEmpleado = new ManaosMarket.RJComboBox();
            this.cmbGenero = new ManaosMarket.RJComboBox();
            this.txtCorreo = new ManaosMarket.RJTexBox();
            this.txtDireccion = new ManaosMarket.RJTexBox();
            this.txtTelefono = new ManaosMarket.RJTexBox();
            this.txtDNI = new ManaosMarket.RJTexBox();
            this.txtApellMaterno = new ManaosMarket.RJTexBox();
            this.txtApellPaterno = new ManaosMarket.RJTexBox();
            this.txtNombres = new ManaosMarket.RJTexBox();
            this.txtCodigoEmpleado = new ManaosMarket.RJTexBox();
            this.BtnCerrar = new ManaosMarket.RadioButon();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLstEmpleados)).BeginInit();
            this.gbEmpleado.SuspendLayout();
            this.gbEncargatura.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(905, 51);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(61, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATOS EMPLEADO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ManaosMarket.Properties.Resources.logoMAnaosDefecto;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.cmbArea);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.lblArea);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Controls.Add(this.lblCodigo);
            this.panel2.Controls.Add(this.DgvLstEmpleados);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(433, 589);
            this.panel2.TabIndex = 0;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblArea.Location = new System.Drawing.Point(43, 52);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(54, 25);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Area";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblCodigo.Location = new System.Drawing.Point(22, 13);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(75, 25);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // DgvLstEmpleados
            // 
            this.DgvLstEmpleados.AllowUserToAddRows = false;
            this.DgvLstEmpleados.AllowUserToDeleteRows = false;
            this.DgvLstEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLstEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CdNombresCompletos,
            this.CdEncargatura,
            this.CdVigente});
            this.DgvLstEmpleados.Location = new System.Drawing.Point(12, 91);
            this.DgvLstEmpleados.MultiSelect = false;
            this.DgvLstEmpleados.Name = "DgvLstEmpleados";
            this.DgvLstEmpleados.ReadOnly = true;
            this.DgvLstEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLstEmpleados.Size = new System.Drawing.Size(405, 446);
            this.DgvLstEmpleados.TabIndex = 5;
            // 
            // CdNombresCompletos
            // 
            this.CdNombresCompletos.DataPropertyName = "NombresCompletos";
            this.CdNombresCompletos.HeaderText = "Nombres Completos";
            this.CdNombresCompletos.Name = "CdNombresCompletos";
            this.CdNombresCompletos.ReadOnly = true;
            this.CdNombresCompletos.Width = 160;
            // 
            // CdEncargatura
            // 
            this.CdEncargatura.DataPropertyName = "NombreEncargatura";
            this.CdEncargatura.HeaderText = "Encargatura";
            this.CdEncargatura.Name = "CdEncargatura";
            this.CdEncargatura.ReadOnly = true;
            // 
            // CdVigente
            // 
            this.CdVigente.DataPropertyName = "Vigencia";
            this.CdVigente.HeaderText = "Vigencia";
            this.CdVigente.Name = "CdVigente";
            this.CdVigente.ReadOnly = true;
            this.CdVigente.Width = 70;
            // 
            // gbEmpleado
            // 
            this.gbEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.gbEmpleado.Controls.Add(this.dtpFechaNacimiento);
            this.gbEmpleado.Controls.Add(this.cmbAreaEmpleado);
            this.gbEmpleado.Controls.Add(this.cmbGenero);
            this.gbEmpleado.Controls.Add(this.chkVigencia);
            this.gbEmpleado.Controls.Add(this.lblAreaEmpleado);
            this.gbEmpleado.Controls.Add(this.txtCorreo);
            this.gbEmpleado.Controls.Add(this.txtDireccion);
            this.gbEmpleado.Controls.Add(this.txtTelefono);
            this.gbEmpleado.Controls.Add(this.txtDNI);
            this.gbEmpleado.Controls.Add(this.txtApellMaterno);
            this.gbEmpleado.Controls.Add(this.txtApellPaterno);
            this.gbEmpleado.Controls.Add(this.txtNombres);
            this.gbEmpleado.Controls.Add(this.txtCodigoEmpleado);
            this.gbEmpleado.Controls.Add(this.lblCorreo);
            this.gbEmpleado.Controls.Add(this.lblDireccion);
            this.gbEmpleado.Controls.Add(this.lblTelefono);
            this.gbEmpleado.Controls.Add(this.lblFechaNacimiento);
            this.gbEmpleado.Controls.Add(this.lblGenero);
            this.gbEmpleado.Controls.Add(this.lblDNI);
            this.gbEmpleado.Controls.Add(this.lblApellPaterno);
            this.gbEmpleado.Controls.Add(this.lblApellMaterno);
            this.gbEmpleado.Controls.Add(this.lblNombres);
            this.gbEmpleado.Controls.Add(this.lblCodigoEmpleado);
            this.gbEmpleado.Enabled = false;
            this.gbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmpleado.ForeColor = System.Drawing.Color.Gray;
            this.gbEmpleado.Location = new System.Drawing.Point(436, 6);
            this.gbEmpleado.Name = "gbEmpleado";
            this.gbEmpleado.Size = new System.Drawing.Size(461, 476);
            this.gbEmpleado.TabIndex = 1;
            this.gbEmpleado.TabStop = false;
            this.gbEmpleado.Text = "Empleado";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "";
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(198, 293);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(234, 26);
            this.dtpFechaNacimiento.TabIndex = 23;
            this.dtpFechaNacimiento.Value = new System.DateTime(2023, 2, 21, 0, 0, 0, 0);
            // 
            // chkVigencia
            // 
            this.chkVigencia.AutoSize = true;
            this.chkVigencia.Location = new System.Drawing.Point(198, 443);
            this.chkVigencia.Name = "chkVigencia";
            this.chkVigencia.Size = new System.Drawing.Size(97, 24);
            this.chkVigencia.TabIndex = 22;
            this.chkVigencia.Text = "Vigencia";
            this.chkVigencia.UseVisualStyleBackColor = true;
            // 
            // lblAreaEmpleado
            // 
            this.lblAreaEmpleado.AutoSize = true;
            this.lblAreaEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaEmpleado.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblAreaEmpleado.Location = new System.Drawing.Point(132, 171);
            this.lblAreaEmpleado.Name = "lblAreaEmpleado";
            this.lblAreaEmpleado.Size = new System.Drawing.Size(54, 25);
            this.lblAreaEmpleado.TabIndex = 8;
            this.lblAreaEmpleado.Text = "Area";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblCorreo.Location = new System.Drawing.Point(114, 414);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(72, 25);
            this.lblCorreo.TabIndex = 20;
            this.lblCorreo.Text = "Correo";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblDireccion.Location = new System.Drawing.Point(93, 375);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(93, 25);
            this.lblDireccion.TabIndex = 18;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblTelefono.Location = new System.Drawing.Point(97, 336);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(89, 25);
            this.lblTelefono.TabIndex = 16;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(17, 297);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(169, 25);
            this.lblFechaNacimiento.TabIndex = 14;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblGenero.Location = new System.Drawing.Point(109, 254);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(77, 25);
            this.lblGenero.TabIndex = 12;
            this.lblGenero.Text = "Genero";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblDNI.Location = new System.Drawing.Point(141, 213);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(45, 25);
            this.lblDNI.TabIndex = 10;
            this.lblDNI.Text = "DNI";
            // 
            // lblApellPaterno
            // 
            this.lblApellPaterno.AutoSize = true;
            this.lblApellPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellPaterno.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblApellPaterno.Location = new System.Drawing.Point(31, 90);
            this.lblApellPaterno.Name = "lblApellPaterno";
            this.lblApellPaterno.Size = new System.Drawing.Size(155, 25);
            this.lblApellPaterno.TabIndex = 4;
            this.lblApellPaterno.Text = "Apellido Paterno";
            // 
            // lblApellMaterno
            // 
            this.lblApellMaterno.AutoSize = true;
            this.lblApellMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellMaterno.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblApellMaterno.Location = new System.Drawing.Point(27, 129);
            this.lblApellMaterno.Name = "lblApellMaterno";
            this.lblApellMaterno.Size = new System.Drawing.Size(159, 25);
            this.lblApellMaterno.TabIndex = 6;
            this.lblApellMaterno.Text = "Apellido Materno";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblNombres.Location = new System.Drawing.Point(95, 52);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(91, 25);
            this.lblNombres.TabIndex = 2;
            this.lblNombres.Text = "Nombres";
            // 
            // lblCodigoEmpleado
            // 
            this.lblCodigoEmpleado.AutoSize = true;
            this.lblCodigoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEmpleado.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblCodigoEmpleado.Location = new System.Drawing.Point(111, 18);
            this.lblCodigoEmpleado.Name = "lblCodigoEmpleado";
            this.lblCodigoEmpleado.Size = new System.Drawing.Size(75, 25);
            this.lblCodigoEmpleado.TabIndex = 0;
            this.lblCodigoEmpleado.Text = "Codigo";
            // 
            // gbEncargatura
            // 
            this.gbEncargatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.gbEncargatura.Controls.Add(this.dtpFechaFinEncar);
            this.gbEncargatura.Controls.Add(this.dtpFechaInicioEncar);
            this.gbEncargatura.Controls.Add(this.cmbEncargatura);
            this.gbEncargatura.Controls.Add(this.lblNombreEncargatura);
            this.gbEncargatura.Controls.Add(this.lblFechaFin);
            this.gbEncargatura.Controls.Add(this.lblFechaInicio);
            this.gbEncargatura.Enabled = false;
            this.gbEncargatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEncargatura.ForeColor = System.Drawing.Color.Gray;
            this.gbEncargatura.Location = new System.Drawing.Point(439, 488);
            this.gbEncargatura.Name = "gbEncargatura";
            this.gbEncargatura.Size = new System.Drawing.Size(458, 146);
            this.gbEncargatura.TabIndex = 2;
            this.gbEncargatura.TabStop = false;
            this.gbEncargatura.Text = "Encargatura";
            // 
            // dtpFechaFinEncar
            // 
            this.dtpFechaFinEncar.CustomFormat = "";
            this.dtpFechaFinEncar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinEncar.Location = new System.Drawing.Point(195, 100);
            this.dtpFechaFinEncar.Name = "dtpFechaFinEncar";
            this.dtpFechaFinEncar.Size = new System.Drawing.Size(234, 26);
            this.dtpFechaFinEncar.TabIndex = 25;
            this.dtpFechaFinEncar.Value = new System.DateTime(2023, 2, 21, 0, 0, 0, 0);
            // 
            // dtpFechaInicioEncar
            // 
            this.dtpFechaInicioEncar.CustomFormat = "";
            this.dtpFechaInicioEncar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicioEncar.Location = new System.Drawing.Point(195, 62);
            this.dtpFechaInicioEncar.MaxDate = new System.DateTime(9997, 11, 19, 0, 0, 0, 0);
            this.dtpFechaInicioEncar.Name = "dtpFechaInicioEncar";
            this.dtpFechaInicioEncar.Size = new System.Drawing.Size(234, 26);
            this.dtpFechaInicioEncar.TabIndex = 24;
            this.dtpFechaInicioEncar.Value = new System.DateTime(2023, 2, 21, 0, 0, 0, 0);
            // 
            // lblNombreEncargatura
            // 
            this.lblNombreEncargatura.AutoSize = true;
            this.lblNombreEncargatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEncargatura.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblNombreEncargatura.Location = new System.Drawing.Point(102, 24);
            this.lblNombreEncargatura.Name = "lblNombreEncargatura";
            this.lblNombreEncargatura.Size = new System.Drawing.Size(81, 25);
            this.lblNombreEncargatura.TabIndex = 0;
            this.lblNombreEncargatura.Text = "Nombre";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblFechaFin.Location = new System.Drawing.Point(84, 101);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(99, 25);
            this.lblFechaFin.TabIndex = 4;
            this.lblFechaFin.Text = "Fecha Fin";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblFechaInicio.Location = new System.Drawing.Point(66, 62);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(117, 25);
            this.lblFechaInicio.TabIndex = 2;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnCodigo);
            this.panel6.Controls.Add(this.btnDarDeBaja);
            this.panel6.Controls.Add(this.btnCarnet);
            this.panel6.Controls.Add(this.btnCancelar);
            this.panel6.Controls.Add(this.btnAceptar);
            this.panel6.Controls.Add(this.gbEncargatura);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.gbEmpleado);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 51);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(905, 683);
            this.panel6.TabIndex = 2;
            // 
            // btnCodigo
            // 
            this.btnCodigo.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCodigo.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.btnCodigo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCodigo.BorderRadius = 40;
            this.btnCodigo.BorderSize = 0;
            this.btnCodigo.Enabled = false;
            this.btnCodigo.FlatAppearance.BorderSize = 0;
            this.btnCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnCodigo.Image = ((System.Drawing.Image)(resources.GetObject("btnCodigo.Image")));
            this.btnCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCodigo.Location = new System.Drawing.Point(152, 631);
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Size = new System.Drawing.Size(129, 40);
            this.btnCodigo.TabIndex = 4;
            this.btnCodigo.Text = "  CODIGO";
            this.btnCodigo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnCodigo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCodigo.UseVisualStyleBackColor = false;
            this.btnCodigo.Click += new System.EventHandler(this.btnCodigo_Click);
            // 
            // btnDarDeBaja
            // 
            this.btnDarDeBaja.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDarDeBaja.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.btnDarDeBaja.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDarDeBaja.BorderRadius = 40;
            this.btnDarDeBaja.BorderSize = 0;
            this.btnDarDeBaja.Enabled = false;
            this.btnDarDeBaja.FlatAppearance.BorderSize = 0;
            this.btnDarDeBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarDeBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarDeBaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnDarDeBaja.Image = ((System.Drawing.Image)(resources.GetObject("btnDarDeBaja.Image")));
            this.btnDarDeBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDarDeBaja.Location = new System.Drawing.Point(14, 631);
            this.btnDarDeBaja.Name = "btnDarDeBaja";
            this.btnDarDeBaja.Size = new System.Drawing.Size(129, 40);
            this.btnDarDeBaja.TabIndex = 5;
            this.btnDarDeBaja.Text = "  DAR DE BAJA";
            this.btnDarDeBaja.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnDarDeBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDarDeBaja.UseVisualStyleBackColor = false;
            this.btnDarDeBaja.Click += new System.EventHandler(this.btnDarDeBaja_Click);
            // 
            // btnCarnet
            // 
            this.btnCarnet.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCarnet.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.btnCarnet.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCarnet.BorderRadius = 40;
            this.btnCarnet.BorderSize = 0;
            this.btnCarnet.Enabled = false;
            this.btnCarnet.FlatAppearance.BorderSize = 0;
            this.btnCarnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarnet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnCarnet.Image = ((System.Drawing.Image)(resources.GetObject("btnCarnet.Image")));
            this.btnCarnet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarnet.Location = new System.Drawing.Point(289, 631);
            this.btnCarnet.Name = "btnCarnet";
            this.btnCarnet.Size = new System.Drawing.Size(129, 40);
            this.btnCarnet.TabIndex = 3;
            this.btnCarnet.Text = "   CARNET";
            this.btnCarnet.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnCarnet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCarnet.UseVisualStyleBackColor = false;
            this.btnCarnet.Click += new System.EventHandler(this.btnCarnet_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnCancelar.BorderRadius = 40;
            this.btnCancelar.BorderSize = 2;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(671, 636);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 39);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAceptar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnAceptar.BorderRadius = 40;
            this.btnAceptar.BorderSize = 2;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnAceptar.Image = global::ManaosMarket.Properties.Resources.ACEPTAR9;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(789, 636);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(108, 39);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cmbEncargatura
            // 
            this.cmbEncargatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cmbEncargatura.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.cmbEncargatura.BorderSize = 2;
            this.cmbEncargatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncargatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEncargatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(106)))), ((int)(((byte)(203)))));
            this.cmbEncargatura.IconColor = System.Drawing.Color.Crimson;
            this.cmbEncargatura.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.cmbEncargatura.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.cmbEncargatura.Location = new System.Drawing.Point(195, 24);
            this.cmbEncargatura.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbEncargatura.Name = "cmbEncargatura";
            this.cmbEncargatura.Padding = new System.Windows.Forms.Padding(2);
            this.cmbEncargatura.Size = new System.Drawing.Size(234, 30);
            this.cmbEncargatura.TabIndex = 1;
            this.cmbEncargatura.Texts = "";
            // 
            // cmbArea
            // 
            this.cmbArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmbArea.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.cmbArea.BorderSize = 2;
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(106)))), ((int)(((byte)(203)))));
            this.cmbArea.IconColor = System.Drawing.Color.Crimson;
            this.cmbArea.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.cmbArea.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.cmbArea.Location = new System.Drawing.Point(104, 51);
            this.cmbArea.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Padding = new System.Windows.Forms.Padding(2);
            this.cmbArea.Size = new System.Drawing.Size(312, 30);
            this.cmbArea.TabIndex = 3;
            this.cmbArea.Texts = "";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnBuscar.BorderRadius = 40;
            this.btnBuscar.BorderSize = 2;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnBuscar.Image = global::ManaosMarket.Properties.Resources.BUSCAR5;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(308, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 39);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "LISTAR";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnModificar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnModificar.BorderRadius = 40;
            this.btnModificar.BorderSize = 2;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(151, 543);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(130, 39);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnNuevo.BorderRadius = 40;
            this.btnNuevo.BorderSize = 2;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(287, 543);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(130, 39);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.txtCodigo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCodigo.BorderRadius = 1;
            this.txtCodigo.BorderSize = 2;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(106)))), ((int)(((byte)(203)))));
            this.txtCodigo.Location = new System.Drawing.Point(104, 12);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodigo.PasswordChar = false;
            this.txtCodigo.PlaceholderColor = System.Drawing.Color.Teal;
            this.txtCodigo.PlaceholderText = "";
            this.txtCodigo.Size = new System.Drawing.Size(163, 31);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Texts = "";
            this.txtCodigo.UnderlinedStyle = false;
            // 
            // cmbAreaEmpleado
            // 
            this.cmbAreaEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cmbAreaEmpleado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.cmbAreaEmpleado.BorderSize = 2;
            this.cmbAreaEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAreaEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAreaEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(106)))), ((int)(((byte)(203)))));
            this.cmbAreaEmpleado.IconColor = System.Drawing.Color.Crimson;
            this.cmbAreaEmpleado.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.cmbAreaEmpleado.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.cmbAreaEmpleado.Location = new System.Drawing.Point(198, 173);
            this.cmbAreaEmpleado.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbAreaEmpleado.Name = "cmbAreaEmpleado";
            this.cmbAreaEmpleado.Padding = new System.Windows.Forms.Padding(2);
            this.cmbAreaEmpleado.Size = new System.Drawing.Size(234, 30);
            this.cmbAreaEmpleado.TabIndex = 9;
            this.cmbAreaEmpleado.Texts = "";
            // 
            // cmbGenero
            // 
            this.cmbGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cmbGenero.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.cmbGenero.BorderSize = 2;
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(106)))), ((int)(((byte)(203)))));
            this.cmbGenero.IconColor = System.Drawing.Color.Crimson;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGenero.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.cmbGenero.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.cmbGenero.Location = new System.Drawing.Point(198, 250);
            this.cmbGenero.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Padding = new System.Windows.Forms.Padding(2);
            this.cmbGenero.Size = new System.Drawing.Size(234, 30);
            this.cmbGenero.TabIndex = 13;
            this.cmbGenero.Texts = "";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtCorreo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.txtCorreo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCorreo.BorderRadius = 8;
            this.txtCorreo.BorderSize = 1;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(106)))), ((int)(((byte)(203)))));
            this.txtCorreo.Location = new System.Drawing.Point(198, 405);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Multiline = false;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Padding = new System.Windows.Forms.Padding(7);
            this.txtCorreo.PasswordChar = false;
            this.txtCorreo.PlaceholderColor = System.Drawing.Color.Teal;
            this.txtCorreo.PlaceholderText = "";
            this.txtCorreo.Size = new System.Drawing.Size(234, 31);
            this.txtCorreo.TabIndex = 21;
            this.txtCorreo.Texts = "";
            this.txtCorreo.UnderlinedStyle = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtDireccion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.txtDireccion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDireccion.BorderRadius = 8;
            this.txtDireccion.BorderSize = 1;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(106)))), ((int)(((byte)(203)))));
            this.txtDireccion.Location = new System.Drawing.Point(198, 366);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Padding = new System.Windows.Forms.Padding(7);
            this.txtDireccion.PasswordChar = false;
            this.txtDireccion.PlaceholderColor = System.Drawing.Color.Teal;
            this.txtDireccion.PlaceholderText = "";
            this.txtDireccion.Size = new System.Drawing.Size(234, 31);
            this.txtDireccion.TabIndex = 19;
            this.txtDireccion.Texts = "";
            this.txtDireccion.UnderlinedStyle = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtTelefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.txtTelefono.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTelefono.BorderRadius = 8;
            this.txtTelefono.BorderSize = 1;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(106)))), ((int)(((byte)(203)))));
            this.txtTelefono.Location = new System.Drawing.Point(198, 327);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(7);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.PlaceholderColor = System.Drawing.Color.Teal;
            this.txtTelefono.PlaceholderText = "";
            this.txtTelefono.Size = new System.Drawing.Size(234, 31);
            this.txtTelefono.TabIndex = 17;
            this.txtTelefono.Texts = "";
            this.txtTelefono.UnderlinedStyle = false;
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtDNI.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.txtDNI.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDNI.BorderRadius = 8;
            this.txtDNI.BorderSize = 1;
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(106)))), ((int)(((byte)(203)))));
            this.txtDNI.Location = new System.Drawing.Point(198, 210);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNI.Multiline = false;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Padding = new System.Windows.Forms.Padding(7);
            this.txtDNI.PasswordChar = false;
            this.txtDNI.PlaceholderColor = System.Drawing.Color.Teal;
            this.txtDNI.PlaceholderText = "";
            this.txtDNI.Size = new System.Drawing.Size(142, 31);
            this.txtDNI.TabIndex = 11;
            this.txtDNI.Texts = "";
            this.txtDNI.UnderlinedStyle = false;
            // 
            // txtApellMaterno
            // 
            this.txtApellMaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtApellMaterno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.txtApellMaterno.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtApellMaterno.BorderRadius = 8;
            this.txtApellMaterno.BorderSize = 1;
            this.txtApellMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellMaterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(106)))), ((int)(((byte)(203)))));
            this.txtApellMaterno.Location = new System.Drawing.Point(198, 132);
            this.txtApellMaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellMaterno.Multiline = false;
            this.txtApellMaterno.Name = "txtApellMaterno";
            this.txtApellMaterno.Padding = new System.Windows.Forms.Padding(7);
            this.txtApellMaterno.PasswordChar = false;
            this.txtApellMaterno.PlaceholderColor = System.Drawing.Color.Teal;
            this.txtApellMaterno.PlaceholderText = "";
            this.txtApellMaterno.Size = new System.Drawing.Size(234, 31);
            this.txtApellMaterno.TabIndex = 7;
            this.txtApellMaterno.Texts = "";
            this.txtApellMaterno.UnderlinedStyle = false;
            // 
            // txtApellPaterno
            // 
            this.txtApellPaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtApellPaterno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.txtApellPaterno.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtApellPaterno.BorderRadius = 8;
            this.txtApellPaterno.BorderSize = 1;
            this.txtApellPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellPaterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(106)))), ((int)(((byte)(203)))));
            this.txtApellPaterno.Location = new System.Drawing.Point(198, 93);
            this.txtApellPaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellPaterno.Multiline = false;
            this.txtApellPaterno.Name = "txtApellPaterno";
            this.txtApellPaterno.Padding = new System.Windows.Forms.Padding(7);
            this.txtApellPaterno.PasswordChar = false;
            this.txtApellPaterno.PlaceholderColor = System.Drawing.Color.Teal;
            this.txtApellPaterno.PlaceholderText = "";
            this.txtApellPaterno.Size = new System.Drawing.Size(234, 31);
            this.txtApellPaterno.TabIndex = 5;
            this.txtApellPaterno.Texts = "";
            this.txtApellPaterno.UnderlinedStyle = false;
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtNombres.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.txtNombres.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNombres.BorderRadius = 8;
            this.txtNombres.BorderSize = 1;
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(106)))), ((int)(((byte)(203)))));
            this.txtNombres.Location = new System.Drawing.Point(198, 54);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombres.Multiline = false;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Padding = new System.Windows.Forms.Padding(7);
            this.txtNombres.PasswordChar = false;
            this.txtNombres.PlaceholderColor = System.Drawing.Color.Teal;
            this.txtNombres.PlaceholderText = "";
            this.txtNombres.Size = new System.Drawing.Size(234, 31);
            this.txtNombres.TabIndex = 3;
            this.txtNombres.Texts = "";
            this.txtNombres.UnderlinedStyle = false;
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.BackColor = System.Drawing.Color.RosyBrown;
            this.txtCodigoEmpleado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.txtCodigoEmpleado.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCodigoEmpleado.BorderRadius = 8;
            this.txtCodigoEmpleado.BorderSize = 1;
            this.txtCodigoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(106)))), ((int)(((byte)(203)))));
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(198, 16);
            this.txtCodigoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoEmpleado.Multiline = false;
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodigoEmpleado.PasswordChar = false;
            this.txtCodigoEmpleado.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(106)))), ((int)(((byte)(203)))));
            this.txtCodigoEmpleado.PlaceholderText = "";
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(142, 35);
            this.txtCodigoEmpleado.TabIndex = 1;
            this.txtCodigoEmpleado.Texts = "";
            this.txtCodigoEmpleado.UnderlinedStyle = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.BackgroundColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.BtnCerrar.BorderRadius = 40;
            this.BtnCerrar.BorderSize = 4;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(828, 5);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(69, 40);
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.TextColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FrmGestionarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(905, 734);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionarEmpleado";
            this.Text = "FrmGestionarEmpleado";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmGestionarEmpleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLstEmpleados)).EndInit();
            this.gbEmpleado.ResumeLayout(false);
            this.gbEmpleado.PerformLayout();
            this.gbEncargatura.ResumeLayout(false);
            this.gbEncargatura.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RadioButon BtnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private RadioButon btnModificar;
        private RadioButon btnNuevo;
        private RJTexBox txtCodigo;
        private System.Windows.Forms.DataGridView DgvLstEmpleados;
        private System.Windows.Forms.GroupBox gbEmpleado;
        private RJTexBox txtCorreo;
        private RJTexBox txtDireccion;
        private RJTexBox txtTelefono;
        private RJTexBox txtDNI;
        private RJTexBox txtApellMaterno;
        private RJTexBox txtApellPaterno;
        private RJTexBox txtNombres;
        private RJTexBox txtCodigoEmpleado;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellPaterno;
        private System.Windows.Forms.Label lblApellMaterno;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblCodigoEmpleado;
        private System.Windows.Forms.GroupBox gbEncargatura;
        private System.Windows.Forms.Label lblNombreEncargatura;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.CheckBox chkVigencia;
        private System.Windows.Forms.Label lblAreaEmpleado;
        private RadioButon btnBuscar;
        private RadioButon btnAceptar;
        private RJComboBox cmbArea;
        private RadioButon btnCancelar;
        private RJComboBox cmbAreaEmpleado;
        private RJComboBox cmbGenero;
        private RJComboBox cmbEncargatura;
        private RadioButon btnCodigo;
        private RadioButon btnDarDeBaja;
        private RadioButon btnCarnet;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaFinEncar;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioEncar;
        private System.Windows.Forms.Timer FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdNombresCompletos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdEncargatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdVigente;
    }
}