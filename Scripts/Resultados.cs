/* Arias Cortina Carlos     0217787
 * Cabrera Ábrego Raúl Andres   0213359
 * González Juárez Javier 0215241
 * Guerrero Valadez Juan Manuel 0211637
 * nombre id materia equipo
 * Programación Orientada a Objetos
 * Sala Maya
 */
 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSalaMaya.Scripts
{
    public partial class Resultados : Form
    {
        public Resultados()
        {
            InitializeComponent();
        }
        public bool[] boolaneos;
        private void Resultados_Load(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;
            int i = 0;
            foreach (Label lb in flowLayoutPanel1.Controls)
            {
                if (boolaneos[i])
                    lb.Text += " ✔";
                else
                    lb.Text += " ✘";
                i++;
            }
        }

        private void BtnRegre_Click(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;
            this.Dispose();
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;

        }

        private void Label5_Click(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;

        }

        private void Label4_Click(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;

        }
    }
}
