using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULearn.Administrador;
using ULearn.LibraryWS;

namespace ULearn.Bibliotecario
{
    public partial class frmNuevoAutor : Form
    {
        private LibraryWSClient _daoLibraryWS;
        private autor _autor;
        private Estado _estado;
        public frmNuevoAutor()
        {
            _daoLibraryWS = new LibraryWSClient();
            _estado = Estado.Inicial;
            InitializeComponent();
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    txtID.Enabled = false;
                    txtNombre.Enabled = false;
                    txtNacionalidad.Enabled = false;
                    break;
                case Estado.Nuevo:
                case Estado.Modificar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    txtNombre.Enabled = true;
                    txtNacionalidad.Enabled = true;

                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    txtNombre.Enabled = false;
                    txtNacionalidad.Enabled = false;

                    break;
            }
        }
        public void limpiarComponentes()
        {
            txtID.Text = "";
            txtNacionalidad.Text = "";
            txtNombre.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaDeAutor frmBusqAutor = new frmBusquedaDeAutor();
            if (frmBusqAutor.ShowDialog() == DialogResult.OK)
            {
                _estado = Estado.Buscar;
                establecerEstadoComponentes();
                _autor = frmBusqAutor.AutorSeleccionado;
                txtID.Text = _autor.idAutor.ToString();
                txtNombre.Text = _autor.nombre;
                txtNacionalidad.Text= _autor.nacionalidad;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _autor.nombre = txtNombre.Text;
            _autor.nacionalidad = txtNacionalidad.Text;

            if(_estado == Estado.Nuevo)
            {
                if (MessageBox.Show("¿Está seguro de que desea agregar este autor?", "Mensaje de confirmacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int resultado = _daoLibraryWS.insertarAutor(_autor);
                    if(resultado != 0)
                    {
                        MessageBox.Show("Autor correctamente agregado", "Mensaje de confirmacion", MessageBoxButtons.OK);
                        limpiarComponentes();
                        _estado = Estado.Inicial;
                        establecerEstadoComponentes();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error en el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else if(_estado == Estado.Modificar)
            {
                _autor.idAutor = Int32.Parse(txtID.Text);
                if (MessageBox.Show("¿Está seguro de que desea modificar este autor?", "Mensaje de confirmacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int resultado = _daoLibraryWS.modificarAutor(_autor);
                    if (resultado != 0)
                    {
                        MessageBox.Show("Autor correctamente modificado", "Mensaje de confirmacion", MessageBoxButtons.OK);
                        limpiarComponentes();
                        _estado = Estado.Inicial;
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
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            _autor = new autor();
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro que desea eliminar este autor?", "Mensaje de confirmación", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int resultado = _daoLibraryWS.eliminarAutor(_autor.idAutor);
                if(resultado != 0)
                {
                    MessageBox.Show("Autor correctamente eliminado", "Mensaje de confirmacion", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Hubo un error en la eliminación", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Modificar;
            establecerEstadoComponentes();
        }
    }
}
