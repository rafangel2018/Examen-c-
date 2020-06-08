using BLL;
using Entity;
using ExamenDeOndas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExamenDeOndas
{
    public partial class FrmEstudiante : Form
    {
        EstudianteService estudianteService = new EstudianteService();
        Estudiante estudiante;
        public FrmEstudiante()
        {
            InitializeComponent();
        }
        

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtIdentificacion.Text != "" && txtNombres.Text != "" && txtGrupo.Text != "")
            {
                estudiante = new Estudiante();
                estudiante.Identificacion = txtIdentificacion.Text.Trim();
                estudiante.Nombre = txtNombres.Text.Trim();
                estudiante.Grupo = txtGrupo.Text.Trim();
                string mensaje = estudianteService.Guardar(estudiante);
                MessageBox.Show(mensaje, "MENSAJE DE GUARDADO");
                Limpiar();
                Prueba frmExamen = new Prueba();
                frmExamen.Show();
                this.Close();
                
                

            }
            else
            {
                MessageBox.Show("Todos los campos deben estar llenos", "MENSAJE DE RECTIFICACION");
            }
        }
        private void Limpiar()
        {
            txtIdentificacion.Text = "";
            txtNombres.Text = "";
            txtGrupo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmConsultar frmConsultar  = new FrmConsultar();
            frmConsultar.Show();
        }
    }
}
