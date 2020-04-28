namespace TP2_Dominguez
{
    partial class VentanaDetalles
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
            this.txtVDNombre = new System.Windows.Forms.TextBox();
            this.txtVDPrecio = new System.Windows.Forms.TextBox();
            this.txtVDCategoria = new System.Windows.Forms.TextBox();
            this.txtVDMarca = new System.Windows.Forms.TextBox();
            this.txtVDDescripcion = new System.Windows.Forms.TextBox();
            this.txtVDCodArt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picVDImagenURL = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picVDImagenURL)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVDNombre
            // 
            this.txtVDNombre.Location = new System.Drawing.Point(176, 111);
            this.txtVDNombre.Name = "txtVDNombre";
            this.txtVDNombre.ReadOnly = true;
            this.txtVDNombre.Size = new System.Drawing.Size(268, 31);
            this.txtVDNombre.TabIndex = 0;
            // 
            // txtVDPrecio
            // 
            this.txtVDPrecio.Location = new System.Drawing.Point(176, 335);
            this.txtVDPrecio.Name = "txtVDPrecio";
            this.txtVDPrecio.ReadOnly = true;
            this.txtVDPrecio.Size = new System.Drawing.Size(161, 31);
            this.txtVDPrecio.TabIndex = 1;
            // 
            // txtVDCategoria
            // 
            this.txtVDCategoria.Location = new System.Drawing.Point(176, 279);
            this.txtVDCategoria.Name = "txtVDCategoria";
            this.txtVDCategoria.ReadOnly = true;
            this.txtVDCategoria.Size = new System.Drawing.Size(268, 31);
            this.txtVDCategoria.TabIndex = 2;
            // 
            // txtVDMarca
            // 
            this.txtVDMarca.Location = new System.Drawing.Point(176, 223);
            this.txtVDMarca.Name = "txtVDMarca";
            this.txtVDMarca.ReadOnly = true;
            this.txtVDMarca.Size = new System.Drawing.Size(268, 31);
            this.txtVDMarca.TabIndex = 3;
            // 
            // txtVDDescripcion
            // 
            this.txtVDDescripcion.Location = new System.Drawing.Point(176, 167);
            this.txtVDDescripcion.Name = "txtVDDescripcion";
            this.txtVDDescripcion.ReadOnly = true;
            this.txtVDDescripcion.Size = new System.Drawing.Size(268, 31);
            this.txtVDDescripcion.TabIndex = 4;
            // 
            // txtVDCodArt
            // 
            this.txtVDCodArt.Location = new System.Drawing.Point(176, 55);
            this.txtVDCodArt.Name = "txtVDCodArt";
            this.txtVDCodArt.ReadOnly = true;
            this.txtVDCodArt.Size = new System.Drawing.Size(161, 31);
            this.txtVDCodArt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "COD. ART.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "DESCRIPCION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "MARCA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "CATEGORIA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "PRECIO";
            // 
            // picVDImagenURL
            // 
            this.picVDImagenURL.Location = new System.Drawing.Point(472, 33);
            this.picVDImagenURL.Name = "picVDImagenURL";
            this.picVDImagenURL.Size = new System.Drawing.Size(350, 350);
            this.picVDImagenURL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVDImagenURL.TabIndex = 12;
            this.picVDImagenURL.TabStop = false;
            this.picVDImagenURL.Click += new System.EventHandler(this.picVDImagenURL_Click);
            // 
            // VentanaDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(857, 412);
            this.Controls.Add(this.picVDImagenURL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVDCodArt);
            this.Controls.Add(this.txtVDDescripcion);
            this.Controls.Add(this.txtVDMarca);
            this.Controls.Add(this.txtVDCategoria);
            this.Controls.Add(this.txtVDPrecio);
            this.Controls.Add(this.txtVDNombre);
            this.Name = "VentanaDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaDetalles";
            this.Load += new System.EventHandler(this.VentanaDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picVDImagenURL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtVDPrecio;
        public System.Windows.Forms.TextBox txtVDCategoria;
        public System.Windows.Forms.TextBox txtVDMarca;
        public System.Windows.Forms.TextBox txtVDDescripcion;
        public System.Windows.Forms.TextBox txtVDCodArt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.PictureBox picVDImagenURL;
        public System.Windows.Forms.TextBox txtVDNombre;
    }
}