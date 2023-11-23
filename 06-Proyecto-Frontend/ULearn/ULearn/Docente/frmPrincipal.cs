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
using ULearn.Alumno;
using ULearn.ServiciosAcademicos;

namespace ULearn.Docente
{
    public partial class frmPrincipal : Form
    {
        private AcademicsWSClient dao;
        private BindingList<curso> _cursos;
        private BindingList<horario> _horarios;
        private docente _docente;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        public frmPrincipal(docente docente)
        {
            dao = new AcademicsWSClient();
            InitializeComponent();
            try
            {
                _cursos = new BindingList<curso>(dao.listarCursosDocentePorId(docente.idEmpleado));
                _horarios = new BindingList<horario>(dao.listarHorariosPorDocente(docente.idEmpleado));
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            _docente = docente;
            _docente.idUsuario = _docente.idEmpleado;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = "Bienvenido, " + _docente.nombre + " " + _docente.apellidoPaterno;
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            frmCursos formCursos = new frmCursos(this.panelContenido, _cursos, _horarios);
            mostrarFormulario(formCursos);
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

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            frmBuscarPersonas formBusqPersona = new frmBuscarPersonas(this.panelContenido);
            mostrarFormulario(formBusqPersona);
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            frmPerfil formPerfil = new frmPerfil(_docente);
            mostrarFormulario(formPerfil);
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            frmEventos formEventos = new frmEventos();
            mostrarFormulario(formEventos);
        }

        private void btnBiblioteca_Click(object sender, EventArgs e)
        {
            frmBiblioteca formBiblioteca = new frmBiblioteca(_docente);
            mostrarFormulario(formBiblioteca);
        }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea cerrar sesión?","Confirmación de " +
                "cierre de sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resultado == DialogResult.Yes)
            {
                Application.Exit();
                MessageBox.Show("Se cerró la sesión satisfactoriamente");
            }
        }
    }
}
