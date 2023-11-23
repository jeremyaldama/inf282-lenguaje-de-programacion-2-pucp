using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULearn.LogisticsWs;

namespace ULearn.Docente
{
    public partial class frmInfoEvento : Form
    {
        private evento _evento;
        private LogisticsWSClient dao;
        public frmInfoEvento(evento evento)
        {
            dao = new LogisticsWSClient();
            InitializeComponent();
            this._evento = evento;
            gboInfoEvento.Text = _evento.nombre;
            lblLugarValor.Visible = true;
            lblValorFecha.Visible = true;
            lblHoraValor.Visible = true;
            lblOrganizadorValor.Visible = true;
            lblLugarValor.Visible = true;
            lblValorFecha.Text = _evento.fecha.ToString("dd-MM-yyyy");
            lblHoraValor.Text = _evento.horaInicio.ToString() + " - " + _evento.horaFin.ToString();
            lblOrganizadorValor.Text = _evento.organizador.ToString();
            lblLugarValor.Text = _evento.espacio.nombre;
        }

        private void btnInscribirse_Click(object sender, EventArgs e)
        {

            int res = dao.inscribirseCharla(_evento.idEvento);
            if (res == 1)
            {
                MessageBox.Show("Se ha registrado en el evento con éxito", "Mensaje de confirmacion");
                btnInscribirse.Enabled = false;
                btnInscribirse.Text = "Inscrito";
            }

        }

        private void frmInfoEvento_Load(object sender, EventArgs e)
        {
            this.btnInscribirse.Enabled = false;
            if (_evento.fecha < DateTime.Now) 
            {
                this.btnInscribirse.Text = "Evento Culminado"; 
            }
            else if ((_evento.inscritos == _evento.espacio.aforo) && _evento.inscritos != 0)
            {
                this.btnInscribirse.Text = "Aforo Lleno";
            }
            else//correcto
            {
                this.btnInscribirse.Enabled = true;
            }
        }
    }
}
