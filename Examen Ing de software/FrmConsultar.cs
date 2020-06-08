using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace ExamenDeOndas
{
    public partial class FrmConsultar : Form
    {
        EstudianteService estudianteService = new EstudianteService();
        public FrmConsultar()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DtgConsultarExamenes.DataSource = null;
            DtgConsultarExamenes.DataSource = estudianteService.Consultar();
        }
    }
}
