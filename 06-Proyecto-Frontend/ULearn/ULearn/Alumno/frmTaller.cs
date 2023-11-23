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
    public partial class frmTaller : Form
    {
        private LogisticsWSClient daotaller;
        private taller tall;
        public frmTaller()
        {
            daotaller = new LogisticsWSClient();
            InitializeComponent();
        }

        private void bttnBuscarTaller_Click(object sender, EventArgs e)
        {
            dgvTalleres.AutoGenerateColumns = false;
            DateTime fechaSeleccionada = dtpTaller.Value;
            string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd");
            try
            {
                dgvTalleres.DataSource = daotaller.listarTalleresFecha(fechaFormateada).ToList();
            }
            catch(Exception ex) {
                MessageBox.Show("No hay talleres a partir de esa fecha, ingresar otra fecha", "Sin talleres", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvTalleres_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            tall = (taller)dgvTalleres.Rows[e.RowIndex].DataBoundItem;
            if (tall != null)
            {
                dgvTalleres.Rows[e.RowIndex].Cells[0].Value = tall.nombre;
                dgvTalleres.Rows[e.RowIndex].Cells[1].Value = tall.organizador;
                dgvTalleres.Rows[e.RowIndex].Cells[2].Value = tall.fecha;
                dgvTalleres.Rows[e.RowIndex].Cells[3].Value = tall.horaInicio;
                dgvTalleres.Rows[e.RowIndex].Cells[4].Value = tall.horaFin;
                dgvTalleres.Rows[e.RowIndex].Cells[5].Value = tall.areaInteres;
            }
            
        }

        private void bttnIncribirseTaller_Click(object sender, EventArgs e)
        {
            tall = (taller)dgvTalleres.CurrentRow.DataBoundItem;

            int resultado = daotaller.inscribirseTaller(tall.idEvento);
            if (resultado != 0)
            {
                MessageBox.Show("Se ha enviado un correo con la informacion acerca del evento," +
                " gracias", "Inscripción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
