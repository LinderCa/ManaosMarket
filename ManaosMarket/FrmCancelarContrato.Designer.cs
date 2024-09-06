namespace ManaosMarket
{
    partial class FrmCancelarContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCancelarContrato));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new ManaosMarket.RadioButon();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButon5 = new ManaosMarket.RadioButon();
            this.rjTexBox3 = new ManaosMarket.RJTexBox();
            this.lblFechaContrato = new System.Windows.Forms.Label();
            this.rjTexBox13 = new ManaosMarket.RJTexBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.rjTexBox1 = new ManaosMarket.RJTexBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CdCodigoContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdNombresCompletos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdFechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdVigencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaContrato = new System.Windows.Forms.Timer(this.components);
            this.radioButon4 = new ManaosMarket.RadioButon();
            this.radioButon3 = new ManaosMarket.RadioButon();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(592, 51);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(77, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "CANCELAR CONTRATO";
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
            this.BtnCerrar.Location = new System.Drawing.Point(511, 5);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(69, 40);
            this.BtnCerrar.TabIndex = 3;
            this.BtnCerrar.TextColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(111)))), ((int)(((byte)(116)))));
            this.panel2.Controls.Add(this.radioButon5);
            this.panel2.Controls.Add(this.rjTexBox3);
            this.panel2.Controls.Add(this.lblFechaContrato);
            this.panel2.Controls.Add(this.rjTexBox13);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.rjTexBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(592, 122);
            this.panel2.TabIndex = 3;
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
            this.radioButon5.Location = new System.Drawing.Point(249, 62);
            this.radioButon5.Name = "radioButon5";
            this.radioButon5.Size = new System.Drawing.Size(109, 36);
            this.radioButon5.TabIndex = 19;
            this.radioButon5.Text = "BUSCAR";
            this.radioButon5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButon5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.radioButon5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radioButon5.UseVisualStyleBackColor = false;
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
            this.rjTexBox3.Location = new System.Drawing.Point(532, 22);
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
            // lblFechaContrato
            // 
            this.lblFechaContrato.AutoSize = true;
            this.lblFechaContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaContrato.ForeColor = System.Drawing.Color.White;
            this.lblFechaContrato.Location = new System.Drawing.Point(397, 61);
            this.lblFechaContrato.Name = "lblFechaContrato";
            this.lblFechaContrato.Size = new System.Drawing.Size(118, 33);
            this.lblFechaContrato.TabIndex = 14;
            this.lblFechaContrato.Text = "FECHA";
            // 
            // rjTexBox13
            // 
            this.rjTexBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rjTexBox13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.rjTexBox13.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTexBox13.BorderRadius = 1;
            this.rjTexBox13.BorderSize = 2;
            this.rjTexBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTexBox13.ForeColor = System.Drawing.Color.DimGray;
            this.rjTexBox13.Location = new System.Drawing.Point(83, 26);
            this.rjTexBox13.Margin = new System.Windows.Forms.Padding(4);
            this.rjTexBox13.Multiline = false;
            this.rjTexBox13.Name = "rjTexBox13";
            this.rjTexBox13.Padding = new System.Windows.Forms.Padding(7);
            this.rjTexBox13.PasswordChar = false;
            this.rjTexBox13.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTexBox13.PlaceholderText = "";
            this.rjTexBox13.Size = new System.Drawing.Size(275, 31);
            this.rjTexBox13.TabIndex = 18;
            this.rjTexBox13.Texts = "";
            this.rjTexBox13.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(378, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 29);
            this.label3.TabIndex = 33;
            this.label3.Text = "N° Contrato";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label14.Location = new System.Drawing.Point(22, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 25);
            this.label14.TabIndex = 17;
            this.label14.Text = "Area";
            // 
            // rjTexBox1
            // 
            this.rjTexBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rjTexBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.rjTexBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTexBox1.BorderRadius = 1;
            this.rjTexBox1.BorderSize = 2;
            this.rjTexBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTexBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjTexBox1.Location = new System.Drawing.Point(83, 65);
            this.rjTexBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTexBox1.Multiline = false;
            this.rjTexBox1.Name = "rjTexBox1";
            this.rjTexBox1.Padding = new System.Windows.Forms.Padding(7);
            this.rjTexBox1.PasswordChar = false;
            this.rjTexBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTexBox1.PlaceholderText = "";
            this.rjTexBox1.Size = new System.Drawing.Size(140, 31);
            this.rjTexBox1.TabIndex = 16;
            this.rjTexBox1.Texts = "";
            this.rjTexBox1.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Location = new System.Drawing.Point(1, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Codigo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CdCodigoContrato,
            this.CdNombresCompletos,
            this.CdFechaInicio,
            this.CdFechaFin,
            this.CdVigencia});
            this.dataGridView1.Location = new System.Drawing.Point(0, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(592, 270);
            this.dataGridView1.TabIndex = 4;
            // 
            // CdCodigoContrato
            // 
            this.CdCodigoContrato.HeaderText = "Codigo";
            this.CdCodigoContrato.Name = "CdCodigoContrato";
            this.CdCodigoContrato.ReadOnly = true;
            this.CdCodigoContrato.Width = 90;
            // 
            // CdNombresCompletos
            // 
            this.CdNombresCompletos.HeaderText = "Nombres Completos";
            this.CdNombresCompletos.Name = "CdNombresCompletos";
            this.CdNombresCompletos.ReadOnly = true;
            this.CdNombresCompletos.Width = 140;
            // 
            // CdFechaInicio
            // 
            this.CdFechaInicio.HeaderText = "Fecha Inicio";
            this.CdFechaInicio.Name = "CdFechaInicio";
            this.CdFechaInicio.ReadOnly = true;
            this.CdFechaInicio.Width = 90;
            // 
            // CdFechaFin
            // 
            this.CdFechaFin.HeaderText = "Fecha Fin";
            this.CdFechaFin.Name = "CdFechaFin";
            this.CdFechaFin.ReadOnly = true;
            this.CdFechaFin.Width = 90;
            // 
            // CdVigencia
            // 
            this.CdVigencia.HeaderText = "Vigencia";
            this.CdVigencia.Name = "CdVigencia";
            this.CdVigencia.ReadOnly = true;
            this.CdVigencia.Width = 80;
            // 
            // FechaContrato
            // 
            this.FechaContrato.Enabled = true;
            this.FechaContrato.Tick += new System.EventHandler(this.FechaContrato_Tick);
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
            this.radioButon4.Location = new System.Drawing.Point(472, 455);
            this.radioButon4.Name = "radioButon4";
            this.radioButon4.Size = new System.Drawing.Size(108, 39);
            this.radioButon4.TabIndex = 82;
            this.radioButon4.Text = "ACEPTAR";
            this.radioButon4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButon4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.radioButon4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radioButon4.UseVisualStyleBackColor = false;
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
            this.radioButon3.Image = ((System.Drawing.Image)(resources.GetObject("radioButon3.Image")));
            this.radioButon3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButon3.Location = new System.Drawing.Point(336, 455);
            this.radioButon3.Name = "radioButon3";
            this.radioButon3.Size = new System.Drawing.Size(130, 39);
            this.radioButon3.TabIndex = 12;
            this.radioButon3.Text = "MODIFICAR";
            this.radioButon3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButon3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.radioButon3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radioButon3.UseVisualStyleBackColor = false;
            // 
            // FrmCancelarContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(592, 510);
            this.Controls.Add(this.radioButon4);
            this.Controls.Add(this.radioButon3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCancelarContrato";
            this.Text = "CANCELAR CONTRATO";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RadioButon BtnCerrar;
        private System.Windows.Forms.Panel panel2;
        private RJTexBox rjTexBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFechaContrato;
        private RadioButon radioButon5;
        private RJTexBox rjTexBox13;
        private System.Windows.Forms.Label label14;
        private RJTexBox rjTexBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdCodigoContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdNombresCompletos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdFechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdVigencia;
        private RadioButon radioButon3;
        private RadioButon radioButon4;
        private System.Windows.Forms.Timer FechaContrato;
    }
}