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
            components = new System.ComponentModel.Container();
            txtBuscador = new TextBox();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            radAuto = new RadioButton();
            radMoto = new RadioButton();
            radCamion = new RadioButton();
            lblSaludo = new Label();
            cmsMenu = new ContextMenuStrip(components);
            agregarToolStripMenuItem = new ToolStripMenuItem();
            autoToolStripMenuItem = new ToolStripMenuItem();
            motoToolStripMenuItem = new ToolStripMenuItem();
            camionToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            cmsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuscador
            // 
            txtBuscador.Location = new Point(296, 186);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.PlaceholderText = "Buscar";
            txtBuscador.Size = new Size(586, 23);
            txtBuscador.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.Snow;
            btnBuscar.Location = new Point(296, 648);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(81, 27);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = Color.Snow;
            btnModificar.Location = new Point(405, 648);
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
            btnBorrar.Location = new Point(520, 648);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(81, 27);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(296, 437);
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
            label1.Location = new Point(405, 57);
            label1.Name = "label1";
            label1.Size = new Size(332, 78);
            label1.TabIndex = 6;
            label1.Text = "WheelsHub";
            // 
            // radAuto
            // 
            radAuto.AutoSize = true;
            radAuto.BackColor = Color.Transparent;
            radAuto.Location = new Point(296, 224);
            radAuto.Name = "radAuto";
            radAuto.Size = new Size(14, 13);
            radAuto.TabIndex = 7;
            radAuto.TabStop = true;
            radAuto.UseVisualStyleBackColor = false;
            radAuto.CheckedChanged += radAuto_CheckedChanged;
            // 
            // radMoto
            // 
            radMoto.AutoSize = true;
            radMoto.BackColor = Color.Transparent;
            radMoto.Location = new Point(320, 224);
            radMoto.Name = "radMoto";
            radMoto.Size = new Size(14, 13);
            radMoto.TabIndex = 8;
            radMoto.TabStop = true;
            radMoto.UseVisualStyleBackColor = false;
            radMoto.CheckedChanged += radMoto_CheckedChanged;
            // 
            // radCamion
            // 
            radCamion.AutoSize = true;
            radCamion.BackColor = Color.Transparent;
            radCamion.Location = new Point(343, 224);
            radCamion.Name = "radCamion";
            radCamion.Size = new Size(14, 13);
            radCamion.TabIndex = 9;
            radCamion.TabStop = true;
            radCamion.UseVisualStyleBackColor = false;
            radCamion.CheckedChanged += radCamion_CheckedChanged;
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.BackColor = Color.Transparent;
            lblSaludo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaludo.ForeColor = Color.Snow;
            lblSaludo.Location = new Point(777, 33);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(105, 21);
            lblSaludo.TabIndex = 10;
            lblSaludo.Text = "Bienvenido: ";
            // 
            // cmsMenu
            // 
            cmsMenu.BackColor = SystemColors.ActiveCaptionText;
            cmsMenu.Items.AddRange(new ToolStripItem[] { agregarToolStripMenuItem });
            cmsMenu.Name = "cmsMenu";
            cmsMenu.ShowCheckMargin = true;
            cmsMenu.Size = new Size(203, 48);
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.BackColor = SystemColors.ButtonHighlight;
            agregarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { autoToolStripMenuItem, motoToolStripMenuItem, camionToolStripMenuItem });
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(202, 22);
            agregarToolStripMenuItem.Text = "Agregar";
            // 
            // autoToolStripMenuItem
            // 
            autoToolStripMenuItem.Checked = true;
            autoToolStripMenuItem.CheckState = CheckState.Checked;
            autoToolStripMenuItem.Name = "autoToolStripMenuItem";
            autoToolStripMenuItem.Size = new Size(180, 22);
            autoToolStripMenuItem.Text = "Auto";
            autoToolStripMenuItem.Click += autoToolStripMenuItem_Click;
            // 
            // motoToolStripMenuItem
            // 
            motoToolStripMenuItem.Name = "motoToolStripMenuItem";
            motoToolStripMenuItem.Size = new Size(180, 22);
            motoToolStripMenuItem.Text = "Moto";
            // 
            // camionToolStripMenuItem
            // 
            camionToolStripMenuItem.Name = "camionToolStripMenuItem";
            camionToolStripMenuItem.Size = new Size(180, 22);
            camionToolStripMenuItem.Text = "Camion";
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1185, 742);
            Controls.Add(lblSaludo);
            Controls.Add(radCamion);
            Controls.Add(radMoto);
            Controls.Add(radAuto);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscador);
            DoubleBuffered = true;
            Name = "FormInicio";
            Text = "Inicio";
            Load += FormInicio_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            cmsMenu.ResumeLayout(false);
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
        private Label lblSaludo;
        private ToolStripComboBox toolStripComboBox1;
        private ContextMenuStrip cmsMenu;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem autoToolStripMenuItem;
        private ToolStripMenuItem motoToolStripMenuItem;
        private ToolStripMenuItem camionToolStripMenuItem;
    }
}