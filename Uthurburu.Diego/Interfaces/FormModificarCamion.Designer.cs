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
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epErrores).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Size = new Size(496, 78);
            lblTitulo.Text = "Modificar Camion";
            // 
            // btnGuardar
            // 
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cboMarca
            // 
            cboMarca.DataSource = new eMarcasCamiones[]
    {
    eMarcasCamiones.Seleccionar,
    eMarcasCamiones.Volvo,
    eMarcasCamiones.Scania,
    eMarcasCamiones.MercedesBenzTrucks,
    eMarcasCamiones.MAN,
    eMarcasCamiones.DAF,
    eMarcasCamiones.RenaultTrucks,
    eMarcasCamiones.Iveco,
    eMarcasCamiones.Kenworth,
    eMarcasCamiones.Peterbilt,
    eMarcasCamiones.MackTrucks,
    eMarcasCamiones.InternationalTrucks,
    eMarcasCamiones.Freightliner,
    eMarcasCamiones.WesternStar,
    eMarcasCamiones.Isuzu,
    eMarcasCamiones.Hino,
    eMarcasCamiones.Fuso,
    eMarcasCamiones.FordTrucks,
    eMarcasCamiones.GMC,
    eMarcasCamiones.ChevroletTrucks,
    eMarcasCamiones.RamTrucks
    };
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
            // 
            // FormModificarCamion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 450);
            Name = "FormModificarCamion";
            Text = "Modificar Camion";
            Load += FormModificarCamion_Load;
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)epErrores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}