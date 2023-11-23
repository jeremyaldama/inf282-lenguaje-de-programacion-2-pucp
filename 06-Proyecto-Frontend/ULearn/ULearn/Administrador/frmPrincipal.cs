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

namespace ULearn.Administrador
{
    public partial class frmPrincipal : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private administrador _administrador; 
        public frmPrincipal(administrador administrador)
        {
            _administrador = administrador; 
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAsuntosAcademicos formAcademico = new frmAsuntosAcademicos();
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


        private void frmAdministrador_Load(object sender, EventArgs e)
        {
            lblNombre.Text = _administrador.nombre + " " + _administrador.apellidoPaterno + " " + _administrador.apellidoMaterno;
        }

        private void lblPregunta_Click(object sender, EventArgs e)
        {

        }

        private void btnAcademico_Click(object sender, EventArgs e)
        {
            frmAsuntosAcademicos formAcademico = new frmAsuntosAcademicos();
            mostrarFormulario(formAcademico);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogistica_Click(object sender, EventArgs e)
        {
            frmLogistica formLogistica = new frmLogistica();
            mostrarFormulario(formLogistica);
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0XA1, 0x2, 0);
        }

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea cerrar sesión?", "Confirmación de " +
                "cierre de sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
                MessageBox.Show("Se cerró la sesión satisfactoriamente");
            }
        }
    }
}
