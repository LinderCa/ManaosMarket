namespace ManaosMarket
{
    partial class FrmControlAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControlAsistencia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnCerrar = new ManaosMarket.RadioButon();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.lblHora1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.horaFecha2 = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioButon4 = new ManaosMarket.RadioButon();
            this.rjTexBox5 = new ManaosMarket.RJTexBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CdFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdHoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdAsistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.rjTexBox7 = new ManaosMarket.RJTexBox();
            this.rjTexBox6 = new ManaosMarket.RJTexBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rjTexBox4 = new ManaosMarket.RJTexBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rjTexBox1 = new ManaosMarket.RJTexBox();
            this.radioButon5 = new ManaosMarket.RadioButon();
            this.rjTexBox3 = new ManaosMarket.RJTexBox();
            this.rjTexBox2 = new ManaosMarket.RJTexBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnCerrar);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(855, 51);
            this.panel3.TabIndex = 0;
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
            this.BtnCerrar.Location = new System.Drawing.Point(778, 7);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(69, 40);
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.TextColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = ":: CONTROL ASISTENCIA";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblFecha2);
            this.panel4.Controls.Add(this.lblHora1);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 496);
            this.panel4.TabIndex = 1;
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblFecha2.Location = new System.Drawing.Point(22, 385);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(118, 33);
            this.lblFecha2.TabIndex = 2;
            this.lblFecha2.Text = "FECHA";
            this.lblFecha2.Click += new System.EventHandler(this.lblFecha2_Click);
            // 
            // lblHora1
            // 
            this.lblHora1.AutoSize = true;
            this.lblHora1.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblHora1.Location = new System.Drawing.Point(31, 296);
            this.lblHora1.Name = "lblHora1";
            this.lblHora1.Size = new System.Drawing.Size(254, 85);
            this.lblHora1.TabIndex = 1;
            this.lblHora1.Text = "HORA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ManaosMarket.Properties.Resources.logoMAnaosDefecto;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(394, 332);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // horaFecha2
            // 
            this.horaFecha2.Enabled = true;
            this.horaFecha2.Tick += new System.EventHandler(this.horaFecha2_Tick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.panel5.Controls.Add(this.radioButon4);
            this.panel5.Controls.Add(this.rjTexBox5);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.dataGridView2);
            this.panel5.Controls.Add(this.checkBox3);
            this.panel5.Controls.Add(this.rjTexBox7);
            this.panel5.Controls.Add(this.rjTexBox6);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.rjTexBox4);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.rjTexBox1);
            this.panel5.Controls.Add(this.radioButon5);
            this.panel5.Controls.Add(this.rjTexBox3);
            this.panel5.Controls.Add(this.rjTexBox2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(394, 51);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(461, 496);
            this.panel5.TabIndex = 2;
            // 
            // radioButon4
            // 
            this.radioButon4.BackColor = System.Drawing.Color.Transparent;
            this.radioButon4.BackgroundColor = System.Drawing.Color.Transparent;
            this.radioButon4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.radioButon4.BorderRadius = 40;
            this.radioButon4.BorderSize = 2;
            this.radioButon4.FlatAppearance.BorderSize = 0;
            this.radioButon4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButon4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButon4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.radioButon4.Image = global::ManaosMarket.Properties.Resources.ACEPTAR9;
            this.radioButon4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButon4.Location = new System.Drawing.Point(337, 220);
            this.radioButon4.Name = "radioButon4";
            this.radioButon4.Size = new System.Drawing.Size(108, 39);
            this.radioButon4.TabIndex = 81;
            this.radioButon4.Text = "ACEPTAR";
            this.radioButon4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButon4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.radioButon4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radioButon4.UseVisualStyleBackColor = false;
            // 
            // rjTexBox5
            // 
            this.rjTexBox5.BackColor = System.Drawing.Color.RosyBrown;
            this.rjTexBox5.BorderColor = System.Drawing.Color.DarkGray;
            this.rjTexBox5.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTexBox5.BorderRadius = 8;
            this.rjTexBox5.BorderSize = 1;
            this.rjTexBox5.Enabled = false;
            this.rjTexBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTexBox5.ForeColor = System.Drawing.Color.DimGray;
            this.rjTexBox5.Location = new System.Drawing.Point(338, 435);
            this.rjTexBox5.Margin = new System.Windows.Forms.Padding(4);
            this.rjTexBox5.Multiline = false;
            this.rjTexBox5.Name = "rjTexBox5";
            this.rjTexBox5.Padding = new System.Windows.Forms.Padding(7);
            this.rjTexBox5.PasswordChar = false;
            this.rjTexBox5.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTexBox5.PlaceholderText = "";
            this.rjTexBox5.Size = new System.Drawing.Size(107, 31);
            this.rjTexBox5.TabIndex = 20;
            this.rjTexBox5.Texts = "";
            this.rjTexBox5.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label8.Location = new System.Drawing.Point(194, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "N° Dias Laborables";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CdFecha,
            this.CdHoraEntrada,
            this.CdAsistencia});
            this.dataGridView2.Location = new System.Drawing.Point(29, 272);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(413, 146);
            this.dataGridView2.TabIndex = 18;
            // 
            // CdFecha
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.CdFecha.DefaultCellStyle = dataGridViewCellStyle1;
            this.CdFecha.HeaderText = "Fecha";
            this.CdFecha.Name = "CdFecha";
            this.CdFecha.ReadOnly = true;
            // 
            // CdHoraEntrada
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.CdHoraEntrada.DefaultCellStyle = dataGridViewCellStyle2;
            this.CdHoraEntrada.HeaderText = "Hora Entrada";
            this.CdHoraEntrada.Name = "CdHoraEntrada";
            this.CdHoraEntrada.ReadOnly = true;
            this.CdHoraEntrada.Width = 120;
            // 
            // CdAsistencia
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.CdAsistencia.DefaultCellStyle = dataGridViewCellStyle3;
            this.CdAsistencia.HeaderText = "Asistencia";
            this.CdAsistencia.Name = "CdAsistencia";
            this.CdAsistencia.ReadOnly = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBox3.Location = new System.Drawing.Point(139, 227);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(93, 24);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "Asitencia";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // rjTexBox7
            // 
            this.rjTexBox7.BackColor = System.Drawing.Color.RosyBrown;
            this.rjTexBox7.BorderColor = System.Drawing.Color.DarkGray;
            this.rjTexBox7.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTexBox7.BorderRadius = 8;
            this.rjTexBox7.BorderSize = 1;
            this.rjTexBox7.Enabled = false;
            this.rjTexBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTexBox7.ForeColor = System.Drawing.Color.DimGray;
            this.rjTexBox7.Location = new System.Drawing.Point(184, 185);
            this.rjTexBox7.Margin = new System.Windows.Forms.Padding(4);
            this.rjTexBox7.Multiline = false;
            this.rjTexBox7.Name = "rjTexBox7";
            this.rjTexBox7.Padding = new System.Windows.Forms.Padding(7);
            this.rjTexBox7.PasswordChar = false;
            this.rjTexBox7.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTexBox7.PlaceholderText = "";
            this.rjTexBox7.Size = new System.Drawing.Size(151, 31);
            this.rjTexBox7.TabIndex = 15;
            this.rjTexBox7.Texts = "";
            this.rjTexBox7.UnderlinedStyle = false;
            // 
            // rjTexBox6
            // 
            this.rjTexBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.rjTexBox6.BorderColor = System.Drawing.Color.DimGray;
            this.rjTexBox6.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTexBox6.BorderRadius = 0;
            this.rjTexBox6.BorderSize = 2;
            this.rjTexBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTexBox6.ForeColor = System.Drawing.Color.DimGray;
            this.rjTexBox6.Location = new System.Drawing.Point(19, 234);
            this.rjTexBox6.Margin = new System.Windows.Forms.Padding(4);
            this.rjTexBox6.Multiline = false;
            this.rjTexBox6.Name = "rjTexBox6";
            this.rjTexBox6.Padding = new System.Windows.Forms.Padding(7);
            this.rjTexBox6.PasswordChar = false;
            this.rjTexBox6.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTexBox6.PlaceholderText = "";
            this.rjTexBox6.Size = new System.Drawing.Size(426, 31);
            this.rjTexBox6.TabIndex = 14;
            this.rjTexBox6.Texts = "";
            this.rjTexBox6.UnderlinedStyle = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label7.Location = new System.Drawing.Point(135, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Area";
            // 
            // rjTexBox4
            // 
            this.rjTexBox4.BackColor = System.Drawing.Color.RosyBrown;
            this.rjTexBox4.BorderColor = System.Drawing.Color.DarkGray;
            this.rjTexBox4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTexBox4.BorderRadius = 8;
            this.rjTexBox4.BorderSize = 1;
            this.rjTexBox4.Enabled = false;
            this.rjTexBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTexBox4.ForeColor = System.Drawing.Color.DimGray;
            this.rjTexBox4.Location = new System.Drawing.Point(184, 144);
            this.rjTexBox4.Margin = new System.Windows.Forms.Padding(4);
            this.rjTexBox4.Multiline = false;
            this.rjTexBox4.Name = "rjTexBox4";
            this.rjTexBox4.Padding = new System.Windows.Forms.Padding(7);
            this.rjTexBox4.PasswordChar = false;
            this.rjTexBox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTexBox4.PlaceholderText = "";
            this.rjTexBox4.Size = new System.Drawing.Size(151, 31);
            this.rjTexBox4.TabIndex = 10;
            this.rjTexBox4.Texts = "";
            this.rjTexBox4.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label6.Location = new System.Drawing.Point(135, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "DNI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label5.Location = new System.Drawing.Point(25, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombres Completos";
            // 
            // rjTexBox1
            // 
            this.rjTexBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.rjTexBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.rjTexBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTexBox1.BorderRadius = 8;
            this.rjTexBox1.BorderSize = 1;
            this.rjTexBox1.Enabled = false;
            this.rjTexBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTexBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjTexBox1.Location = new System.Drawing.Point(183, 105);
            this.rjTexBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTexBox1.Multiline = false;
            this.rjTexBox1.Name = "rjTexBox1";
            this.rjTexBox1.Padding = new System.Windows.Forms.Padding(7);
            this.rjTexBox1.PasswordChar = false;
            this.rjTexBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTexBox1.PlaceholderText = "";
            this.rjTexBox1.Size = new System.Drawing.Size(260, 31);
            this.rjTexBox1.TabIndex = 7;
            this.rjTexBox1.Texts = "";
            this.rjTexBox1.UnderlinedStyle = false;
            // 
            // radioButon5
            // 
            this.radioButon5.BackColor = System.Drawing.Color.Transparent;
            this.radioButon5.BackgroundColor = System.Drawing.Color.Transparent;
            this.radioButon5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.radioButon5.BorderRadius = 40;
            this.radioButon5.BorderSize = 2;
            this.radioButon5.FlatAppearance.BorderSize = 0;
            this.radioButon5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButon5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButon5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.radioButon5.Image = global::ManaosMarket.Properties.Resources.BUSCAR5;
            this.radioButon5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButon5.Location = new System.Drawing.Point(336, 39);
            this.radioButon5.Name = "radioButon5";
            this.radioButon5.Size = new System.Drawing.Size(109, 39);
            this.radioButon5.TabIndex = 6;
            this.radioButon5.Text = "BUSCAR";
            this.radioButon5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButon5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.radioButon5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radioButon5.UseVisualStyleBackColor = false;
            // 
            // rjTexBox3
            // 
            this.rjTexBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.rjTexBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.rjTexBox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTexBox3.BorderRadius = 0;
            this.rjTexBox3.BorderSize = 3;
            this.rjTexBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTexBox3.ForeColor = System.Drawing.Color.DimGray;
            this.rjTexBox3.Location = new System.Drawing.Point(19, 47);
            this.rjTexBox3.Margin = new System.Windows.Forms.Padding(4);
            this.rjTexBox3.Multiline = false;
            this.rjTexBox3.Name = "rjTexBox3";
            this.rjTexBox3.Padding = new System.Windows.Forms.Padding(7);
            this.rjTexBox3.PasswordChar = true;
            this.rjTexBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTexBox3.PlaceholderText = "";
            this.rjTexBox3.Size = new System.Drawing.Size(250, 31);
            this.rjTexBox3.TabIndex = 5;
            this.rjTexBox3.Texts = "";
            this.rjTexBox3.UnderlinedStyle = false;
            // 
            // rjTexBox2
            // 
            this.rjTexBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.rjTexBox2.BorderColor = System.Drawing.Color.DimGray;
            this.rjTexBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTexBox2.BorderRadius = 0;
            this.rjTexBox2.BorderSize = 2;
            this.rjTexBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTexBox2.ForeColor = System.Drawing.Color.DimGray;
            this.rjTexBox2.Location = new System.Drawing.Point(19, 66);
            this.rjTexBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rjTexBox2.Multiline = false;
            this.rjTexBox2.Name = "rjTexBox2";
            this.rjTexBox2.Padding = new System.Windows.Forms.Padding(7);
            this.rjTexBox2.PasswordChar = false;
            this.rjTexBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTexBox2.PlaceholderText = "";
            this.rjTexBox2.Size = new System.Drawing.Size(426, 31);
            this.rjTexBox2.TabIndex = 4;
            this.rjTexBox2.Texts = "";
            this.rjTexBox2.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label3.Location = new System.Drawing.Point(25, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Codigo";
            // 
            // FrmControlAsistencia
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(855, 547);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmControlAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private RadioButon radioButon2;
        private RadioButon radioButon3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdNombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdNAsistencias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RadioButon BtnCerrar;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.Label lblHora1;
        private System.Windows.Forms.Timer horaFecha2;
        private System.Windows.Forms.Panel panel5;
        private RadioButon radioButon5;
        private RJTexBox rjTexBox3;
        private RJTexBox rjTexBox2;
        private System.Windows.Forms.Label label3;
        private RJTexBox rjTexBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private RJTexBox rjTexBox7;
        private RJTexBox rjTexBox6;
        private System.Windows.Forms.Label label7;
        private RJTexBox rjTexBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private RJTexBox rjTexBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdHoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdAsistencia;
        private RadioButon radioButon4;
    }
}