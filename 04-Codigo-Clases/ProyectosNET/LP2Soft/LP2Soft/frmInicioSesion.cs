using LP2SoftRRHHController.DAO;
using LP2SoftRRHHController.MySQL;
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
    public partial class frmInicioSesion : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private CuentaUsuarioDAO _daoCuentaUsuario;
        private EmpleadoDAO _daoEmpleado;
        public frmInicioSesion()
        {
            InitializeComponent();
            _daoCuentaUsuario = new CuentaUsuarioMySQL();
            _daoEmpleado = new EmpleadoMySQL();
            lblMensaje.Text = "";
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            CuentaUsuario cuentaUsuario = new CuentaUsuario();
            cuentaUsuario.Username = txtUsername.Text;
            cuentaUsuario.Password = txtPassword.Text;
            int resultado = _daoCuentaUsuario.verificar(cuentaUsuario);
            if (resultado != 0)
            {
                this.Hide();
                Empleado empleado = _daoEmpleado.buscarPorId(resultado);
                frmPrincipal formPrincipal = new frmPrincipal(empleado);
                formPrincipal.Show();
            } else
            {
                lblMensaje.Text = "Credenciales incorrectas";
            }
        }

        private void panelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void pbLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
                btnIniciarSesion_Click(sender, e);
        }
    }
}
