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

namespace RentCar.Views.Marcas
{
    public partial class frmMarcas : Form
    {
        public int? Id_Marca;
        Models.Marca oMarca = null;
        public frmMarcas(int? Id_Marca = null)
        {
            InitializeComponent();

            this.Id_Marca = Id_Marca;
            if (Id_Marca != null)
                LoadData();

        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
           
        }

        #region HELPER
        private void LoadData()
        {
            using (rentcarEntities db = new rentcarEntities())
            {
                oMarca = db.Marcas.Find(Id_Marca);
                txtDescripcion.Text = oMarca.Descripcion;
                cmbEstado.Text = oMarca.Estado;     
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
                    if (Id_Marca == null)
                        oMarca = new Models.Marca();

                    if (txtDescripcion.Text.Trim().Equals("") || cmbEstado.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Por favor, llenar todos los campos.");
                    }
                    else 
                    {
                        var exists = db.Marcas.Any(x => x.Descripcion.Equals(txtDescripcion.Text));

                        if (exists && Id_Marca == null)
                        {
                            MessageBox.Show("Esta marca ya habia sido registrada.");
                            return;
                        }
                        else 
                        {
                            oMarca.Descripcion = txtDescripcion.Text;
                            oMarca.Estado = cmbEstado.Text;

                            if (Id_Marca == null)
                                db.Marcas.Add(oMarca);
                            else
                            {
                                db.Entry(oMarca).State = System.Data.Entity.EntityState.Modified;
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
    }
}
