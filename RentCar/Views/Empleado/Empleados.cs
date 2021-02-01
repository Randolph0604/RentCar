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

namespace RentCar.Views
{
    public partial class Empleados : Form
    {

        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        #region HELPER

        private void Refresh()
        {
            using (rentcarEntities db = new rentcarEntities())
            {
                var lst = (from Empleados in db.Empleados
                          select new { Id = Empleados.Id_Empleado, 
                                       Nombre = Empleados.Nombre, Apellido = 
                                       Empleados.Apellido, 
                                       Cedula = Empleados.Cedula,
                                       Correo = Empleados.Correo, 
                                       Tanda = Empleados.Tanda_laboral, 
                                       Comision = Empleados.Porciento_Comision,
                                       Fecha_Ingreso = Empleados.Fecha_Ingreso,
                                       Estado = Empleados.Estado}).AsQueryable();

                if (!txtBusqueda.Text.Trim().Equals(""))
                {
                    lst = lst.Where(d => d.Nombre.Contains(txtBusqueda.Text.Trim()));
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
            /*OpenChildForm(new Views.Empleado.frmEmpleados());*/
            Views.Empleado.frmEmpleados oFrmCliente = new Views.Empleado.frmEmpleados();
            oFrmCliente.ShowDialog();
            Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? Id_Empleado = GetId();
            if (Id_Empleado != null) 
            {
                /*OpenChildForm(new Views.Empleado.frmEmpleados(Id_Empleado));*/
                Views.Empleado.frmEmpleados oFrmCliente = new Views.Empleado.frmEmpleados(Id_Empleado);
                oFrmCliente.ShowDialog();
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
                    int? Id_Empleado = GetId();
                    if (Id_Empleado != null)
                    {
                        using (rentcarEntities db = new rentcarEntities())
                        {
                            Models.Empleado oEmpleado = db.Empleados.Find(Id_Empleado);
                            db.Empleados.Remove(oEmpleado);
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

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
