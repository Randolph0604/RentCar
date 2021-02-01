using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentCar.Models;

namespace RentCar.Views.Consultas
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            Refresh();     
            dtpFechaRenta.Enabled = false;
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
                          where DbFunctions.TruncateTime(Renta.Fecha_Renta) == DbFunctions.TruncateTime(dtpFechaRenta.Value)
                           select new
                          {
                              Id = Renta.No_Renta,
                              Placa = Vehiculos.No_Placa,
                              Vehiculo = Vehiculos.Descripcion,
                              Cliente = Clientes.Nombre + " " + Clientes.Apellido,
                              CedulaCliente = Clientes.Cedula,
                              FechaRenta = Renta.Fecha_Renta,
                              FechaDevolucion = Renta.Fecha_Devolucion,
                              MontoxDia = Renta.MontoxDia,
                              Dias = Renta.Cantidad_Dias,
                              EstadoVehiculo = Vehiculos.Estado,
                              Comentario = Renta.Comentario,
                              Empleado = Empleados.Nombre + " " + Empleados.Apellido,
                              CedulaEmpleado = Empleados.Cedula,
                              Estado = Renta.Estado
                          }).AsQueryable();

                if (!txtCedulaCliente.Text.Trim().Equals("")) 
                {
                    lst = lst.Where(d => d.CedulaCliente.Contains(txtCedulaCliente.Text.Trim()));
                }

                if (!txtCedulaEmpleado.Text.Trim().Equals(""))
                {
                    lst = lst.Where(d => d.CedulaEmpleado.Contains(txtCedulaEmpleado.Text.Trim()));
                }
                if (!txtPlaca.Text.Trim().Equals(""))
                {
                    lst = lst.Where(d => d.Placa.Contains(txtPlaca.Text.Trim()));
                }
                dataGridView1.DataSource = lst.ToList();
            }
        }
        #endregion

        #region COMPONENTS
        private void ckFechaRenta_CheckedChanged(object sender, EventArgs e)
        {
            if (ckFechaRenta.Checked == true)
            {
                dtpFechaRenta.Enabled = true;
            }
            else
            {
                dtpFechaRenta.Enabled = false;
            }
        }

        private void dtpFechaRenta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        #endregion
    }
}
