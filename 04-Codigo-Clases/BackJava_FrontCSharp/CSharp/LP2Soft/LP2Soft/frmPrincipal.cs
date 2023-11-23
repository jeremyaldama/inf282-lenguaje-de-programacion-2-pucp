using LP2SoftRRHHModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft
{
    public partial class frmPrincipal : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private Empleado _empleado;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public frmPrincipal(Empleado empleado)
        {
            InitializeComponent();
            this._empleado = empleado;
            lblEmpleado.Text = "Bienvenido(a) " + empleado.Nombre + " " + empleado.ApellidoPaterno;
        }

        private void btnGestionarEmpleados_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();
            frmGestionarEmpleados frmGestEmp = new frmGestionarEmpleados();
            frmGestEmp.FormBorderStyle = FormBorderStyle.None;
            frmGestEmp.TopLevel = false;
            panelContenido.Controls.Add(frmGestEmp);
            frmGestEmp.Visible = true;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void btnGestionarOrdenesVenta_Click(object sender, EventArgs e)
        {
            frmGestionarOrdenesVenta formGestOV = new frmGestionarOrdenesVenta(_empleado);
            mostrarFormulario(formGestOV);
        }

        public void mostrarFormulario(Form form)
        {
            panelContenido.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panelContenido.Controls.Add(form);
            form.Visible = true;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
