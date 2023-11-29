namespace Interfaces
{
    partial class FormVerUsuarios
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
            ltsUsuarios = new ListBox();
            lblTitulo = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // ltsUsuarios
            // 
            ltsUsuarios.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ltsUsuarios.FormattingEnabled = true;
            ltsUsuarios.ItemHeight = 16;
            ltsUsuarios.Location = new Point(35, 129);
            ltsUsuarios.Name = "ltsUsuarios";
            ltsUsuarios.Size = new Size(489, 292);
            ltsUsuarios.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Snow;
            lblTitulo.Location = new Point(128, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(271, 65);
            lblTitulo.TabIndex = 9;
            lblTitulo.Text = "WheelsHub";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(128, 86);
            label1.Name = "label1";
            label1.Size = new Size(278, 40);
            label1.TabIndex = 10;
            label1.Text = "Registro de Usuarios";
            // 
            // FormVerUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(561, 455);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Controls.Add(ltsUsuarios);
            Enabled = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormVerUsuarios";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Log Usuarios";
            Load += FormVerUsuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ltsUsuarios;
        protected Label lblTitulo;
        protected Label label1;
    }
}