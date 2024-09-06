namespace ManaosMarket
{
    partial class FrmJustificarTardanza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJustificarTardanza));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCerrrar = new ManaosMarket.RadioButon();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rjTexBox3 = new ManaosMarket.RJTexBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.DgvLstEmpleados = new System.Windows.Forms.DataGridView();
            this.CdNombresCompletos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdAsistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rjTexBox7 = new ManaosMarket.RJTexBox();
            this.rjTexBox1 = new ManaosMarket.RJTexBox();
            this.rjTexBox4 = new ManaosMarket.RJTexBox();
            this.rjTexBox2 = new ManaosMarket.RJTexBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioButon3 = new ManaosMarket.RadioButon();
            this.radioButon1 = new ManaosMarket.RadioButon();
            this.rjTexBox6 = new ManaosMarket.RJTexBox();
            this.rjTexBox5 = new ManaosMarket.RJTexBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLstEmpleados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnCerrrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(759, 51);
            this.panel1.TabIndex = 1;
            // 
            // BtnCerrrar
            // 
            this.BtnCerrrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrrar.BackgroundColor = System.Drawing.Color.Transparent;
            this.BtnCerrrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.BtnCerrrar.BorderRadius = 40;
            this.BtnCerrrar.BorderSize = 4;
            this.BtnCerrrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrrar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCerrrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrrar.Image")));
            this.BtnCerrrar.Location = new System.Drawing.Point(668, 5);
            this.BtnCerrrar.Name = "BtnCerrrar";
            this.BtnCerrrar.Size = new System.Drawing.Size(69, 40);
            this.BtnCerrrar.TabIndex = 6;
            this.BtnCerrrar.TextColor = System.Drawing.Color.Transparent;
            this.BtnCerrrar.UseVisualStyleBackColor = false;
            this.BtnCerrrar.Click += new System.EventHandler(this.BtnCerrrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(61, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "TARDANZAS DEL DIA";
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(111)))), ((int)(((byte)(116)))));
            this.panel2.Controls.Add(this.rjTexBox3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblFecha2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(759, 69);
            this.panel2.TabIndex = 2;
            // 
            // rjTexBox3
            // 
            this.rjTexBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(111)))), ((int)(((byte)(116)))));
            this.rjTexBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.rjTexBox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTexBox3.BorderRadius = 0;
            this.rjTexBox3.BorderSize = 3;
            this.rjTexBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTexBox3.ForeColor = System.Drawing.Color.DimGray;
            this.rjTexBox3.Location = new System.Drawing.Point(689, 18);
            this.rjTexBox3.Margin = new System.Windows.Forms.Padding(4);
            this.rjTexBox3.Multiline = false;
            this.rjTexBox3.Name = "rjTexBox3";
            this.rjTexBox3.Padding = new System.Windows.Forms.Padding(7);
            this.rjTexBox3.PasswordChar = true;
            this.rjTexBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTexBox3.PlaceholderText = "001";
            this.rjTexBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rjTexBox3.Size = new System.Drawing.Size(48, 35);
            this.rjTexBox3.TabIndex = 52;
            this.rjTexBox3.Texts = "";
            this.rjTexBox3.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(497, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 33);
            this.label3.TabIndex = 33;
            this.label3.Text = "N° Tardanza";
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha2.ForeColor = System.Drawing.Color.White;
            this.lblFecha2.Location = new System.Drawing.Point(30, 16);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(118, 33);
            this.lblFecha2.TabIndex = 14;
            this.lblFecha2.Text = "FECHA";
            // 
            // DgvLstEmpleados
            // 
            this.DgvLstEmpleados.AllowUserToAddRows = false;
            this.DgvLstEmpleados.AllowUserToDeleteRows = false;
            this.DgvLstEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLstEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CdNombresCompletos,
            this.CdAsistencia});
            this.DgvLstEmpleados.Location = new System.Drawing.Point(23, 6);
            this.DgvLstEmpleados.MultiSelect = false;
            this.DgvLstEmpleados.Name = "DgvLstEmpleados";
            this.DgvLstEmpleados.ReadOnly = true;
            this.DgvLstEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLstEmpleados.Size = new System.Drawing.Size(296, 374);
            this.DgvLstEmpleados.TabIndex = 0;
            // 
            // CdNombresCompletos
            // 
            this.CdNombresCompletos.DataPropertyName = "NombresCompletos";
            this.CdNombresCompletos.HeaderText = "Nombres Completos";
            this.CdNombresCompletos.Name = "CdNombresCompletos";
            this.CdNombresCompletos.ReadOnly = true;
            this.CdNombresCompletos.Width = 140;
            // 
            // CdAsistencia
            // 
            this.CdAsistencia.HeaderText = "Asistencia";
            this.CdAsistencia.Name = "CdAsistencia";
            this.CdAsistencia.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.groupBox1.Controls.Add(this.rjTexBox7);
            this.groupBox1.Controls.Add(this.rjTexBox1);
            this.groupBox1.Controls.Add(this.rjTexBox4);
            this.groupBox1.Controls.Add(this.rjTexBox2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(341, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 304);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleado";
            // 
            // rjTexBox7
            // 
            this.rjTexBox7.BackColor = System.Drawing.Color.Khaki;
            this.rjTexBox7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.rjTexBox7.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTexBox7.BorderRadius = 8;
            this.rjTexBox7.BorderSize = 1;
            this.rjTexBox7.Enabled = false;
            this.rjTexBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTexBox7.ForeColor = System.Drawing.Color.DimGray;
            this.rjTexBox7.Location = new System.Drawing.Point(252, 237);
            this.rjTexBox7.Margin = new System.Windows.Forms.Padding(4);
            this.rjTexBox7.Multiline = false;
            this.rjTexBox7.Name = "rjTexBox7";
            this.rjTexBox7.Padding = new System.Windows.Forms.Padding(7);
            this.rjTexBox7.PasswordChar = false;
            this.rjTexBox7.PlaceholderColor = System.Drawing.Color.CadetBlue;
            this.rjTexBox7.PlaceholderText = "";
            this.rjTexBox7.Size = new System.Drawing.Size(94, 31);
            this.rjTexBox7.TabIndex = 52;
            this.rjTexBox7.Texts = "";
            this.rjTexBox7.UnderlinedStyle = false;
            // 
            // rjTexBox1
            // 
            this.rjTexBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.rjTexBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.rjTexBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTexBox1.BorderRadius = 8;
            this.rjTexBox1.BorderSize = 1;
            this.rjTexBox1.Enabled = false;
            this.rjTexBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTexBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjTexBox1.Location = new System.Drawing.Point(112, 73);
            this.rjTexBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTexBox1.Multiline = false;
            this.rjTexBox1.Name = "rjTexBox1";
            this.rjTexBox1.Padding = new System.Windows.Forms.Padding(7);
            this.rjTexBox1.PasswordChar = false;
            this.rjTexBox1.PlaceholderColor = System.Drawing.Color.CadetBlue;
            this.rjTexBox1.PlaceholderText = "";
            this.rjTexBox1.Size = new System.Drawing.Size(234, 31);
            this.rjTexBox1.TabIndex = 51;
            this.rjTexBox1.Texts = "";
            this.rjTexBox1.UnderlinedStyle = false;
            // 
            // rjTexBox4
            // 
            this.rjTexBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.rjTexBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.rjTexBox4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTexBox4.BorderRadius = 8;
            this.rjTexBox4.BorderSize = 1;
            this.rjTexBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTexBox4.ForeColor = System.Drawing.Color.Transparent;
            this.rjTexBox4.Location = new System.Drawing.Point(112, 112);
            this.rjTexBox4.Margin = new System.Windows.Forms.Padding(4);
            this.rjTexBox4.Multiline = true;
            this.rjTexBox4.Name = "rjTexBox4";
            this.rjTexBox4.Padding = new System.Windows.Forms.Padding(7);
            this.rjTexBox4.PasswordChar = false;
            this.rjTexBox4.PlaceholderColor = System.Drawing.Color.CadetBlue;
            this.rjTexBox4.PlaceholderText = "";
            this.rjTexBox4.Size = new System.Drawing.Size(234, 107);
            this.rjTexBox4.TabIndex = 43;
            this.rjTexBox4.Texts = "";
            this.rjTexBox4.UnderlinedStyle = false;
            // 
            // rjTexBox2
            // 
            this.rjTexBox2.BackColor = System.Drawing.Color.RosyBrown;
            this.rjTexBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.rjTexBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTexBox2.BorderRadius = 8;
            this.rjTexBox2.BorderSize = 1;
            this.rjTexBox2.Enabled = false;
            this.rjTexBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTexBox2.ForeColor = System.Drawing.Color.DimGray;
            this.rjTexBox2.Location = new System.Drawing.Point(112, 34);
            this.rjTexBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rjTexBox2.Multiline = false;
            this.rjTexBox2.Name = "rjTexBox2";
            this.rjTexBox2.Padding = new System.Windows.Forms.Padding(7);
            this.rjTexBox2.PasswordChar = false;
            this.rjTexBox2.PlaceholderColor = System.Drawing.Color.CadetBlue;
            this.rjTexBox2.PlaceholderText = "";
            this.rjTexBox2.Size = new System.Drawing.Size(142, 31);
            this.rjTexBox2.TabIndex = 31;
            this.rjTexBox2.Texts = "";
            this.rjTexBox2.UnderlinedStyle = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label9.Location = new System.Drawing.Point(173, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 25);
            this.label9.TabIndex = 38;
            this.label9.Text = "Monto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label6.Location = new System.Drawing.Point(40, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Motivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label4.Location = new System.Drawing.Point(56, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Location = new System.Drawing.Point(35, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Codigo";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.panel5.Controls.Add(this.radioButon3);
            this.panel5.Controls.Add(this.radioButon1);
            this.panel5.Controls.Add(this.rjTexBox6);
            this.panel5.Controls.Add(this.rjTexBox5);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.DgvLstEmpleados);
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 120);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(759, 442);
            this.panel5.TabIndex = 52;
            // 
            // radioButon3
            // 
            this.radioButon3.BackColor = System.Drawing.Color.Transparent;
            this.radioButon3.BackgroundColor = System.Drawing.Color.Transparent;
            this.radioButon3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.radioButon3.BorderRadius = 40;
            this.radioButon3.BorderSize = 2;
            this.radioButon3.FlatAppearance.BorderSize = 0;
            this.radioButon3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButon3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButon3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.radioButon3.Image = global::ManaosMarket.Properties.Resources.MONTO1;
            this.radioButon3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButon3.Location = new System.Drawing.Point(471, 386);
            this.radioButon3.Name = "radioButon3";
            this.radioButon3.Size = new System.Drawing.Size(130, 39);
            this.radioButon3.TabIndex = 57;
            this.radioButon3.Text = "REGISTRAR MONTO";
            this.radioButon3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButon3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.radioButon3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radioButon3.UseVisualStyleBackColor = false;
            // 
            // radioButon1
            // 
            this.radioButon1.BackColor = System.Drawing.Color.Transparent;
            this.radioButon1.BackgroundColor = System.Drawing.Color.Transparent;
            this.radioButon1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.radioButon1.BorderRadius = 40;
            this.radioButon1.BorderSize = 2;
            this.radioButon1.FlatAppearance.BorderSize = 0;
            this.radioButon1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.radioButon1.Image = ((System.Drawing.Image)(resources.GetObject("radioButon1.Image")));
            this.radioButon1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButon1.Location = new System.Drawing.Point(607, 386);
            this.radioButon1.Name = "radioButon1";
            this.radioButon1.Size = new System.Drawing.Size(130, 39);
            this.radioButon1.TabIndex = 56;
            this.radioButon1.Text = "JUSTIFICAR";
            this.radioButon1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButon1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.radioButon1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radioButon1.UseVisualStyleBackColor = false;
            // 
            // rjTexBox6
            // 
            this.rjTexBox6.BackColor = System.Drawing.Color.RosyBrown;
            this.rjTexBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.rjTexBox6.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTexBox6.BorderRadius = 8;
            this.rjTexBox6.BorderSize = 1;
            this.rjTexBox6.Enabled = false;
            this.rjTexBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTexBox6.ForeColor = System.Drawing.Color.DimGray;
            this.rjTexBox6.Location = new System.Drawing.Point(622, 38);
            this.rjTexBox6.Margin = new System.Windows.Forms.Padding(4);
            this.rjTexBox6.Multiline = false;
            this.rjTexBox6.Name = "rjTexBox6";
            this.rjTexBox6.Padding = new System.Windows.Forms.Padding(7);
            this.rjTexBox6.PasswordChar = false;
            this.rjTexBox6.PlaceholderColor = System.Drawing.Color.CadetBlue;
            this.rjTexBox6.PlaceholderText = "";
            this.rjTexBox6.Size = new System.Drawing.Size(115, 31);
            this.rjTexBox6.TabIndex = 55;
            this.rjTexBox6.Texts = "";
            this.rjTexBox6.UnderlinedStyle = false;
            // 
            // rjTexBox5
            // 
            this.rjTexBox5.BackColor = System.Drawing.Color.RosyBrown;
            this.rjTexBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.rjTexBox5.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTexBox5.BorderRadius = 8;
            this.rjTexBox5.BorderSize = 1;
            this.rjTexBox5.Enabled = false;
            this.rjTexBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTexBox5.ForeColor = System.Drawing.Color.DimGray;
            this.rjTexBox5.Location = new System.Drawing.Point(341, 38);
            this.rjTexBox5.Margin = new System.Windows.Forms.Padding(4);
            this.rjTexBox5.Multiline = false;
            this.rjTexBox5.Name = "rjTexBox5";
            this.rjTexBox5.Padding = new System.Windows.Forms.Padding(7);
            this.rjTexBox5.PasswordChar = false;
            this.rjTexBox5.PlaceholderColor = System.Drawing.Color.CadetBlue;
            this.rjTexBox5.PlaceholderText = "";
            this.rjTexBox5.Size = new System.Drawing.Size(110, 31);
            this.rjTexBox5.TabIndex = 52;
            this.rjTexBox5.Texts = "";
            this.rjTexBox5.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(579, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 29);
            this.label7.TabIndex = 54;
            this.label7.Text = "H.Retrasadas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(335, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 29);
            this.label5.TabIndex = 53;
            this.label5.Text = "H.Entrada";
            // 
            // Fecha
            // 
            this.Fecha.Enabled = true;
            this.Fecha.Tick += new System.EventHandler(this.Fecha_Tick);
            // 
            // FrmJustificarTardanza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(759, 556);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmJustificarTardanza";
            this.Text = "FrmJustificarTardanza";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLstEmpleados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RadioButon BtnCerrrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgvLstEmpleados;
        private System.Windows.Forms.GroupBox groupBox1;
        private RJTexBox rjTexBox4;
        private RJTexBox rjTexBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFecha2;
        private RJTexBox rjTexBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdNombresCompletos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdAsistencia;
        private RJTexBox rjTexBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer Fecha;
        private RJTexBox rjTexBox5;
        private System.Windows.Forms.Label label7;
        private RJTexBox rjTexBox7;
        private RJTexBox rjTexBox6;
        private RadioButon radioButon1;
        private RadioButon radioButon3;
    }
}