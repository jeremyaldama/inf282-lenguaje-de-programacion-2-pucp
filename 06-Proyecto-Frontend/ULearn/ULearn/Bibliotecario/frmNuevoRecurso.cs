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
using ULearn.Administrador;
using ULearn.LibraryWS;
using ULearn.StaffWS;

namespace ULearn.Bibliotecario
{
    public partial class frmNuevoRecurso : Form
    {
        private Estado estado;
        private frmNuevoDigital frmDigital;
        private frmNuevoLibro frmLibro;
        private LibraryWSClient _daoLibraryWS;
        private recursoBiblioteca _recurso;
        private BindingList<autor> _listaAutores;
        private BindingList<biblioteca> _bibliotecasEncargado;
        private encargadoBiblioteca _encargado;
        private bool _cambio_disponibilidad;
        private string _rutaPortada = "";
        public frmNuevoRecurso(encargadoBiblioteca encargado)
        {
            InitializeComponent();
            _encargado = encargado;
            estado = Estado.Inicial;
            _daoLibraryWS = new LibraryWSClient();
            try
            {
                if (_encargado.titulo_trabajo == "Supervisor Principal" || _encargado.titulo_trabajo == "Supervisor Secundario")
                {
                    _bibliotecasEncargado = new BindingList<biblioteca>(_daoLibraryWS.listarBibliotecasTodas().ToList());
                }
                else _bibliotecasEncargado = new BindingList<biblioteca>(_daoLibraryWS.listarBibliotecasIdEncargado(_encargado.idUsuario).ToList());
            }
            catch (Exception ex){
                _bibliotecasEncargado = null;
            }
            cboBiblioteca.DataSource = _bibliotecasEncargado;
            cboBiblioteca.DisplayMember = "nombre";
            cboBiblioteca.ValueMember = "idBiblioteca";
            cboBiblioteca.SelectedIndex = -1;
            frmLibro = new frmNuevoLibro();
            frmDigital = new frmNuevoDigital();
            txtIDRecurso.Enabled = false;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnPortada.Enabled = false;
                    btnEliminarPortada.Enabled = false;
                    btnCancelar.Enabled = false;
                    gbInformacion.Enabled = false;
                    gbTipo.Enabled = false;
                    frmDigital.Enabled = false;
                    frmLibro.Enabled = false;
                    txtIDRecurso.Enabled = false;
                    txtTitulo.Enabled = false;
                    txtISBN.Enabled = false;
                    rbDisponible.Enabled = false;
                    rbNoDisponible.Enabled = false;
                    dtpPublicacion.Enabled = false;
                    cboBiblioteca.Enabled = false;
                    rbDigital.Enabled = false;
                    rbLibro.Enabled = false;
                    _cambio_disponibilidad = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnPortada.Enabled = true;
                    btnEliminarPortada.Enabled = true;
                    btnCancelar.Enabled = true;
                    gbInformacion.Enabled = true;
                    gbTipo.Enabled = true;
                    frmDigital.Enabled = true;
                    frmLibro.Enabled = true;
                    txtTitulo.Enabled = true;
                    txtISBN.Enabled = true;
                    rbDisponible.Enabled = true;
                    rbNoDisponible.Enabled = true;
                    dtpPublicacion.Enabled = true;
                    cboBiblioteca.Enabled = true;
                    rbDigital.Enabled = true;
                    rbLibro.Enabled = true;
                    _cambio_disponibilidad = false;
                    break;
                case Estado.Modificar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnPortada.Enabled = true;
                    btnEliminarPortada.Enabled = true;
                    btnCancelar.Enabled = true;
                    gbInformacion.Enabled = true;
                    gbTipo.Enabled = true;
                    rbDisponible.Enabled = true;
                    rbNoDisponible.Enabled = true;
                    txtTitulo.Enabled = true;
                    txtISBN.Enabled = true;
                    dtpPublicacion.Enabled = true;
                    cboBiblioteca.Enabled = true;
                    frmDigital.Enabled = true;
                    frmLibro.Enabled = true;
                    rbDigital.Enabled = false;
                    rbLibro.Enabled = false;
                    _cambio_disponibilidad = false;
                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnPortada.Enabled = false;
                    btnEliminarPortada.Enabled = false;
                    btnCancelar.Enabled = true;
                    gbInformacion.Enabled = true;
                    txtIDRecurso.Enabled = false;
                    txtTitulo.Enabled = false;
                    txtISBN.Enabled = false;
                    rbDisponible.Enabled = false;
                    rbNoDisponible.Enabled = false;
                    dtpPublicacion.Enabled = false;
                    cboBiblioteca.Enabled = false;
                    gbTipo.Enabled = false;
                    btnBusqAutor.Enabled = true;
                    frmDigital.Enabled = false;
                    frmLibro.Enabled = false;
                    rbDigital.Enabled = false;
                    rbLibro.Enabled = false;
                    _cambio_disponibilidad = false;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtIDRecurso.Text = "";
            txtTitulo.Text = "";
            txtTitulo.Text = "";
            lblAutores.Text = "Lista de Autores...";
            txtTitulo.Text = "";
            txtTitulo.Text = "";
            txtTitulo.Text = "";
            lblMensaje.Text = "";
            txtISBN.Text = "";
            dtpPublicacion.Value = DateTime.Now;
            cboBiblioteca.SelectedIndex = -1;
            cboBiblioteca.Text = "";
            rbDigital.Checked = false;
            rbLibro.Checked = false;
            rbDisponible.Checked = false;
            rbNoDisponible.Checked = false;
            pbPortada.Image = null;
            _rutaPortada = "";
            panelTipo.Controls.Clear();
            frmDigital.limpiarFormulario();
            frmLibro.limpiarFormulario();
        }

        public void mostrarFormulario(Form form)
        {
            panelTipo.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelTipo.Controls.Add(form);
            form.Visible = true;
        }

        
        private void rbLibro_CheckedChanged(object sender, EventArgs e)
        {
            mostrarFormulario(frmLibro);
        }

        private void rbDigital_CheckedChanged(object sender, EventArgs e)
        {
            mostrarFormulario(frmDigital);
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaRecursos frmBusqRec = new frmBusquedaRecursos();
            if (frmBusqRec.ShowDialog() == DialogResult.OK)
            {
                estado = Estado.Buscar;
                establecerEstadoComponentes();
                if (frmBusqRec.RecursoSeleccionado.tipoRecurso == 'L') _recurso = new libro();
                else _recurso = new digital();
                _recurso = frmBusqRec.RecursoSeleccionado;
                txtIDRecurso.Text = _recurso.idRecurso.ToString();
                txtTitulo.Text = _recurso.titulo;
                _listaAutores = new BindingList<autor>(_recurso.autores);
                mostrarAutores();
                dtpPublicacion.Value = _recurso.fechaPublicacion;
                txtISBN.Text = _recurso.ISBN;
                if (_recurso.disponible) rbDisponible.Checked = true;
                else rbNoDisponible.Checked = true;
                if(_recurso.foto != null)
                {
                    MemoryStream ms = new MemoryStream(_recurso.foto);
                    pbPortada.Image = new Bitmap(ms);
                }
                else pbPortada.Image = null;
                
                if(_recurso.tipoRecurso == 'L')
                {
                    rbLibro.Checked = true;
                    mostrarFormulario(frmLibro);
                    frmLibro.setNroCopias(((libro)_recurso).nroCopias);
                    frmLibro.setNroPaginas(((libro)_recurso).nroPaginas);
                }
                else if (_recurso.tipoRecurso == 'D')
                {
                    rbDigital.Checked = true;
                    mostrarFormulario(frmDigital);
                    frmDigital.setRepositorio(((digital)_recurso).repositorio);
                    frmDigital.setDescargable(((digital)_recurso).descargable);
                    frmDigital.setURL(((digital)_recurso).URL);
                }
                if (_encargado.titulo_trabajo == "Supervisor Principal" || _encargado.titulo_trabajo == "Supervisor Secundario")
                {
                    cboBiblioteca.SelectedValue = _recurso.biblioteca.idBiblioteca;
                    return;
                }
                if(_bibliotecasEncargado != null)
                {
                    foreach (biblioteca b in _bibliotecasEncargado)
                    {
                        if (b.idBiblioteca == _recurso.biblioteca.idBiblioteca)
                        {
                            cboBiblioteca.SelectedValue = _recurso.biblioteca.idBiblioteca;
                            return;
                        }
                    }
                }  
                lblMensaje.Text = "*Usted no cuenta con los permisos necesarios para editar o eliminar la información de este recurso";
                cboBiblioteca.Text = _recurso.biblioteca.nombre;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            
        }

        private void btnBusqAutor_Click(object sender, EventArgs e)
        {
            if (estado == Estado.Buscar)
            {
                frmAutoresLibro frmAutor = new frmAutoresLibro(_listaAutores, false);
                if (frmAutor.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                frmAutoresLibro frmAutor = new frmAutoresLibro(_listaAutores);
                if (frmAutor.ShowDialog() == DialogResult.OK)
                {
                    _listaAutores = frmAutor.AutoresLibro;
                    mostrarAutores();
                }
            }
            
        }

        public void mostrarAutores()
        {
            lblAutores.Text = "";
            int i = 0;
            foreach (autor a in _listaAutores)
            {
                lblAutores.Text += a.nombre;
                if (_listaAutores.Count - 1 != i) lblAutores.Text += ", ";
                i++;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (rbDigital.Checked)
            {
                _recurso = new digital();
                _recurso.tipoRecurso = 'D';
                ((digital)_recurso).repositorio = frmDigital.getRepositorio();
                ((digital)_recurso).descargable = frmDigital.getDescargable();
                ((digital)_recurso).URL = frmDigital.getURL();
            }
            else if (rbLibro.Checked)
            {
                _recurso = new libro();
                _recurso.tipoRecurso = 'L';
                ((libro)_recurso).nroCopias = frmLibro.getNroCopias();
                ((libro)_recurso).nroPaginas = frmLibro.getNroPaginas();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el tipo de recurso a ingresar", "Mensaje de advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(cboBiblioteca.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar la biblioteca del recurso a ingresar", "Mensaje de advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _recurso.titulo = txtTitulo.Text;
            _recurso.biblioteca = new biblioteca();
            _recurso.biblioteca.idBiblioteca = (int)cboBiblioteca.SelectedValue;
            _recurso.fechaPublicacion = dtpPublicacion.Value;
            _recurso.fechaPublicacionSpecified = true;
            _recurso.ISBN = txtISBN.Text;

            if (_rutaPortada != "")
            {
                FileStream fs = new FileStream(_rutaPortada, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                _recurso.foto = br.ReadBytes((int)fs.Length);
                fs.Close();
                br.Close();
            }
            else _recurso.foto = null;
            
            if (rbDisponible.Checked) _recurso.disponible = true;
            else if (rbNoDisponible.Checked) _recurso.disponible = false;
            else
            {
                MessageBox.Show("Debe seleccionar la disponibilidad del recurso a ingresar", "Mensaje de advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(_listaAutores.Count() == 0)
            {
                MessageBox.Show("Debe seleccionar por lo menos un autor para el recurso", "Mensaje de advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _recurso.autores = new autor[_listaAutores.Count];
            _recurso.autores = _listaAutores.ToArray();

            if (estado == Estado.Nuevo)
            {
                if (MessageBox.Show("¿Está seguro de que desea agregar este recurso?", "Mensaje de confirmacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int resultado;
                    if (_recurso.tipoRecurso == 'L') resultado = _daoLibraryWS.insertarLibro((libro)_recurso);
                    else resultado = _daoLibraryWS.insetarDigital((digital)_recurso);

                    if (resultado != 0)
                    {
                        MessageBox.Show("Recurso correctamente agregado", "Mensaje de confirmacion", MessageBoxButtons.OK);
                        limpiarComponentes();
                        estado = Estado.Inicial;
                        establecerEstadoComponentes();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error en el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else if (estado == Estado.Modificar)
            {
                if (MessageBox.Show("¿Está seguro de que desea modificar este autor?", "Mensaje de confirmacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _recurso.idRecurso = Int32.Parse(txtIDRecurso.Text);
                    if (_recurso.tipoRecurso == 'L' && _cambio_disponibilidad == true && _recurso.disponible == true)
                    {
                        try
                        {
                            BindingList<prestamo> prestamos = new BindingList<prestamo>(_daoLibraryWS.listarPrestamosPorLibro(_recurso.idRecurso));
                            foreach (prestamo p in prestamos)
                            {
                                if (p.anulado == false && p.fechaDevolucionConfirmadaSpecified == false)
                                {
                                    MessageBox.Show("No se puede cambiar la disponibilidad de este libro porque se encuentra bajo préstamo",
                                        "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                        }
                        catch (Exception ex) {}
                    }
                    int resultado;
                    if (_recurso.tipoRecurso == 'L') resultado = _daoLibraryWS.modificarLibro((libro)_recurso);
                    else resultado = _daoLibraryWS.modificarDigital((digital)_recurso);
                    if (resultado != 0)
                    {
                        MessageBox.Show("Recurso correctamente modificado", "Mensaje de confirmacion", MessageBoxButtons.OK);
                        limpiarComponentes();
                        estado = Estado.Inicial;
                        establecerEstadoComponentes();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error en la modificacion", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estado = Estado.Nuevo;
            _listaAutores = new BindingList<autor>();
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar este recurso?", "Mensaje de confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (_recurso.tipoRecurso == 'L' && _recurso.disponible == false)
                {
                    try
                    {
                        BindingList<prestamo> prestamos = new BindingList<prestamo>(_daoLibraryWS.listarPrestamosPorLibro(_recurso.idRecurso));
                        foreach (prestamo p in prestamos)
                        {
                            if (p.anulado == false && p.fechaDevolucionConfirmadaSpecified == false)
                            {
                                MessageBox.Show("No se puede eliminar este libro porque se encuentra bajo préstamo",
                                    "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                    catch (Exception ex) {}
                }
                int resultado;
                if (_recurso.tipoRecurso == 'L') resultado = _daoLibraryWS.eliminarLibro(_recurso.idRecurso);
                else resultado = _daoLibraryWS.eliminarDigital(_recurso.idRecurso);
                if (resultado != 0)
                {
                    MessageBox.Show("Recurso correctamente eliminado", "Mensaje de confirmacion", MessageBoxButtons.OK);
                    establecerEstadoComponentes();
                }
                else
                {
                    MessageBox.Show("Hubo un error en la eliminación", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estado = Estado.Modificar;
            establecerEstadoComponentes();
        }

        private void rbNoDisponible_CheckedChanged(object sender, EventArgs e)
        {
            _cambio_disponibilidad = true;
        }

        private void rbDisponible_CheckedChanged(object sender, EventArgs e)
        {
            _cambio_disponibilidad = true;
        }

        private void btnPortada_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdPortada = new OpenFileDialog();
            try
            {
                if(ofdPortada.ShowDialog() == DialogResult.OK)
                {
                    _rutaPortada = ofdPortada.FileName;
                    pbPortada.Image = Image.FromFile(_rutaPortada);
                }
            }catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnEliminarPortada_Click(object sender, EventArgs e)
        {
            _rutaPortada = "";
            pbPortada.Image = null;
        }
    }
}
