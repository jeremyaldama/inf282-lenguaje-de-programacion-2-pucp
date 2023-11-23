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
using ULearn.Docente;
using ULearn.ServiciosAcademicos;

namespace ULearn.Alumno
{
    public partial class frmPrincipal : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private alumno _alumno;

        public frmPrincipal(alumno alumno)
        {
            InitializeComponent();
            _alumno = alumno;
            _alumno.codAlumno = _alumno.idUsuario;
        }

        public void mostrarForm(Form form)
        {
            panelContenido.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            panelContenido.Controls.Add(form);
            form.Visible = true;
        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            frmHorario frmHorario = new frmHorario(_alumno);
            mostrarForm(frmHorario);
        }

        private void btnHistorialAcademico_Click(object sender, EventArgs e)
        {
            frmHistorialAcademico frmHistAcad = new frmHistorialAcademico(_alumno);
            mostrarForm(frmHistAcad);
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            frmBiblioteca frmBib = new frmBiblioteca(_alumno);
            mostrarForm(frmBib);
        }

        private void btnBusquedaPersonas_Click(object sender, EventArgs e)
        {
            frmBuscarCursosPersonas frmSearch = new frmBuscarCursosPersonas();
            mostrarForm(frmSearch);
        }

        private void btnReclamos_Click(object sender, EventArgs e)
        {
            frmReclamos frmReclamos = new frmReclamos(_alumno);
            mostrarForm(frmReclamos);
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            Docente.frmEventos frmEventos = new Docente.frmEventos();
            mostrarForm(frmEventos);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estas seguro de que deseas cerrar sesión?",
                "Confirmacion de cierre de sesión", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(resultado == DialogResult.Yes)
            {
                MessageBox.Show("Se cerro la sesión satisfactoriamente");
                this.DialogResult = DialogResult.OK;
                Application.Exit();
            }
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            frmPerfil frmPrfl = new frmPerfil(_alumno);
            mostrarForm(frmPrfl);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = "Bienvenido, " + _alumno.nombre + " " + _alumno.apellidoPaterno + " (" + _alumno.codigoAlumno + ")";
            try
            {
                lblCiclo.Text = "Ciclo: " + _alumno.historialAcademico.nivelAcademico;
            }catch(Exception ex)
            {
                lblCiclo.Text = "Ciclo: ";
                Console.WriteLine(ex.Message);
            }
        }
    }
}
