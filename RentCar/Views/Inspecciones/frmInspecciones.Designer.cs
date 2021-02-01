
namespace RentCar.Views.Inspecciones
{
    partial class frmInspecciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInspecciones));
            this.cmbEstadoGomaA = new System.Windows.Forms.ComboBox();
            this.lblEstadoGomaA = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.lblCantidadCombustible = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.panelChildFrom = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbEstadoGomaD = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbEstadoGomaC = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbEstadoGomaB = new System.Windows.Forms.ComboBox();
            this.lblEstadoGomaB = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVehiculos = new System.Windows.Forms.Label();
            this.ckGato = new System.Windows.Forms.CheckBox();
            this.ckRoturas = new System.Windows.Forms.CheckBox();
            this.ckRespuesta = new System.Windows.Forms.CheckBox();
            this.ckRalladuras = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpInspeccion = new System.Windows.Forms.DateTimePicker();
            this.cmbCantidadCombustible = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbVehiculo = new System.Windows.Forms.ComboBox();
            this.lblEmpleadoInspeccion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panelChildFrom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEstadoGomaA
            // 
            this.cmbEstadoGomaA.DisplayMember = "Descripcion";
            this.cmbEstadoGomaA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoGomaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoGomaA.FormattingEnabled = true;
            this.cmbEstadoGomaA.Items.AddRange(new object[] {
            "Nueva",
            "Regular",
            "Gastada"});
            this.cmbEstadoGomaA.Location = new System.Drawing.Point(38, 275);
            this.cmbEstadoGomaA.Name = "cmbEstadoGomaA";
            this.cmbEstadoGomaA.Size = new System.Drawing.Size(226, 28);
            this.cmbEstadoGomaA.TabIndex = 46;
            this.cmbEstadoGomaA.ValueMember = "Descripcion";
            // 
            // lblEstadoGomaA
            // 
            this.lblEstadoGomaA.AutoSize = true;
            this.lblEstadoGomaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoGomaA.Location = new System.Drawing.Point(34, 252);
            this.lblEstadoGomaA.Name = "lblEstadoGomaA";
            this.lblEstadoGomaA.Size = new System.Drawing.Size(141, 20);
            this.lblEstadoGomaA.TabIndex = 45;
            this.lblEstadoGomaA.Text = "Estado de goma A";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.DisplayMember = "Descripcion";
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(344, 95);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(226, 28);
            this.cmbEmpleado.TabIndex = 44;
            this.cmbEmpleado.ValueMember = "Descripcion";
            // 
            // lblCantidadCombustible
            // 
            this.lblCantidadCombustible.AutoSize = true;
            this.lblCantidadCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadCombustible.Location = new System.Drawing.Point(34, 137);
            this.lblCantidadCombustible.Name = "lblCantidadCombustible";
            this.lblCantidadCombustible.Size = new System.Drawing.Size(165, 20);
            this.lblCantidadCombustible.TabIndex = 40;
            this.lblCantidadCombustible.Text = "Cantidad Combustible";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(34, 11);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(58, 20);
            this.lblCliente.TabIndex = 36;
            this.lblCliente.Text = "Cliente";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(344, 34);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(226, 28);
            this.cmbEstado.TabIndex = 27;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(340, 13);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 26;
            this.lblEstado.Text = "Estado";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.Location = new System.Drawing.Point(0, 0);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(100, 23);
            this.lblVehiculo.TabIndex = 74;
            // 
            // panelChildFrom
            // 
            this.panelChildFrom.BackColor = System.Drawing.Color.White;
            this.panelChildFrom.Controls.Add(this.pictureBox1);
            this.panelChildFrom.Controls.Add(this.cmbEstadoGomaD);
            this.panelChildFrom.Controls.Add(this.label19);
            this.panelChildFrom.Controls.Add(this.cmbEstadoGomaC);
            this.panelChildFrom.Controls.Add(this.label18);
            this.panelChildFrom.Controls.Add(this.cmbEstadoGomaB);
            this.panelChildFrom.Controls.Add(this.lblEstadoGomaB);
            this.panelChildFrom.Controls.Add(this.label5);
            this.panelChildFrom.Controls.Add(this.label4);
            this.panelChildFrom.Controls.Add(this.label3);
            this.panelChildFrom.Controls.Add(this.label2);
            this.panelChildFrom.Controls.Add(this.label1);
            this.panelChildFrom.Controls.Add(this.lblVehiculos);
            this.panelChildFrom.Controls.Add(this.ckGato);
            this.panelChildFrom.Controls.Add(this.ckRoturas);
            this.panelChildFrom.Controls.Add(this.ckRespuesta);
            this.panelChildFrom.Controls.Add(this.ckRalladuras);
            this.panelChildFrom.Controls.Add(this.btnGuardar);
            this.panelChildFrom.Controls.Add(this.dtpInspeccion);
            this.panelChildFrom.Controls.Add(this.cmbCantidadCombustible);
            this.panelChildFrom.Controls.Add(this.cmbCliente);
            this.panelChildFrom.Controls.Add(this.cmbVehiculo);
            this.panelChildFrom.Controls.Add(this.lblEmpleadoInspeccion);
            this.panelChildFrom.Controls.Add(this.lblFecha);
            this.panelChildFrom.Controls.Add(this.cmbEstadoGomaA);
            this.panelChildFrom.Controls.Add(this.lblEstadoGomaA);
            this.panelChildFrom.Controls.Add(this.cmbEmpleado);
            this.panelChildFrom.Controls.Add(this.lblCantidadCombustible);
            this.panelChildFrom.Controls.Add(this.lblCliente);
            this.panelChildFrom.Controls.Add(this.cmbEstado);
            this.panelChildFrom.Controls.Add(this.lblEstado);
            this.panelChildFrom.Controls.Add(this.lblVehiculo);
            this.panelChildFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildFrom.Location = new System.Drawing.Point(0, 0);
            this.panelChildFrom.Name = "panelChildFrom";
            this.panelChildFrom.Size = new System.Drawing.Size(731, 817);
            this.panelChildFrom.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(344, 252);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 260);
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // cmbEstadoGomaD
            // 
            this.cmbEstadoGomaD.DisplayMember = "Descripcion";
            this.cmbEstadoGomaD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoGomaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoGomaD.FormattingEnabled = true;
            this.cmbEstadoGomaD.Items.AddRange(new object[] {
            "Nueva",
            "Regular",
            "Gastada"});
            this.cmbEstadoGomaD.Location = new System.Drawing.Point(38, 480);
            this.cmbEstadoGomaD.Name = "cmbEstadoGomaD";
            this.cmbEstadoGomaD.Size = new System.Drawing.Size(226, 28);
            this.cmbEstadoGomaD.TabIndex = 93;
            this.cmbEstadoGomaD.ValueMember = "Descripcion";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(34, 457);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(142, 20);
            this.label19.TabIndex = 92;
            this.label19.Text = "Estado de goma D";
            // 
            // cmbEstadoGomaC
            // 
            this.cmbEstadoGomaC.DisplayMember = "Descripcion";
            this.cmbEstadoGomaC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoGomaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoGomaC.FormattingEnabled = true;
            this.cmbEstadoGomaC.Items.AddRange(new object[] {
            "Nueva",
            "Regular",
            "Gastada"});
            this.cmbEstadoGomaC.Location = new System.Drawing.Point(38, 412);
            this.cmbEstadoGomaC.Name = "cmbEstadoGomaC";
            this.cmbEstadoGomaC.Size = new System.Drawing.Size(226, 28);
            this.cmbEstadoGomaC.TabIndex = 91;
            this.cmbEstadoGomaC.ValueMember = "Descripcion";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(34, 389);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(141, 20);
            this.label18.TabIndex = 90;
            this.label18.Text = "Estado de goma C";
            // 
            // cmbEstadoGomaB
            // 
            this.cmbEstadoGomaB.DisplayMember = "Descripcion";
            this.cmbEstadoGomaB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoGomaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoGomaB.FormattingEnabled = true;
            this.cmbEstadoGomaB.Items.AddRange(new object[] {
            "Nueva",
            "Regular",
            "Gastada"});
            this.cmbEstadoGomaB.Location = new System.Drawing.Point(38, 343);
            this.cmbEstadoGomaB.Name = "cmbEstadoGomaB";
            this.cmbEstadoGomaB.Size = new System.Drawing.Size(226, 28);
            this.cmbEstadoGomaB.TabIndex = 85;
            this.cmbEstadoGomaB.ValueMember = "Descripcion";
            // 
            // lblEstadoGomaB
            // 
            this.lblEstadoGomaB.AutoSize = true;
            this.lblEstadoGomaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoGomaB.Location = new System.Drawing.Point(34, 320);
            this.lblEstadoGomaB.Name = "lblEstadoGomaB";
            this.lblEstadoGomaB.Size = new System.Drawing.Size(141, 20);
            this.lblEstadoGomaB.TabIndex = 84;
            this.lblEstadoGomaB.Text = "Estado de goma B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 76;
            this.label5.Text = "Estados de gomas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 692);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 79;
            this.label4.Text = "Tiene gato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 643);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 78;
            this.label3.Text = "Tiene goma de respuesta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 598);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 77;
            this.label2.Text = "Tiene roturas de cristal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 545);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "Tiene ralladuras";
            // 
            // lblVehiculos
            // 
            this.lblVehiculos.AutoSize = true;
            this.lblVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculos.Location = new System.Drawing.Point(34, 72);
            this.lblVehiculos.Name = "lblVehiculos";
            this.lblVehiculos.Size = new System.Drawing.Size(78, 20);
            this.lblVehiculos.TabIndex = 75;
            this.lblVehiculos.Text = "Vehículos";
            // 
            // ckGato
            // 
            this.ckGato.AutoSize = true;
            this.ckGato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckGato.Location = new System.Drawing.Point(39, 698);
            this.ckGato.Name = "ckGato";
            this.ckGato.Size = new System.Drawing.Size(15, 14);
            this.ckGato.TabIndex = 73;
            this.ckGato.Tag = "";
            this.ckGato.UseVisualStyleBackColor = true;
            this.ckGato.CheckedChanged += new System.EventHandler(this.ckGato_CheckedChanged);
            // 
            // ckRoturas
            // 
            this.ckRoturas.AutoSize = true;
            this.ckRoturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckRoturas.Location = new System.Drawing.Point(39, 602);
            this.ckRoturas.Name = "ckRoturas";
            this.ckRoturas.Size = new System.Drawing.Size(15, 14);
            this.ckRoturas.TabIndex = 72;
            this.ckRoturas.UseVisualStyleBackColor = true;
            this.ckRoturas.CheckedChanged += new System.EventHandler(this.ckRoturas_CheckedChanged);
            // 
            // ckRespuesta
            // 
            this.ckRespuesta.AutoSize = true;
            this.ckRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckRespuesta.Location = new System.Drawing.Point(39, 649);
            this.ckRespuesta.Name = "ckRespuesta";
            this.ckRespuesta.Size = new System.Drawing.Size(15, 14);
            this.ckRespuesta.TabIndex = 71;
            this.ckRespuesta.UseVisualStyleBackColor = true;
            this.ckRespuesta.CheckedChanged += new System.EventHandler(this.ckRespuesta_CheckedChanged);
            // 
            // ckRalladuras
            // 
            this.ckRalladuras.AutoSize = true;
            this.ckRalladuras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckRalladuras.Location = new System.Drawing.Point(39, 549);
            this.ckRalladuras.Name = "ckRalladuras";
            this.ckRalladuras.Size = new System.Drawing.Size(15, 14);
            this.ckRalladuras.TabIndex = 70;
            this.ckRalladuras.UseVisualStyleBackColor = true;
            this.ckRalladuras.CheckedChanged += new System.EventHandler(this.ckRalladuras_CheckedChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(316, 742);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 40);
            this.btnGuardar.TabIndex = 69;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtpInspeccion
            // 
            this.dtpInspeccion.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInspeccion.Location = new System.Drawing.Point(344, 168);
            this.dtpInspeccion.Name = "dtpInspeccion";
            this.dtpInspeccion.Size = new System.Drawing.Size(226, 20);
            this.dtpInspeccion.TabIndex = 53;
            // 
            // cmbCantidadCombustible
            // 
            this.cmbCantidadCombustible.DisplayMember = "Descripcion";
            this.cmbCantidadCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantidadCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCantidadCombustible.FormattingEnabled = true;
            this.cmbCantidadCombustible.Items.AddRange(new object[] {
            "1/4",
            "1/2",
            "3/4",
            "Lleno"});
            this.cmbCantidadCombustible.Location = new System.Drawing.Point(38, 160);
            this.cmbCantidadCombustible.Name = "cmbCantidadCombustible";
            this.cmbCantidadCombustible.Size = new System.Drawing.Size(226, 28);
            this.cmbCantidadCombustible.TabIndex = 52;
            this.cmbCantidadCombustible.ValueMember = "Descripcion";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DisplayMember = "Descripcion";
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(38, 34);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(226, 28);
            this.cmbCliente.TabIndex = 51;
            this.cmbCliente.ValueMember = "Descripcion";
            // 
            // cmbVehiculo
            // 
            this.cmbVehiculo.DisplayMember = "Descripcion";
            this.cmbVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVehiculo.FormattingEnabled = true;
            this.cmbVehiculo.Location = new System.Drawing.Point(38, 95);
            this.cmbVehiculo.Name = "cmbVehiculo";
            this.cmbVehiculo.Size = new System.Drawing.Size(226, 28);
            this.cmbVehiculo.TabIndex = 50;
            this.cmbVehiculo.ValueMember = "Descripcion";
            // 
            // lblEmpleadoInspeccion
            // 
            this.lblEmpleadoInspeccion.AutoSize = true;
            this.lblEmpleadoInspeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleadoInspeccion.Location = new System.Drawing.Point(340, 72);
            this.lblEmpleadoInspeccion.Name = "lblEmpleadoInspeccion";
            this.lblEmpleadoInspeccion.Size = new System.Drawing.Size(76, 20);
            this.lblEmpleadoInspeccion.TabIndex = 49;
            this.lblEmpleadoInspeccion.Text = "Inspector";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(340, 145);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(157, 20);
            this.lblFecha.TabIndex = 48;
            this.lblFecha.Text = "Fecha de Inspección";
            // 
            // frmInspecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 817);
            this.Controls.Add(this.panelChildFrom);
            this.Name = "frmInspecciones";
            this.Text = "frmInspecciones";
            this.Load += new System.EventHandler(this.frmInspecciones_Load);
            this.panelChildFrom.ResumeLayout(false);
            this.panelChildFrom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbEstadoGomaA;
        private System.Windows.Forms.Label lblEstadoGomaA;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label lblCantidadCombustible;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Panel panelChildFrom;
        private System.Windows.Forms.Label lblEmpleadoInspeccion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpInspeccion;
        private System.Windows.Forms.ComboBox cmbCantidadCombustible;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbVehiculo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox ckGato;
        private System.Windows.Forms.CheckBox ckRoturas;
        private System.Windows.Forms.CheckBox ckRespuesta;
        private System.Windows.Forms.CheckBox ckRalladuras;
        private System.Windows.Forms.Label lblVehiculos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEstadoGomaB;
        private System.Windows.Forms.Label lblEstadoGomaB;
        private System.Windows.Forms.ComboBox cmbEstadoGomaD;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbEstadoGomaC;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}