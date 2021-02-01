
namespace RentCar.Views.Consultas
{
    partial class Consultas
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaRenta = new System.Windows.Forms.DateTimePicker();
            this.ckFechaRenta = new System.Windows.Forms.CheckBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.txtCedulaEmpleado = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCedulaCliente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpFechaRenta);
            this.panel1.Controls.Add(this.ckFechaRenta);
            this.panel1.Controls.Add(this.lblEmpleado);
            this.panel1.Controls.Add(this.txtCedulaEmpleado);
            this.panel1.Controls.Add(this.lblPlaca);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Controls.Add(this.txtCedulaCliente);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtPlaca);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 438);
            this.panel1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Fecha de renta";
            // 
            // dtpFechaRenta
            // 
            this.dtpFechaRenta.Enabled = false;
            this.dtpFechaRenta.Location = new System.Drawing.Point(338, 82);
            this.dtpFechaRenta.Name = "dtpFechaRenta";
            this.dtpFechaRenta.Size = new System.Drawing.Size(225, 20);
            this.dtpFechaRenta.TabIndex = 30;
            this.dtpFechaRenta.ValueChanged += new System.EventHandler(this.dtpFechaRenta_ValueChanged);
            // 
            // ckFechaRenta
            // 
            this.ckFechaRenta.AutoSize = true;
            this.ckFechaRenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckFechaRenta.Location = new System.Drawing.Point(317, 83);
            this.ckFechaRenta.Name = "ckFechaRenta";
            this.ckFechaRenta.Size = new System.Drawing.Size(15, 14);
            this.ckFechaRenta.TabIndex = 29;
            this.ckFechaRenta.UseVisualStyleBackColor = true;
            this.ckFechaRenta.CheckedChanged += new System.EventHandler(this.ckFechaRenta_CheckedChanged);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(335, 9);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(117, 16);
            this.lblEmpleado.TabIndex = 28;
            this.lblEmpleado.Text = "Cedula Empleado";
            // 
            // txtCedulaEmpleado
            // 
            this.txtCedulaEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaEmpleado.Location = new System.Drawing.Point(338, 30);
            this.txtCedulaEmpleado.Name = "txtCedulaEmpleado";
            this.txtCedulaEmpleado.Size = new System.Drawing.Size(225, 22);
            this.txtCedulaEmpleado.TabIndex = 27;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AccessibleName = "lblMatricula";
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(30, 64);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(118, 16);
            this.lblPlaca.TabIndex = 26;
            this.lblPlaca.Text = "Placa del vehículo";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(29, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(95, 16);
            this.lblCliente.TabIndex = 25;
            this.lblCliente.Text = "Cedula Cliente";
            // 
            // txtCedulaCliente
            // 
            this.txtCedulaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaCliente.Location = new System.Drawing.Point(30, 30);
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.Size = new System.Drawing.Size(225, 22);
            this.txtCedulaCliente.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(601, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 23;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(30, 83);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(225, 22);
            this.txtPlaca.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 115);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(671, 295);
            this.dataGridView1.TabIndex = 18;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 438);
            this.Controls.Add(this.panel1);
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Consultas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpFechaRenta;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.TextBox txtCedulaEmpleado;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCedulaCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckFechaRenta;
    }
}