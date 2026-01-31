using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        double Promedio;
        public Form1()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            buttonEnviar.Enabled = false;

            int N1 = int.Parse(textBoxN1.Text);
            int N2 = int.Parse(textBoxN2.Text);
            int N3 = int.Parse(textBoxN3.Text);
            int N4 = int.Parse(textBoxN4.Text);

            Promedio = (N1 + N2 + N3 + N4) / 4.0;

            labelN.Text = $"Promedio: {Promedio:F2}";
            labelN.Visible = true;

            if (Promedio >= 70)
            {
                labelEstado.Text = "Aprobado";
            }
            else
            {
                groupBox2.Visible = true; // Muestra Completivo
            }
        }

        private void buttonEnviar2_Click(object sender, EventArgs e)
        {
            buttonEnviar2.Enabled = false;

            double Completivo = double.Parse(textBoxCompletivo.Text);
            double NotaCompletivo = (Completivo * 0.5) + (Promedio * 0.5);

            label8.Text = $"Nota Completivo: {NotaCompletivo:F2}";
            label8.Visible = true;
            labelNC.Text = $"Nota Completivo: {NotaCompletivo:F2}";
            labelNC.Visible = true;

            if (NotaCompletivo >= 70)
            {
                labelEstado.Text = "Aprobado";
            }
            else
            {
                groupBox3.Visible = true;
            }
        }

        private void buttonEnviar3_Click(object sender, EventArgs e)
        {
            buttonEnviar3.Enabled = false;

            double Extraordinario = double.Parse(textBoxExtra.Text);
            double NotaExtra = (Extraordinario * 0.7) + (Promedio * 0.3);

            label9.Text = $"Nota Extraordinario: {NotaExtra:F2}";
            label9.Visible = true;
            labelNE.Text = $"Nota Extraordinario: {NotaExtra:F2}";
            labelNE.Visible = true;

            if (NotaExtra >= 70)
            {
                labelEstado.Text = "Aprobado";
            }
            else
            {
                labelEstado.Text = "Reprobado";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxN1.Clear();
            textBoxN2.Clear();
            textBoxN3.Clear();
            textBoxN4.Clear();
            textBoxCompletivo.Clear();
            textBoxExtra.Clear();

            labelN.Text = "Promedio:";
            labelNC.Text = "Nota Completivo:";
            labelNE.Text = "Nota Extraordinario:";
            labelEstado.Text = "";

            labelN.Visible = false;
            labelNC.Visible = false;
            labelNE.Visible = false;

            groupBox2.Visible = false;
            groupBox3.Visible = false;

            buttonEnviar.Enabled = true;
            buttonEnviar2.Enabled = true;
            buttonEnviar3.Enabled = true;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
