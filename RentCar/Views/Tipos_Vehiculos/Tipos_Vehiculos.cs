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
    public partial class Tipos_Vehiculos : Form
    {
        public Tipos_Vehiculos()
        {
            InitializeComponent();
        }

        private void Tipos_Vehiculos_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        #region HELPER
        private void Refresh()
        {
            using (rentcarEntities db = new rentcarEntities())
            {

                var lst = (from Tipos_Vehiculos in db.Tipos_Vehiculos
                          select new { Id = Tipos_Vehiculos.Id_Tipos_Vehiculo, 
                                       Descripcion = Tipos_Vehiculos.Descripcion, 
                                       Estado = Tipos_Vehiculos.Estado}).AsQueryable();

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
            /*OpenChildForm(new Views.Tipos_Vehiculos.frmTipos_Vehiculos());*/
            Views.Tipos_Vehiculos.frmTipos_Vehiculos oFrmTipos_Vehiculos = new Views.Tipos_Vehiculos.frmTipos_Vehiculos();
            oFrmTipos_Vehiculos.ShowDialog();
            Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? Id_Tipos_Vehiculo = GetId();
            if (Id_Tipos_Vehiculo != null)
            {
                /*OpenChildForm(new Views.Tipos_Vehiculos.frmTipos_Vehiculos(Id_Tipos_Vehiculo));*/
                Views.Tipos_Vehiculos.frmTipos_Vehiculos oFrmTipos_Vehiculos = new Views.Tipos_Vehiculos.frmTipos_Vehiculos(Id_Tipos_Vehiculo);
                oFrmTipos_Vehiculos.ShowDialog();
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
                    int? Id_Tipos_Vehiculo = GetId();
                    if (Id_Tipos_Vehiculo != null)
                    {
                        using (rentcarEntities db = new rentcarEntities())
                        {
                            Models.Tipos_Vehiculos oTipos_Vehiculo = db.Tipos_Vehiculos.Find(Id_Tipos_Vehiculo);
                            db.Tipos_Vehiculos.Remove(oTipos_Vehiculo);
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

        private void panelChildFrom_Paint(object sender, PaintEventArgs e)
        {

        }    
    }
}
