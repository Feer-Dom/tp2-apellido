namespace TP2_Dominguez
{
    partial class VentanaAMArticulo
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVAMCodArt = new System.Windows.Forms.TextBox();
            this.txtVAMDescripcion = new System.Windows.Forms.TextBox();
            this.txtVAMPrecio = new System.Windows.Forms.TextBox();
            this.txtVAMNombre = new System.Windows.Forms.TextBox();
            this.cboVAMMarca = new System.Windows.Forms.ComboBox();
            this.cboVAMCategoria = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVAMImagenURL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(461, 465);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 65);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "PRECIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "CATEGORIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "MARCA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "DESCRIPCION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "COD. ART.";
            // 
            // txtVAMCodArt
            // 
            this.txtVAMCodArt.Location = new System.Drawing.Point(202, 64);
            this.txtVAMCodArt.Name = "txtVAMCodArt";
            this.txtVAMCodArt.Size = new System.Drawing.Size(377, 31);
            this.txtVAMCodArt.TabIndex = 0;
            // 
            // txtVAMDescripcion
            // 
            this.txtVAMDescripcion.Location = new System.Drawing.Point(202, 176);
            this.txtVAMDescripcion.Name = "txtVAMDescripcion";
            this.txtVAMDescripcion.Size = new System.Drawing.Size(484, 31);
            this.txtVAMDescripcion.TabIndex = 2;
            // 
            // txtVAMPrecio
            // 
            this.txtVAMPrecio.Location = new System.Drawing.Point(202, 347);
            this.txtVAMPrecio.Name = "txtVAMPrecio";
            this.txtVAMPrecio.Size = new System.Drawing.Size(377, 31);
            this.txtVAMPrecio.TabIndex = 5;
            this.txtVAMPrecio.Text = "0,00";
            this.txtVAMPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVAMPrecio_KeyPress);
            // 
            // txtVAMNombre
            // 
            this.txtVAMNombre.Location = new System.Drawing.Point(202, 120);
            this.txtVAMNombre.Name = "txtVAMNombre";
            this.txtVAMNombre.Size = new System.Drawing.Size(484, 31);
            this.txtVAMNombre.TabIndex = 1;
            // 
            // cboVAMMarca
            // 
            this.cboVAMMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVAMMarca.FormattingEnabled = true;
            this.cboVAMMarca.Location = new System.Drawing.Point(202, 234);
            this.cboVAMMarca.Name = "cboVAMMarca";
            this.cboVAMMarca.Size = new System.Drawing.Size(484, 33);
            this.cboVAMMarca.TabIndex = 3;
            // 
            // cboVAMCategoria
            // 
            this.cboVAMCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVAMCategoria.FormattingEnabled = true;
            this.cboVAMCategoria.Location = new System.Drawing.Point(202, 292);
            this.cboVAMCategoria.Name = "cboVAMCategoria";
            this.cboVAMCategoria.Size = new System.Drawing.Size(484, 33);
            this.cboVAMCategoria.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(139, 465);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 65);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "IMAGEN URL";
            // 
            // txtVAMImagenURL
            // 
            this.txtVAMImagenURL.Location = new System.Drawing.Point(202, 404);
            this.txtVAMImagenURL.Name = "txtVAMImagenURL";
            this.txtVAMImagenURL.Size = new System.Drawing.Size(377, 31);
            this.txtVAMImagenURL.TabIndex = 6;
            // 
            // VentanaAMArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(722, 568);
            this.Controls.Add(this.txtVAMImagenURL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboVAMCategoria);
            this.Controls.Add(this.cboVAMMarca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVAMCodArt);
            this.Controls.Add(this.txtVAMDescripcion);
            this.Controls.Add(this.txtVAMPrecio);
            this.Controls.Add(this.txtVAMNombre);
            this.Controls.Add(this.btnCancelar);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "VentanaAMArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NUEVO ARTICULO";
            this.Load += new System.EventHandler(this.VentanaAMArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtVAMCodArt;
        public System.Windows.Forms.TextBox txtVAMDescripcion;
        public System.Windows.Forms.TextBox txtVAMPrecio;
        public System.Windows.Forms.TextBox txtVAMNombre;
        private System.Windows.Forms.ComboBox cboVAMMarca;
        private System.Windows.Forms.ComboBox cboVAMCategoria;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtVAMImagenURL;
    }
}