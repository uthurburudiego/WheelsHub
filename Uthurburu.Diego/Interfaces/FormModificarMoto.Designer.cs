namespace Interfaces
{
    partial class FormModificarMoto
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
            lblTitulo.Size = new Size(439, 78);
            lblTitulo.Text = "Modificar Moto";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(356, 335);
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(502, 335);
            // 
            // txtTara
            // 
            txtTara.Location = new Point(937, 458);
            // 
            // txtCantidadEjes
            // 
            txtCantidadEjes.Location = new Point(1083, 458);
            // 
            // txtCantidadPuertas
            // 
            txtCantidadPuertas.Location = new Point(1205, 458);
            // 
            // txtCantidadPasajeros
            // 
            txtCantidadPasajeros.Location = new Point(1361, 458);
            // 
            // picImagen
            // 
            picImagen.Location = new Point(38, 124);
            picImagen.Size = new Size(240, 186);
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(62, 335);
            // 
            // lblTara
            // 
            lblTara.Location = new Point(937, 435);
            // 
            // lblEjes
            // 
            lblEjes.Location = new Point(1079, 435);
            // 
            // lblPuertas
            // 
            lblPuertas.Location = new Point(1205, 435);
            // 
            // lblPasajeros
            // 
            lblPasajeros.Location = new Point(1359, 435);
            // 
            // dlgImagen
            // 
            dlgImagen.FileName = "openFileDialog1";
            // 
            // FormModificarMoto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 411);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormModificarMoto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormModificarMoto";
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog dlgImagen;
    }
}