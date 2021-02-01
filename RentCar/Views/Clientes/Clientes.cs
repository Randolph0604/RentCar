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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        #region HELPER
        private void Refresh()
        {
            using (rentcarEntities db = new rentcarEntities())
            {
                var lst = (from Clientes in db.Clientes
                          select new { Id = Clientes.Id_Cliente, 
                                       Nombre = Clientes.Nombre, 
                                       Apellido = Clientes.Apellido, 
                                       Cedula = Clientes.Cedula, 
                                       Trajeta = Clientes.No_Tarjeta_CR, 
                                       Credito = Clientes.Limite_Credito,
                                       Tipo_Persona = Clientes.Tipo_Persona,
                                       Estado = Clientes.Estado}).AsQueryable();

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
            /*OpenChildForm(new Views.Clientes.frmClientes());*/
            Views.Clientes.frmClientes oFrmCliente = new Views.Clientes.frmClientes();
            oFrmCliente.ShowDialog();
            Refresh();
            
                       
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? Id_Cliente = GetId();
            if (Id_Cliente != null)
            {
                /*OpenChildForm(new Views.Clientes.frmClientes(Id_Cliente));*/
                Views.Clientes.frmClientes oFrmCliente = new Views.Clientes.frmClientes(Id_Cliente);
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
                    int? Id_Cliente = GetId();
                    if (Id_Cliente != null)
                    {
                        using (rentcarEntities db = new rentcarEntities())
                        {
                            Models.Cliente oCliente = db.Clientes.Find(Id_Cliente);
                            db.Clientes.Remove(oCliente);
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
            Refresh();
        }
        #endregion

        private void Nombre_Click(object sender, EventArgs e)
        {

        }
    }
}
