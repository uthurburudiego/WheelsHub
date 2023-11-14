namespace Interfaces
{
    partial class Agregar
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
            label1 = new Label();
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 44.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(325, 23);
            label1.Name = "label1";
            label1.Size = new Size(332, 78);
            label1.TabIndex = 7;
            label1.Text = "WheelsHub";
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
            picImagen.Location = new Point(84, 147);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(187, 209);
            picImagen.TabIndex = 21;
            picImagen.TabStop = false;
            // 
            // btnExaminar
            // 
            btnExaminar.FlatStyle = FlatStyle.Flat;
            btnExaminar.ForeColor = Color.Snow;
            btnExaminar.Location = new Point(84, 383);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(187, 27);
            btnExaminar.TabIndex = 22;
            btnExaminar.Text = "Examinar...";
            btnExaminar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(356, 124);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 23;
            label2.Text = "N° de chasis:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(560, 124);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 24;
            label3.Text = "Marca:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(749, 124);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 25;
            label4.Text = "Modelo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(350, 203);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 26;
            label5.Text = "Cilindrada:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(502, 203);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 27;
            label6.Text = "Sist. ABS:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(659, 203);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 28;
            label7.Text = "Precio:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(780, 203);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 29;
            label8.Text = "Color:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(356, 288);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 30;
            label9.Text = "Tara:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(498, 288);
            label10.Name = "label10";
            label10.Size = new Size(95, 20);
            label10.TabIndex = 31;
            label10.Text = "Cant. ejes:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(624, 288);
            label11.Name = "label11";
            label11.Size = new Size(123, 20);
            label11.TabIndex = 32;
            label11.Text = "Cant. puertas:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(778, 288);
            label12.Name = "label12";
            label12.Size = new Size(140, 20);
            label12.TabIndex = 33;
            label12.Text = "Cant. pasajeros:";
            // 
            // Agregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(953, 483);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
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
            Controls.Add(label1);
            Name = "Agregar";
            Text = "FormAgregar";
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtChasis;
        private ComboBox cboMarca;
        private TextBox txtModelo;
        private TextBox txtCilindrada;
        private ComboBox cboABS;
        private TextBox txtCosto;
        private ComboBox cboColor;
        private TextBox txtTara;
        private TextBox txtCantidadEjes;
        private TextBox txtCantidadPuertas;
        private TextBox txtCantidadPasajeros;
        private PictureBox picImagen;
        private Button btnExaminar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}