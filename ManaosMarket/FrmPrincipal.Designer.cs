namespace ManaosMarket
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuPrivado = new System.Windows.Forms.MenuStrip();
            this.menuSesionAbierta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAdministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuControlAsistencia = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuGestionarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuJustificarTardanzas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuJustificarPermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuVacaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuGestionarContrato = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuCancelarContrato = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImpresionBoleta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVentanas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEstado = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuPublico = new System.Windows.Forms.ToolStrip();
            this.menuSesion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAsistencia = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSesionAdministracion = new System.Windows.Forms.ToolStripButton();
            this.menuPrivado.SuspendLayout();
            this.menuEstado.SuspendLayout();
            this.menuPublico.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrivado
            // 
            this.menuPrivado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSesionAbierta,
            this.MenuAdministracion,
            this.menuReportes,
            this.menuVer,
            this.menuVentanas,
            this.menuAyuda});
            this.menuPrivado.Location = new System.Drawing.Point(0, 0);
            this.menuPrivado.Name = "menuPrivado";
            this.menuPrivado.Size = new System.Drawing.Size(1016, 24);
            this.menuPrivado.TabIndex = 0;
            this.menuPrivado.Text = "menuPrivado";
            // 
            // menuSesionAbierta
            // 
            this.menuSesionAbierta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCerrar});
            this.menuSesionAbierta.Name = "menuSesionAbierta";
            this.menuSesionAbierta.Size = new System.Drawing.Size(53, 20);
            this.menuSesionAbierta.Text = "Sesion";
            // 
            // menuCerrar
            // 
            this.menuCerrar.Name = "menuCerrar";
            this.menuCerrar.Size = new System.Drawing.Size(106, 22);
            this.menuCerrar.Text = "Cerrar";
            this.menuCerrar.Click += new System.EventHandler(this.menuCerrar_Click);
            // 
            // MenuAdministracion
            // 
            this.MenuAdministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuControlAsistencia,
            this.toolStripMenuItem1,
            this.menuGestionarEmpleado,
            this.toolStripMenuItem2,
            this.menuJustificarTardanzas,
            this.toolStripMenuItem4,
            this.menuJustificarPermisos,
            this.toolStripMenuItem3,
            this.menuVacaciones,
            this.toolStripMenuItem5,
            this.menuGestionarContrato,
            this.toolStripMenuItem6,
            this.MenuCancelarContrato});
            this.MenuAdministracion.Name = "MenuAdministracion";
            this.MenuAdministracion.Size = new System.Drawing.Size(100, 20);
            this.MenuAdministracion.Text = "Administración";
            // 
            // menuControlAsistencia
            // 
            this.menuControlAsistencia.Name = "menuControlAsistencia";
            this.menuControlAsistencia.Size = new System.Drawing.Size(211, 22);
            this.menuControlAsistencia.Text = "CONTROL DE ASISTENCIA";
            this.menuControlAsistencia.Click += new System.EventHandler(this.menuControlAsistencia_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(208, 6);
            // 
            // menuGestionarEmpleado
            // 
            this.menuGestionarEmpleado.Name = "menuGestionarEmpleado";
            this.menuGestionarEmpleado.Size = new System.Drawing.Size(211, 22);
            this.menuGestionarEmpleado.Text = "GESTIONAR EMPLEADO";
            this.menuGestionarEmpleado.Click += new System.EventHandler(this.menuGestionarEmpleado_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(208, 6);
            // 
            // menuJustificarTardanzas
            // 
            this.menuJustificarTardanzas.Name = "menuJustificarTardanzas";
            this.menuJustificarTardanzas.Size = new System.Drawing.Size(211, 22);
            this.menuJustificarTardanzas.Text = "JUSTIFICAR TARDANZAS";
            this.menuJustificarTardanzas.Click += new System.EventHandler(this.menuJustificarTardanzas_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(208, 6);
            // 
            // menuJustificarPermisos
            // 
            this.menuJustificarPermisos.Name = "menuJustificarPermisos";
            this.menuJustificarPermisos.Size = new System.Drawing.Size(211, 22);
            this.menuJustificarPermisos.Text = "REGISTRAR PERMISOS";
            this.menuJustificarPermisos.Click += new System.EventHandler(this.menuJustificarPermisos_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(208, 6);
            // 
            // menuVacaciones
            // 
            this.menuVacaciones.Name = "menuVacaciones";
            this.menuVacaciones.Size = new System.Drawing.Size(211, 22);
            this.menuVacaciones.Text = "REGISTRAR VACACIONES";
            this.menuVacaciones.Click += new System.EventHandler(this.menuVacaciones_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(208, 6);
            // 
            // menuGestionarContrato
            // 
            this.menuGestionarContrato.Name = "menuGestionarContrato";
            this.menuGestionarContrato.Size = new System.Drawing.Size(211, 22);
            this.menuGestionarContrato.Text = "GESTIONAR CONTRATO";
            this.menuGestionarContrato.Click += new System.EventHandler(this.menuGestionarContrato_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(208, 6);
            // 
            // MenuCancelarContrato
            // 
            this.MenuCancelarContrato.Name = "MenuCancelarContrato";
            this.MenuCancelarContrato.Size = new System.Drawing.Size(211, 22);
            this.MenuCancelarContrato.Text = "CANCELAR CONTRATO";
            this.MenuCancelarContrato.Click += new System.EventHandler(this.MenuCancelarContrato_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImpresionBoleta});
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(65, 20);
            this.menuReportes.Text = "Reportes";
            // 
            // menuImpresionBoleta
            // 
            this.menuImpresionBoleta.Name = "menuImpresionBoleta";
            this.menuImpresionBoleta.Size = new System.Drawing.Size(196, 22);
            this.menuImpresionBoleta.Text = "IMPRESION DE BOLETA";
            this.menuImpresionBoleta.Click += new System.EventHandler(this.menuImpresionBoleta_Click);
            // 
            // menuVer
            // 
            this.menuVer.Name = "menuVer";
            this.menuVer.Size = new System.Drawing.Size(35, 20);
            this.menuVer.Text = "&Ver";
            // 
            // menuVentanas
            // 
            this.menuVentanas.Name = "menuVentanas";
            this.menuVentanas.Size = new System.Drawing.Size(66, 20);
            this.menuVentanas.Text = "&Ventanas";
            // 
            // menuAyuda
            // 
            this.menuAyuda.Name = "menuAyuda";
            this.menuAyuda.Size = new System.Drawing.Size(53, 20);
            this.menuAyuda.Text = "&Ayuda";
            // 
            // menuEstado
            // 
            this.menuEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.menuEstado.Location = new System.Drawing.Point(0, 547);
            this.menuEstado.Name = "menuEstado";
            this.menuEstado.Size = new System.Drawing.Size(1016, 22);
            this.menuEstado.TabIndex = 2;
            this.menuEstado.Text = "menuEstado";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "Usuario";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel5.Text = "Fecha";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.AutoSize = false;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(100, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel3.Text = "Hora";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.AutoSize = false;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(100, 17);
            // 
            // menuPublico
            // 
            this.menuPublico.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSesion,
            this.toolStripSeparator2,
            this.menuAsistencia,
            this.toolStripSeparator1,
            this.menuSesionAdministracion});
            this.menuPublico.Location = new System.Drawing.Point(0, 24);
            this.menuPublico.Name = "menuPublico";
            this.menuPublico.Size = new System.Drawing.Size(1016, 25);
            this.menuPublico.TabIndex = 3;
            this.menuPublico.Text = "menuPublico";
            // 
            // menuSesion
            // 
            this.menuSesion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuSesion.Image = ((System.Drawing.Image)(resources.GetObject("menuSesion.Image")));
            this.menuSesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuSesion.Name = "menuSesion";
            this.menuSesion.Size = new System.Drawing.Size(94, 22);
            this.menuSesion.Text = "INICIAR SESIÓN";
            this.menuSesion.Click += new System.EventHandler(this.menuSesion_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // menuAsistencia
            // 
            this.menuAsistencia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuAsistencia.Image = ((System.Drawing.Image)(resources.GetObject("menuAsistencia.Image")));
            this.menuAsistencia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuAsistencia.Name = "menuAsistencia";
            this.menuAsistencia.Size = new System.Drawing.Size(74, 22);
            this.menuAsistencia.Text = "ASISTENCIA";
            this.menuAsistencia.Click += new System.EventHandler(this.menuAsistencia_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // menuSesionAdministracion
            // 
            this.menuSesionAdministracion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuSesionAdministracion.Image = ((System.Drawing.Image)(resources.GetObject("menuSesionAdministracion.Image")));
            this.menuSesionAdministracion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuSesionAdministracion.Name = "menuSesionAdministracion";
            this.menuSesionAdministracion.Size = new System.Drawing.Size(230, 22);
            this.menuSesionAdministracion.Text = "INICIAR SESIÓN COMO ADMINISTRADOR";
            this.menuSesionAdministracion.Click += new System.EventHandler(this.menuSesionAdministracion_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 569);
            this.Controls.Add(this.menuPublico);
            this.Controls.Add(this.menuEstado);
            this.Controls.Add(this.menuPrivado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrivado;
            this.Name = "FrmPrincipal";
            this.Text = "SISTEMA MANAOS MARKET";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuPrivado.ResumeLayout(false);
            this.menuPrivado.PerformLayout();
            this.menuEstado.ResumeLayout(false);
            this.menuEstado.PerformLayout();
            this.menuPublico.ResumeLayout(false);
            this.menuPublico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrivado;
        private System.Windows.Forms.ToolStripMenuItem MenuAdministracion;
        private System.Windows.Forms.ToolStripMenuItem menuControlAsistencia;
        private System.Windows.Forms.ToolStripMenuItem menuReportes;
        private System.Windows.Forms.ToolStripMenuItem menuImpresionBoleta;
        private System.Windows.Forms.ToolStripMenuItem MenuCancelarContrato;
        private System.Windows.Forms.ToolStripMenuItem menuGestionarEmpleado;
        private System.Windows.Forms.ToolStripMenuItem menuJustificarTardanzas;
        private System.Windows.Forms.ToolStripMenuItem menuJustificarPermisos;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuVacaciones;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem menuGestionarContrato;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem menuVer;
        private System.Windows.Forms.ToolStripMenuItem menuVentanas;
        private System.Windows.Forms.ToolStripMenuItem menuAyuda;
        private System.Windows.Forms.StatusStrip menuEstado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStrip menuPublico;
        private System.Windows.Forms.ToolStripButton menuSesion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton menuAsistencia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton menuSesionAdministracion;
        private System.Windows.Forms.ToolStripMenuItem menuSesionAbierta;
        private System.Windows.Forms.ToolStripMenuItem menuCerrar;
    }
}

