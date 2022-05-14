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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSalaMaya
{
    public partial class MAYA_O_NO : Form
    {
        Maya maya = new Maya();

        public MAYA_O_NO()
        {
            InitializeComponent();
            dador = maya.Picture();
            PB01.Image = (Image)(Properties.Resources.ResourceManager.GetObject(string.Format("_" + dador.ToString())));

        }

        private void BipC(object sender, EventArgs e)
        {
            Scripts.TimerDialog.segundos = 0;
            if (maya.Contador == 0)
            {
                maya = new Maya();
                label1.Text = "Puntaje: " + maya.Score;
            }

            //Suma 2 puntos al score cada vez que hay un acierto
            #region Puntaje

            if (((Button)sender).Text == "Si")
            {
                if (dador <= 15)
                {
                    maya.Score += 2;
                    label1.Text = "Puntaje: " + maya.Score;
                    maya.Bip = true;
                }
                else { maya.Bip = false; }
            }
            else
            {
                if (dador > 15)
                {
                    maya.Score += 2;
                    label1.Text = "Puntaje: " + maya.Score;
                    maya.Bip = true;
                }
                else { maya.Bip = false; }
            }

            #endregion

            //Cambia la imagen depues de contestar
            dador = maya.Picture();
            PB01.Image = (Image)(Properties.Resources.ResourceManager.GetObject(string.Format("_" + dador.ToString())));

            //Permite que los botones Cambien de color al momento de dar una respuesta
            #region BIP

            if (maya.Bip == true)
            {
                ((Button)sender).BackColor = Color.LightGreen; ((Button)sender).Update(); Thread.Sleep(200);
                ((Button)sender).BackColor = Color.Transparent; ((Button)sender).Update(); Thread.Sleep(200);
                ((Button)sender).BackColor = Color.LightGreen; ((Button)sender).Update(); Thread.Sleep(200);
                ((Button)sender).BackColor = Color.Transparent; ((Button)sender).Update();
            }
            else
            {
                ((Button)sender).BackColor = Color.LightPink; ((Button)sender).Update(); Thread.Sleep(200);
                ((Button)sender).BackColor = Color.Transparent; ((Button)sender).Update(); Thread.Sleep(200);
                ((Button)sender).BackColor = Color.LightPink; ((Button)sender).Update(); Thread.Sleep(200);
                ((Button)sender).BackColor = Color.Transparent; ((Button)sender).Update();
            }

            #endregion

            maya.Contador -= 1;

            //Reinica el contador y el score una vez que se llega al máximo de preguntas
            if (maya.Contador == 0)
            {
                Score score = new Score();
                this.Hide();
                score.FinalS.Text = "Garcias por paticipar \r\n" +
                    "su puntaje final es: \r\n" +
                    maya.Score.ToString() + " puntos";
                score.ShowDialog();
                Scripts.Menu.menu.Show();
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Scripts.TimerDialog.segundos = 0;
            Scripts.Menu.menu.Show();
            Usuario.usuario.PuntajeMaya = maya.Score;
            this.Dispose();
        }

        private void MAYA_O_NO_Load(object sender, EventArgs e)
        {

        }
    }
}
