namespace Interfaces
{
    partial class FormMostrar
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
            openFileDialog1 = new OpenFileDialog();
            picImagen = new PictureBox();
            btnSalir = new Button();
            lblTitulo = new Label();
            lblMarcaModelo = new Label();
            lblInformacion = new Label();
            lblDrescripcion = new Label();
            lblMantenimieto = new Label();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // picImagen
            // 
            picImagen.BackColor = Color.Gray;
            picImagen.Location = new Point(54, 221);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(386, 224);
            picImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            picImagen.TabIndex = 0;
            picImagen.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(881, 616);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(117, 30);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 44.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Snow;
            lblTitulo.Location = new Point(333, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(332, 78);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "WheelsHub";
            // 
            // lblMarcaModelo
            // 
            lblMarcaModelo.AutoSize = true;
            lblMarcaModelo.BackColor = Color.Transparent;
            lblMarcaModelo.Font = new Font("Segoe UI", 44.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarcaModelo.ForeColor = Color.Snow;
            lblMarcaModelo.Location = new Point(305, 115);
            lblMarcaModelo.Name = "lblMarcaModelo";
            lblMarcaModelo.Size = new Size(413, 78);
            lblMarcaModelo.TabIndex = 9;
            lblMarcaModelo.Text = "Marca Modelo";
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.BackColor = Color.Transparent;
            lblInformacion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInformacion.ForeColor = Color.Snow;
            lblInformacion.Location = new Point(530, 221);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(148, 30);
            lblInformacion.TabIndex = 10;
            lblInformacion.Text = "Marca Modelo";
            // 
            // lblDrescripcion
            // 
            lblDrescripcion.AutoSize = true;
            lblDrescripcion.BackColor = Color.Transparent;
            lblDrescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDrescripcion.ForeColor = Color.Snow;
            lblDrescripcion.Location = new Point(54, 490);
            lblDrescripcion.Name = "lblDrescripcion";
            lblDrescripcion.Size = new Size(91, 21);
            lblDrescripcion.TabIndex = 11;
            lblDrescripcion.Text = "Descripcion";
            // 
            // lblMantenimieto
            // 
            lblMantenimieto.AutoSize = true;
            lblMantenimieto.BackColor = Color.Transparent;
            lblMantenimieto.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMantenimieto.ForeColor = Color.Snow;
            lblMantenimieto.Location = new Point(772, 221);
            lblMantenimieto.Name = "lblMantenimieto";
            lblMantenimieto.Size = new Size(253, 30);
            lblMantenimieto.TabIndex = 12;
            lblMantenimieto.Text = "Costo de mantenimiento: ";
            // 
            // FormMostrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1064, 681);
            Controls.Add(lblMantenimieto);
            Controls.Add(lblDrescripcion);
            Controls.Add(lblInformacion);
            Controls.Add(lblMarcaModelo);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Controls.Add(picImagen);
            Name = "FormMostrar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormMostrar";
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private PictureBox picImagen;
        private Button btnSalir;
        protected Label lblTitulo;
        protected Label lblMarcaModelo;
        protected Label lblInformacion;
        protected Label lblDrescripcion;
        protected Label lblMantenimieto;
    }
}