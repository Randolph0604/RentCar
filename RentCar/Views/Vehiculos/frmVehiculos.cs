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

namespace RentCar.Views.Vehiculos
{
    public partial class frmVehiculos : Form
    {
        public int? Id_Vehiculo;
        Models.Vehiculo oVehiculo = null;
        public frmVehiculos(int? Id_Vehiculo = null)
        {
            InitializeComponent();

            this.Id_Vehiculo = Id_Vehiculo;
            if (Id_Vehiculo != null)
            {
                LoadData();
            }
            else 
            {
                FillCombo();
            }
        }

        private void frmVehiculos_Load(object sender, EventArgs e)
        {
            
        }

        #region HELPER
        private void LoadData()
        {
            using (rentcarEntities db = new rentcarEntities())
            {
                oVehiculo = db.Vehiculos.Find(Id_Vehiculo);

                txtDescripcion.Text = oVehiculo.Descripcion;
                txtNoChasis.Text = oVehiculo.No_Chasis;
                txtNoMotor.Text = oVehiculo.No_Motor;
                txtNoPlaca.Text = oVehiculo.No_Placa;
                cmbEstado.Text = oVehiculo.Estado;

                var marcas = db.Marcas.Where(x => x.Estado == "Activo").Select(x => new { x.Id_Marca, x.Descripcion }).ToList();
                var marcaSelected = db.Marcas.Where(w => w.Id_Marca == oVehiculo.Marca).Select(x => new { x.Id_Marca, x.Descripcion }).FirstOrDefault();

                marcas.Insert(0, marcaSelected);
                marcas = marcas.Distinct().ToList();

                cmbMarca.DataSource = marcas;
                cmbMarca.DisplayMember = "Descripcion";
                cmbMarca.ValueMember = "Id_Marca";
                cmbMarca.SelectedItem = marcaSelected;

                var modelos = db.Modelos.Where(x => x.Estado == "Activo").Select(x => new { x.Id_Modelo, x.Descripcion }).ToList();
                var modeloSelected = db.Modelos.Where(w => w.Id_Modelo == oVehiculo.Modelo).Select(x => new { x.Id_Modelo, x.Descripcion }).FirstOrDefault();

                modelos.Insert(0, modeloSelected);
                modelos = modelos.Distinct().ToList();

                cmbModelo.DataSource = modelos;
                cmbModelo.DisplayMember = "Descripcion";
                cmbModelo.ValueMember = "Id_Modelo";
                cmbModelo.SelectedItem = modeloSelected;

                var combustibles = db.Tipos_Combustibles.Where(x => x.Estado == "Activo").Select(x => new { x.Id_Tipos_Combustible, x.Descripcion }).ToList();
                var combustibleSelected = db.Tipos_Combustibles.Where(w => w.Id_Tipos_Combustible == oVehiculo.Tipo_Combustible).Select(x => new { x.Id_Tipos_Combustible, x.Descripcion }).FirstOrDefault();

                combustibles.Insert(0, combustibleSelected);
                combustibles = combustibles.Distinct().ToList();

                cmbTipoCombustible.DataSource = combustibles;
                cmbTipoCombustible.DisplayMember = "Descripcion";
                cmbTipoCombustible.ValueMember = "Id_Tipos_Combustible";
                cmbTipoCombustible.SelectedItem = combustibleSelected;

                var tiposvehiculos = db.Tipos_Vehiculos.Where(x => x.Estado == "Activo").Select(x => new { x.Id_Tipos_Vehiculo, x.Descripcion }).ToList();
                var tipoSelected = db.Tipos_Vehiculos.Where(w => w.Id_Tipos_Vehiculo == oVehiculo.Tipo_Vehiculo).Select(x => new { x.Id_Tipos_Vehiculo, x.Descripcion }).FirstOrDefault();

                tiposvehiculos.Insert(0, tipoSelected);
                tiposvehiculos = tiposvehiculos.Distinct().ToList();

                cmbTipoVehiculo.DataSource = tiposvehiculos;
                cmbTipoVehiculo.DisplayMember = "Descripcion";
                cmbTipoVehiculo.ValueMember = "Id_Tipos_Vehiculo";
                cmbTipoVehiculo.SelectedItem = tipoSelected;
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
                    var tipos = db.Tipos_Vehiculos.Where(x => x.Estado == "Activo").Select(x => new { x.Id_Tipos_Vehiculo, x.Descripcion }).ToList();
                    cmbTipoVehiculo.DataSource = tipos;
                    cmbTipoVehiculo.DisplayMember = "Descripcion";
                    cmbTipoVehiculo.ValueMember = "Id_Tipos_Vehiculo";
                    if (cmbTipoVehiculo.Items.Count > 1)
                        cmbTipoVehiculo.SelectedIndex = -1;

                    var marcas = db.Marcas.Where(x => x.Estado == "Activo").Select(x => new { x.Id_Marca, x.Descripcion }).ToList();
                    cmbMarca.DataSource = marcas;
                    cmbMarca.DisplayMember = "Descripcion";
                    cmbMarca.ValueMember = "Id_Marca";
                    if (cmbMarca.Items.Count > 1)
                        cmbMarca.SelectedIndex = -1;

                    var modelos = db.Modelos.Where(x => x.Estado == "Activo").Select(x => new { x.Id_Modelo, x.Descripcion }).ToList();
                    cmbModelo.DataSource = modelos;
                    cmbModelo.DisplayMember = "Descripcion";
                    cmbModelo.ValueMember = "Id_Modelo";
                    if (cmbModelo.Items.Count > 1)
                        cmbModelo.SelectedIndex = -1;

                    var combustibles = db.Tipos_Combustibles.Where(x => x.Estado == "Activo").Select(x => new { x.Id_Tipos_Combustible, x.Descripcion }).ToList();
                    cmbTipoCombustible.DataSource = combustibles;
                    cmbTipoCombustible.DisplayMember = "Descripcion";
                    cmbTipoCombustible.ValueMember = "Id_Tipos_Combustible";
                    if (cmbTipoCombustible.Items.Count > 1)
                        cmbTipoCombustible.SelectedIndex = -1;
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
                    if (Id_Vehiculo == null)
                        oVehiculo = new Models.Vehiculo();

                    if (txtDescripcion.Text.Trim().Equals("") || txtNoChasis.Text.Trim().Equals("") || txtNoMotor.Text.Trim().Equals("") ||
                    txtNoPlaca.Text.Trim().Equals("") || cmbTipoVehiculo.Text.Trim().Equals("") || cmbMarca.Text.Trim().Equals("") ||
                    cmbModelo.Text.Trim().Equals("") || cmbTipoCombustible.Text.Trim().Equals("") || cmbEstado.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Por favor, llenar todos los campos.");
                    }
                    else
                    {
                        var exists = db.Vehiculos.Any(x => x.No_Placa.Equals(txtNoPlaca.Text) || x.No_Chasis.Equals(txtNoChasis.Text));

                        if (exists && Id_Vehiculo == null)
                        {
                            MessageBox.Show("Este vehículo ya habia sido registrado.");
                            return;
                        }
                        else 
                        {
                            oVehiculo.Descripcion = txtDescripcion.Text;
                            oVehiculo.No_Chasis = txtNoChasis.Text;
                            oVehiculo.No_Motor = txtNoMotor.Text;
                            oVehiculo.No_Placa = txtNoPlaca.Text;
                            oVehiculo.Tipo_Vehiculo = Convert.ToInt32(cmbTipoVehiculo.SelectedValue.ToString());
                            oVehiculo.Marca = Convert.ToInt32(cmbMarca.SelectedValue.ToString());
                            oVehiculo.Modelo = Convert.ToInt32(cmbModelo.SelectedValue.ToString());
                            oVehiculo.Tipo_Combustible = Convert.ToInt32(cmbTipoCombustible.SelectedValue.ToString());
                            oVehiculo.Estado = cmbEstado.Text;

                            if (Id_Vehiculo == null)
                                db.Vehiculos.Add(oVehiculo);
                            else
                            {
                                db.Entry(oVehiculo).State = System.Data.Entity.EntityState.Modified;
                            }
                            db.SaveChanges();
                            MessageBox.Show("Guardado exitosamente");
                            this.Close();
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

        private void cmbMarca_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelChildFrom_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion
    }
}
