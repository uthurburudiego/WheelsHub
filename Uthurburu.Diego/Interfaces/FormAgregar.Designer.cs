namespace Interfaces
{
    public partial class FormAgregar
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
        void InitializeComponent()
        {
            lblTitulo = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtChasis = new TextBox();
            cboMarca = new ComboBox();
            txtModelo = new TextBox();
            txtCilindrada = new TextBox();
            cboABS = new ComboBox();
            txtCosto = new TextBox();
            cboColor = new ComboBox();
            txtTara = new TextBox();
            txtCantidadEjes = new TextBox();
            txtCantidadPuertas = new TextBox();
            txtCantidadPasajeros = new TextBox();
            picImagen = new PictureBox();
            btnExaminar = new Button();
            lblChasis = new Label();
            lblMarca = new Label();
            lblModelo = new Label();
            lblCilindrada = new Label();
            lblABS = new Label();
            lblPrecio = new Label();
            lblColor = new Label();
            lblTara = new Label();
            lblEjes = new Label();
            lblPuertas = new Label();
            lblPasajeros = new Label();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 44.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Snow;
            lblTitulo.Location = new Point(325, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(332, 78);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "WheelsHub";
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.Snow;
            btnGuardar.Location = new Point(659, 383);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(81, 27);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = SystemColors.ButtonFace;
            btnCancelar.Location = new Point(805, 383);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(81, 27);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtChasis
            // 
            txtChasis.Location = new Point(356, 147);
            txtChasis.Name = "txtChasis";
            txtChasis.PlaceholderText = "Ej:A123456BC....";
            txtChasis.Size = new Size(152, 23);
            txtChasis.TabIndex = 10;
            // 
            // cboMarca
            // 
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(560, 147);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(121, 23);
            cboMarca.TabIndex = 11;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(749, 147);
            txtModelo.Name = "txtModelo";
            txtModelo.PlaceholderText = "Modelo";
            txtModelo.Size = new Size(152, 23);
            txtModelo.TabIndex = 12;
            // 
            // txtCilindrada
            // 
            txtCilindrada.Location = new Point(356, 226);
            txtCilindrada.Name = "txtCilindrada";
            txtCilindrada.PlaceholderText = "CC";
            txtCilindrada.Size = new Size(88, 23);
            txtCilindrada.TabIndex = 13;
            // 
            // cboABS
            // 
            cboABS.FormattingEnabled = true;
            cboABS.Location = new Point(502, 226);
            cboABS.Name = "cboABS";
            cboABS.Size = new Size(91, 23);
            cboABS.TabIndex = 14;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(659, 226);
            txtCosto.Name = "txtCosto";
            txtCosto.PlaceholderText = "USD$";
            txtCosto.Size = new Size(88, 23);
            txtCosto.TabIndex = 15;
            // 
            // cboColor
            // 
            cboColor.FormattingEnabled = true;
            cboColor.Location = new Point(780, 226);
            cboColor.Name = "cboColor";
            cboColor.Size = new Size(121, 23);
            cboColor.TabIndex = 16;
            // 
            // txtTara
            // 
            txtTara.ForeColor = SystemColors.MenuText;
            txtTara.Location = new Point(356, 311);
            txtTara.Name = "txtTara";
            txtTara.PlaceholderText = "Ej:1234...";
            txtTara.Size = new Size(88, 23);
            txtTara.TabIndex = 17;
            // 
            // txtCantidadEjes
            // 
            txtCantidadEjes.Location = new Point(502, 311);
            txtCantidadEjes.Name = "txtCantidadEjes";
            txtCantidadEjes.PlaceholderText = "Ej:1234...";
            txtCantidadEjes.Size = new Size(88, 23);
            txtCantidadEjes.TabIndex = 18;
            // 
            // txtCantidadPuertas
            // 
            txtCantidadPuertas.Location = new Point(624, 311);
            txtCantidadPuertas.Name = "txtCantidadPuertas";
            txtCantidadPuertas.PlaceholderText = "Ej:1234...";
            txtCantidadPuertas.Size = new Size(74, 23);
            txtCantidadPuertas.TabIndex = 19;
            // 
            // txtCantidadPasajeros
            // 
            txtCantidadPasajeros.Location = new Point(780, 311);
            txtCantidadPasajeros.Name = "txtCantidadPasajeros";
            txtCantidadPasajeros.PlaceholderText = "Ej:1234...";
            txtCantidadPasajeros.Size = new Size(75, 23);
            txtCantidadPasajeros.TabIndex = 20;
            // 
            // picImagen
            // 
            picImagen.BackColor = Color.Gray;
            picImagen.Location = new Point(80, 147);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(187, 209);
            picImagen.TabIndex = 21;
            picImagen.TabStop = false;
            // 
            // btnExaminar
            // 
            btnExaminar.FlatStyle = FlatStyle.Flat;
            btnExaminar.ForeColor = Color.Snow;
            btnExaminar.Location = new Point(80, 383);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(187, 27);
            btnExaminar.TabIndex = 22;
            btnExaminar.Text = "Examinar...";
            btnExaminar.UseVisualStyleBackColor = true;

            // 
            // lblChasis
            // 
            lblChasis.AutoSize = true;
            lblChasis.BackColor = Color.Transparent;
            lblChasis.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblChasis.ForeColor = Color.White;
            lblChasis.Location = new Point(356, 124);
            lblChasis.Name = "lblChasis";
            lblChasis.Size = new Size(113, 20);
            lblChasis.TabIndex = 23;
            lblChasis.Text = "N° de chasis:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.BackColor = Color.Transparent;
            lblMarca.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMarca.ForeColor = Color.White;
            lblMarca.Location = new Point(560, 124);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(63, 20);
            lblMarca.TabIndex = 24;
            lblMarca.Text = "Marca:";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.BackColor = Color.Transparent;
            lblModelo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblModelo.ForeColor = Color.White;
            lblModelo.Location = new Point(749, 124);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(72, 20);
            lblModelo.TabIndex = 25;
            lblModelo.Text = "Modelo:";
            // 
            // lblCilindrada
            // 
            lblCilindrada.AutoSize = true;
            lblCilindrada.BackColor = Color.Transparent;
            lblCilindrada.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCilindrada.ForeColor = Color.White;
            lblCilindrada.Location = new Point(350, 203);
            lblCilindrada.Name = "lblCilindrada";
            lblCilindrada.Size = new Size(94, 20);
            lblCilindrada.TabIndex = 26;
            lblCilindrada.Text = "Cilindrada:";
            // 
            // lblABS
            // 
            lblABS.AutoSize = true;
            lblABS.BackColor = Color.Transparent;
            lblABS.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblABS.ForeColor = Color.White;
            lblABS.Location = new Point(502, 203);
            lblABS.Name = "lblABS";
            lblABS.Size = new Size(91, 20);
            lblABS.TabIndex = 27;
            lblABS.Text = "Sist. ABS:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecio.ForeColor = Color.White;
            lblPrecio.Location = new Point(659, 203);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(64, 20);
            lblPrecio.TabIndex = 28;
            lblPrecio.Text = "Precio:";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.BackColor = Color.Transparent;
            lblColor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblColor.ForeColor = Color.White;
            lblColor.Location = new Point(780, 203);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(56, 20);
            lblColor.TabIndex = 29;
            lblColor.Text = "Color:";
            // 
            // lblTara
            // 
            lblTara.AutoSize = true;
            lblTara.BackColor = Color.Transparent;
            lblTara.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTara.ForeColor = Color.White;
            lblTara.Location = new Point(356, 288);
            lblTara.Name = "lblTara";
            lblTara.Size = new Size(50, 20);
            lblTara.TabIndex = 30;
            lblTara.Text = "Tara:";
            // 
            // lblEjes
            // 
            lblEjes.AutoSize = true;
            lblEjes.BackColor = Color.Transparent;
            lblEjes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEjes.ForeColor = Color.White;
            lblEjes.Location = new Point(498, 288);
            lblEjes.Name = "lblEjes";
            lblEjes.Size = new Size(95, 20);
            lblEjes.TabIndex = 31;
            lblEjes.Text = "Cant. ejes:";
            // 
            // lblPuertas
            // 
            lblPuertas.AutoSize = true;
            lblPuertas.BackColor = Color.Transparent;
            lblPuertas.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPuertas.ForeColor = Color.White;
            lblPuertas.Location = new Point(624, 288);
            lblPuertas.Name = "lblPuertas";
            lblPuertas.Size = new Size(123, 20);
            lblPuertas.TabIndex = 32;
            lblPuertas.Text = "Cant. puertas:";
            // 
            // lblPasajeros
            // 
            lblPasajeros.AutoSize = true;
            lblPasajeros.BackColor = Color.Transparent;
            lblPasajeros.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPasajeros.ForeColor = Color.White;
            lblPasajeros.Location = new Point(778, 288);
            lblPasajeros.Name = "lblPasajeros";
            lblPasajeros.Size = new Size(140, 20);
            lblPasajeros.TabIndex = 33;
            lblPasajeros.Text = "Cant. pasajeros:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1004, 450);
            Controls.Add(lblPasajeros);
            Controls.Add(lblPuertas);
            Controls.Add(lblEjes);
            Controls.Add(lblTara);
            Controls.Add(lblColor);
            Controls.Add(lblPrecio);
            Controls.Add(lblABS);
            Controls.Add(lblCilindrada);
            Controls.Add(lblModelo);
            Controls.Add(lblMarca);
            Controls.Add(lblChasis);
            Controls.Add(btnExaminar);
            Controls.Add(picImagen);
            Controls.Add(txtCantidadPasajeros);
            Controls.Add(txtCantidadPuertas);
            Controls.Add(txtCantidadEjes);
            Controls.Add(txtTara);
            Controls.Add(cboColor);
            Controls.Add(txtCosto);
            Controls.Add(cboABS);
            Controls.Add(txtCilindrada);
            Controls.Add(txtModelo);
            Controls.Add(cboMarca);
            Controls.Add(txtChasis);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(lblTitulo);
            Name = "FormAgregar";
            Text = "FormAgregar";
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected Label lblTitulo;
        protected Button btnGuardar;
        protected Button btnCancelar;
        protected TextBox txtChasis;
        protected ComboBox cboMarca;
        protected TextBox txtModelo;
        protected TextBox txtCilindrada;
        protected ComboBox cboABS;
        protected TextBox txtCosto;
        protected ComboBox cboColor;
        protected TextBox txtTara;
        protected TextBox txtCantidadEjes;
        protected TextBox txtCantidadPuertas;
        protected TextBox txtCantidadPasajeros;
        protected PictureBox picImagen;
        public Button btnExaminar;
        protected Label lblChasis;
        protected Label lblMarca;
        protected Label lblModelo;
        protected Label lblCilindrada;
        protected Label lblABS;
        protected Label lblPrecio;
        protected Label lblColor;
        protected Label lblTara;
        protected Label lblEjes;
        protected Label lblPuertas;
        protected Label lblPasajeros;
        private OpenFileDialog openFileDialog1;
    }
}