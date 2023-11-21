namespace Interfaces
{
    partial class FormModificarCamion
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
            lblTitulo.Size = new Size(496, 78);
            lblTitulo.Text = "Modificar Camion";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(351, 339);
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(497, 339);
            // 
            // txtChasis
            // 
            txtChasis.Location = new Point(341, 147);
            // 
            // cboMarca
            // 
            cboMarca.Location = new Point(545, 147);
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(734, 147);
            // 
            // txtCilindrada
            // 
            txtCilindrada.Location = new Point(949, 524);
            // 
            // cboABS
            // 
            cboABS.Location = new Point(1095, 524);
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(644, 226);
            // 
            // cboColor
            // 
            cboColor.Location = new Point(765, 226);
            // 
            // txtTara
            // 
            txtTara.Location = new Point(340, 226);
            // 
            // txtCantidadEjes
            // 
            txtCantidadEjes.Location = new Point(486, 226);
            // 
            // txtCantidadPuertas
            // 
            txtCantidadPuertas.Location = new Point(942, 464);
            // 
            // txtCantidadPasajeros
            // 
            txtCantidadPasajeros.Location = new Point(1098, 464);
            // 
            // picImagen
            // 
            picImagen.Location = new Point(26, 124);
            picImagen.Size = new Size(255, 193);
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(56, 339);
            btnExaminar.Click += btnExaminar_Click;
            // 
            // lblChasis
            // 
            lblChasis.Location = new Point(341, 124);
            // 
            // lblMarca
            // 
            lblMarca.Location = new Point(545, 124);
            // 
            // lblModelo
            // 
            lblModelo.Location = new Point(734, 124);
            // 
            // lblCilindrada
            // 
            lblCilindrada.Location = new Point(943, 501);
            // 
            // lblABS
            // 
            lblABS.Location = new Point(1095, 501);
            // 
            // lblPrecio
            // 
            lblPrecio.Location = new Point(644, 203);
            // 
            // lblColor
            // 
            lblColor.Location = new Point(765, 203);
            // 
            // lblTara
            // 
            lblTara.Location = new Point(340, 203);
            // 
            // lblEjes
            // 
            lblEjes.Location = new Point(482, 203);
            // 
            // lblPuertas
            // 
            lblPuertas.Location = new Point(942, 441);
            // 
            // lblPasajeros
            // 
            lblPasajeros.Location = new Point(1096, 441);
            // 
            // dlgImagen
            // 
            dlgImagen.FileName = "openFileDialog1";
            // 
            // FormModificarCamion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 450);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormModificarCamion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormModificarCamioncs";
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog dlgImagen;
    }
}