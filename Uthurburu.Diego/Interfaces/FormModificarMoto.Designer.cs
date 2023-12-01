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
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epErrores).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Size = new Size(439, 78);
            lblTitulo.Text = "Modificar Moto";
            // 
            // btnGuardar
            // 
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cboMarca
            // 
            cboMarca.DataSource = new eMarcasMotos[]
    {
    eMarcasMotos.Seleccionar,
    eMarcasMotos.HarleyDavidson,
    eMarcasMotos.Honda,
    eMarcasMotos.Yamaha,
    eMarcasMotos.Kawasaki,
    eMarcasMotos.Suzuki,
    eMarcasMotos.Ducati,
    eMarcasMotos.BMWMotorrad,
    eMarcasMotos.KTM,
    eMarcasMotos.Triumph,
    eMarcasMotos.Aprilia,
    eMarcasMotos.MotoGuzzi,
    eMarcasMotos.Husqvarna,
    eMarcasMotos.RoyalEnfield,
    eMarcasMotos.IndianMotorcycle,
    eMarcasMotos.MVAgusta,
    eMarcasMotos.Vespa,
    eMarcasMotos.Piaggio,
    eMarcasMotos.Norton,
    eMarcasMotos.Bajaj,
    eMarcasMotos.ZeroMotorcycles
    };
            // 
            // cboABS
            // 
            cboABS.DataSource = new eTipoDeFrenos[]
    {
    eTipoDeFrenos.Seleccionar,
    eTipoDeFrenos.Si,
    eTipoDeFrenos.No
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
            // picImagen
            // 
            picImagen.Location = new Point(27, 130);
            picImagen.Size = new Size(268, 192);
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(70, 340);
            // 
            // FormModificarMoto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 450);
            Name = "FormModificarMoto";
            Text = "Modificar Moto";
            Load += FormModificarMoto_Load;
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)epErrores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}