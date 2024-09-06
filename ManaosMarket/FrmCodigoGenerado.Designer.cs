namespace ManaosMarket
{
    partial class FrmCodigoGenerado
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new CustomControls.RJControls.RJTextBox();
            this.btnAceptar = new ManaosMarket.RadioButon();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 71;
            this.label1.Text = "CODIGO GENERADO";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.txtCodigo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCodigo.BorderSize = 3;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(106)))), ((int)(((byte)(203)))));
            this.txtCodigo.Location = new System.Drawing.Point(13, 42);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodigo.PasswordChar = false;
            this.txtCodigo.Size = new System.Drawing.Size(250, 47);
            this.txtCodigo.TabIndex = 71;
            this.txtCodigo.Texts = "                       ";
            this.txtCodigo.UnderlinedStyle = false;
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
            this.btnAceptar.Location = new System.Drawing.Point(88, 96);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(108, 39);
            this.btnAceptar.TabIndex = 72;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FrmCodigoGenerado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(282, 141);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCodigoGenerado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCodigoGenerado";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox txtCodigo;
        private RadioButon btnAceptar;
    }
}