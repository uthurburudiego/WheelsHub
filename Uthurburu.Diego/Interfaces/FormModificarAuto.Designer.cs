namespace Interfaces
{
    partial class FormModificarAuto
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
            lblTitulo.Size = new Size(422, 78);
            lblTitulo.Text = "Modificar Auto";
            // 
            // btnGuardar
            // 
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cboMarca
            // 
            cboMarca.DataSource = new eMarcasAutos[]
    {
    eMarcasAutos.Seleccionar,
    eMarcasAutos.Toyota,
    eMarcasAutos.Honda,
    eMarcasAutos.Ford,
    eMarcasAutos.Chevrolet,
    eMarcasAutos.Volkswagen,
    eMarcasAutos.BMW,
    eMarcasAutos.MercedesBenz,
    eMarcasAutos.Audi,
    eMarcasAutos.Nissan,
    eMarcasAutos.Hyundai,
    eMarcasAutos.Kia,
    eMarcasAutos.Subaru,
    eMarcasAutos.Tesla,
    eMarcasAutos.Jaguar,
    eMarcasAutos.Ferrari,
    eMarcasAutos.Fiat,
    eMarcasAutos.Lamborghini,
    eMarcasAutos.Porsche,
    eMarcasAutos.AstonMartin,
    eMarcasAutos.Jeep,
    eMarcasAutos.LandRover
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
            // FormModificarAuto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 450);
            Name = "FormModificarAuto";
            Text = "Modificar Auto";
            Load += FormModificarAuto_Load;
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)epErrores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}