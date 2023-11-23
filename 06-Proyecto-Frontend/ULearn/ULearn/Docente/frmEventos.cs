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
    public partial class frmEventos : Form
    {
        LogisticsWSClient dao;
        public frmEventos()
        {
            InitializeComponent();
            dao = new LogisticsWSClient();
            cbCharla.Checked = true;
            cbTaller.Checked = true;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtpDesde.Value;
            string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd");
            BindingList<charla> charlas = new BindingList<charla>();
            BindingList<taller> talleres = new BindingList<taller>();
            this.panelContenido.Controls.Clear();
            if (cbCharla.Checked)
            {
                try
                {
                    charlas = new BindingList<charla>(dao.listaCharlasFecha(fechaFormateada));
                    foreach (charla c in charlas)
                    {
                        frmInfoEvento formInfoEvento = new frmInfoEvento(c); //se haria por cada evento
                        formInfoEvento.TopLevel = false;
                        formInfoEvento.Dock = DockStyle.Top;
                        this.panelContenido.Controls.Add(formInfoEvento);
                        formInfoEvento.Visible = true;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("No se hallaron charlas con los filtros indicados", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    charlas = null;
                }
            }
            if (cbTaller.Checked)
            {
                try
                {
                    talleres = new BindingList<taller>(dao.listarTalleresFecha(fechaFormateada));
                    foreach (taller t in talleres)
                    {
                        frmInfoEvento formInfoEvento = new frmInfoEvento(t); //se haria por cada evento
                        formInfoEvento.TopLevel = false;
                        formInfoEvento.Dock = DockStyle.Top;
                        this.panelContenido.Controls.Add(formInfoEvento);
                        formInfoEvento.Visible = true;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("No se hallaron talleres con los filtros indicados", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    talleres = null;
                }
            }
            if(charlas == null && talleres == null)
            {
                MessageBox.Show("No se hallaron eventos con los filtros indicados", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            this.panelContenido.Controls.Clear();
            Label lbl = new Label();
            lbl.Text = "Por favor, aplicar filtros de búsqueda";
            lbl.Dock = DockStyle.Top;
            this.panelContenido.Controls.Add(lbl);
        }
    }
}
