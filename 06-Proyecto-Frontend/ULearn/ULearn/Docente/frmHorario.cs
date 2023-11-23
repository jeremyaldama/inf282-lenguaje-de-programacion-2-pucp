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

namespace ULearn.Docente
{
    public partial class frmHorario : Form
    {
        private BindingList<horario> _horarios;
        public frmHorario(BindingList<horario> horarios)
        {
            InitializeComponent();
            agregarFilasDeHoras();
            this._horarios = horarios;
            foreach (horario horario in _horarios)
            {
                TimeSpan t1 = TimeSpan.Parse(horario.horaInicio);
                TimeSpan t2 = TimeSpan.Parse(horario.horaFin);

                int inicio = Int32.Parse(t1.Hours.ToString());
                int fin = Int32.Parse(t2.Hours.ToString());

                for (int i = inicio - 7; i < fin - 7; i++)
                {
                    string dia = horario.dia.ToString();
                    if (dia == "Lunes")
                        dgvHorario.Rows[i].Cells[1].Value = horario.curso.codCurso + " - " + horario.curso.nombre.ToString();
                    if (dia == "Martes")
                        dgvHorario.Rows[i].Cells[2].Value = horario.curso.codCurso + " - " + horario.curso.nombre.ToString();
                    if (dia == "Miercoles")
                        dgvHorario.Rows[i].Cells[3].Value = horario.curso.codCurso + " - " + horario.curso.nombre.ToString();
                    if (dia == "Jueves")
                        dgvHorario.Rows[i].Cells[4].Value = horario.curso.codCurso + " - " + horario.curso.nombre.ToString();
                    if (dia == "Viernes")
                        dgvHorario.Rows[i].Cells[5].Value = horario.curso.codCurso + " - " + horario.curso.nombre.ToString();
                    if (dia == "Sabado")
                        dgvHorario.Rows[i].Cells[6].Value = horario.curso.codCurso + " - " + horario.curso.nombre.ToString();
                    if (dia == "Domingo")
                        dgvHorario.Rows[i].Cells[7].Value = horario.curso.codCurso + " - " + horario.curso.nombre.ToString();
                }
            }
        }

        private void agregarFilasDeHoras()
        {
            dgvHorario.Rows.Add("7:00-8:00");
            dgvHorario.Rows.Add("8:00-9:00");
            dgvHorario.Rows.Add("9:00-10:00");
            dgvHorario.Rows.Add("10:00-11:00");
            dgvHorario.Rows.Add("11:00-12:00");
            dgvHorario.Rows.Add("12:00-13:00");
            dgvHorario.Rows.Add("13:00-14:00");
            dgvHorario.Rows.Add("14:00-15:00");
            dgvHorario.Rows.Add("15:00-16:00");
            dgvHorario.Rows.Add("16:00-17:00");
            dgvHorario.Rows.Add("16:00-17:00");
            dgvHorario.Rows.Add("17:00-18:00");
            dgvHorario.Rows.Add("18:00-19:00");
            dgvHorario.Rows.Add("19:00-20:00");
            dgvHorario.Rows.Add("20:00-21:00");
            dgvHorario.Rows.Add("21:00-22:00");
            dgvHorario.Rows.Add("22:00-23:00");
        }
    }
}
