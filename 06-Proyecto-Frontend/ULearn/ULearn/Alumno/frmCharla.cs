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

namespace ULearn.Alumno
{
    public partial class frmCharla : Form
    {
        private LogisticsWSClient daoClient;
        private charla charl;
        public frmCharla()
        {
            daoClient = new LogisticsWSClient();
            InitializeComponent();
        }

        private void bttnBuscarTaller_Click(object sender, EventArgs e)
        {
            dgvCharla.AutoGenerateColumns = false;
            DateTime fechaSeleccionada = dtpCharla.Value;
            string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd");

            try
            {
                dgvCharla.DataSource = daoClient.listaCharlasFecha(fechaFormateada).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay charlas a partir de esa fecha, ingresar otra fecha", "Sin talleres", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvCharla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            charl = (charla)dgvCharla.Rows[e.RowIndex].DataBoundItem;
            if (charl != null)
            {
                dgvCharla.Rows[e.RowIndex].Cells[0].Value = charl.nombre;
                dgvCharla.Rows[e.RowIndex].Cells[1].Value = charl.organizador;
                dgvCharla.Rows[e.RowIndex].Cells[2].Value = charl.fecha;
                dgvCharla.Rows[e.RowIndex].Cells[3].Value = charl.horaInicio;
                dgvCharla.Rows[e.RowIndex].Cells[4].Value = charl.horaFin;
                dgvCharla.Rows[e.RowIndex].Cells[5].Value = charl.ponente;
            }
        }

        private void bttnIncribirseCharla_Click(object sender, EventArgs e)
        {
            charl = (charla)dgvCharla.CurrentRow.DataBoundItem;

            int resultado = daoClient.inscribirseCharla(charl.idEvento);
            if (resultado != 0)
            {
                MessageBox.Show("Se ha enviado un correo con la informacion acerca del evento," +
                " gracias", "Inscripción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
