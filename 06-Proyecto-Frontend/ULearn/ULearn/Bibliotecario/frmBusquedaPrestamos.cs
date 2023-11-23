using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULearn.LibraryWS;
using ULearn.ServiciosAcademicos;
using ULearn.StaffWS;

namespace ULearn.Bibliotecario
{
    public partial class frmBusquedaPrestamos : Form
    {
        private encargadoBiblioteca _encargado;
        private ServiciosAcademicos.usuario _responsable;
        private LibraryWSClient _daoLibraryWS;
        private frmFiltros frmFlt;
        private biblioteca bibliotecaBusc;
        private DateTime fecha_desde;
        private DateTime fecha_hasta;
        int anulados;
        int devueltos;
        int retraso;
        public frmBusquedaPrestamos(encargadoBiblioteca encargado)
        {
            InitializeComponent();
            dgvPrestamos.AutoGenerateColumns = false;
            _daoLibraryWS = new LibraryWSClient();
            _encargado = encargado;
            btnInspeccionar.Enabled = false;
            btnFiltros.Enabled = false;
            btnActualizar.Enabled = false;
            btnTerminar.Enabled = false;
            frmFlt = new frmFiltros();
        }


        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            frmBusquedaUsuariosPrestamo frmUsuarios = new frmBusquedaUsuariosPrestamo();
            if (frmUsuarios.ShowDialog() == DialogResult.OK)
            {
                btnInspeccionar.Enabled = true;
                btnFiltros.Enabled = true;
                btnInspeccionar.Enabled = true;
                btnActualizar.Enabled = true;
                if (frmUsuarios.UsuarioSeleccionado is alumno) _responsable = new alumno();
                else _responsable = new docente();
                _responsable = frmUsuarios.UsuarioSeleccionado;
                lblNombre.Text = _responsable.nombre;
                lblApellido.Text = _responsable.apellidoPaterno + " " + _responsable.apellidoMaterno;
                if (_responsable is alumno)
                {
                    lblRol.Text = "Alumno";
                    lblDeudor.Text = ((alumno)_responsable).esDeudor == 1 ? "Sí" : "No";
                }
                else if (_responsable is docente)
                {
                    lblRol.Text = "Docente";
                    lblDeudor.Text = ((docente)_responsable).esDeudor == 1 ? "Sí" : "No";
                }
                else lblRol.Text = "?";
                if (_responsable.foto != null)
                {
                    MemoryStream ms = new MemoryStream(_responsable.foto);
                    pboFoto.Image = new Bitmap(ms);
                }
                else pboFoto.Image = ULearn.Properties.Resources.user;
                buscarPrestamos();
                btnTerminar.Enabled = true;
            }
        }

        private void btnInspeccionar_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.SelectedRows.Count != 1)
            {
                MessageBox.Show("Debe seleccionar un préstamo para inspeccionar", "Problema de selección",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            prestamo _prestamoSeleccionado = (prestamo)dgvPrestamos.CurrentRow.DataBoundItem;
            frmDetallesPrestamo frmDetallePrest = new frmDetallesPrestamo(_prestamoSeleccionado,_responsable);
            if(frmDetallePrest.ShowDialog() == DialogResult.OK)
            {
                buscarPrestamos();
            }
        }

        private void dgvPrestamos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            prestamo _prestamo = (prestamo)dgvPrestamos.Rows[e.RowIndex].DataBoundItem;
            dgvPrestamos.Rows[e.RowIndex].Cells[0].Value = _prestamo.idPrestamo.ToString();
            dgvPrestamos.Rows[e.RowIndex].Cells[1].Value = _prestamo.libro.titulo;
            dgvPrestamos.Rows[e.RowIndex].Cells[2].Value = concatenarAutores(_prestamo.libro);
            if (_prestamo.fechaRetiroSpecified == true) dgvPrestamos.Rows[e.RowIndex].Cells[3].Value = _prestamo.fechaRetiro.ToString("dd/MM/yyyy");
            else dgvPrestamos.Rows[e.RowIndex].Cells[3].Value = "--/--/----";
            if (_prestamo.fechaDevolucionConfirmadaSpecified == true) dgvPrestamos.Rows[e.RowIndex].Cells[4].Value = _prestamo.fechaDevolucionConfirmada.ToString("dd/MM/yyyy");
            else dgvPrestamos.Rows[e.RowIndex].Cells[4].Value = "--/--/----";
            dgvPrestamos.Rows[e.RowIndex].Cells[5].Value = definirEstadoPrestamo(_prestamo);
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {
            if(frmFlt.ShowDialog() == DialogResult.OK) {
                buscarPrestamos();
            }
        }

        public string concatenarAutores(libro l)
        {
            string cadena = "";
            int i = 0;
            foreach (autor a in l.autores)
            {
                cadena += a.nombre;
                if (l.autores.Length - 1 != i) cadena += ", ";
                i++;
            }
            return cadena;
        }

        private string definirEstadoPrestamo(prestamo _prestamo)
        {
            string cadena = "";
            if (_prestamo.anulado == true) cadena = "Anulado";
            else
            {
                if (_prestamo.fechaRetiroSpecified == false) cadena = "Solicitado - Por retirar";
                else
                {
                    if (_prestamo.fechaDevolucionConfirmadaSpecified == false)
                    {
                        if (_prestamo.fechaMaximaDevolucion >= DateTime.Now) cadena = "En curso";
                        else
                        {
                            cadena = "En curso - Con retraso";
                        }
                    }
                    else
                    {
                        if (_prestamo.fechaDevolucionConfirmada <= _prestamo.fechaMaximaDevolucion) cadena = "Devuelto";
                        else
                        {
                            cadena = "Devuelto - Con retraso";
                        }
                    }
                }
            }
            return cadena;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            buscarPrestamos();
        }

        private void buscarPrestamos()
        {
            bibliotecaBusc = frmFlt.getBiblioteca();
            fecha_desde = frmFlt.getFechaDesde();
            fecha_hasta = frmFlt.getFechaHasta();
            anulados = frmFlt.getAnulado();
            if(anulados == 1)
            {
                retraso = 2;
                devueltos = 2;
            }
            else
            {
                retraso = frmFlt.getConRetraso();
                devueltos = frmFlt.getDevuelto();
            }
            mostrarMensajeFiltros();
            try
            {
                BindingList<prestamo> prestamos = new BindingList<prestamo>(_daoLibraryWS.listarPrestamosConFiltros(bibliotecaBusc.idBiblioteca, _responsable.idUsuario, fecha_desde, fecha_hasta,
                                    anulados, devueltos, retraso).ToList());
                foreach (prestamo p in prestamos)
                {
                    p.libro.autores = _daoLibraryWS.listarAutoresPorIdRecurso(p.libro.idRecurso);
                }
                lblResultado.Text += "Seleccione un préstamo de la lista para inspeccionar";
                dgvPrestamos.DataSource = prestamos;
            }
            catch (Exception ex)
            {
                lblResultado.Text += "No se encontraron prestamos";
                dgvPrestamos.DataSource = null;
            }
        }

        public void mostrarMensajeFiltros()
        {
            lblResultado.Text = "Mostrando ";
            if(bibliotecaBusc.idBiblioteca == -1 && fecha_desde == frmFlt.getMinDate() && fecha_hasta == frmFlt.getMaxDate()
                && retraso == 2 && devueltos == 2 && anulados == 2)
            {
                lblResultado.Text += "todos los préstamos. \n";
                return;
            }
            lblResultado.Text += "prestamos ";
            if (anulados == 1) lblResultado.Text += "anulados ";
            if (bibliotecaBusc.idBiblioteca != -1) lblResultado.Text += "en " + bibliotecaBusc.nombre + " ";
            if (fecha_desde != frmFlt.getMinDate()) lblResultado.Text += "desde " + fecha_desde.ToString("dd/MM/yyyy") + " ";
            if (fecha_hasta != frmFlt.getMaxDate()) lblResultado.Text += "hasta " + fecha_hasta.ToString("dd/MM/yyyy") + " ";
            if (anulados != 1)
            {
                if (devueltos == 1) lblResultado.Text += "devueltos ";
                else if (devueltos == 0) lblResultado.Text += "sin devolver ";
                if (retraso == 1) lblResultado.Text += "con retraso ";
                else if (retraso == 0) lblResultado.Text += "sin retraso ";
                lblResultado.Text += "\n";
            }
            else lblResultado.Text += "\n";
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            btnTerminar.Enabled = false;
            dgvPrestamos.DataSource = null;
            lblNombre.Text = "";
            lblApellido.Text = "";
            lblDeudor.Text = "";
            lblRol.Text = "";
            _responsable = null;
        }
    }
}
