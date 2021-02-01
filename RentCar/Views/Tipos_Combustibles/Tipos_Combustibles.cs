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
    public partial class Tipos_Combustibles : Form
    {
        public Tipos_Combustibles()
        {
            InitializeComponent();
        }

        private void Tipos_Combustibles_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        #region HELPER
        private void Refresh()
        {
            using (rentcarEntities db = new rentcarEntities())
            {

                var lst = (from Tipos_Combustibles in db.Tipos_Combustibles
                          select new { Id = Tipos_Combustibles.Id_Tipos_Combustible, 
                                       Descripcion = Tipos_Combustibles.Descripcion, 
                                       Estado = Tipos_Combustibles.Estado}).AsQueryable();

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
            /*OpenChildForm(new Views.Tipos_Combustibles.frmTipos_Combustibles());*/
            Views.Tipos_Combustibles.frmTipos_Combustibles oFrmTipos_Combustibles = new Views.Tipos_Combustibles.frmTipos_Combustibles();
            oFrmTipos_Combustibles.ShowDialog();
            Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? Id_Tipos_Combustible = GetId();
            if (Id_Tipos_Combustible != null)
            {
                /*OpenChildForm(new Views.Tipos_Combustibles.frmTipos_Combustibles(Id_Tipos_Combustible));*/
                Views.Tipos_Combustibles.frmTipos_Combustibles oFrmTipos_Combustibles = new Views.Tipos_Combustibles.frmTipos_Combustibles(Id_Tipos_Combustible);
                oFrmTipos_Combustibles.ShowDialog();
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
                    int? Id_Tipos_Combustible = GetId();
                    if (Id_Tipos_Combustible != null)
                    {
                        using (rentcarEntities db = new rentcarEntities())
                        {
                            Models.Tipos_Combustibles oTipos_Combustible = db.Tipos_Combustibles.Find(Id_Tipos_Combustible);
                            db.Tipos_Combustibles.Remove(oTipos_Combustible);
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
