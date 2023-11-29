namespace Interfaces
{
    partial class FormAgregarCamion
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
            lblTitulo.Size = new Size(460, 78);
            lblTitulo.Text = "Agregar Camion";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(363, 337);
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(505, 337);
            // 
            // cboMarca
            // 
            cboMarca.Size = new Size(163, 23);
            // 
            // txtCilindrada
            // 
            txtCilindrada.Location = new Point(1074, 509);
            // 
            // cboABS
            // 
            cboABS.Location = new Point(1220, 509);
            // 
            // cboColor
            // 
            cboColor.Items.AddRange(new object[] { eColores.Seleccionar, eColores.Blanco, eColores.Negro, eColores.Rojo, eColores.Azul, eColores.Plata, eColores.Gris, eColores.Verde, eColores.Amarillo, eColores.Marrón, eColores.Naranja });
            // 
            // txtTara
            // 
            txtTara.Location = new Point(363, 226);
            // 
            // txtCantidadEjes
            // 
            txtCantidadEjes.Location = new Point(509, 226);
            // 
            // txtCantidadPuertas
            // 
            txtCantidadPuertas.Location = new Point(1337, 509);
            // 
            // txtCantidadPasajeros
            // 
            txtCantidadPasajeros.Location = new Point(1493, 509);
            // 
            // picImagen
            // 
            picImagen.Location = new Point(77, 124);
            picImagen.Size = new Size(187, 185);
            picImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(79, 337);
            btnExaminar.Click += btnExaminar_Click_1;
            // 
            // lblCilindrada
            // 
            lblCilindrada.Location = new Point(1068, 486);
            // 
            // lblABS
            // 
            lblABS.Location = new Point(1220, 486);
            // 
            // lblTara
            // 
            lblTara.Location = new Point(363, 203);
            // 
            // lblEjes
            // 
            lblEjes.Location = new Point(505, 203);
            // 
            // lblPuertas
            // 
            lblPuertas.Location = new Point(1337, 486);
            // 
            // lblPasajeros
            // 
            lblPasajeros.Location = new Point(1491, 486);
            // 
            // dlgImagen
            // 
            dlgImagen.FileName = "openFileDialog1";
            // 
            // FormAgregarCamion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 450);
            MaximizeBox = false;
            Name = "FormAgregarCamion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar Camion";
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog dlgImagen;
    }
}