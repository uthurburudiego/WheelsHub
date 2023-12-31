﻿namespace Interfaces
{
    partial class FormAgregarMoto
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
            ((System.ComponentModel.ISupportInitialize)epErrores).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Size = new Size(403, 78);
            lblTitulo.Text = "Agregar Moto";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(350, 340);
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(496, 340);
            // 
            // txtChasis
            // 
            txtChasis.Location = new Point(350, 153);
            // 
            // cboMarca
            // 
            cboMarca.Location = new Point(554, 153);
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(743, 153);
            // 
            // txtCilindrada
            // 
            txtCilindrada.Location = new Point(350, 232);
            // 
            // cboABS
            // 
            cboABS.Location = new Point(496, 232);
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(653, 232);
            // 
            // cboColor
            // 
            cboColor.DataSource = new eColores[]
    {
    eColores.Seleccionar,
    eColores.Blanco,
    eColores.Negro,
    eColores.Rojo,
    eColores.Azul,
    eColores.Plata,
    eColores.Gris,
    eColores.Verde,
    eColores.Amarillo,
    eColores.Marrón,
    eColores.Naranja
    };
      
            cboColor.Location = new Point(774, 232);
            // 
            // txtTara
            // 
            txtTara.Location = new Point(1045, 508);
            // 
            // txtCantidadEjes
            // 
            txtCantidadEjes.Location = new Point(1191, 508);
            // 
            // txtCantidadPuertas
            // 
            txtCantidadPuertas.Location = new Point(1313, 508);
            // 
            // txtCantidadPasajeros
            // 
            txtCantidadPasajeros.Location = new Point(1469, 508);
            // 
            // picImagen
            // 
            picImagen.Size = new Size(187, 175);
            picImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(80, 340);
            btnExaminar.Click += btnExaminar_Click_1;
            // 
            // lblChasis
            // 
            lblChasis.Location = new Point(350, 130);
            // 
            // lblMarca
            // 
            lblMarca.Location = new Point(554, 130);
            // 
            // lblModelo
            // 
            lblModelo.Location = new Point(743, 130);
            // 
            // lblCilindrada
            // 
            lblCilindrada.Location = new Point(344, 209);
            // 
            // lblABS
            // 
            lblABS.Location = new Point(496, 209);
            // 
            // lblPrecio
            // 
            lblPrecio.Location = new Point(653, 209);
            // 
            // lblColor
            // 
            lblColor.Location = new Point(774, 209);
            // 
            // lblTara
            // 
            lblTara.Location = new Point(1045, 485);
            // 
            // lblEjes
            // 
            lblEjes.Location = new Point(1187, 485);
            // 
            // lblPuertas
            // 
            lblPuertas.Location = new Point(1313, 485);
            // 
            // lblPasajeros
            // 
            lblPasajeros.Location = new Point(1467, 485);
            // 
            // dlgImagen
            // 
            dlgImagen.FileName = "openFileDialog1";
            // 
            // FormAgregarMoto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 450);
            MaximizeBox = false;
            Name = "FormAgregarMoto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar Moto";
            Load += FormAgregarMoto_Load;
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)epErrores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog dlgImagen;
    }
}