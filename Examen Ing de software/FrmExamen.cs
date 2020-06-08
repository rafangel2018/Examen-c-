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
    public partial class Prueba : Form
    {
        int resultado = 0;
        int seleccion = 1;
        public Prueba()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void Iniciar()
        {
            
                this.pregunta.Text = "En fisica la palabra Onda se utiliza para?";
                this.opcion1.Text = "Transportar materia de un lado al otro ";
                this.opcion2.Text = "Designar la trasmisión de energía sin desplazamiento de materia.";
                this.opcion3.Text = "Designar la trasmisión de potencia de una materia";
                this.opcion4.Text = "Un requisito para la fisica.";
           
               // Application.Exit();
            

        }

        private void pregunta2()
        {
            this.pregunta.Text = "¿Que es una onda sonora?";
            this.opcion1.Text = "Es una onda no longitudinal que transmite lo que se asocia con sonido.";
            this.opcion2.Text = "Es una onda longitudinal que transmite lo que se asocia con sonido.";
            this.opcion3.Text = "Todas las anteriores.";
            this.opcion4.Text = "Ninguna de las anteriores.";
            seleccion++;
        }
        private void pregunta3()
        {
            this.pregunta.Text = "¿Por que´ medio se propaga las ONDAS ELECTROMAGNÉTICAS?.";
            this.opcion1.Text = "Se desplazan por el sonido.";
            this.opcion2.Text = "Las ondas electromagnéticas se desplazan por las vibraciones de la energia.";
            this.opcion3.Text = "Todas las ondas no necesitan un medio para desplazarce";
            this.opcion4.Text = "Las ondas electromagnéticas no necesitan un medio para desplazarse.";
            seleccion++;
        }
        private void pregunta4()
        {
            this.pregunta.Text = "¿Cual de los siguientes es un ejemplo de ONDAS? ";
            this.opcion1.Text = "Las olas producidas por un objeto que cae en el agua en reposo.";
            this.opcion2.Text = "Un resorte que se estira y encoge.";
            this.opcion3.Text = "Todas las anteriores";
            this.opcion4.Text = "TNinguna de las anteriores";
            seleccion++;
        }
        private void pregunta5()
        {
            this.pregunta.Text = "¿Cual de los siguientes ejemplos son de ONDAS ELECTROMAGNÉTICAS? ";
            this.opcion1.Text = "Las olas del mar";
            this.opcion2.Text = "Las vibraciones de la tierra";
            this.opcion3.Text = "Rayos ultravioletas.";
            this.opcion4.Text = "La forma de comunicarce los murcielagos";
            seleccion++;
        }
        private void pregunta6()
        {
            this.pregunta.Text = "ESCOJA LA OPCION VERDADERA";
            this.opcion1.Text = "Una onda tiene un movimiento periódico que se repite por ciclos.";
            this.opcion2.Text = "Una onda tiene un movimiento circular.";
            this.opcion3.Text = "Todas las ondas necesitan de un medio para desplazarce";
            this.opcion4.Text = "Todas son verdaderas";
            seleccion++;
        }
        private void pregunta7()
        {
            this.pregunta.Text = "Una onda choca con un obstaculo. Invierte la direccion de su movimiento sin cambiar de medio este efecto se llama:";
            this.opcion1.Text = "Reflexion";
            this.opcion2.Text = "Refraccion";
            this.opcion3.Text = "Interferencia";
            this.opcion4.Text = "Difraccion";
            seleccion++;
        }
        private void pregunta8()
        {
            this.pregunta.Text = "El valor de la velocidad de la onda:";
            this.opcion1.Text = "Depende del tiempo trancurrido";
            this.opcion2.Text = "Depende de la longitud y del tiempo";
            this.opcion3.Text = "Depende del material";
            this.opcion4.Text = "Depende del medio";
            seleccion++;
        }
        private void pregunta9()
        {
            this.pregunta.Text = "Las ondas electromagneticas";
            this.opcion1.Text = "No se propagan en medios materiales";
            this.opcion2.Text = "Son siempre transversales";
            this.opcion3.Text = "Pueden ser logitudinales y transversales";
            this.opcion4.Text = "Solo son longitudinales";
            seleccion++;
        }
        private void pregunta10()
        {
            this.pregunta.Text = "¿A que es igual la frecuencia con respecto al periodo?";
            this.opcion1.Text = "La frecuencia es igual al período";
            this.opcion2.Text = "La frecuencia es inversa a a longitud (L=f/t)";
            this.opcion3.Text = "La frecuencia es inversa al período (f=1/T)";
            this.opcion4.Text = "La frecuencia es inversa al período (f=2/T*M)";
            seleccion++;
        }

        private void Limpiar()
        {
            this.opcion1.Checked = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (seleccion)
            {
                case 1:
                    if (this.opcion3.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta2();
                    Limpiar();
                    break;

                case 2:
                    if (this.opcion2.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta3();
                    Limpiar();
                    break;

                case 3:
                    if (this.opcion4.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta4();
                    Limpiar();
                    break;

                case 4:
                    if (this.opcion3.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta5();
                    Limpiar();
                    break;

                case 5:
                    if (this.opcion3.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta6();
                    Limpiar();
                    break;

                case 6:
                    if (this.opcion1.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta7();
                    Limpiar();
                    break;

                case 7:
                    if (this.opcion4.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta8();
                    Limpiar();
                    break;

                case 8:
                    if (this.opcion2.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta9();
                    Limpiar();
                    break;

                case 9:
                    if (this.opcion4.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta10();
                    Limpiar();
                    break;

                case 10:
                    if (this.opcion3.Checked == true)
                    {
                        resultado++;
                    }
                    if (resultado >= 7)
                    {
                        MessageBox.Show("GANASTES, Sacaste  " + resultado.ToString() + "  Preguntas Buenas", "FELICITACIONES GANASTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmEstudiante frmEstudiante = new FrmEstudiante();
                        frmEstudiante.Show();
                        this.Close();
                        // Application.Exit();

                    }
                    else
                    {
                        MessageBox.Show("PERDISTE, Sacaste  " + resultado.ToString() + "  Preguntas Buenas", "PERDISTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        FrmEstudiante frmEstudiante = new FrmEstudiante();
                        frmEstudiante.Show();
                        this.Close();
                        //Application.Exit();
                    }

                    break;
                default:
                    break;
            }
        }

        private void opcion1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        
    }
}
