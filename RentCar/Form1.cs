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

namespace RentCar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomizeDesing();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region SIDEBAR

        #region COLLAPSE

        private void CustomizeDesing() 
        {
            panelServiciosSubMenu.Visible = false;
            panelMantenimientoSubMenu.Visible = false;
            panelReportesSubMenu.Visible = false;
        }

        private void HideSubMenu() 
        {
            if (panelServiciosSubMenu.Visible == true)
                panelServiciosSubMenu.Visible = false;
            if (panelMantenimientoSubMenu.Visible == true)
                panelMantenimientoSubMenu.Visible = false;
            if (panelReportesSubMenu.Visible == true)
                panelReportesSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu) 
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;       
        }

        #endregion

        #region SERVICIOS

        private void panelServiciosSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnServicios_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(panelServiciosSubMenu);
        }

        private void btnInspecciones_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.Inspecciones.Inspecciones());
            HideSubMenu();
        }

        private void btnRentaDevoluciones_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.Renta_Devolucion.Renta_Devolucion());
            HideSubMenu();
        }

        #endregion

        #region REPORTES

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelReportesSubMenu);
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.Consultas.Consultas());
            HideSubMenu();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.Reportes.Reportes());
            HideSubMenu();
        }
        #endregion

        #region MANTENIMIENTO

        private void panelMantenimientoSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelMantenimientoSubMenu);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Empleados());
            HideSubMenu();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.Clientes.Clientes());
            HideSubMenu();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.Marcas.Marcas());
            HideSubMenu();
        }

        private void btnModelos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.Modelos.Modelos());
            HideSubMenu();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.Vehiculos.Vehiculos());
            HideSubMenu();
        }

        private void btnTiposVehiculos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.Tipos_Vehiculos.Tipos_Vehiculos());
            HideSubMenu();
        }

        private void btnTiposCombustibles_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.Tipos_Combustibles.Tipos_Combustibles());
            HideSubMenu();
        }
        #endregion

        #endregion

        #region BUTTONS
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.FormClosed += (s, args) => this.Close();
            log.Show();
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

        #region COMPONENTS
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panelChildFrom_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion
    }
}
