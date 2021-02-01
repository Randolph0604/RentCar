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

namespace RentCar.Views.Empleado
{
    public partial class frmEmpleados : Form
    {
        public int? Id_Empleado;
        Models.Empleado oEmpleado = null;
        public frmEmpleados(int? Id_Empleado = null)
        {
            InitializeComponent();
            
            this.Id_Empleado = Id_Empleado;
            if (Id_Empleado != null)
                LoadData();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {

        }

        #region HELPER
        private void LoadData() 
        {
            using ( rentcarEntities db = new rentcarEntities())
            {              
                oEmpleado = db.Empleados.Find(Id_Empleado);

                txtNombre.Text = oEmpleado.Nombre;
                txtApellido.Text = oEmpleado.Apellido;
                txtCedula.Text = oEmpleado.Cedula;
                txtCorreo.Text = oEmpleado.Correo;
                txtContrasena.Text = oEmpleado.Contrasena;
                cmbTandaLaboral.Text = oEmpleado.Tanda_laboral;              
                nudPorcientoComision.Value = oEmpleado.Porciento_Comision;
                dtpFechaIngreso.Value = oEmpleado.Fecha_Ingreso;
                cmbEstado.Text = oEmpleado.Estado;
            }        
        }

        public static bool CheckCedula(string pCedula)

        {
            int vnTotal = 0;
            string vcCedula = pCedula.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }

            if (vnTotal % 10 == 0)
                return true;
            else
                return false;
        }
        #endregion

        #region BUTTONS

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (rentcarEntities db = new rentcarEntities()) 
            {
                if (Id_Empleado == null)
                    oEmpleado = new Models.Empleado();

                if (txtNombre.Text.Trim().Equals("") || txtApellido.Text.Trim().Equals("") || txtCedula.Text.Trim().Equals("") ||
                    txtCorreo.Text.Trim().Equals("") || txtContrasena.Text.Trim().Equals("") || cmbTandaLaboral.Text.Trim().Equals("") ||
                    nudPorcientoComision.Text.Trim().Equals("") || dtpFechaIngreso.Text.Trim().Equals("") || cmbEstado.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Por favor, llenar todos los campos.");                   
                }
                else
                {
                    if (CheckCedula(txtCedula.Text))
                    {
                        var exists = db.Empleados.Any(x => x.Cedula.Equals(txtCedula.Text));

                        if (exists && Id_Empleado == null)
                        {
                            MessageBox.Show("Este empleado ya habia sido registrado.");
                            return;
                        }
                        else
                        {
                            oEmpleado.Nombre = txtNombre.Text;
                            oEmpleado.Apellido = txtApellido.Text;
                            oEmpleado.Cedula = txtCedula.Text;
                            oEmpleado.Correo = txtCorreo.Text;
                            oEmpleado.Contrasena = txtContrasena.Text;
                            oEmpleado.Tanda_laboral = cmbTandaLaboral.Text;
                            oEmpleado.Porciento_Comision = Convert.ToInt32(nudPorcientoComision.Value);
                            oEmpleado.Fecha_Ingreso = dtpFechaIngreso.Value;
                            oEmpleado.Estado = cmbEstado.Text;

                            if (Id_Empleado == null)
                                db.Empleados.Add(oEmpleado);
                            else
                            {
                                db.Entry(oEmpleado).State = System.Data.Entity.EntityState.Modified;
                            }
                            db.SaveChanges();
                            MessageBox.Show("Guardado exitosamente");
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cedula es invalida.");
                    }
                }
            }
        }
        #endregion

        #region COMPONENTS
        private void dtpFechaSalida_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblPorcientoComision_Click(object sender, EventArgs e)
        {

        }

        private void nudPorcientoComision_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblFechaIngreso_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
