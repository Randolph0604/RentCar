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

namespace RentCar.Views.Tipos_Combustibles
{
    public partial class frmTipos_Combustibles : Form
    {
        public int? Id_Tipos_Combustible;
        Models.Tipos_Combustibles oTipos_Combustibles = null;
        public frmTipos_Combustibles(int? Id_Tipos_Combustible = null)
        {
            InitializeComponent();

            this.Id_Tipos_Combustible = Id_Tipos_Combustible;
            if (Id_Tipos_Combustible != null)
                LoadData();
        }
        private void frmTipos_Combustibles_Load(object sender, EventArgs e)
        {
           
        }

        #region HELPER
        private void LoadData()
        {
            using (rentcarEntities db = new rentcarEntities())
            {
                oTipos_Combustibles = db.Tipos_Combustibles.Find(Id_Tipos_Combustible);
                txtDescripcion.Text = oTipos_Combustibles.Descripcion;
                cmbEstado.Text = oTipos_Combustibles.Estado;
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
                    if (Id_Tipos_Combustible == null)
                        oTipos_Combustibles = new Models.Tipos_Combustibles();

                    if (txtDescripcion.Text.Trim().Equals("") || cmbEstado.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Por favor, llenar todos los campos.");
                    }
                    else
                    {
                        var exists = db.Tipos_Combustibles.Any(x => x.Descripcion.Equals(txtDescripcion.Text));

                        if (exists && Id_Tipos_Combustible == null)
                        {
                            MessageBox.Show("Este tipo de combustible ya habia sido registrado.");
                            return;
                        }
                        else 
                        {
                            oTipos_Combustibles.Descripcion = txtDescripcion.Text;
                            oTipos_Combustibles.Estado = cmbEstado.Text;

                            if (Id_Tipos_Combustible == null)
                                db.Tipos_Combustibles.Add(oTipos_Combustibles);
                            else
                            {
                                db.Entry(oTipos_Combustibles).State = System.Data.Entity.EntityState.Modified;
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
