namespace Interfaces
{
    partial class FormInicio
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
            txtBuscador = new TextBox();
            btnBuscar = new Button();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            radAuto = new RadioButton();
            radMoto = new RadioButton();
            radCamion = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtBuscador
            // 
            txtBuscador.Location = new Point(393, 213);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.PlaceholderText = "Buscar";
            txtBuscador.Size = new Size(586, 23);
            txtBuscador.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.Snow;
            btnBuscar.Location = new Point(393, 675);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(81, 27);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.Snow;
            btnAgregar.Location = new Point(544, 675);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(81, 27);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = Color.Snow;
            btnModificar.Location = new Point(717, 675);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(81, 27);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.ForeColor = Color.Snow;
            btnBorrar.Location = new Point(898, 675);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(81, 27);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(393, 464);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(586, 154);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 44.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(502, 84);
            label1.Name = "label1";
            label1.Size = new Size(332, 78);
            label1.TabIndex = 6;
            label1.Text = "WheelsHub";
            // 
            // radAuto
            // 
            radAuto.AutoSize = true;
            radAuto.BackColor = Color.Transparent;
            radAuto.Location = new Point(393, 251);
            radAuto.Name = "radAuto";
            radAuto.Size = new Size(94, 19);
            radAuto.TabIndex = 7;
            radAuto.TabStop = true;
            radAuto.Text = "radioButton1";
            radAuto.UseVisualStyleBackColor = false;
            radAuto.CheckedChanged += radAuto_CheckedChanged;
            // 
            // radMoto
            // 
            radMoto.AutoSize = true;
            radMoto.BackColor = Color.Transparent;
            radMoto.Location = new Point(417, 251);
            radMoto.Name = "radMoto";
            radMoto.Size = new Size(94, 19);
            radMoto.TabIndex = 8;
            radMoto.TabStop = true;
            radMoto.Text = "radioButton1";
            radMoto.UseVisualStyleBackColor = false;
            radMoto.CheckedChanged += radMoto_CheckedChanged;
            // 
            // radCamion
            // 
            radCamion.AutoSize = true;
            radCamion.BackColor = Color.Transparent;
            radCamion.Location = new Point(440, 251);
            radCamion.Name = "radCamion";
            radCamion.Size = new Size(94, 19);
            radCamion.TabIndex = 9;
            radCamion.TabStop = true;
            radCamion.Text = "radioButton1";
            radCamion.UseVisualStyleBackColor = false;
            radCamion.CheckedChanged += radCamion_CheckedChanged;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1287, 793);
            Controls.Add(radCamion);
            Controls.Add(radMoto);
            Controls.Add(radAuto);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscador);
            DoubleBuffered = true;
            Name = "FormInicio";
            Text = "Inicio";
            Load += FormInicio_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscador;
        private Button btnBuscar;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnBorrar;
        private DataGridView dataGridView1;
        private Label label1;
        private RadioButton radAuto;
        private RadioButton radMoto;
        private RadioButton radCamion;
    }
}