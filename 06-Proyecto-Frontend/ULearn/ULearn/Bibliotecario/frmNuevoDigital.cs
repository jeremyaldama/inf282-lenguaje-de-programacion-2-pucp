using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ULearn.Bibliotecario
{
    public partial class frmNuevoDigital : Form
    {
        public frmNuevoDigital()
        {
            InitializeComponent();
        }

        public string getRepositorio()
        {
            return txtRepositorio.Text;
        }

        public bool getDescargable()
        {
            if (rbSi.Checked) return true;
            else return false;
        }

        public string getURL()
        {
            return txtURL.Text;
        }

        public void limpiarFormulario()
        {
            txtRepositorio.Text = "";
            txtURL.Text = "";
            rbNo.Checked = false;
            rbSi.Checked = false;
        }

        public void setRepositorio(string _repo)
        {
            txtRepositorio.Text = _repo;
        }

        public void setDescargable(bool _descargable)
        {
            if (_descargable)
            {
                rbSi.Checked = true;
                rbNo.Checked = false;
            }
            else
            {
                rbSi.Checked = false;
                rbNo.Checked = true;
            }
        }

        public void setURL(string _url)
        {
            txtURL.Text = _url;
        }


    }
}
