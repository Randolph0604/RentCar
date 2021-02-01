using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentCar.Views;
using RentCar.Models;

namespace RentCar.Views.Modelos
{
    public partial class frmModelos : Form
    {
        public int? Id_Modelo;
        Models.Modelo oModelo = null;
        public frmModelos(int? Id_Modelo = null)
        {
            InitializeComponent();

            this.Id_Modelo = Id_Modelo;
            if (Id_Modelo != null)
            {
                LoadData();
            }
            else 
            {
                FillCombo();
            }
        }

        private void frmModelos_Load(object sender, EventArgs e)
        {
            
        }

        #region HELPER
        private void LoadData()
        {
            using (rentcarEntities db = new rentcarEntities())
            {
                oModelo = db.Modelos.Find(Id_Modelo);
                txtDescripcion.Text = oModelo.Descripcion;
                cmbEstado.Text = oModelo.Estado;

                var marcas = db.Marcas.Where(x => x.Estado == "Activo").Select(x => new { x.Id_Marca, x.Descripcion }).ToList();
                var marcaSelected = db.Marcas.Where(w => w.Id_Marca == oModelo.Id_Marca).Select(x => new { x.Id_Marca, x.Descripcion }).FirstOrDefault();

                marcas.Insert(0, marcaSelected);
                marcas = marcas.Distinct().ToList();

                cmbMarca.DataSource = marcas;
                cmbMarca.DisplayMember = "Descripcion";
                cmbMarca.ValueMember = "Id_Marca";
                cmbMarca.SelectedItem = marcaSelected;
            }
        }

        private void FillCombo()
        {
            try
            {
                using (rentcarEntities db = new rentcarEntities())
                {
                    var marcas = db.Marcas.Where(x => x.Estado == "Activo").Select(x => new { x.Id_Marca, x.Descripcion }).ToList();
                    cmbMarca.DataSource = marcas;
                    cmbMarca.DisplayMember = "Descripcion";
                    cmbMarca.ValueMember = "Id_Marca";
                    if (cmbMarca.Items.Count > 1)
                        cmbMarca.SelectedIndex = -1;
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
                    if (Id_Modelo == null)
                        oModelo = new Models.Modelo();

                    if (cmbMarca.Text.Trim().Equals("") || txtDescripcion.Text.Trim().Equals("") || cmbEstado.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Por favor, llenar todos los campos.");
                    }
                    else 
                    {
                        var exists = db.Modelos.Any(x => x.Descripcion.Equals(txtDescripcion.Text));

                        if (exists && Id_Modelo == null)
                        {
                            MessageBox.Show("Esta marca ya esta registrada.");
                            return;
                        }
                        else
                        {
                            oModelo.Id_Marca = Convert.ToInt32(cmbMarca.SelectedValue.ToString());
                            oModelo.Descripcion = txtDescripcion.Text;
                            oModelo.Estado = cmbEstado.Text;

                            if (Id_Modelo == null)
                                db.Modelos.Add(oModelo);
                            else
                            {
                                db.Entry(oModelo).State = System.Data.Entity.EntityState.Modified;
                            }
                            db.SaveChanges();
                            MessageBox.Show("Guardado exitosamente.");
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
    }
}
