namespace ManaosMarket
{
    partial class FrmGenerarCarnet
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFechaCarnet = new System.Windows.Forms.DateTimePicker();
            this.lblFEcha = new System.Windows.Forms.Label();
            this.btnAceptar = new ManaosMarket.RadioButon();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ManaosMarket.Properties.Resources.CARNET_EMPLEADO;
            this.panel1.Controls.Add(this.dtpFechaCarnet);
            this.panel1.Controls.Add(this.lblFEcha);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 521);
            this.panel1.TabIndex = 0;
            // 
            // dtpFechaCarnet
            // 
            this.dtpFechaCarnet.CustomFormat = "";
            this.dtpFechaCarnet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCarnet.Location = new System.Drawing.Point(181, 307);
            this.dtpFechaCarnet.Name = "dtpFechaCarnet";
            this.dtpFechaCarnet.Size = new System.Drawing.Size(119, 20);
            this.dtpFechaCarnet.TabIndex = 9;
            // 
            // lblFEcha
            // 
            this.lblFEcha.AutoSize = true;
            this.lblFEcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFEcha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(106)))), ((int)(((byte)(202)))));
            this.lblFEcha.Location = new System.Drawing.Point(82, 309);
            this.lblFEcha.Name = "lblFEcha";
            this.lblFEcha.Size = new System.Drawing.Size(63, 18);
            this.lblFEcha.TabIndex = 8;
            this.lblFEcha.Text = "FECHA";
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
            this.btnAceptar.Location = new System.Drawing.Point(354, 484);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(91, 34);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(106)))), ((int)(((byte)(202)))));
            this.lblNombre.Location = new System.Drawing.Point(82, 342);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(264, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "JOSE LINDER CASAS MARTINEZ";
            // 
            // FrmGenerarCarnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(445, 521);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGenerarCarnet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGenerarCarnet";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombre;
        private RadioButon btnAceptar;
        private System.Windows.Forms.Label lblFEcha;
        private System.Windows.Forms.DateTimePicker dtpFechaCarnet;
    }
}