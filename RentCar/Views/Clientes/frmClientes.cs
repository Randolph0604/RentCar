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

namespace RentCar.Views.Clientes
{
    public partial class frmClientes : Form
    {
        public int? Id_Cliente;
        Models.Cliente oCliente = null;
        public frmClientes(int? Id_Cliente = null)
        {
            InitializeComponent();

            this.Id_Cliente = Id_Cliente;
            if (Id_Cliente != null)
                LoadData();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
        }

        #region HELPER
        private void LoadData()
        {
            using (rentcarEntities db = new rentcarEntities())
            {
                oCliente = db.Clientes.Find(Id_Cliente);

                txtNombre.Text = oCliente.Nombre;
                txtApellido.Text = oCliente.Apellido;
                txtCedula.Text = oCliente.Cedula;
                txtNoTarjetaCR.Text = oCliente.No_Tarjeta_CR;
                nudLimiteCredito.Value = oCliente.Limite_Credito;
                cmbTipoPersona.Text = oCliente.Tipo_Persona;
                cmbEstado.Text = oCliente.Estado;
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

        private bool CheckRNC(string pRNC)

        {

            int vnTotal = 0;

            int[] digitoMult = new int[8] { 7, 9, 8, 6, 5, 4, 3, 2 };

            string vcRNC = pRNC.Replace("-", "").Replace(" ", "");

            string vDigito = vcRNC.Substring(8, 1);

            if (vcRNC.Length.Equals(9))

                if (!"145".Contains(vcRNC.Substring(0, 1)))

                    return false;

            for (int vDig = 1; vDig <= 8; vDig++)

            {

                int vCalculo = Int32.Parse(vcRNC.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];

                vnTotal += vCalculo;

            }

            if (vnTotal % 11 == 0 && vDigito == "1" || vnTotal % 11 == 1 && vDigito == "1" ||

                (11 - (vnTotal % 11)).Equals(vDigito))

                return true;

            else

                return false;

        }
        #endregion

        #region BUTTONS
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (rentcarEntities db = new rentcarEntities())
                {
                    if (Id_Cliente == null)
                        oCliente = new Models.Cliente();

                    if (txtNombre.Text.Trim().Equals("") || txtApellido.Text.Trim().Equals("") || txtCedula.Text.Trim().Equals("") ||
                        txtNoTarjetaCR.Text.Trim().Equals("") || cmbTipoPersona.Text.Trim().Equals("") || cmbEstado.Text.Trim().Equals("") || nudLimiteCredito.Value.Equals(""))
                    {
                        MessageBox.Show("Por favor, llenar todos los campos.");
                    }
                    else
                    {
                        if (cmbTipoPersona.SelectedItem.ToString() == "Fisica")
                        {
                            if (CheckCedula(txtCedula.Text))
                            {
                                if (txtNoTarjetaCR.Text.Length != 16)
                                {
                                    MessageBox.Show("La tarjeta de credito debe tener 16 digitos.");
                                }
                                else 
                                {
                                    var exists = db.Clientes.Any(x => x.Cedula.Equals(txtCedula.Text));

                                    if (exists && Id_Cliente == null)
                                    {
                                        MessageBox.Show("Este cliente ya ha sido registrado.");
                                        return;
                                    }
                                    else
                                    {
                                        oCliente.Nombre = txtNombre.Text;
                                        oCliente.Apellido = txtApellido.Text;
                                        oCliente.Cedula = txtCedula.Text;
                                        oCliente.No_Tarjeta_CR = txtNoTarjetaCR.Text;
                                        oCliente.Limite_Credito = Convert.ToInt32(nudLimiteCredito.Value);
                                        oCliente.Tipo_Persona = cmbTipoPersona.Text;
                                        oCliente.Estado = cmbEstado.Text;

                                        if (Id_Cliente == null)
                                            db.Clientes.Add(oCliente);
                                        else
                                        {
                                            db.Entry(oCliente).State = System.Data.Entity.EntityState.Modified;
                                        }
                                        db.SaveChanges();
                                        MessageBox.Show("Guardado exitosamente");
                                        this.Close();
                                    }
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("La cedula no es válida.");
                            }
                        }
                        else
                        {
                            if (CheckRNC(txtCedula.Text))
                            {
                                if (txtNoTarjetaCR.Text.Length != 16)
                                {
                                    MessageBox.Show("La tarjeta de credito debe tener 16 digitos.");
                                }
                                else
                                {
                                    var exists = db.Clientes.Any(x => x.Cedula.Equals(txtCedula.Text));

                                    if (exists && Id_Cliente == null)
                                    {
                                        MessageBox.Show("Este cliente ya ha sido registrado.");
                                        return;
                                    }
                                    else
                                    {
                                        oCliente.Nombre = txtNombre.Text;
                                        oCliente.Apellido = txtApellido.Text;
                                        oCliente.Cedula = txtCedula.Text;
                                        oCliente.No_Tarjeta_CR = txtNoTarjetaCR.Text;
                                        oCliente.Limite_Credito = Convert.ToInt32(nudLimiteCredito.Value);
                                        oCliente.Tipo_Persona = cmbTipoPersona.Text;
                                        oCliente.Estado = cmbEstado.Text;

                                        if (Id_Cliente == null)
                                            db.Clientes.Add(oCliente);
                                        else
                                        {
                                            db.Entry(oCliente).State = System.Data.Entity.EntityState.Modified;
                                        }
                                        db.SaveChanges();
                                        MessageBox.Show("Guardado exitosamente");
                                        this.Close();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("El RNC no es válido.");
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
