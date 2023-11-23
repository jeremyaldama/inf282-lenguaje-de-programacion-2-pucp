using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULearn.LibraryWS;

namespace ULearn.Bibliotecario
{
    public partial class frmFiltros : Form
    {
        private LibraryWSClient _daoLibraryWS;
        public frmFiltros()
        {
            InitializeComponent();
            _daoLibraryWS = new LibraryWSClient();
            biblioteca todas = new biblioteca();
            _daoLibraryWS = new LibraryWSClient();
            todas.idBiblioteca = -1;
            todas.nombre = "Todas las bibliotecas";
            BindingList<biblioteca> listaBibliotecas = new BindingList<biblioteca>(_daoLibraryWS.listarBibliotecasTodas().ToList());
            listaBibliotecas.Insert(0, todas);
            cboBiblioteca.DataSource = listaBibliotecas;
            cboBiblioteca.DisplayMember = "nombre";
            cboBiblioteca.ValueMember = "idBiblioteca";
            cboBiblioteca.SelectedIndex = 0;
            dtpDesde.Value = dtpDesde.MinDate;
            dtpHasta.Value = dtpHasta.MaxDate;
        }

        public DateTime getMinDate()
        {
            return dtpDesde.MinDate;
        }

        public DateTime getMaxDate()
        {
            return dtpHasta.MaxDate;
        }

        public biblioteca getBiblioteca()
        {
            return (biblioteca)cboBiblioteca.SelectedItem;
        }

        public DateTime getFechaDesde()
        {
            return dtpDesde.Value;
        }

        public DateTime getFechaHasta()
        {
            return dtpHasta.Value;
        }

        public int getAnulado()
        {
            if (cbAnulado.Checked && cbNoAnulados.Checked) return 2;
            else if (cbAnulado.Checked) return 1;
            else if (cbNoAnulados.Checked) return 0;
            else return 3; //error
        }

        public int getConRetraso()
        {
            if (cbConRetraso.Checked && cbSinRetraso.Checked) return 2;
            else if (cbConRetraso.Checked) return 1;
            else if (cbSinRetraso.Checked) return 0;
            else return 3; //error
        }

        public int getDevuelto()
        {
            if (cboDevueltos.Checked && cbNoDevuelto.Checked) return 2;
            else if (cbNoDevuelto.Checked) return 0;
            else if (cboDevueltos.Checked) return 1;
            else return 3; //error
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {

            if(cboBiblioteca.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una opcion válida para las bibliotecas", "Falta de parámetros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(cbAnulado.Checked == false && cbNoAnulados.Checked == false)
            {
                MessageBox.Show("Debe seleccionar una opcion para los prestamos anulados", "Falta de parámetros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(cbConRetraso.Checked == false && cbSinRetraso.Checked == false)
            {
                MessageBox.Show("Debe seleccionar una opcion para los prestamos con retraso", "Falta de parámetros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(cboDevueltos.Checked == false && cbNoDevuelto.Checked == false)
            {
                MessageBox.Show("Debe seleccionar una opcion para los prestamos devueltos", "Falta de parámetros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboBiblioteca.SelectedIndex = 0;
            dtpDesde.Value = dtpDesde.MinDate;
            dtpHasta.Value = dtpHasta.MaxDate;
            cbConRetraso.Checked = cbSinRetraso.Checked = cboDevueltos.Checked = cbNoDevuelto.Checked = 
                cbAnulado.Checked = cbNoAnulados.Checked = true;
            this.DialogResult = DialogResult.OK;
        }

        private void cbNoAnulados_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAnulado.Checked == true && cbNoAnulados.Checked == false)
            {
                cbConRetraso.Hide();
                cbSinRetraso.Hide();
                cboDevueltos.Hide();
                cbNoDevuelto.Hide();
            }
            else
            {
                cbConRetraso.Show();
                cbSinRetraso.Show();
                cboDevueltos.Show();
                cbNoDevuelto.Show();
            }
        }

        private void cbAnulado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAnulado.Checked == true && cbNoAnulados.Checked == false)
            {
                cbConRetraso.Hide();
                cbSinRetraso.Hide();
                cboDevueltos.Hide();
                cbNoDevuelto.Hide();
            }
            else
            {
                cbConRetraso.Show();
                cbSinRetraso.Show();
                cboDevueltos.Show();
                cbNoDevuelto.Show();
            }
        }
    }
}
