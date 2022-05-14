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

namespace AppSalaMaya
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private Scripts.Menu menu;
        private int nErrores = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            if (VaidarUsuario(textBox1.Text, textBox2.Text))
            {
                menu = new Scripts.Menu();
                menu.currentPassword = textBox2.Text;
                menu.Show();
                textBox1.Text = "";
                textBox2.Text = "";
                this.Close();
                return;
            }
            nErrores++;
            if (nErrores < 3) MessageBox.Show("Nombre de usuario o contraseña incorrecta", "Error de credenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            { 
                MessageBox.Show("Demasiados intentos fallidos. \n¡El programa se cerrará!", "Error de credenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private static string[] usuarios = { "lcoronel", "0211637", "0215241", "0217787", "0213359" };
        private static string[] passwords = { "admin", "pokemon", "0215241", "arkadium", "deus" };
        public static bool VaidarUsuario(string usuarioEntrada, string contrasenaEntrada)
        {
            for (int i = 0; i < 5; i++)
            {
                if (usuarios[i] == usuarioEntrada && passwords[i] == contrasenaEntrada)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
