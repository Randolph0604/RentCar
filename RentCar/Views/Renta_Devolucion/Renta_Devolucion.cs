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

namespace RentCar.Views.Renta_Devolucion
{
    public partial class Renta_Devolucion : Form
    {
        public Renta_Devolucion()
        {
            InitializeComponent();
        }

        private void Renta_Devolucion_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        #region HELPER
        private void Refresh()
        {
            using (rentcarEntities db = new rentcarEntities())
            {

                var lst = (from Renta in db.Renta_Devolucion
                          join Empleados in db.Empleados
                          on Renta.Empleado equals Empleados.Id_Empleado
                          join Vehiculos in db.Vehiculos
                          on Renta.Vehiculo equals Vehiculos.Id_Vehiculo
                          join Clientes in db.Clientes
                          on Renta.Cliente equals Clientes.Id_Cliente

                          select new
                          {
                              No_Renta = Renta.No_Renta,
                              Vehiculo = Vehiculos.Descripcion,
                              Cliente = Clientes.Nombre + " " + Clientes.Apellido,
                              CedulaCliente = Clientes.Cedula, 
                              Fecha_Renta = Renta.Fecha_Renta,
                              Fecha_Devolucion = Renta.Fecha_Devolucion,
                              MontoxDia = Renta.MontoxDia,
                              Cantidad_Dias = Renta.Cantidad_Dias,
                              Comentario = Renta.Comentario,
                              Empleado = Empleados.Nombre + " " + Empleados.Apellido,
                              CedulaEmpleados = Empleados.Cedula,
                              Estado = Renta.Estado
                          }).AsQueryable();

                if (!txtBusqueda.Text.Trim().Equals(""))
                {
                    lst = lst.Where(d => d.CedulaCliente.Contains(txtBusqueda.Text.Trim()));
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
            /*OpenChildForm(new Views.Renta_Devolucion.frmRenta_Devolucion());*/
            Views.Renta_Devolucion.frmRenta_Devolucion oFrmRenta_Devolucion = new Views.Renta_Devolucion.frmRenta_Devolucion();
            oFrmRenta_Devolucion.ShowDialog();
            Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? Id_Renta = GetId();
            if (Id_Renta != null)
            {
                /*OpenChildForm(new Views.Renta_Devolucion.frmRenta_Devolucion(Id_Renta));*/
                Views.Renta_Devolucion.frmRenta_Devolucion oFrmRenta_Devolucion = new Views.Renta_Devolucion.frmRenta_Devolucion(Id_Renta);
                oFrmRenta_Devolucion.ShowDialog();
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
                    int? No_Renta = GetId();
                    if (No_Renta != null)
                    {
                        using (rentcarEntities db = new rentcarEntities())
                        {
                            Models.Renta_Devolucion oRenta = db.Renta_Devolucion.Find(No_Renta);
                            db.Renta_Devolucion.Remove(oRenta);
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
