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

namespace RentCar.Views.Inspecciones
{
    public partial class Inspecciones : Form
    {
        public Inspecciones()
        {
            InitializeComponent();
        }

        private void Inspecciones_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        #region HELPER
        private void Refresh()
        {
            using (rentcarEntities db = new rentcarEntities())
            {

                var lst = (from Inspeccione in db.Inspecciones
                          join Vehiculos in db.Vehiculos
                          on Inspeccione.Vehiculo equals Vehiculos.Id_Vehiculo
                          join Clientes in db.Clientes
                          on Inspeccione.Id_Cliente equals Clientes.Id_Cliente
                          join Empleados in db.Empleados
                          on Inspeccione.Empleado_Inspeccion equals Empleados.Id_Empleado
                          select new
                          {
                              Id = Inspeccione.Id_Transaccion,
                              Fecha = Inspeccione.Fecha,
                              Placa = Vehiculos.No_Placa,
                              Vehiculo = Vehiculos.Descripcion,
                              CedulaCliente = Clientes.Cedula,
                              Cliente = Clientes.Nombre + " " + Clientes.Apellido,                                                 
                              Combustible = Inspeccione.Cantidad_Combustible,
                              GomaA = Inspeccione.Estado_GomaA,
                              GomaB = Inspeccione.Estado_GomaB,
                              GomaC = Inspeccione.Estado_GomaC,
                              GomaD = Inspeccione.Estado_GomaD,
                              Ralladuras = Inspeccione.Tiene_Ralladuras,
                              Roturas = Inspeccione.Tiene_Roturas_Cristal,
                              Respuesta = Inspeccione.Tiene_Goma_respuesta,
                              Gato = Inspeccione.Tiene_Gato,
                              Empleado = Empleados.Nombre + " " + Empleados.Apellido,                             
                              Estado = Inspeccione.Estado
                          }).AsQueryable();

                if (!txtBusqueda.Text.Trim().Equals(""))
                {
                    lst = lst.Where(d => d.Placa.Contains(txtBusqueda.Text.Trim()));
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
            /*OpenChildForm(new Views.Inspecciones.frmInspecciones());*/
            Views.Inspecciones.frmInspecciones oFrmInspecciones = new Views.Inspecciones.frmInspecciones();
            oFrmInspecciones.ShowDialog();
            Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? Id_Transaccion = GetId();
            if (Id_Transaccion != null)
            {
                /*OpenChildForm(new Views.Inspecciones.frmInspecciones(Id_Transaccion));*/
                Views.Inspecciones.frmInspecciones oFrmInspecciones = new Views.Inspecciones.frmInspecciones(Id_Transaccion);
                oFrmInspecciones.ShowDialog();
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
                    int? Id_Transaccion = GetId();
                    if (Id_Transaccion != null)
                    {
                        using (rentcarEntities db = new rentcarEntities())
                        {
                            Models.Inspeccione oInspeccione = db.Inspecciones.Find(Id_Transaccion);
                            db.Inspecciones.Remove(oInspeccione);
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
