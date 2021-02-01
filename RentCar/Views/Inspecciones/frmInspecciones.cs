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

namespace RentCar.Views.Inspecciones
{
    public partial class frmInspecciones : Form
    {
        public int? Id_Transaccion;
        Models.Inspeccione oInspeccione = null;
        public frmInspecciones(int? Id_Transaccion = null)
        {
            InitializeComponent();
            this.Id_Transaccion = Id_Transaccion;
            if (Id_Transaccion != null)
            {
                LoadData();
            }
            else 
            {
                FillCombo();
            }
        }

        private void frmInspecciones_Load(object sender, EventArgs e)
        {
           
        }

        #region HELPER
        private void LoadData()
        {
            using (rentcarEntities db = new rentcarEntities())
            {
                oInspeccione = db.Inspecciones.Find(Id_Transaccion);
            
                cmbCantidadCombustible.Text = oInspeccione.Cantidad_Combustible;
                cmbEstadoGomaA.Text = oInspeccione.Estado_GomaA;
                cmbEstadoGomaB.Text = oInspeccione.Estado_GomaB;
                cmbEstadoGomaC.Text = oInspeccione.Estado_GomaC;
                cmbEstadoGomaD.Text = oInspeccione.Estado_GomaD;
                dtpInspeccion.Value = oInspeccione.Fecha;
                cmbEstado.Text = oInspeccione.Estado;
                ckRalladuras.Checked = oInspeccione.Tiene_Ralladuras == "Si" ? true : false;
                ckRespuesta.Checked = oInspeccione.Tiene_Goma_respuesta == "Si" ? true : false;
                ckGato.Checked = oInspeccione.Tiene_Gato == "Si" ? true : false;
                ckRoturas.Checked = oInspeccione.Tiene_Roturas_Cristal == "Si" ? true : false;


                var empleados = db.Empleados.Where(x => x.Estado == "Activo").Select(x => new { x.Id_Empleado, Empleado = x.Nombre + " " + x.Apellido }).ToList();
                var empSelected = db.Empleados.Where(w => w.Id_Empleado == oInspeccione.Empleado_Inspeccion).Select(x => new { x.Id_Empleado, Empleado = x.Nombre + " " + x.Apellido }).FirstOrDefault();

                empleados.Insert(0, empSelected);
                empleados = empleados.Distinct().ToList();

                cmbEmpleado.DataSource = empleados;
                cmbEmpleado.DisplayMember = "Empleado";
                cmbEmpleado.ValueMember = "Id_Empleado";
                cmbEmpleado.SelectedItem = empSelected;


                var vehiculos = db.Vehiculos.Where(x => x.Estado == "Disponible").Select(x => new { x.Id_Vehiculo, Vehiculo = x.Descripcion + " - " + x.No_Placa }).ToList();
                var vehiculoSelected = db.Vehiculos.Where(w => w.Id_Vehiculo == oInspeccione.Vehiculo).Select(x => new { x.Id_Vehiculo, Vehiculo = x.Descripcion + " - " + x.No_Placa }).ToList().FirstOrDefault();

                vehiculos.Insert(0, vehiculoSelected);
                vehiculos = vehiculos.Distinct().ToList();

                cmbVehiculo.DataSource = vehiculos;
                cmbVehiculo.DisplayMember = "Vehiculo"; 
                cmbVehiculo.ValueMember = "Id_Vehiculo";  
                cmbVehiculo.SelectedItem = vehiculoSelected;


                var clientes = db.Clientes.Where(x => x.Estado == "Activo").Select(x => new { x.Id_Cliente, Cliente = x.Nombre + " " + x.Apellido }).ToList();
                var clienteSelected = db.Clientes.Where(w => w.Id_Cliente == oInspeccione.Id_Cliente).Select(x => new { x.Id_Cliente, Cliente = x.Nombre + " " + x.Apellido }).ToList().FirstOrDefault();

                clientes.Insert(0, clienteSelected);
                clientes = clientes.Distinct().ToList();

                cmbCliente.DataSource = clientes;
                cmbCliente.DisplayMember = "Cliente";
                cmbCliente.ValueMember = "Id_Cliente"; 
                cmbCliente.SelectedItem = vehiculoSelected;

            }
        }
        #endregion

        #region FILLERS
        private void FillCombo()
        {
            try
            {
                using (rentcarEntities db = new rentcarEntities())
                {
                    var vehiculos = db.Vehiculos.Where(x => x.Estado == "Disponible").Select(x => new { x.Id_Vehiculo, Vehiculo = x.Descripcion + " - " + x.No_Placa }).ToList();
                    cmbVehiculo.DataSource = vehiculos;
                    cmbVehiculo.DisplayMember = "Vehiculo";
                    cmbVehiculo.ValueMember = "Id_Vehiculo";
                    if (cmbVehiculo.Items.Count > 1)
                        cmbVehiculo.SelectedIndex = -1;

                    var clientes = db.Clientes.Where(x => x.Estado == "Activo").Select(x => new { x.Id_Cliente, Cliente = x.Nombre + " " + x.Apellido }).ToList();
                    cmbCliente.DataSource = clientes;
                    cmbCliente.DisplayMember = "Cliente";
                    cmbCliente.ValueMember = "Id_Cliente";
                    if (cmbCliente.Items.Count > 1)
                        cmbCliente.SelectedIndex = -1;

                    var empleados = db.Empleados.Where(x => x.Estado == "Activo").Select(x => new { x.Id_Empleado, Empleado = x.Nombre + " " + x.Apellido }).ToList();
                    cmbEmpleado.DataSource = empleados;
                    cmbEmpleado.DisplayMember = "Empleado";
                    cmbEmpleado.ValueMember = "Id_Empleado";
                    if (cmbEmpleado.Items.Count > 1)
                        cmbEmpleado.SelectedIndex = -1;
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
                    if (Id_Transaccion == null)
                        oInspeccione = new Models.Inspeccione();

                    if (cmbVehiculo.Text.Trim().Equals("") || cmbCliente.Text.Trim().Equals("") || cmbCantidadCombustible.Text.Trim().Equals("") ||
                       cmbEstadoGomaA.Text.Trim().Equals("") || cmbEstadoGomaB.Text.Trim().Equals("") || cmbEstadoGomaC.Text.Trim().Equals("") ||
                       cmbEstadoGomaD.Text.Trim().Equals("") || dtpInspeccion.Text.Trim().Equals("") || cmbEmpleado.Text.Trim().Equals("") ||
                       cmbEstado.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Por favor, llenar todos los campos.");
                    }
                    else 
                    {
                        oInspeccione.Vehiculo = Convert.ToInt32(cmbVehiculo.SelectedValue.ToString());
                        oInspeccione.Id_Cliente = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
                        oInspeccione.Cantidad_Combustible = cmbCantidadCombustible.Text;
                        oInspeccione.Estado_GomaA = cmbEstadoGomaA.Text;
                        oInspeccione.Estado_GomaB = cmbEstadoGomaB.Text;
                        oInspeccione.Estado_GomaC = cmbEstadoGomaC.Text;
                        oInspeccione.Estado_GomaD = cmbEstadoGomaD.Text;
                        oInspeccione.Fecha = dtpInspeccion.Value;
                        oInspeccione.Empleado_Inspeccion = Convert.ToInt32(cmbEmpleado.SelectedValue.ToString());
                        oInspeccione.Estado = cmbEstado.Text;

                        if (ckRalladuras.Checked){oInspeccione.Tiene_Ralladuras = "Si";} 
                        else{oInspeccione.Tiene_Ralladuras = "No";}

                        if (ckRespuesta.Checked){oInspeccione.Tiene_Goma_respuesta = "Si";}
                        else{oInspeccione.Tiene_Goma_respuesta = "No";}

                        if (ckGato.Checked){oInspeccione.Tiene_Gato = "Si";}
                        else{ oInspeccione.Tiene_Gato = "No";}

                        if (ckRoturas.Checked){ oInspeccione.Tiene_Roturas_Cristal = "Si";}
                        else{ oInspeccione.Tiene_Roturas_Cristal = "No";}

                        if (Id_Transaccion == null)
                            db.Inspecciones.Add(oInspeccione);
                        else
                        {
                            db.Entry(oInspeccione).State = System.Data.Entity.EntityState.Modified;
                        }
                        db.SaveChanges();
                        MessageBox.Show("Guardado exitosamente");
                        this.Close();
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void ckRalladuras_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckRoturas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckRespuesta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckGato_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
