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
using ULearn.ServiciosAcademicos;
using ULearn.StaffWS;

namespace ULearn
{
    public partial class frmInicioSesion : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private StaffWS.StaffWSClient daoStaff;
        private AcademicsWSClient daoAcademico;
        private StaffWS.usuarioSesion usuario;
        public frmInicioSesion()
        {
            InitializeComponent();
            lblMensaje.Text = "";
            daoStaff = new StaffWS.StaffWSClient();
            daoAcademico = new AcademicsWSClient();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            this.usuario = daoStaff.iniciarSesion(txtUsername.Text, txtPassword.Text);
            if(usuario != null)
            {
                this.Hide();
                switch (usuario.tipoUsuario)
                {
                    case 'A':
                        administrador administrador = daoStaff.hallarAdministradorPorId(usuario.idUsuario);
                        Administrador.frmPrincipal formPrincipalAdmin = new Administrador.frmPrincipal(administrador);
                        formPrincipalAdmin.Show();
                        break;
                    case 'E':
                        alumno alumno = daoAcademico.hallarAlumnoPorId(usuario.idUsuario);
                        Alumno.frmPrincipal formPrincipalAlumno = new Alumno.frmPrincipal(alumno); //pasar alumno
                        formPrincipalAlumno.Show();
                        break;
                    case 'D':
                        docente docente = daoAcademico.hallarDocentePorId(usuario.idUsuario);
                        Docente.frmPrincipal formPrincipalDocente = new Docente.frmPrincipal(docente);
                        formPrincipalDocente.Show();
                        break;
                    case 'B':
                        encargadoBiblioteca encargado = daoStaff.hallarEncargadoPorId(usuario.idUsuario);
                        Bibliotecario.frmPrincipal formPrincipalBibliotecario = new Bibliotecario.frmPrincipal(encargado);
                        formPrincipalBibliotecario.Show();
                        break;
                }
            }
            else
            {
                lblMensaje.Text = "Credenciales incorrectas";
                txtUsername.Text = "";
                txtPassword.Text = "";
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
