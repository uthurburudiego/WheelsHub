namespace Interfaces
{
    partial class FormLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            chkVer = new CheckBox();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(304, 182);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese usuario";
            txtUsuario.Size = new Size(182, 33);
            txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(304, 251);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PlaceholderText = "Ingrese contraseña";
            txtContraseña.Size = new Size(182, 33);
            txtContraseña.TabIndex = 3;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // btnAceptar
            // 
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.ForeColor = Color.Snow;
            btnAceptar.Location = new Point(304, 313);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(81, 27);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = SystemColors.ButtonFace;
            btnCancelar.Location = new Point(405, 313);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(81, 27);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 44.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(259, 58);
            label1.Name = "label1";
            label1.Size = new Size(332, 78);
            label1.TabIndex = 0;
            label1.Text = "WheelsHub";
            // 
            // chkVer
            // 
            chkVer.AutoSize = true;
            chkVer.ForeColor = SystemColors.ButtonHighlight;
            chkVer.Location = new Point(492, 261);
            chkVer.Name = "chkVer";
            chkVer.Size = new Size(42, 19);
            chkVer.TabIndex = 4;
            chkVer.Text = "Ver";
            chkVer.UseVisualStyleBackColor = true;
            chkVer.CheckedChanged += chkVer_CheckedChanged;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(chkVer);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label1;
        private CheckBox chkVer;
    }
}