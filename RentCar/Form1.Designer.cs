namespace RentCar
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnInspecciones = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelMantenimientoSubMenu = new System.Windows.Forms.Panel();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnTiposCombustibles = new System.Windows.Forms.Button();
            this.btnModelos = new System.Windows.Forms.Button();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.btnTiposVehiculos = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.panelReportesSubMenu = new System.Windows.Forms.Panel();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.panelServiciosSubMenu = new System.Windows.Forms.Panel();
            this.btnRentaDevoluciones = new System.Windows.Forms.Button();
            this.btnServicios = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelChildFrom = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            this.panelMantenimientoSubMenu.SuspendLayout();
            this.panelReportesSubMenu.SuspendLayout();
            this.panelServiciosSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelChildFrom.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInspecciones
            // 
            this.btnInspecciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnInspecciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInspecciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInspecciones.FlatAppearance.BorderSize = 0;
            this.btnInspecciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInspecciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInspecciones.ForeColor = System.Drawing.Color.White;
            this.btnInspecciones.Location = new System.Drawing.Point(0, 0);
            this.btnInspecciones.Name = "btnInspecciones";
            this.btnInspecciones.Size = new System.Drawing.Size(170, 40);
            this.btnInspecciones.TabIndex = 3;
            this.btnInspecciones.Text = "Inspecciones";
            this.btnInspecciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInspecciones.UseVisualStyleBackColor = false;
            this.btnInspecciones.Click += new System.EventHandler(this.btnInspecciones_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.panelSideMenu.Controls.Add(this.panelMantenimientoSubMenu);
            this.panelSideMenu.Controls.Add(this.btnMantenimiento);
            this.panelSideMenu.Controls.Add(this.panelReportesSubMenu);
            this.panelSideMenu.Controls.Add(this.btnReportes);
            this.panelSideMenu.Controls.Add(this.panelServiciosSubMenu);
            this.panelSideMenu.Controls.Add(this.btnServicios);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.ForeColor = System.Drawing.SystemColors.Window;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelSideMenu.Size = new System.Drawing.Size(187, 561);
            this.panelSideMenu.TabIndex = 0;
            this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelMantenimientoSubMenu
            // 
            this.panelMantenimientoSubMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelMantenimientoSubMenu.Controls.Add(this.btnEmpleados);
            this.panelMantenimientoSubMenu.Controls.Add(this.btnClientes);
            this.panelMantenimientoSubMenu.Controls.Add(this.btnMarcas);
            this.panelMantenimientoSubMenu.Controls.Add(this.btnTiposCombustibles);
            this.panelMantenimientoSubMenu.Controls.Add(this.btnModelos);
            this.panelMantenimientoSubMenu.Controls.Add(this.btnVehiculos);
            this.panelMantenimientoSubMenu.Controls.Add(this.btnTiposVehiculos);
            this.panelMantenimientoSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMantenimientoSubMenu.Location = new System.Drawing.Point(0, 364);
            this.panelMantenimientoSubMenu.Name = "panelMantenimientoSubMenu";
            this.panelMantenimientoSubMenu.Size = new System.Drawing.Size(170, 280);
            this.panelMantenimientoSubMenu.TabIndex = 10;
            this.panelMantenimientoSubMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMantenimientoSubMenu_Paint);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 0);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(187, 40);
            this.btnEmpleados.TabIndex = 8;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(0, 40);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(187, 40);
            this.btnClientes.TabIndex = 7;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcas.FlatAppearance.BorderSize = 0;
            this.btnMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcas.ForeColor = System.Drawing.Color.White;
            this.btnMarcas.Location = new System.Drawing.Point(0, 79);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(187, 40);
            this.btnMarcas.TabIndex = 9;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarcas.UseVisualStyleBackColor = false;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnTiposCombustibles
            // 
            this.btnTiposCombustibles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnTiposCombustibles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTiposCombustibles.FlatAppearance.BorderSize = 0;
            this.btnTiposCombustibles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiposCombustibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiposCombustibles.ForeColor = System.Drawing.Color.White;
            this.btnTiposCombustibles.Location = new System.Drawing.Point(0, 239);
            this.btnTiposCombustibles.Name = "btnTiposCombustibles";
            this.btnTiposCombustibles.Size = new System.Drawing.Size(187, 40);
            this.btnTiposCombustibles.TabIndex = 13;
            this.btnTiposCombustibles.Text = "Tipos de Combustibles";
            this.btnTiposCombustibles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTiposCombustibles.UseVisualStyleBackColor = false;
            this.btnTiposCombustibles.Click += new System.EventHandler(this.btnTiposCombustibles_Click);
            // 
            // btnModelos
            // 
            this.btnModelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnModelos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModelos.FlatAppearance.BorderSize = 0;
            this.btnModelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModelos.ForeColor = System.Drawing.Color.White;
            this.btnModelos.Location = new System.Drawing.Point(0, 119);
            this.btnModelos.Name = "btnModelos";
            this.btnModelos.Size = new System.Drawing.Size(187, 40);
            this.btnModelos.TabIndex = 10;
            this.btnModelos.Text = "Modelos";
            this.btnModelos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModelos.UseVisualStyleBackColor = false;
            this.btnModelos.Click += new System.EventHandler(this.btnModelos_Click);
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnVehiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVehiculos.FlatAppearance.BorderSize = 0;
            this.btnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculos.ForeColor = System.Drawing.Color.White;
            this.btnVehiculos.Location = new System.Drawing.Point(0, 159);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(187, 40);
            this.btnVehiculos.TabIndex = 11;
            this.btnVehiculos.Text = "Vehículos";
            this.btnVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehiculos.UseVisualStyleBackColor = false;
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // btnTiposVehiculos
            // 
            this.btnTiposVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnTiposVehiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTiposVehiculos.FlatAppearance.BorderSize = 0;
            this.btnTiposVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiposVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiposVehiculos.ForeColor = System.Drawing.Color.White;
            this.btnTiposVehiculos.Location = new System.Drawing.Point(0, 199);
            this.btnTiposVehiculos.Name = "btnTiposVehiculos";
            this.btnTiposVehiculos.Size = new System.Drawing.Size(187, 40);
            this.btnTiposVehiculos.TabIndex = 12;
            this.btnTiposVehiculos.Text = "Tipos de Vehículos";
            this.btnTiposVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTiposVehiculos.UseVisualStyleBackColor = false;
            this.btnTiposVehiculos.Click += new System.EventHandler(this.btnTiposVehiculos_Click);
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(143)))), ((int)(((byte)(119)))));
            this.btnMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantenimiento.FlatAppearance.BorderSize = 0;
            this.btnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimiento.ForeColor = System.Drawing.Color.White;
            this.btnMantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnMantenimiento.Image")));
            this.btnMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimiento.Location = new System.Drawing.Point(0, 324);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(170, 40);
            this.btnMantenimiento.TabIndex = 12;
            this.btnMantenimiento.Text = "Mantenimiento";
            this.btnMantenimiento.UseVisualStyleBackColor = false;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // panelReportesSubMenu
            // 
            this.panelReportesSubMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelReportesSubMenu.Controls.Add(this.btnReporte);
            this.panelReportesSubMenu.Controls.Add(this.btnConsultas);
            this.panelReportesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReportesSubMenu.Location = new System.Drawing.Point(0, 245);
            this.panelReportesSubMenu.Name = "panelReportesSubMenu";
            this.panelReportesSubMenu.Size = new System.Drawing.Size(170, 79);
            this.panelReportesSubMenu.TabIndex = 11;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Location = new System.Drawing.Point(0, 40);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(170, 40);
            this.btnReporte.TabIndex = 14;
            this.btnReporte.Text = "Reporte de rentas";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.Color.White;
            this.btnConsultas.Location = new System.Drawing.Point(0, 0);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(170, 40);
            this.btnConsultas.TabIndex = 15;
            this.btnConsultas.Text = "Consultas de Rentas";
            this.btnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(143)))), ((int)(((byte)(119)))));
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 205);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(170, 40);
            this.btnReportes.TabIndex = 11;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // panelServiciosSubMenu
            // 
            this.panelServiciosSubMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelServiciosSubMenu.Controls.Add(this.btnRentaDevoluciones);
            this.panelServiciosSubMenu.Controls.Add(this.btnInspecciones);
            this.panelServiciosSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelServiciosSubMenu.Location = new System.Drawing.Point(0, 124);
            this.panelServiciosSubMenu.Name = "panelServiciosSubMenu";
            this.panelServiciosSubMenu.Size = new System.Drawing.Size(170, 81);
            this.panelServiciosSubMenu.TabIndex = 10;
            // 
            // btnRentaDevoluciones
            // 
            this.btnRentaDevoluciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnRentaDevoluciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRentaDevoluciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRentaDevoluciones.FlatAppearance.BorderSize = 0;
            this.btnRentaDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentaDevoluciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentaDevoluciones.ForeColor = System.Drawing.Color.White;
            this.btnRentaDevoluciones.Location = new System.Drawing.Point(0, 40);
            this.btnRentaDevoluciones.Name = "btnRentaDevoluciones";
            this.btnRentaDevoluciones.Size = new System.Drawing.Size(170, 40);
            this.btnRentaDevoluciones.TabIndex = 5;
            this.btnRentaDevoluciones.Text = "Renta y Devoluciones";
            this.btnRentaDevoluciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRentaDevoluciones.UseVisualStyleBackColor = false;
            this.btnRentaDevoluciones.Click += new System.EventHandler(this.btnRentaDevoluciones_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(143)))), ((int)(((byte)(119)))));
            this.btnServicios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServicios.FlatAppearance.BorderSize = 0;
            this.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicios.ForeColor = System.Drawing.Color.White;
            this.btnServicios.Image = ((System.Drawing.Image)(resources.GetObject("btnServicios.Image")));
            this.btnServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.Location = new System.Drawing.Point(0, 84);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(170, 40);
            this.btnServicios.TabIndex = 9;
            this.btnServicios.Text = "Servicios";
            this.btnServicios.UseVisualStyleBackColor = false;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click_1);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 10);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(170, 74);
            this.panelLogo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "S.A RentCar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(187, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 84);
            this.panel1.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(697, 23);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(38, 34);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelChildFrom
            // 
            this.panelChildFrom.BackColor = System.Drawing.Color.White;
            this.panelChildFrom.Controls.Add(this.label3);
            this.panelChildFrom.Controls.Add(this.label2);
            this.panelChildFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildFrom.Location = new System.Drawing.Point(187, 84);
            this.panelChildFrom.Name = "panelChildFrom";
            this.panelChildFrom.Size = new System.Drawing.Size(747, 477);
            this.panelChildFrom.TabIndex = 3;
            this.panelChildFrom.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildFrom_Paint);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rent A Car";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Santo Domingo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChildFrom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideMenu);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelMantenimientoSubMenu.ResumeLayout(false);
            this.panelReportesSubMenu.ResumeLayout(false);
            this.panelServiciosSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelChildFrom.ResumeLayout(false);
            this.panelChildFrom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInspecciones;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelMantenimientoSubMenu;
        private System.Windows.Forms.Button btnTiposCombustibles;
        private System.Windows.Forms.Button btnTiposVehiculos;
        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Button btnModelos;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel panelServiciosSubMenu;
        private System.Windows.Forms.Button btnRentaDevoluciones;
        private System.Windows.Forms.Button btnServicios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelChildFrom;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelReportesSubMenu;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnConsultas;
    }
}

