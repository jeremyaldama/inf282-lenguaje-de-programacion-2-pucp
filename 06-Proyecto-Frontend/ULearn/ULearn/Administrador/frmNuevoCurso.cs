using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULearn.ServiciosAcademicos;
using ULearn.LogisticsWs;
using curso = ULearn.ServiciosAcademicos.curso;

namespace ULearn.Administrador
{
    public partial class frmNuevoCurso : Form
    {
        private Estado _estado;
        private curso _curso;
        private LogisticsWSClient _daoFacultad; 
        private AcademicsWSClient _daoCurso;
        public frmNuevoCurso()
        {
            _estado = Estado.Inicial;
            _daoFacultad = new LogisticsWSClient(); 
            _daoCurso = new AcademicsWSClient();
            InitializeComponent();
            cboSemestre.DataSource = _daoCurso.listarTodosSemestres();
            cboSemestre.DisplayMember = "semestre1";
            cboSemestre.ValueMember = "idSemestre";
            establecerEstadoComponentes();
            limpiarComponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    tsbNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    tsbBuscarCurso.Enabled = true;
                    btnCancelar.Enabled = true;
                    txtNombre.Enabled = false;
                    txtCodigoCurso.Enabled = false;
                    txtCreditos.Enabled = false;
                    rbNoElectivo.Enabled = false;
                    rbSiElectivo.Enabled = false;
                    cboSemestre.Enabled = false;
                    break;
                case Estado.Nuevo:
                    tsbNuevo.Enabled = false;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnGuardar.Enabled = true;
                    tsbBuscarCurso.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtNombre.Enabled = true;
                    txtCodigoCurso.Enabled = true;
                    txtCreditos.Enabled = true;
                    rbNoElectivo.Enabled = true;
                    rbSiElectivo.Enabled = true;
                    cboSemestre.Enabled = false;
                    break;
                case Estado.Modificar:
                    tsbNuevo.Enabled = false;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnGuardar.Enabled = true;
                    tsbBuscarCurso.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtNombre.Enabled = true;
                    txtCodigoCurso.Enabled = true;
                    txtCreditos.Enabled = true;
                    rbNoElectivo.Enabled = true;
                    rbSiElectivo.Enabled = true;
                    break;
                case Estado.Buscar:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    tsbBuscarCurso.Enabled = false;
                    tsbEditar.Enabled = true;
                    tsbEliminar.Enabled = true;
                    btnCancelar.Enabled = true;
                    txtNombre.Enabled = false;
                    txtCodigoCurso.Enabled = false;
                    txtCreditos.Enabled = false;
                    rbNoElectivo.Enabled = false;
                    rbSiElectivo.Enabled = false;                
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtIDCurso.Text = "";
            txtNombre.Text = "";
            txtCodigoCurso.Text = "";
            txtCreditos.Text = "";
            cboSemestre.SelectedIndex = -1; 
            rbNoElectivo.Checked = false;
            rbSiElectivo.Checked = false;
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


        private void tsbBuscarCurso_Click(object sender, EventArgs e)
        {
            frmBuscarCursos formBuscarCursos = new frmBuscarCursos();
            if (formBuscarCursos.ShowDialog() == DialogResult.OK)
            {
                _curso = formBuscarCursos.CursoSeleccionado;
                txtIDCurso.Text = _curso.idCurso.ToString();
                txtNombre.Text = _curso.nombre;
                txtCodigoCurso.Text = _curso.codCurso;
                txtCreditos.Text = _curso.creditos.ToString();
                if (_curso.esElectivo == 1) rbSiElectivo.Checked = true;
                else rbNoElectivo.Checked = true;
            }
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            _curso = new curso();
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Modificar;
            establecerEstadoComponentes();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (
            MessageBox.Show("¿Está seguro que desea eliminar este curso?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int resultado = _daoCurso.eliminarCurso(_curso.idCurso);
                _estado = Estado.Inicial;
                if (resultado != 0)
                {
                    MessageBox.Show("El curso se eliminó correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El curso no pudo eliminarse", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void lblFacultad_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el nombre del curso", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCodigoCurso.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el codigo del curso", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rbSiElectivo.Checked == false && rbNoElectivo.Checked == false)
            {
                MessageBox.Show("Debe indicar si el curso es un electivo o no", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCreditos.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar los creditos del curso", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Double.Parse(txtCreditos.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número como creditaje", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            _curso.nombre = txtNombre.Text;
            _curso.creditos = Double.Parse(txtCreditos.Text);
            _curso.codCurso = txtCodigoCurso.Text;
            if (rbSiElectivo.Checked) _curso.esElectivo = 1;
            else _curso.esElectivo = 0;

            if (_estado == Estado.Nuevo)
            {
                int resultado = _daoCurso.insertarCurso(_curso);
                if (resultado != 0)
                {
                    txtIDCurso.Text = _curso.idCurso.ToString();
                    MessageBox.Show("El curso se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    limpiarComponentes();
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (_estado == Estado.Modificar)
            {
                if(cboSemestre.SelectedIndex != -1)
                {
                    ServiciosAcademicos.semestre s = (ServiciosAcademicos.semestre)cboSemestre.SelectedItem;
                    int resu = _daoCurso.agregarCursoASemestre(_curso.idCurso, s.idSemestre);   
                    if(resu != 0)
                    {
                        MessageBox.Show("El curso se ha aperturado en el semestre " + s.semestre1 + " con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _estado = Estado.Inicial;
                        limpiarComponentes();
                        establecerEstadoComponentes();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error en la apertura para el curso en el semestre", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    _curso.idCurso = Int32.Parse(txtIDCurso.Text);
                    int resultado = _daoCurso.actualizarCurso(_curso);
                    if (resultado != 0)
                    {
                        MessageBox.Show("El curso se ha modificado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _estado = Estado.Inicial;
                        limpiarComponentes();
                        establecerEstadoComponentes();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error en la modificacion", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                

            }
        }

        private void tsbCursoSemestre_Click(object sender, EventArgs e)
        {
            cboSemestre.Enabled = true;
            this._estado = Estado.Modificar;
            btnGuardar.Enabled = true;
        }
    }
}
