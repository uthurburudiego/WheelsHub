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
            btnModificar = new Button();
            btnBorrar = new Button();
            dtgVehiculos = new DataGridView();
            label1 = new Label();
            lblSaludo = new Label();
            msMenu = new MenuStrip();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            autoToolStripMenuItem = new ToolStripMenuItem();
            motoToolStripMenuItem = new ToolStripMenuItem();
            camionToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            motosToolStripMenuItem = new ToolStripMenuItem();
            autosToolStripMenuItem = new ToolStripMenuItem();
            camionesToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dtgVehiculos).BeginInit();
            msMenu.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuscador
            // 
            txtBuscador.Location = new Point(164, 186);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.PlaceholderText = "Buscar";
            txtBuscador.Size = new Size(759, 23);
            txtBuscador.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveCaptionText;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(952, 183);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(81, 27);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = Color.Snow;
            btnModificar.Location = new Point(164, 505);
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
            btnBorrar.Location = new Point(292, 505);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(81, 27);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // dtgVehiculos
            // 
            dtgVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgVehiculos.Location = new Point(164, 288);
            dtgVehiculos.Name = "dtgVehiculos";
            dtgVehiculos.RowTemplate.Height = 25;
            dtgVehiculos.Size = new Size(857, 196);
            dtgVehiculos.TabIndex = 5;
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
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.BackColor = Color.Transparent;
            lblSaludo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaludo.ForeColor = Color.Snow;
            lblSaludo.Location = new Point(782, 9);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(105, 21);
            lblSaludo.TabIndex = 10;
            lblSaludo.Text = "Bienvenido: ";
            // 
            // msMenu
            // 
            msMenu.BackColor = Color.Transparent;
            msMenu.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            msMenu.Items.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, salirToolStripMenuItem, salirToolStripMenuItem1 });
            msMenu.Location = new Point(0, 0);
            msMenu.Name = "msMenu";
            msMenu.Size = new Size(1185, 29);
            msMenu.TabIndex = 11;
            msMenu.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.BackColor = Color.White;
            agregarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { autoToolStripMenuItem, motoToolStripMenuItem, camionToolStripMenuItem });
            agregarToolStripMenuItem.ForeColor = Color.Black;
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(84, 25);
            agregarToolStripMenuItem.Text = "Agregar";
            // 
            // autoToolStripMenuItem
            // 
            autoToolStripMenuItem.Name = "autoToolStripMenuItem";
            autoToolStripMenuItem.Size = new Size(180, 26);
            autoToolStripMenuItem.Text = "Auto";
            autoToolStripMenuItem.Click += autoToolStripMenuItem_Click;
            // 
            // motoToolStripMenuItem
            // 
            motoToolStripMenuItem.Name = "motoToolStripMenuItem";
            motoToolStripMenuItem.Size = new Size(180, 26);
            motoToolStripMenuItem.Text = "Moto";
            motoToolStripMenuItem.Click += motoToolStripMenuItem_Click;
            // 
            // camionToolStripMenuItem
            // 
            camionToolStripMenuItem.Name = "camionToolStripMenuItem";
            camionToolStripMenuItem.Size = new Size(180, 26);
            camionToolStripMenuItem.Text = "Camion";
            camionToolStripMenuItem.Click += camionToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.BackColor = Color.White;
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { motosToolStripMenuItem, autosToolStripMenuItem, camionesToolStripMenuItem });
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(48, 25);
            salirToolStripMenuItem.Text = "Ver";
            // 
            // motosToolStripMenuItem
            // 
            motosToolStripMenuItem.Name = "motosToolStripMenuItem";
            motosToolStripMenuItem.Size = new Size(156, 26);
            motosToolStripMenuItem.Text = "Motos";
            motosToolStripMenuItem.Click += motosToolStripMenuItem_Click;
            // 
            // autosToolStripMenuItem
            // 
            autosToolStripMenuItem.Name = "autosToolStripMenuItem";
            autosToolStripMenuItem.Size = new Size(156, 26);
            autosToolStripMenuItem.Text = "Autos";
            autosToolStripMenuItem.Click += autosToolStripMenuItem_Click;
            // 
            // camionesToolStripMenuItem
            // 
            camionesToolStripMenuItem.Name = "camionesToolStripMenuItem";
            camionesToolStripMenuItem.Size = new Size(156, 26);
            camionesToolStripMenuItem.Text = "Camiones";
            camionesToolStripMenuItem.Click += camionesToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.BackColor = Color.White;
            salirToolStripMenuItem1.ForeColor = SystemColors.ControlText;
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(54, 25);
            salirToolStripMenuItem1.Text = "Salir";
            salirToolStripMenuItem1.Click += salirToolStripMenuItem1_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.fondoMoto;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1185, 742);
            Controls.Add(lblSaludo);
            Controls.Add(label1);
            Controls.Add(dtgVehiculos);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscador);
            Controls.Add(msMenu);
            DoubleBuffered = true;
            MainMenuStrip = msMenu;
            Name = "FormInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += FormInicio_Load;
            ((System.ComponentModel.ISupportInitialize)dtgVehiculos).EndInit();
            msMenu.ResumeLayout(false);
            msMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscador;
        private Button btnBuscar;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnBorrar;
        private DataGridView dtgVehiculos;
        private Label label1;
        private Label lblSaludo;
        private ToolStripComboBox toolStripComboBox1;
        private MenuStrip msMenu;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem autoToolStripMenuItem;
        private ToolStripMenuItem motoToolStripMenuItem;
        private ToolStripMenuItem camionToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem1;
        private ToolStripMenuItem motosToolStripMenuItem;
        private ToolStripMenuItem autosToolStripMenuItem;
        private ToolStripMenuItem camionesToolStripMenuItem;
    }
}