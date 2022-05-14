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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            TimerDialog elTimer = new TimerDialog();
        }
        private Form[] subForms;
        public string currentPassword;
        public static Scripts.Menu menu;
        private void btnAbrirForm(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;
            for (int i = 0; i < 6; i++)
            {
                if (int.Parse((string)((Button)sender).Tag) == i)
                {
                    defineForms(i);
                    subForms[i].Show();
                    this.Hide();
                    break;
                }
            }
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            TimerDialog.segundos = -1;
            Conexion.getCon();
            menu = this;
            subForms = new Form[5];
        }
        private void defineForms(int f)
        {
            switch (f)
            {
                case 0:
                    subForms[0] = new Codices();
                    break;
                case 1:
                    subForms[1] = new TimeLine();
                    break;
                case 2:
                    subForms[2] = new QuizDios();
                    break;
                case 3:
                    subForms[3] = new MAYA_O_NO();
                    break;
                case 4:
                    subForms[4] = new Registrar();
                    break;
            }
        }

        private void AccionAdministrador(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;
            IngresarCredenciales dialog = new IngresarCredenciales();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                switch (int.Parse((string)((ToolStripMenuItem)sender).Tag))
                {
                    case 0:
                        Registro registro = new Registro();
                        registro.ShowDialog();
                        break;
                    case 1:
                        LogIn logIn = new LogIn();
                        logIn.Show();
                        TimerDialog.segundos = -1;
                        this.Dispose();
                        break;
                    case 2:
                        Application.Exit();
                        break;
                }
            }
        }

    }
}
