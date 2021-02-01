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
using RentCar.Views;

namespace RentCar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            using (Models.rentcarEntities db = new Models.rentcarEntities())
            {
                var lts = from d in db.Empleados
                          where d.Correo == txtCorreo.Text
                          && d.Contrasena == txtContrasena.Text
                          select d;

                if (lts.Count() > 0)
                {
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.FormClosed += (s, args) => this.Close();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Correo o Contraseña incorrectos");
                }
            }
        }      
    }
}
