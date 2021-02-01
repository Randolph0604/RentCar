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
    public partial class Vehiculos : Form
    {
        public Vehiculos()
        {
            InitializeComponent();
        }

        private void Vehiculos_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        #region HELPER
        private void Refresh()
        {
            using (rentcarEntities db = new rentcarEntities())
            {

                var lst = (from Vehiculo in db.Vehiculos
                          join Tipos_Vehiculos in db.Tipos_Vehiculos
                          on Vehiculo.Tipo_Vehiculo equals Tipos_Vehiculos.Id_Tipos_Vehiculo
                          join Marcas in db.Marcas
                          on Vehiculo.Marca equals Marcas.Id_Marca
                          join Modelos in db.Modelos
                          on Vehiculo.Modelo equals Modelos.Id_Modelo
                          join Tipos_Combustibles in db.Tipos_Combustibles
                          on Vehiculo.Tipo_Combustible equals Tipos_Combustibles.Id_Tipos_Combustible
                          select new
                          {
                              Id = Vehiculo.Id_Vehiculo,
                              Descripcion = Vehiculo.Descripcion,
                              Chasis = Vehiculo.No_Chasis,
                              Motor = Vehiculo.No_Motor,
                              Placa = Vehiculo.No_Placa,
                              TipoVehiculo = Tipos_Vehiculos.Descripcion,
                              Marca = Marcas.Descripcion,
                              Modelo = Modelos.Descripcion,
                              TipoCombustible = Tipos_Combustibles.Descripcion,
                              Estado = Vehiculo.Estado
                          }).AsQueryable();

                if (!txtBusqueda.Text.Trim().Equals(""))
                {
                    lst = lst.Where(d => d.Descripcion.Contains(txtBusqueda.Text.Trim()));
                }

                dataGridView1.DataSource = lst.ToList();
            }
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region BUTTONS
        private void btnCrear_Click(object sender, EventArgs e)
        {
            /*OpenChildForm(new Views.Vehiculos.frmVehiculos());*/
            Views.Vehiculos.frmVehiculos oFrmVehiculos = new Views.Vehiculos.frmVehiculos();
            oFrmVehiculos.ShowDialog();
            Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? Id_Vehiculo = GetId();
            if (Id_Vehiculo != null)
            {
                /*OpenChildForm(new Views.Vehiculos.frmVehiculos(Id_Vehiculo));*/
                Views.Vehiculos.frmVehiculos oFrmVehiculos = new Views.Vehiculos.frmVehiculos(Id_Vehiculo);
                oFrmVehiculos.ShowDialog();
                Refresh();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "¿Estas seguro de eliminar el registo?";
                string title = "Eliminar";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    int? Id_Vehiculo = GetId();
                    if (Id_Vehiculo != null)
                    {
                        using (rentcarEntities db = new rentcarEntities())
                        {
                            Models.Vehiculo oVehiculo = db.Vehiculos.Find(Id_Vehiculo);
                            db.Vehiculos.Remove(oVehiculo);
                            db.SaveChanges();
                        }
                        Refresh();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Este registro esta enzalado a otra tabla.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        #endregion

        #region VIEWS
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildFrom.Controls.Add(childForm);
            panelChildFrom.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        #endregion     
    }
}
