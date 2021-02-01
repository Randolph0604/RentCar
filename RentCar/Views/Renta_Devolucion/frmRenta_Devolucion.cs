using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentCar.Models;

namespace RentCar.Views.Renta_Devolucion
{
    public partial class frmRenta_Devolucion : Form
    {
        public int? Id_Renta;
        Models.Renta_Devolucion oRenta = null;
        public frmRenta_Devolucion(int? Id_Renta = null)
        {
            InitializeComponent();
            this.Id_Renta = Id_Renta;
            if (Id_Renta != null)
            {
                LoadData();
            }
            else 
            {
                FillCombo();
            }
        }

        private void frmRenta_Devolucion_Load(object sender, EventArgs e)
        {
            
        }

        #region HELPER
        private void LoadData()
        {
            using (rentcarEntities db = new rentcarEntities())
            {
                oRenta = db.Renta_Devolucion.Find(Id_Renta);
                
                dtpRenta.Value = oRenta.Fecha_Renta;
                dtpDevolucion.Value = oRenta.Fecha_Devolucion;
                nudMontoxDia.Value = oRenta.MontoxDia;
                nudCantidadDias.Value = oRenta.Cantidad_Dias;
                txtComentario.Text = oRenta.Comentario;
                cmbEstado.Text = oRenta.Estado;

                var empleados = db.Empleados.Where(x => x.Estado == "Activo").Select(x => new { x.Id_Empleado, Empleado = x.Nombre + " " + x.Apellido }).ToList();
                var empSelected = db.Empleados.Where(w => w.Id_Empleado == oRenta.Empleado).Select(x => new { x.Id_Empleado, Empleado = x.Nombre + " " + x.Apellido }).FirstOrDefault();

                empleados.Insert(0, empSelected);
                empleados = empleados.Distinct().ToList();

                cmbEmpleado.DataSource = empleados;
                cmbEmpleado.DisplayMember = "Empleado";
                cmbEmpleado.ValueMember = "Id_Empleado";
                cmbEmpleado.SelectedItem = empSelected;

                var vehiculos = db.Vehiculos.Where(x => x.Estado == "Disponible").Select(x => new { x.Id_Vehiculo, Vehiculo = x.Descripcion + " - " + x.No_Placa }).ToList();
                var vehiculoSelected = db.Vehiculos.Where(w => w.Id_Vehiculo == oRenta.Vehiculo).Select(x => new { x.Id_Vehiculo, Vehiculo = x.Descripcion + " - " + x.No_Placa }).ToList().FirstOrDefault();

                vehiculos.Insert(0, vehiculoSelected);
                vehiculos = vehiculos.Distinct().ToList();

                cmbVehiculo.DataSource = vehiculos;
                cmbVehiculo.DisplayMember = "Vehiculo";
                cmbVehiculo.ValueMember = "Id_Vehiculo";  
                cmbVehiculo.SelectedItem = vehiculoSelected;

                var clientes = db.Clientes.Where(x => x.Estado == "Activo").Select(x => new { x.Id_Cliente, Cliente =x.Nombre + " " + x.Apellido }).ToList();
                var clienteSelected = db.Clientes.Where(w => w.Id_Cliente == oRenta.Cliente).Select(x => new { x.Id_Cliente, Cliente = x.Nombre + " " + x.Apellido }).ToList().FirstOrDefault();

                clientes.Insert(0, clienteSelected);
                clientes = clientes.Distinct().ToList();

                cmbCliente.DataSource = clientes;
                cmbCliente.DisplayMember = "Cliente";
                cmbCliente.ValueMember = "Id_Cliente";
                cmbCliente.SelectedItem = vehiculoSelected;
            }
        }
        public void DaysCount() 
        {
            try
            {
                DateTime FechaRenta = dtpRenta.Value.Date;
                DateTime FechaDevolucion = dtpDevolucion.Value.Date;
                TimeSpan tSpan = FechaDevolucion - FechaRenta;

                int Dias = tSpan.Days;
                nudCantidadDias.Value = Dias;
            }
            catch 
            {
                MessageBox.Show("Por favor, seleccione una fecha de devolución mayor a la de renta.");
            }
        }
        private void dtpDevolucion_ValueChanged(object sender, EventArgs e)
        {
            DaysCount();
        }
        #endregion

        #region FILLERS
        private void FillCombo()
        {
            try
            {
                using (rentcarEntities db = new rentcarEntities())
                {
                    var empleados = db.Empleados.Where(x => x.Estado == "Activo").Select(x => new { x.Id_Empleado, Empleado = x.Nombre + " " + x.Apellido }).ToList();
                    cmbEmpleado.DataSource = empleados;
                    cmbEmpleado.DisplayMember = "Empleado";
                    cmbEmpleado.ValueMember = "Id_Empleado";
                    if (cmbEmpleado.Items.Count > 1)
                        cmbEmpleado.SelectedIndex = -1;

                    var clientes = db.Clientes.Where(x => x.Estado == "Activo").Select(x => new { x.Id_Cliente, Cliente = x.Nombre + " " + x.Apellido }).ToList();
                    cmbCliente.DataSource = clientes;
                    cmbCliente.DisplayMember = "Cliente";
                    cmbCliente.ValueMember = "Id_Cliente";
                    if (cmbCliente.Items.Count > 1)
                        cmbCliente.SelectedIndex = -1;

                    var vehiculos = db.Vehiculos.Where(x => x.Estado == "Disponible").Select(x => new { x.Id_Vehiculo, Vehiculo = x.Descripcion + " - " + x.No_Placa }).ToList();
                    cmbVehiculo.DataSource = vehiculos;
                    cmbVehiculo.DisplayMember = "Vehiculo";
                    cmbVehiculo.ValueMember = "Id_Vehiculo";
                    if (cmbVehiculo.Items.Count > 1)
                        cmbVehiculo.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region BUTTONS
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (rentcarEntities db = new rentcarEntities())
                {
                    if (Id_Renta == null)
                        oRenta = new Models.Renta_Devolucion();

                    if (cmbEmpleado.Text.Trim().Equals("") || cmbVehiculo.Text.Trim().Equals("") || cmbCliente.Text.Trim().Equals("") ||
                        cmbEstado.Text.Trim().Equals("") || dtpRenta.Text.Trim().Equals("") || dtpDevolucion.Text.Trim().Equals("") ||
                        nudMontoxDia.Text.Trim().Equals("") || nudCantidadDias.Text.Trim().Equals("") || txtComentario.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Por favor, llenar todos los campos.");
                    }
                    else 
                    {
                        try
                        {
                            if (dtpRenta.Value > dtpDevolucion.Value)
                            {
                                MessageBox.Show("Debe seleccionar una fecha de devolución mayor a la de renta.");
                            }
                            else 
                            {
                                oRenta.Empleado = Convert.ToInt32(cmbEmpleado.SelectedValue.ToString());
                                oRenta.Vehiculo = Convert.ToInt32(cmbVehiculo.SelectedValue.ToString());
                                oRenta.Cliente = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
                                oRenta.Fecha_Renta = dtpRenta.Value;
                                oRenta.Fecha_Devolucion = dtpDevolucion.Value;
                                oRenta.MontoxDia = Convert.ToInt32(nudMontoxDia.Value);
                                oRenta.Cantidad_Dias = Convert.ToInt32(nudCantidadDias.Value);
                                oRenta.Comentario = txtComentario.Text;
                                oRenta.Estado = cmbEstado.Text;

                                if (Id_Renta == null)
                                    db.Renta_Devolucion.Add(oRenta);
                                else
                                {
                                    db.Entry(oRenta).State = System.Data.Entity.EntityState.Modified;
                                }
                                db.SaveChanges();
                                MessageBox.Show("Guardado exitosamente");
                                this.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region COMPONENTS
        private void lblNoChasis_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
