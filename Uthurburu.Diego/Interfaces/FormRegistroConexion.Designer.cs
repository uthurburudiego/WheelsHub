namespace Interfaces
{
    partial class FormRegistroConexion
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
            label2 = new Label();
            ltsRegistros = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(165, 20);
            label1.Name = "label1";
            label1.Size = new Size(163, 40);
            label1.TabIndex = 7;
            label1.Text = "WheelsHub";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(27, 113);
            label2.Name = "label2";
            label2.Size = new Size(192, 25);
            label2.TabIndex = 8;
            label2.Text = "Registro de conexión:";
            // 
            // ltsRegistros
            // 
            ltsRegistros.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ltsRegistros.FormattingEnabled = true;
            ltsRegistros.ItemHeight = 15;
            ltsRegistros.Location = new Point(27, 141);
            ltsRegistros.Name = "ltsRegistros";
            ltsRegistros.Size = new Size(473, 304);
            ltsRegistros.TabIndex = 9;
            // 
            // FormRegistroConexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(530, 493);
            Controls.Add(ltsRegistros);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormRegistroConexion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registro";
            Load += FormRegistroConexion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox ltsRegistros;
    }
}