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
    public partial class IngresarCredenciales : Form
    {
        public IngresarCredenciales()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;
            if (LogIn.VaidarUsuario(textBox1.Text, textBox2.Text))
                this.DialogResult = DialogResult.OK;
            else
            {
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Red;
                System.Threading.Thread.Sleep(200);
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                System.Threading.Thread.Sleep(200);
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Red;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;
            this.Dispose();
        }

        private void IngresarCredenciales_Load(object sender, EventArgs e)
        {

        }
    }
}
