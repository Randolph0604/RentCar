
namespace RentCar.Views.Clientes
{
    partial class frmClientes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.nudLimiteCredito = new System.Windows.Forms.NumericUpDown();
            this.cmbTipoPersona = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblLimiteCredito = new System.Windows.Forms.Label();
            this.lblNoTarjetaCR = new System.Windows.Forms.Label();
            this.lblTipoPersona = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNoTarjetaCR = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimiteCredito)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.nudLimiteCredito);
            this.panel1.Controls.Add(this.cmbTipoPersona);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.cmbEstado);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.lblLimiteCredito);
            this.panel1.Controls.Add(this.lblNoTarjetaCR);
            this.panel1.Controls.Add(this.lblTipoPersona);
            this.panel1.Controls.Add(this.lblCedula);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtNoTarjetaCR);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 435);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(62, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 67;
            this.label2.Text = "Sin guiones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(62, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Sin espacio";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(61, 110);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 20);
            this.lblApellido.TabIndex = 65;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(65, 137);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(226, 26);
            this.txtApellido.TabIndex = 64;
            // 
            // nudLimiteCredito
            // 
            this.nudLimiteCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLimiteCredito.Location = new System.Drawing.Point(65, 359);
            this.nudLimiteCredito.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudLimiteCredito.Name = "nudLimiteCredito";
            this.nudLimiteCredito.Size = new System.Drawing.Size(226, 26);
            this.nudLimiteCredito.TabIndex = 62;
            // 
            // cmbTipoPersona
            // 
            this.cmbTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoPersona.FormattingEnabled = true;
            this.cmbTipoPersona.Items.AddRange(new object[] {
            "Fisica",
            "Juridica"});
            this.cmbTipoPersona.Location = new System.Drawing.Point(361, 67);
            this.cmbTipoPersona.Name = "cmbTipoPersona";
            this.cmbTipoPersona.Size = new System.Drawing.Size(226, 28);
            this.cmbTipoPersona.TabIndex = 61;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(605, 332);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 40);
            this.btnGuardar.TabIndex = 60;
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
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(361, 135);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(226, 28);
            this.cmbEstado.TabIndex = 59;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(357, 114);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 57;
            this.lblEstado.Text = "Estado";
            // 
            // lblLimiteCredito
            // 
            this.lblLimiteCredito.AutoSize = true;
            this.lblLimiteCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimiteCredito.Location = new System.Drawing.Point(64, 336);
            this.lblLimiteCredito.Name = "lblLimiteCredito";
            this.lblLimiteCredito.Size = new System.Drawing.Size(125, 20);
            this.lblLimiteCredito.TabIndex = 55;
            this.lblLimiteCredito.Text = "Limite de credito";
            // 
            // lblNoTarjetaCR
            // 
            this.lblNoTarjetaCR.AutoSize = true;
            this.lblNoTarjetaCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTarjetaCR.Location = new System.Drawing.Point(61, 256);
            this.lblNoTarjetaCR.Name = "lblNoTarjetaCR";
            this.lblNoTarjetaCR.Size = new System.Drawing.Size(163, 20);
            this.lblNoTarjetaCR.TabIndex = 53;
            this.lblNoTarjetaCR.Text = "No. Tarjeta de Credito";
            // 
            // lblTipoPersona
            // 
            this.lblTipoPersona.AutoSize = true;
            this.lblTipoPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPersona.Location = new System.Drawing.Point(360, 44);
            this.lblTipoPersona.Name = "lblTipoPersona";
            this.lblTipoPersona.Size = new System.Drawing.Size(123, 20);
            this.lblTipoPersona.TabIndex = 52;
            this.lblTipoPersona.Text = "Tipo de persona";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(61, 175);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(59, 20);
            this.lblCedula.TabIndex = 51;
            this.lblCedula.Text = "Cedula";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(61, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 50;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNoTarjetaCR
            // 
            this.txtNoTarjetaCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoTarjetaCR.Location = new System.Drawing.Point(65, 281);
            this.txtNoTarjetaCR.MaxLength = 16;
            this.txtNoTarjetaCR.Name = "txtNoTarjetaCR";
            this.txtNoTarjetaCR.Size = new System.Drawing.Size(226, 26);
            this.txtNoTarjetaCR.TabIndex = 48;
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(65, 198);
            this.txtCedula.MaxLength = 13;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(226, 26);
            this.txtCedula.TabIndex = 47;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(65, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(226, 26);
            this.txtNombre.TabIndex = 46;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 435);
            this.Controls.Add(this.panel1);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimiteCredito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.NumericUpDown nudLimiteCredito;
        private System.Windows.Forms.ComboBox cmbTipoPersona;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblLimiteCredito;
        private System.Windows.Forms.Label lblNoTarjetaCR;
        private System.Windows.Forms.Label lblTipoPersona;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNoTarjetaCR;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}