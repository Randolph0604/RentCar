
namespace RentCar.Views.Vehiculos
{
    partial class frmVehiculos
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
            this.panelChildFrom = new System.Windows.Forms.Panel();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.cmbTipoCombustible = new System.Windows.Forms.ComboBox();
            this.lblTipoCombustible = new System.Windows.Forms.Label();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblNoPlaca = new System.Windows.Forms.Label();
            this.txtNoPlaca = new System.Windows.Forms.TextBox();
            this.lblNoMotor = new System.Windows.Forms.Label();
            this.txtNoMotor = new System.Windows.Forms.TextBox();
            this.lblNoChasis = new System.Windows.Forms.Label();
            this.txtNoChasis = new System.Windows.Forms.TextBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.panelChildFrom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChildFrom
            // 
            this.panelChildFrom.BackColor = System.Drawing.Color.White;
            this.panelChildFrom.Controls.Add(this.cmbTipoVehiculo);
            this.panelChildFrom.Controls.Add(this.cmbTipoCombustible);
            this.panelChildFrom.Controls.Add(this.lblTipoCombustible);
            this.panelChildFrom.Controls.Add(this.cmbModelo);
            this.panelChildFrom.Controls.Add(this.lblModelo);
            this.panelChildFrom.Controls.Add(this.lblTipoVehiculo);
            this.panelChildFrom.Controls.Add(this.lblNoPlaca);
            this.panelChildFrom.Controls.Add(this.txtNoPlaca);
            this.panelChildFrom.Controls.Add(this.lblNoMotor);
            this.panelChildFrom.Controls.Add(this.txtNoMotor);
            this.panelChildFrom.Controls.Add(this.lblNoChasis);
            this.panelChildFrom.Controls.Add(this.txtNoChasis);
            this.panelChildFrom.Controls.Add(this.cmbMarca);
            this.panelChildFrom.Controls.Add(this.lblMarca);
            this.panelChildFrom.Controls.Add(this.btnGuardar);
            this.panelChildFrom.Controls.Add(this.cmbEstado);
            this.panelChildFrom.Controls.Add(this.lblEstado);
            this.panelChildFrom.Controls.Add(this.lblDescripcion);
            this.panelChildFrom.Controls.Add(this.txtDescripcion);
            this.panelChildFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildFrom.Location = new System.Drawing.Point(0, 0);
            this.panelChildFrom.Name = "panelChildFrom";
            this.panelChildFrom.Size = new System.Drawing.Size(731, 438);
            this.panelChildFrom.TabIndex = 2;
            this.panelChildFrom.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildFrom_Paint);
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(38, 302);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(226, 28);
            this.cmbTipoVehiculo.TabIndex = 47;
            // 
            // cmbTipoCombustible
            // 
            this.cmbTipoCombustible.DisplayMember = "Descripcion";
            this.cmbTipoCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoCombustible.FormattingEnabled = true;
            this.cmbTipoCombustible.Location = new System.Drawing.Point(312, 173);
            this.cmbTipoCombustible.Name = "cmbTipoCombustible";
            this.cmbTipoCombustible.Size = new System.Drawing.Size(226, 28);
            this.cmbTipoCombustible.TabIndex = 46;
            this.cmbTipoCombustible.ValueMember = "Descripcion";
            // 
            // lblTipoCombustible
            // 
            this.lblTipoCombustible.AutoSize = true;
            this.lblTipoCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCombustible.Location = new System.Drawing.Point(308, 150);
            this.lblTipoCombustible.Name = "lblTipoCombustible";
            this.lblTipoCombustible.Size = new System.Drawing.Size(150, 20);
            this.lblTipoCombustible.TabIndex = 45;
            this.lblTipoCombustible.Text = "Tipo de combustible";
            // 
            // cmbModelo
            // 
            this.cmbModelo.DisplayMember = "Descripcion";
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(312, 103);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(226, 28);
            this.cmbModelo.TabIndex = 44;
            this.cmbModelo.ValueMember = "Descripcion";
            this.cmbModelo.SelectedIndexChanged += new System.EventHandler(this.cmbModelo_SelectedIndexChanged);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(308, 80);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(61, 20);
            this.lblModelo.TabIndex = 43;
            this.lblModelo.Text = "Modelo";
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculo.Location = new System.Drawing.Point(34, 279);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(122, 20);
            this.lblTipoVehiculo.TabIndex = 41;
            this.lblTipoVehiculo.Text = "Tipo de vehículo";
            this.lblTipoVehiculo.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblNoPlaca
            // 
            this.lblNoPlaca.AutoSize = true;
            this.lblNoPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPlaca.Location = new System.Drawing.Point(34, 216);
            this.lblNoPlaca.Name = "lblNoPlaca";
            this.lblNoPlaca.Size = new System.Drawing.Size(76, 20);
            this.lblNoPlaca.TabIndex = 40;
            this.lblNoPlaca.Text = "No. Placa";
            // 
            // txtNoPlaca
            // 
            this.txtNoPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNoPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoPlaca.Location = new System.Drawing.Point(38, 239);
            this.txtNoPlaca.Name = "txtNoPlaca";
            this.txtNoPlaca.Size = new System.Drawing.Size(226, 26);
            this.txtNoPlaca.TabIndex = 39;
            // 
            // lblNoMotor
            // 
            this.lblNoMotor.AutoSize = true;
            this.lblNoMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoMotor.Location = new System.Drawing.Point(34, 152);
            this.lblNoMotor.Name = "lblNoMotor";
            this.lblNoMotor.Size = new System.Drawing.Size(78, 20);
            this.lblNoMotor.TabIndex = 38;
            this.lblNoMotor.Text = "No. Motor";
            // 
            // txtNoMotor
            // 
            this.txtNoMotor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNoMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoMotor.Location = new System.Drawing.Point(38, 175);
            this.txtNoMotor.Name = "txtNoMotor";
            this.txtNoMotor.Size = new System.Drawing.Size(226, 26);
            this.txtNoMotor.TabIndex = 37;
            // 
            // lblNoChasis
            // 
            this.lblNoChasis.AutoSize = true;
            this.lblNoChasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoChasis.Location = new System.Drawing.Point(34, 82);
            this.lblNoChasis.Name = "lblNoChasis";
            this.lblNoChasis.Size = new System.Drawing.Size(85, 20);
            this.lblNoChasis.TabIndex = 36;
            this.lblNoChasis.Text = "No. Chasis";
            // 
            // txtNoChasis
            // 
            this.txtNoChasis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNoChasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoChasis.Location = new System.Drawing.Point(38, 105);
            this.txtNoChasis.Name = "txtNoChasis";
            this.txtNoChasis.Size = new System.Drawing.Size(226, 26);
            this.txtNoChasis.TabIndex = 35;
            // 
            // cmbMarca
            // 
            this.cmbMarca.DisplayMember = "Descripcion";
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(312, 40);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(226, 28);
            this.cmbMarca.TabIndex = 34;
            this.cmbMarca.ValueMember = "Descripcion";
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            this.cmbMarca.SelectedValueChanged += new System.EventHandler(this.cmbMarca_SelectedValueChanged);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(308, 17);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(53, 20);
            this.lblMarca.TabIndex = 33;
            this.lblMarca.Text = "Marca";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(605, 360);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 40);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Rentado",
            "Mantenimiento",
            "Disponible"});
            this.cmbEstado.Location = new System.Drawing.Point(312, 239);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(226, 28);
            this.cmbEstado.TabIndex = 27;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(308, 218);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 26;
            this.lblEstado.Text = "Estado";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(34, 19);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 20);
            this.lblDescripcion.TabIndex = 25;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(38, 42);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(226, 26);
            this.txtDescripcion.TabIndex = 24;
            // 
            // frmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 438);
            this.Controls.Add(this.panelChildFrom);
            this.Name = "frmVehiculos";
            this.Text = "frmVehiculos";
            this.Load += new System.EventHandler(this.frmVehiculos_Load);
            this.panelChildFrom.ResumeLayout(false);
            this.panelChildFrom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildFrom;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbTipoCombustible;
        private System.Windows.Forms.Label lblTipoCombustible;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblNoPlaca;
        private System.Windows.Forms.TextBox txtNoPlaca;
        private System.Windows.Forms.Label lblNoMotor;
        private System.Windows.Forms.TextBox txtNoMotor;
        private System.Windows.Forms.Label lblNoChasis;
        private System.Windows.Forms.TextBox txtNoChasis;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
    }
}