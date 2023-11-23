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
using ULearn.StaffWS;

namespace ULearn.Bibliotecario
{
    public partial class frmPrincipal : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private encargadoBiblioteca _encargadoBiblioteca;
        public frmPrincipal(encargadoBiblioteca encargado)
        {
            InitializeComponent();
            _encargadoBiblioteca = encargado;
            lblBienvenida.Text = _encargadoBiblioteca.nombre + " " + _encargadoBiblioteca.apellidoPaterno + " " + _encargadoBiblioteca.apellidoMaterno +
                " - " + _encargadoBiblioteca.titulo_trabajo;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void mostrarFormulario(Form form)
        {
            panelContenido.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(form);
            form.Visible = true;
        }

        private void btnRecursos_Click(object sender, EventArgs e)
        {
            frmGestionLibrosRecursos frmGestion = new frmGestionLibrosRecursos(_encargadoBiblioteca);
            mostrarFormulario(frmGestion);
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            frmBusquedaPrestamos frmBusqPrestamos = new frmBusquedaPrestamos(_encargadoBiblioteca);
            mostrarFormulario(frmBusqPrestamos);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes frmRep = new frmReportes(_encargadoBiblioteca);
            mostrarFormulario(frmRep);
        }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro de que desea cerrar sesión?", 
                "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
