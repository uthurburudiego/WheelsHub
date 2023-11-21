namespace Interfaces
{
    partial class FormAgregarAuto
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
            dlgImagen = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Size = new Size(386, 78);
            lblTitulo.Text = "Agregar Auto";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(340, 351);
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(486, 351);
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtChasis
            // 
            txtChasis.Location = new Point(340, 168);
            // 
            // cboMarca
            // 
            cboMarca.AccessibleRole = AccessibleRole.Clock;
            cboMarca.Location = new Point(544, 168);
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(733, 168);
            // 
            // txtCilindrada
            // 
            txtCilindrada.Location = new Point(1113, 544);
            // 
            // cboABS
            // 
            cboABS.Location = new Point(1259, 544);
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(643, 247);
            // 
            // cboColor
            // 
            cboColor.Items.AddRange(new object[] { eColores.Seleccionar, eColores.Blanco, eColores.Negro, eColores.Rojo, eColores.Azul, eColores.Plata, eColores.Gris, eColores.Verde, eColores.Amarillo, eColores.Marrón, eColores.Naranja });
            cboColor.Location = new Point(764, 247);
            // 
            // txtTara
            // 
            txtTara.Location = new Point(1113, 640);
            // 
            // txtCantidadEjes
            // 
            txtCantidadEjes.Location = new Point(1259, 629);
            // 
            // txtCantidadPuertas
            // 
            txtCantidadPuertas.Location = new Point(340, 247);
            // 
            // txtCantidadPasajeros
            // 
            txtCantidadPasajeros.Location = new Point(486, 247);
            // 
            // picImagen
            // 
            picImagen.Size = new Size(187, 185);
            picImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(80, 351);
            btnExaminar.Click += btnExaminar_Click_1;
            // 
            // lblChasis
            // 
            lblChasis.Location = new Point(340, 145);
            // 
            // lblMarca
            // 
            lblMarca.Location = new Point(544, 145);
            // 
            // lblModelo
            // 
            lblModelo.Location = new Point(733, 145);
            // 
            // lblCilindrada
            // 
            lblCilindrada.Location = new Point(1107, 521);
            // 
            // lblABS
            // 
            lblABS.Location = new Point(1259, 521);
            // 
            // lblPrecio
            // 
            lblPrecio.Location = new Point(643, 224);
            // 
            // lblColor
            // 
            lblColor.Location = new Point(764, 224);
            // 
            // lblTara
            // 
            lblTara.Location = new Point(1113, 606);
            // 
            // lblEjes
            // 
            lblEjes.Location = new Point(1255, 606);
            // 
            // lblPuertas
            // 
            lblPuertas.Location = new Point(340, 224);
            // 
            // lblPasajeros
            // 
            lblPasajeros.Location = new Point(484, 224);
            // 
            // dlgImagen
            // 
            dlgImagen.FileName = "openFileDialog1";
            // 
            // FormAgregarAuto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 450);
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAgregarAuto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar Auto";
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog dlgImagen;
    }
}