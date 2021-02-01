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

namespace RentCar.Views.Tipos_Vehiculos
{
    public partial class frmTipos_Vehiculos : Form
    {
        public int? Id_Tipos_Vehiculos;
        Models.Tipos_Vehiculos oTipos_Vehiculos = null;
        public frmTipos_Vehiculos(int? Id_Tipos_Vehiculos = null)
        {
            InitializeComponent();

            this.Id_Tipos_Vehiculos = Id_Tipos_Vehiculos;
            if (Id_Tipos_Vehiculos != null)
                LoadData();
        }

        private void frmTipos_Vehiculos_Load(object sender, EventArgs e)
        {
            
        }

        #region HELPER
        private void LoadData()
        {
            using (rentcarEntities db = new rentcarEntities())
            {
                oTipos_Vehiculos = db.Tipos_Vehiculos.Find(Id_Tipos_Vehiculos);
                txtDescripcion.Text = oTipos_Vehiculos.Descripcion;
                cmbEstado.Text = oTipos_Vehiculos.Estado;
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
                    if (Id_Tipos_Vehiculos == null)
                        oTipos_Vehiculos = new Models.Tipos_Vehiculos();

                    if (txtDescripcion.Text.Trim().Equals("") || cmbEstado.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Por favor, llenar todos los campos.");
                    }
                    else
                    {
                        var exists = db.Tipos_Vehiculos.Any(x => x.Descripcion.Equals(txtDescripcion.Text));

                        if (exists && Id_Tipos_Vehiculos == null)
                        {
                            MessageBox.Show("Este tipo de Vehiculo ya habia sido registrado.");
                            return;
                        }
                        else 
                        {
                            oTipos_Vehiculos.Descripcion = txtDescripcion.Text;
                            oTipos_Vehiculos.Estado = cmbEstado.Text;

                            if (Id_Tipos_Vehiculos == null)
                                db.Tipos_Vehiculos.Add(oTipos_Vehiculos);
                            else
                            {
                                db.Entry(oTipos_Vehiculos).State = System.Data.Entity.EntityState.Modified;
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
