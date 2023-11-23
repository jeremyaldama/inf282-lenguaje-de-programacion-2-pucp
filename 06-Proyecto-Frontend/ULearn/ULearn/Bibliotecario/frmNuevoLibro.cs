using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ULearn.Bibliotecario
{
    public partial class frmNuevoLibro : Form
    {
        public frmNuevoLibro()
        {
            InitializeComponent();
        }
        
        public void limpiarFormulario()
        {
            txtCopias.Text = "";
            txtPaginas.Text = "";
        }


        public int getNroCopias()
        {
            return Int32.Parse(txtCopias.Text);
        }

        public int getNroPaginas()
        {
            return Int32.Parse(txtPaginas.Text);
        }


        public void setNroCopias(int _nroCopias)
        {
            txtCopias.Text = _nroCopias.ToString();
        }

        public void setNroPaginas(int _nroPaginas)
        {
            txtPaginas.Text = _nroPaginas.ToString();
        }
    }
}
