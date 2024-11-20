using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABAJO_CRUDF
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btn_Inscribiralumno_Click(object sender, EventArgs e)
        {
            INSAlumnos form = new INSAlumnos();
            form.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btn_Inscribirasignatura_Click(object sender, EventArgs e)
        {
            AsignaturaForm form = new AsignaturaForm();
            form.Show();
        }
    }
}
