using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULearn.ServiciosAcademicos;

namespace ULearn.Docente
{
    public partial class frmRegNota : Form
    {
        private int _nota;
        private ServiciosAcademicos.alumno _alumno;
        private bool _falto;
        private ServiciosAcademicos.evaluacion _evaluacion;
        public frmRegNota(ServiciosAcademicos.alumno a, evaluacion eval)
        {
            InitializeComponent();
            lblCodigo.Text = a.codigoAlumno;
            lblNombre.Text = a.apellidoPaterno + ", " + a.nombre;
            txtNota.Text = eval.nota != -1? eval.nota.ToString() : "";
            txtNota.Enabled = false;
            lblGuardado.Visible = false;
            cbFalto.Enabled = false;
            this.Alumno = a;
            this.Evaluacion = eval;
        }

        public int Nota { get => _nota; set => _nota = value; }
        public alumno Alumno { get => _alumno; set => _alumno = value; }
        public bool Falto { get => _falto; set => _falto = value; }
        public evaluacion Evaluacion { get => _evaluacion; set => _evaluacion = value; }

        public void cambioEvaluacion()
        { 
            if ((char)Evaluacion.asistio == 'F')
            {
                txtNota.Text = "F";
                cbFalto.Checked = true;
            }
            else
            {
                txtNota.Text = Evaluacion.nota != -1 ? Evaluacion.nota.ToString() : "";
            }
        }
        public void actualizarEstado(Estado _estado, int res = 0)
        {
            if(_estado == Estado.Modificar)
            {
                txtNota.Enabled = true;
                cbFalto.Enabled = true;
                cbFalto.Checked = false;
                lblGuardado.Visible = false;
            }
                
            if (_estado == Estado.Guardar)
            {
                txtNota.Enabled = false;
                cbFalto.Enabled = false;
                if (res != 0)
                {
                    lblGuardado.Text = "Registro exitoso";
                    lblGuardado.ForeColor = Color.Blue;
                }
                else
                {
                    lblGuardado.Text = "Reintentar";
                    lblGuardado.ForeColor = Color.Red;
                }
                lblGuardado.Visible = true;
            }
           
        }

        public int esValido()
        {
            this.Falto = cbFalto.Checked;
            try
            {
                if (this.Falto == false)
                {
                    Nota = Int32.Parse(txtNota.Text);
                    if (Nota >= 0 && Nota <= 20)
                    {
                        return 1;
                    }
                    else
                    {
                        txtNota.Text = "";
                        lblGuardado.Text = "Reintentar";
                        lblGuardado.ForeColor = Color.Red;
                        lblGuardado.Visible = true;
                        throw new FormatException();
                    }
                }
                else
                {
                    Nota = -1; //si falto
                    return 1;
                }
                
            }
            catch(FormatException ex)
            {
                MessageBox.Show("El valor de nota del alumno " + lblCodigo.Text + " debe ser un número del 0 al 20","Mensaje de error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNota.Text = "";
                lblGuardado.Text = "Reintentar";
                lblGuardado.ForeColor = Color.Red;
                lblGuardado.Visible= true;
                return 0;   
            }    
        }

        private void txtNota_TextChanged(object sender, EventArgs e)
        {
            if (txtNota.Text != "")
                cbFalto.Enabled = false;
            else 
                cbFalto.Enabled = true;
        }

        private void cbFalto_CheckedChanged(object sender, EventArgs e)
        {
            txtNota.Enabled = !cbFalto.Checked;
        }
    }
}
