/* Arias Cortina Carlos     0217787
 * Cabrera Ábrego Raúl Andres   0213359
 * González Juárez Javier 0215241
 * Guerrero Valadez Juan Manuel 0211637
 * nombre id materia equipo
 * Programación Orientada a Objetos
 * Sala Maya
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace AppSalaMaya.Scripts
{
    public partial class Codices : Form
    {
        public static Codices thisForm;
        public Codices()
        {
            InitializeComponent();
            thisForm = this;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;
            
            try
            {
                Usuario.usuario.Nacimiento = new DateTime(int.Parse(tbAno.Text), int.Parse(tbMes.Text), int.Parse(tbDia.Text));
                Nawal nawal = new Nawal();
                Usuario.usuario.NawualString = nawal.Calcular(Usuario.usuario.Nacimiento);
                Usuario.usuario.Nawal = nawal.GenerateBitmap();

                Glifo glifo = new Glifo(nawal.RefImage, nawal.Numero);
                nawal.GenerarDetalles(ref glifo);
                flowLayoutPanel1.Controls.Clear();
                foreach (Button btn in glifo.Buttons)
                {
                    flowLayoutPanel1.Controls.Add(btn);
                }
                pbFondo.BackgroundImage = Usuario.usuario.Nawal;
                lbNahual.Text = Usuario.usuario.NawualString;
                Usuario.usuario.Descripcion = glifo.GetDescripcion();
                tbExplicacion.Text = Usuario.usuario.Descripcion;

            }
            catch(FormatException)
            {
                MessageBox.Show("Formato incorrecto. Únicamente use números");
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("No se reconoció la fecha. Revise los datos.");
            }
            catch(FueraDeRango ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            catch(Exception)
            {
                MessageBox.Show("Lo sentimos, esto no debió de haber ocurrido.", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public async void ResaltarGlifo(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;
            Color aux = ((Button)sender).BackColor;
            System.Threading.Thread.Sleep(50);//Para evitar que se ejecute 2 veces la misma tarea;
            ((Button)sender).BackColor = Color.FromArgb(50, aux.R, aux.G, aux.B);
            pbGlifo.Image = (Image)AppSalaMaya.Properties.Resources.ResourceManager.GetObject((string)((Button)sender).Tag);
            await Task.Delay(1000);
            pbGlifo.Image = null;
            ((Button)sender).BackColor = aux;
        }

        private void tbDia_Enter(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;
            if (((TextBox)sender).Text == (string)((TextBox)sender).Tag)
                ((TextBox)sender).Text = "";
            ((TextBox)sender).ForeColor = Color.Black;
        }

        private void tbDia_Leave(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = (string)((TextBox)sender).Tag;
                ((TextBox)sender).ForeColor = System.Drawing.SystemColors.ControlDark;
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;
            this.Dispose();
            Scripts.Menu.menu.Show();
        }


        private void tbDia_TextChanged(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;
        }
    }

    class Nawal
    {
        public static DateTime refDate = new DateTime(1910, 1, 2); //Fecha de referencia. http://mcd.gob.gt/calcular-nawal/      
        //Atributos
        private uint glifo;
        private uint numero;
        private string refImage;

        public uint Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public uint Glifo
        {
            get { return glifo; }
            set { glifo = value; }
        }
        public string RefImage
        {
            get { return refImage; }
            set { refImage = value; }
        }
        public Nawal() //Constructor vació
        {
            Numero = 0;
            Glifo = 0;
            RefImage = "";
        }
        
        //Metodos
        public string Calcular(DateTime nacimiento) //Obtiene el nawal de acuerdo a la fecha de entrada y devuelve el nombre del nawual
        {
            int diference;
            string nombre = "";
            diference = (int)nacimiento.Subtract(refDate).TotalDays;
            if (nacimiento.CompareTo(refDate) < 0) throw new FueraDeRango();
            Numero = (uint)(((diference % 13) + 4) % 13); //Calcular numero
            if (Numero == 0) Numero = 13; //En caso de que MOD sea 0, pasar a 13
            Glifo = (uint)(diference % 20); //Obtener glifo
            Conexion.callReader(Querries.SELECT("TNawales", "Nombre", "ID = " + (Glifo + 1)));
            while (Conexion.reader.Read())
            {
                nombre = Numero + " " + Conexion.reader.GetString(0);
            }
            return nombre;
        }
        public Bitmap GenerateBitmap() //Devuelve un nuevo bitmap que junta el número maya con el glifo
        {

            Bitmap dia;
            Conexion.callReader(Querries.SELECT("TNawales", "refImage", "ID = " + (Glifo + 1)));
            while (Conexion.reader.Read())
            {
                refImage = Conexion.reader.GetString(0);
            }
            dia = new Bitmap((Image)AppSalaMaya.Properties.Resources.ResourceManager.GetObject(refImage));
            Bitmap mes = new Bitmap((Image)AppSalaMaya.Properties.Resources.ResourceManager.GetObject("num" + Numero));
            Graphics imagen = Graphics.FromImage(dia);
            imagen.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            imagen.DrawImage(mes, new Point(0, 4));
            imagen.Save();
            return dia;
        }

        public void GenerarDetalles(ref Glifo glifo)
        {
            glifo = new GlifoEspecifico(refImage, Numero);
            glifo.SetButtons();
            //descripcion = glifo.Descripcion;
        }
    }
    class Glifo : Nawal
    {
        //Atributos
        private Button[] buttons;
        //Propiedades
        public Button[] Buttons { get { return buttons; } set { buttons = value; } } 
        //Constructores
        public Glifo() //Vacío
        {
            Numero = 0;
            RefImage = "";
            Buttons = null;
        }
        public Glifo(string theID, uint num)//Sobrecarga del constructor
        {
            RefImage = theID;
            Numero = num;

        }
        public string GetDescripcion()
        {
            string descripcion = "";
            Conexion.callReader((Querries.SELECT("TNawales", "Descripcion", "refImage = \"" + RefImage + "\"")));
            while (Conexion.reader.Read())
            {
                descripcion = Conexion.reader.GetString(0);
            }
            return descripcion;
        }
        public virtual void SetButtons() //Generar un único botón unicamente para identificar números mayas
        {
            if (Buttons == null) Buttons = new Button[1];
            Buttons[0] = new Button
            {
                Text = "Número " + Numero,
                Tag = "resaltar", //Para identificar al boton
                BackColor = Color.Red,
                ForeColor = Color.Black,
            Font = new Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Margin = new Padding(0, 3, 0, 3),
                Size = new Size(250, 60)

            };
            Buttons[0].Click += new System.EventHandler(Codices.thisForm.ResaltarGlifo);
        }
    }
    class GlifoEspecifico : Glifo
    {
        private Array botones; //Referencia: http://www.sabiduriamaya.org
        static Color[] color = { Color.LightBlue, Color.LightGreen, Color.Pink, Color.LightCyan };
        public GlifoEspecifico(string theID, uint num) : base(theID, num)
        {
            RefImage = theID;
            Numero = num;
            Conexion.callReader((Querries.SELECT("TNawales", "Simbologia", "refImage = \"" + RefImage + "\"")));
            while (Conexion.reader.Read())
            {
                botones = Conexion.reader.GetString(0).Split(',').ToArray();
            }
        }
        public override void SetButtons() //Polimorfismo de la función para generar un arreglo de botones para identificar todos los símbolos dentro de un glifo
        {
            Buttons = new Button[botones.Length + 1];
            
            for (int i = 1; i <= botones.Length; i++)
            {
                Buttons[i] = new Button
                {
                    Text = (string)botones.GetValue(i - 1),
                    Tag = RefImage + i,
                    BackColor = color[i - 1],
                    ForeColor = Color.Black,
                    Font = new Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    Margin = new Padding(0, 3, 0, 3),
                    Size = new Size(250, 60)
            };
                Buttons[i].Click += new System.EventHandler(Codices.thisForm.ResaltarGlifo);
            }
            base.SetButtons(); 
        }

    }

    class FueraDeRango : Exception //Nueva excepción
    {
        public override string Message { get { return "La fecha especificada excede el mínimo. Favor de ingresar\n fechas de nacimiento posteriores al 2 de enero de 1910"; } }
    }
}
