/* Arias Cortina Carlos     0217787
 * Cabrera Ábrego Raúl Andres   0213359
 * González Juárez Javier 0215241
 * Guerrero Valadez Juan Manuel 0211637
 * nombre id materia equipo
 * Programación Orientada a Objetos
 * Sala Maya
 */
using AppSalaMaya.Properties;
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
    public partial class QuizDios : Form
    {
        public QuizDios()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;
            //Crear arreglo de dioses con valores predefinidos.
            Dios[] dioses = new Dios[5];
            dioses[0] = new Dios("Kauil", "Es el dios del fuego. Se relaciona con los gobernadores ya que su sinónimo es de poder.", new Bitmap(Resources.kauil));
            dioses[1] = new Dios("Itzamná", "Dios del sol y la sabiduría. También señor del cielo, el día y la noche.", new Bitmap(Resources.itzamna));
            dioses[2] = new Dios("Chaac", "Es el dios de la lluvia, el relámpago y el agua. ", new Bitmap(Resources.chaac));
            dioses[3] = new Dios("Ixchel", "Diosa de la fertilidad y de la Luna. Muy relacionada con el género femenino y la maternidad. ", new Bitmap(Resources.ixchel));
            dioses[4] = new Dios("Kukulcán", "En la cultura maya, es el creador del universo. Es el dios del viento y su nombre se traduce como “serpiente emplumada”.", new Bitmap(Resources.Kukulcan));
            bool validar;
            foreach (GroupBox group in mainLayout.Controls) //leer todos los groupbox dentro del mainLayout
            {
                validar = false; //reiniciar bandera
                foreach (RadioButton rb in group.Controls[0].Controls) //Para acceder a todos los radiobuttons dentro del flowlayoutpanel del groupbox actual
                {
                    if (rb.Checked) //En caso de que el usuario haya seleccionado el RadioButton rb
                    {
                        validar = true; //al encontrar un radiobutton que este seleccionado, se sabrá que si se lleno el groupbox actual
                        for (int i = 0; i < 5; i++)
                        {
                            dioses[i].Puntos += ((string)rb.Tag)[i]; //Se le suma el valor que tiene rb en su propiedad tag en el caracter i al dios i
                        }
                    }
                }
                if(validar == false)//en caso de que halla dejado una respuesta sin contestar
                {
                    MessageBox.Show("No puedes dejar respuestas sin responder", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    return;
                }
            }
            int MaxPuntos = 0;
            for(int i = 1; i < 5; i++)
            {
                if(dioses[i].Puntos > dioses[MaxPuntos].Puntos)
                {
                    MaxPuntos = i;
                }
            }//Para obtener el indice del dios mas cercano a las respuestas del usuario
            Usuario.usuario.Dios = dioses[MaxPuntos].Nombre;//mandaremos la información al objeto Usuario según el Dios que le haya tocado al usuario
            MessageBoxDios boxDios = new MessageBoxDios();
            //Pasar resultados al MessageBoxDios
            boxDios.lbName.Text = dioses[MaxPuntos].Nombre;
            boxDios.lbDesc.Text = dioses[MaxPuntos].Descripcion;
            boxDios.pbDios.Image = dioses[MaxPuntos].Imagen;
            this.Hide();
            boxDios.ShowDialog();//Mostrar resultado
            Scripts.Menu.menu.Show();//volver al menu
            this.Dispose();     
        }

        private void btnRegresar_Click(object sender, EventArgs e)//en caso de que no quiera llenar el formulario
        {
            TimerDialog.segundos = 0;
            Scripts.Menu.menu.Show();//volver al menu
            this.Dispose();
        }

        private void rbPink_Click(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;
        }

        private void QuizDios_Load(object sender, EventArgs e)
        {

        }

        private void rbPink_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked) radio.BackColor = Color.FromArgb(100, radio.BackColor.R, radio.BackColor.G, radio.BackColor.B);
           else radio.BackColor = Color.FromArgb(255, radio.BackColor.R, radio.BackColor.G, radio.BackColor.B);
        }
    }
    public class Dios
    {
        //atributos
        private string nombre;
        private string descripción;
        private Bitmap imagen;
        private uint puntos;
        //propiedades
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Descripcion { get { return descripción; } set { descripción = value; } }
        public Bitmap Imagen { get { return imagen; } set { imagen = value; } }
        public uint Puntos { get { return puntos; } set { puntos = value; } }

        public Dios()//constructor vacio
        {
            this.Nombre = "";
            this.Descripcion = "";
            this.Imagen = null;
            this.Puntos = 0;
        }
        public Dios(string nom, string desc, Bitmap imag)//constructor usado para la inicialización 
        {
            this.Nombre = nom;
            this.Descripcion = desc;
            this.Imagen = imag;
            this.Puntos = 0;
        }

    }
}
