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
            dlgImagen = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(340, 22);
            lblTitulo.Size = new Size(422, 78);
            lblTitulo.Text = "Modificar Auto";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(349, 329);
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(495, 329);
            // 
            // txtChasis
            // 
            txtChasis.Location = new Point(353, 143);
            // 
            // cboMarca
            // 
            cboMarca.Location = new Point(557, 143);
            // 
            // txtCilindrada
            // 
            txtCilindrada.Location = new Point(1040, 489);
            // 
            // cboABS
            // 
            cboABS.Location = new Point(1186, 489);
            // 
            // txtTara
            // 
            txtTara.Location = new Point(1040, 574);
            // 
            // txtCantidadEjes
            // 
            txtCantidadEjes.Location = new Point(1186, 574);
            // 
            // txtCantidadPuertas
            // 
            txtCantidadPuertas.Location = new Point(353, 226);
            // 
            // txtCantidadPasajeros
            // 
            txtCantidadPasajeros.Location = new Point(495, 226);
            // 
            // picImagen
            // 
            picImagen.Location = new Point(43, 124);
            picImagen.Size = new Size(258, 179);
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(74, 329);
            // 
            // lblCilindrada
            // 
            lblCilindrada.Location = new Point(1034, 466);
            // 
            // lblABS
            // 
            lblABS.Location = new Point(1186, 466);
            // 
            // lblTara
            // 
            lblTara.Location = new Point(1040, 551);
            // 
            // lblEjes
            // 
            lblEjes.Location = new Point(1182, 551);
            // 
            // lblPuertas
            // 
            lblPuertas.Location = new Point(350, 203);
            // 
            // lblPasajeros
            // 
            lblPasajeros.Location = new Point(495, 203);
            // 
            // dlgImagen
            // 
            dlgImagen.FileName = "openFileDialog1";
            // 
            // FormModificarAuto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 481);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormModificarAuto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ss";
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog dlgImagen;
    }
}