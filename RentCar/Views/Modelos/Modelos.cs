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

namespace RentCar.Views.Modelos
{
    public partial class Modelos : Form
    {
        public Modelos()
        {
            InitializeComponent();
        }

        private void Modelos_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        #region HELPER
        private void Refresh()
        {
            using (rentcarEntities db = new rentcarEntities())
            {

                var lst = (from Modelos in db.Modelos
                          join Marcas in db.Marcas
                          on Modelos.Id_Marca equals Marcas.Id_Marca
                          select new { Id = Modelos.Id_Modelo,
                                       Marca = Marcas.Descripcion,
                                       Modelo = Modelos.Descripcion,                                                                           
                                       Estado = Modelos.Estado}).AsQueryable();

                if (!txtBusqueda.Text.Trim().Equals(""))
                {
                    lst = lst.Where(d => d.Marca.Contains(txtBusqueda.Text.Trim()));
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
            /*OpenChildForm(new Views.Modelos.frmModelos());*/
            Views.Modelos.frmModelos oFrmModelos = new Views.Modelos.frmModelos();
            oFrmModelos.ShowDialog();
            Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? Id_Modelo = GetId();
            if (Id_Modelo != null)
            {
                /*OpenChildForm(new Views.Modelos.frmModelos(Id_Modelo));*/
                Views.Modelos.frmModelos oFrmModelos = new Views.Modelos.frmModelos(Id_Modelo);
                oFrmModelos.ShowDialog();
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
                    int? Id_Modelo = GetId();
                    if (Id_Modelo != null)
                    {
                        using (rentcarEntities db = new rentcarEntities())
                        {
                            Models.Modelo oModelo = db.Modelos.Find(Id_Modelo);
                            db.Modelos.Remove(oModelo);
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
