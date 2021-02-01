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
    public partial class Marcas : Form
    {
        public Marcas()
        {
            InitializeComponent();
        }

        private void Marcas_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        #region HELPER
        private void Refresh()
        {
            using (rentcarEntities db = new rentcarEntities())
            {
                var lst = (from Marcas in db.Marcas 
                          select new { Id = Marcas.Id_Marca, 
                              Descripcion = Marcas.Descripcion, 
                              Estado = Marcas.Estado}).AsQueryable();

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
            /*OpenChildForm(new Views.Marcas.frmMarcas());*/
            Views.Marcas.frmMarcas oFrmMarcas = new Views.Marcas.frmMarcas();
            oFrmMarcas.ShowDialog();
            Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? Id_Marca = GetId();
            if (Id_Marca != null)
            {
                /*OpenChildForm(new Views.Marcas.frmMarcas(Id_Marca));*/
                Views.Marcas.frmMarcas oFrmMarcas = new Views.Marcas.frmMarcas(Id_Marca);
                oFrmMarcas.ShowDialog();
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
                    int? Id_Marca = GetId();
                    if (Id_Marca != null)
                    {
                        using (rentcarEntities db = new rentcarEntities())
                        {
                            Models.Marca oMarca = db.Marcas.Find(Id_Marca);
                            db.Marcas.Remove(oMarca);
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
