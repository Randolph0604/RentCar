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
using SpreadsheetLight;

namespace RentCar.Views.Reportes
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
            FillTipoVehiculo();
            FillMarca();
            FillModelo();
            FillTipoCombustible();
        }

        private void Reportes_Load(object sender, EventArgs e)
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
                           join Marcas in db.Marcas
                           on Vehiculos.Marca equals Marcas.Id_Marca
                           join Modelos in db.Modelos
                           on Vehiculos.Modelo equals Modelos.Id_Modelo
                           join Tipos_Combustibles in db.Tipos_Combustibles
                           on Vehiculos.Tipo_Combustible equals Tipos_Combustibles.Id_Tipos_Combustible
                           join Tipos_Vehiculos in db.Tipos_Vehiculos
                           on Vehiculos.Tipo_Vehiculo equals Tipos_Vehiculos.Id_Tipos_Vehiculo
                           where ckFechaRenta.Checked ? DbFunctions.TruncateTime(Renta.Fecha_Renta) >= DbFunctions.TruncateTime(dtpDesde.Value) &&
                                 DbFunctions.TruncateTime(Renta.Fecha_Devolucion) <= DbFunctions.TruncateTime(dtpHasta.Value) : true
                           select new
                           {
                               Id = Renta.No_Renta,
                               Vehiculo = Vehiculos.Descripcion,
                               EstadoVehiculo = Vehiculos.Estado,
                               Marca = Marcas.Descripcion,
                               Modelo = Modelos.Descripcion,
                               TipoVehiculo = Tipos_Vehiculos.Descripcion,
                               TipoCombustible = Tipos_Combustibles.Descripcion,
                               Cliente = Clientes.Nombre + " " + Clientes.Apellido,
                               CedulaCliente = Clientes.Cedula,
                               FechaRenta = Renta.Fecha_Renta,
                               FechaDevolucion = Renta.Fecha_Devolucion,
                               MontoxDia = Renta.MontoxDia,
                               Dias = Renta.Cantidad_Dias,
                               Comentario = Renta.Comentario,
                               Empleado = Empleados.Nombre + " " + Empleados.Apellido,
                               CedulaEmpleado = Empleados.Cedula,
                               Estado = Renta.Estado
                           }).AsQueryable();

                if (!cmbTipoVehiculo.Text.Trim().Equals(""))
                {
                    lst = lst.Where(d => d.TipoVehiculo.Contains(cmbTipoVehiculo.Text.Trim()));
                }

                if (!cmbMarca.Text.Trim().Equals(""))
                {
                    lst = lst.Where(d => d.Marca.Contains(cmbMarca.Text.Trim()));
                }

                if (!cmbModelo.Text.Trim().Equals(""))
                {
                    lst = lst.Where(d => d.Modelo.Contains(cmbModelo.Text.Trim()));
                }

                if (!cmbTipoCombustible.Text.Trim().Equals(""))
                {
                    lst = lst.Where(d => d.TipoCombustible.Contains(cmbTipoCombustible.Text.Trim()));
                }
                dataGridView2.DataSource = lst.ToList();
            }
        }



        #endregion

        #region FILLERS
        private void FillTipoVehiculo()
        {
            try
            {
                using (rentcarEntities db = new rentcarEntities())
                {
                    var lts = from Tipos_Vehiculos in db.Tipos_Vehiculos
                              where Tipos_Vehiculos.Estado == "Activo"
                              select Tipos_Vehiculos;

                    if (lts.Count() > 0)
                    {
                        cmbTipoVehiculo.DataSource = lts.ToList();
                        cmbTipoVehiculo.DisplayMember = "Descripcion";
                        cmbTipoVehiculo.ValueMember = "Id_Tipos_Vehiculo";
                        if (cmbTipoVehiculo.Items.Count > 1)
                            cmbTipoVehiculo.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillMarca()
        {
            try
            {
                using (rentcarEntities db = new rentcarEntities())
                {
                    var lts = from Marcas in db.Marcas
                              where Marcas.Estado == "Activo"
                              select Marcas;

                    if (lts.Count() > 0)
                    {
                        cmbMarca.DataSource = lts.ToList();
                        cmbMarca.DisplayMember = "Descripcion";
                        cmbMarca.ValueMember = "Id_Marca";
                        if (cmbMarca.Items.Count > 1)
                            cmbMarca.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillModelo()
        {
            try
            {
                using (rentcarEntities db = new rentcarEntities())
                {
                    var lts = from Modelos in db.Modelos
                              where Modelos.Estado == "Activo"
                              select Modelos;

                    if (lts.Count() > 0)
                    {
                        cmbModelo.DataSource = lts.ToList();
                        cmbModelo.DisplayMember = "Descripcion";
                        cmbModelo.ValueMember = "Id_Modelo";
                        if (cmbModelo.Items.Count > 1)
                            cmbModelo.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillTipoCombustible()
        {
            try
            {
                using (rentcarEntities db = new rentcarEntities())
                {
                    var lts = from Tipos_Combustibles in db.Tipos_Combustibles
                              where Tipos_Combustibles.Estado == "Activo"
                              select Tipos_Combustibles;

                    if (lts.Count() > 0)
                    {
                        cmbTipoCombustible.DataSource = lts.ToList();
                        cmbTipoCombustible.DisplayMember = "Descripcion";
                        cmbTipoCombustible.ValueMember = "Id_Tipos_Combustible";
                        if (cmbTipoCombustible.Items.Count > 1)
                            cmbTipoCombustible.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region CHECKBOXS
        private void ckFechaRenta_CheckedChanged(object sender, EventArgs e)
        {
            if (ckFechaRenta.Checked == true)
            {
                dtpDesde.Enabled = true;
                dtpHasta.Enabled = true;
            }
            else
            {
                dtpDesde.Enabled = false;
                dtpHasta.Enabled = false;
            }
        }

        private void ckTipoVehiculo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckTipoVehiculo.Checked == true)
            {
                cmbTipoVehiculo.Enabled = true;
            }
            else
            {
                cmbTipoVehiculo.Enabled = false;
            }
        }

        private void ckMarca_CheckedChanged(object sender, EventArgs e)
        {
            if (ckMarca.Checked == true)
            {
                cmbMarca.Enabled = true;
            }
            else
            {
                cmbMarca.Enabled = false;
            }
        }

        private void ckTipoCombustible_CheckedChanged(object sender, EventArgs e)
        {
            if (ckTipoCombustible.Checked == true)
            {
                cmbTipoCombustible.Enabled = true;
            }
            else
            {
                cmbTipoCombustible.Enabled = false;
            }
        }

        private void ckModelo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckModelo.Checked == true)
            {
                cmbModelo.Enabled = true;
            }
            else
            {
                cmbModelo.Enabled = false;
                cmbModelo.ResetText();
            }
        }
        #endregion

        #region BUTTONS
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                SLDocument sl = new SLDocument();
                SLStyle style = new SLStyle();
                style.Font.FontSize = 12;
                style.Font.Bold = true;

                int iC = 1;
                foreach (DataGridViewColumn column in dataGridView2.Columns)
                {
                    sl.SetCellValue(1, iC, column.HeaderText.ToString());
                    sl.SetCellStyle(1, iC, style);
                    iC++;
                }

                int iR = 2;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    sl.SetCellValue(iR, 1, row.Cells[0].Value.ToString());
                    sl.SetCellValue(iR, 2, row.Cells[1].Value.ToString());
                    sl.SetCellValue(iR, 3, row.Cells[2].Value.ToString());
                    sl.SetCellValue(iR, 4, row.Cells[3].Value.ToString());
                    sl.SetCellValue(iR, 5, row.Cells[4].Value.ToString());
                    sl.SetCellValue(iR, 6, row.Cells[5].Value.ToString());
                    sl.SetCellValue(iR, 7, row.Cells[6].Value.ToString());
                    sl.SetCellValue(iR, 8, row.Cells[7].Value.ToString());
                    sl.SetCellValue(iR, 9, row.Cells[8].Value.ToString());
                    sl.SetCellValue(iR, 10, row.Cells[9].Value.ToString());
                    sl.SetCellValue(iR, 11, row.Cells[10].Value.ToString());
                    sl.SetCellValue(iR, 12, row.Cells[11].Value.ToString());
                    sl.SetCellValue(iR, 13, row.Cells[12].Value.ToString());
                    sl.SetCellValue(iR, 14, row.Cells[13].Value.ToString());
                    sl.SetCellValue(iR, 15, row.Cells[14].Value.ToString());
                    sl.SetCellValue(iR, 16, row.Cells[15].Value.ToString());
                    sl.SetCellValue(iR, 17, row.Cells[16].Value.ToString());
                    iR++;
                }
                sl.SaveAs(@"C:\Users\Rando\OneDrive\Desktop\Archivo\Archivo.xlsx");
                MessageBox.Show("La tabla ha sido exportada.");
            }
            catch
            {
                MessageBox.Show("La carpeta asignada no existe");
            }
        }
        #endregion

        #region COMPONENTS
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelChildFrom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

     
    }
}
