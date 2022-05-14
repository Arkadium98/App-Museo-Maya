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
    public partial class TimerDialog : Form
    {
        public TimerDialog()
        {
            InitializeComponent();
            this.timer1.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            segundos = 80;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            segundos = 0;

        }

        private void Timer_Load(object sender, EventArgs e)
        {
            

        }
        public static int segundos =-1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(segundos != -1)
                segundos++;
            if(segundos== 60) this.ShowDialog();
            if (segundos > 60)
            {
                label2.Text = "Tiempo restante: " + (80 - segundos) + "s.";
            }
            if(segundos > 80)
            {
                Usuario.GenerarUsuario();
                Cerrar(this);
                this.Hide();
            }
        }
        private static void Cerrar(Form este)//Reinicia el programa al menú principal en caso de que un usuario abandone la computadora
        {
            
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Application.OpenForms[i].Hide();
            }
            Scripts.Menu.menu.Show();
            segundos = -1;
        }
    }
}
