﻿namespace Interfaces
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
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // FormModificarCamion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 450);
            Name = "FormModificarCamion";
            Text = "FormModificarCamion";
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}