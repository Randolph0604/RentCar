
namespace RentCar.Views.Renta_Devolucion
{
    partial class frmRenta_Devolucion
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
            this.nudCantidadDias = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudMontoxDia = new System.Windows.Forms.NumericUpDown();
            this.dtpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.lblDevolucion = new System.Windows.Forms.Label();
            this.dtpRenta = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblComentario = new System.Windows.Forms.Label();
            this.cmbVehiculo = new System.Windows.Forms.ComboBox();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblMontoxDia = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.panelChildFrom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoxDia)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChildFrom
            // 
            this.panelChildFrom.BackColor = System.Drawing.Color.White;
            this.panelChildFrom.Controls.Add(this.nudCantidadDias);
            this.panelChildFrom.Controls.Add(this.lblCantidad);
            this.panelChildFrom.Controls.Add(this.nudMontoxDia);
            this.panelChildFrom.Controls.Add(this.dtpDevolucion);
            this.panelChildFrom.Controls.Add(this.lblDevolucion);
            this.panelChildFrom.Controls.Add(this.dtpRenta);
            this.panelChildFrom.Controls.Add(this.lblFecha);
            this.panelChildFrom.Controls.Add(this.cmbEmpleado);
            this.panelChildFrom.Controls.Add(this.cmbCliente);
            this.panelChildFrom.Controls.Add(this.lblCliente);
            this.panelChildFrom.Controls.Add(this.lblEmpleado);
            this.panelChildFrom.Controls.Add(this.lblComentario);
            this.panelChildFrom.Controls.Add(this.cmbVehiculo);
            this.panelChildFrom.Controls.Add(this.lblVehiculo);
            this.panelChildFrom.Controls.Add(this.btnGuardar);
            this.panelChildFrom.Controls.Add(this.cmbEstado);
            this.panelChildFrom.Controls.Add(this.lblEstado);
            this.panelChildFrom.Controls.Add(this.lblMontoxDia);
            this.panelChildFrom.Controls.Add(this.txtComentario);
            this.panelChildFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildFrom.Location = new System.Drawing.Point(0, 0);
            this.panelChildFrom.Name = "panelChildFrom";
            this.panelChildFrom.Size = new System.Drawing.Size(731, 438);
            this.panelChildFrom.TabIndex = 3;
            // 
            // nudCantidadDias
            // 
            this.nudCantidadDias.Enabled = false;
            this.nudCantidadDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidadDias.Location = new System.Drawing.Point(356, 162);
            this.nudCantidadDias.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudCantidadDias.Name = "nudCantidadDias";
            this.nudCantidadDias.ReadOnly = true;
            this.nudCantidadDias.Size = new System.Drawing.Size(226, 26);
            this.nudCantidadDias.TabIndex = 60;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(352, 139);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(128, 20);
            this.lblCantidad.TabIndex = 59;
            this.lblCantidad.Text = "Cantidad de dias";
            // 
            // nudMontoxDia
            // 
            this.nudMontoxDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMontoxDia.Location = new System.Drawing.Point(356, 225);
            this.nudMontoxDia.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudMontoxDia.Name = "nudMontoxDia";
            this.nudMontoxDia.Size = new System.Drawing.Size(226, 26);
            this.nudMontoxDia.TabIndex = 58;
            // 
            // dtpDevolucion
            // 
            this.dtpDevolucion.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDevolucion.Location = new System.Drawing.Point(356, 105);
            this.dtpDevolucion.Name = "dtpDevolucion";
            this.dtpDevolucion.Size = new System.Drawing.Size(226, 20);
            this.dtpDevolucion.TabIndex = 57;
            this.dtpDevolucion.ValueChanged += new System.EventHandler(this.dtpDevolucion_ValueChanged);
            // 
            // lblDevolucion
            // 
            this.lblDevolucion.AutoSize = true;
            this.lblDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevolucion.Location = new System.Drawing.Point(352, 80);
            this.lblDevolucion.Name = "lblDevolucion";
            this.lblDevolucion.Size = new System.Drawing.Size(155, 20);
            this.lblDevolucion.TabIndex = 56;
            this.lblDevolucion.Text = "Fecha de devolucion";
            // 
            // dtpRenta
            // 
            this.dtpRenta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRenta.Location = new System.Drawing.Point(356, 42);
            this.dtpRenta.Name = "dtpRenta";
            this.dtpRenta.Size = new System.Drawing.Size(226, 20);
            this.dtpRenta.TabIndex = 55;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(352, 17);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(117, 20);
            this.lblFecha.TabIndex = 54;
            this.lblFecha.Text = "Fecha de renta";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.DisplayMember = "Descripcion";
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(38, 40);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(226, 28);
            this.cmbEmpleado.TabIndex = 47;
            this.cmbEmpleado.ValueMember = "Descripcion";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DisplayMember = "Descripcion";
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(38, 162);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(226, 28);
            this.cmbCliente.TabIndex = 44;
            this.cmbCliente.ValueMember = "Descripcion";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(34, 139);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(58, 20);
            this.lblCliente.TabIndex = 43;
            this.lblCliente.Text = "Cliente";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(34, 17);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(81, 20);
            this.lblEmpleado.TabIndex = 41;
            this.lblEmpleado.Text = "Empleado";
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.Location = new System.Drawing.Point(34, 271);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(91, 20);
            this.lblComentario.TabIndex = 36;
            this.lblComentario.Text = "Comentario";
            this.lblComentario.Click += new System.EventHandler(this.lblNoChasis_Click);
            // 
            // cmbVehiculo
            // 
            this.cmbVehiculo.DisplayMember = "Descripcion";
            this.cmbVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVehiculo.FormattingEnabled = true;
            this.cmbVehiculo.Location = new System.Drawing.Point(38, 103);
            this.cmbVehiculo.Name = "cmbVehiculo";
            this.cmbVehiculo.Size = new System.Drawing.Size(226, 28);
            this.cmbVehiculo.TabIndex = 34;
            this.cmbVehiculo.ValueMember = "Descripcion";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(34, 80);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(70, 20);
            this.lblVehiculo.TabIndex = 33;
            this.lblVehiculo.Text = "Vehiculo";
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
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(38, 223);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(226, 28);
            this.cmbEstado.TabIndex = 27;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(34, 202);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 26;
            this.lblEstado.Text = "Estado";
            // 
            // lblMontoxDia
            // 
            this.lblMontoxDia.AutoSize = true;
            this.lblMontoxDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoxDia.Location = new System.Drawing.Point(352, 202);
            this.lblMontoxDia.Name = "lblMontoxDia";
            this.lblMontoxDia.Size = new System.Drawing.Size(93, 20);
            this.lblMontoxDia.TabIndex = 25;
            this.lblMontoxDia.Text = "Monto x Dia";
            // 
            // txtComentario
            // 
            this.txtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentario.Location = new System.Drawing.Point(38, 307);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(469, 81);
            this.txtComentario.TabIndex = 24;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // frmRenta_Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 438);
            this.Controls.Add(this.panelChildFrom);
            this.Name = "frmRenta_Devolucion";
            this.Text = "frmRenta_Devolucion";
            this.Load += new System.EventHandler(this.frmRenta_Devolucion_Load);
            this.panelChildFrom.ResumeLayout(false);
            this.panelChildFrom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoxDia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildFrom;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cmbVehiculo;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblMontoxDia;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.DateTimePicker dtpDevolucion;
        private System.Windows.Forms.Label lblDevolucion;
        private System.Windows.Forms.DateTimePicker dtpRenta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.NumericUpDown nudCantidadDias;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudMontoxDia;
        private System.Windows.Forms.Label lblComentario;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}