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
using System.Collections;

namespace AppSalaMaya.Scripts
{
    public partial class TimeLine : Form
    {
        public int imgNum = 0, score = 0 ,numcont = 0 ;
        public int[] Fecha = { 0, 0, 0, 0, 0 };
        private Bitmap aux;
        private Pieza[] pie = new Pieza[5];
        public TimeLine()
        {
            InitializeComponent();
        }
        public Form menu;
        static PictureBox[] pictureBoxes; //Arreglo de picturebox
        static Label[] labels;//Arreglo de label
        
        private void TimeLine_Load(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;
            //Se definen los pictureBoxes
            pictureBoxes = new PictureBox[5];

            pictureBoxes[0] = pictureBox1;
            pictureBoxes[1] = pictureBox2;
            pictureBoxes[2] = pictureBox3;
            pictureBoxes[3] = pictureBox4;
            pictureBoxes[4] = pictureBox5;

            //Se definen los labels
            labels = new Label[5];
            labels[0] = lbl1;
            labels[1] = lbl2;
            labels[2] = lbl3;
            labels[3] = lbl4;
            labels[4] = lbl5;

            Random aleat = new Random();
            int[] Position = { 0, 0, 0, 0, 0 };
            int num = 0, cont = 0;
            //Se crean las posiciones random
            for (int i = 0; i < 5; i++)
            {
                if (cont > 0)
                {
                    do
                    {
                        Position[i] = aleat.Next(0, 8);
                        for (int j = 0; j < cont; j++)
                        {
                            if (Position[i] == Position[j]) //Se valida la posición
                            {
                                num = 0;
                            }
                            else
                            {
                                num += 1;
                            }
                        }
                    } while (num < cont);
                }
                if (cont == 0)
                {
                    Position[i] = aleat.Next(0, 8);//Se toma la primera posición random
                }
                num = 0;
                cont++;
            }
            
            int[] AllFechas = { 250, 550, 591, 600, 683, 900, 1000, 1250 };//Arreglo con todas las fechas
            for (int i = 0; i < 5; i++)
            {
                Fecha[i] = AllFechas[Position[i]]; //Fechas random

            }
            Pieza xpi = new Pieza();
            for (int i = 0; i < 5; i++)
            {
                //imagen random
                pictureBoxes[i].Image = (Image)(Properties.Resources.ResourceManager.GetObject(string.Format("image{0}", Position[i] + 1)));
                //Se inicializa el constructor
                pie[i] = new Pieza(AllFechas[Position[i]], (Bitmap)pictureBoxes[i].Image);
                
            }

            Array a = Fecha.ToArray();
            Array.Sort(a);
            for (int i = 0; i < Fecha.Length; i++)
            {
                Fecha[i] = (int)a.GetValue(i); //Fechas ordenadas
                labels[i].Text = (Fecha[i]).ToString(); 
            }

            pictBox1.Tag = (Fecha[0]).ToString();
            pictBox2.Tag = (Fecha[1]).ToString();
            pictBox3.Tag = (Fecha[2]).ToString();
            pictBox4.Tag = (Fecha[3]).ToString();
            pictBox5.Tag = (Fecha[4]).ToString();

            //Se habilita la propiedad AllowDrop para todos los pictureBox

            pictBox1.AllowDrop = true;
            pictBox2.AllowDrop = true;
            pictBox3.AllowDrop = true;
            pictBox4.AllowDrop = true;
            pictBox5.AllowDrop = true;

            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            pictureBox5.AllowDrop = true;

        }

        bool estaEnArea;
        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            TimerDialog.segundos = 0;
            estaEnArea = false;
            PictureBox pb = (PictureBox)sender; //Se crea objeto tipo picturebox
            pb.Select();
            if(pb.Image != null)
            { 
            pb.DoDragDrop(pb.Image, DragDropEffects.Move);
            int Num = int.Parse(pb.TabIndex.ToString());
            if (estaEnArea)
                pb.Image = aux;
            for (int i = 0; i < 5; i++)
            {
                if (((PictureBox)sender).Image == pie[i].Pict)
                {
                    if (((PictureBox)sender).Tag != null)
                    {


                        if ((string)((PictureBox)sender).Tag == pie[i].Tiempo.ToString())
                        {
                            pie[i].Correct = true;
                        }
                        else
                        {
                            pie[i].Correct = false;
                        }
                        break;
                    }
                    else
                    {
                        pie[i].Correct = false;
                    }
                }
            }
            }
        }
        private void PictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

    

        private void PictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            estaEnArea = true;
            PictureBox pb = (PictureBox)sender;
            aux = (Bitmap)pb.Image;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

            for (int i = 0; i < 5; i++)
            {
                if (((PictureBox)sender).Image == pie[i].Pict)
                {
                    if (((PictureBox)sender).Tag != null)
                    {


                        if ((string)((PictureBox)sender).Tag == pie[i].Tiempo.ToString())
                        {
                            pie[i].Correct = true;
                        }
                        else
                        {
                            pie[i].Correct = false;
                        }
                        break;
                    }
                    else
                    {
                        pie[i].Correct = false;
                    }
                }
            }
         
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;
            
            
            Scripts.Menu.menu.Show();
            this.Close();

        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;

            Resultados res = new Resultados();
            for (int i = 0; i < 5; i++)
            {
                if (pie[i].Correct)
                { 
                    score++;
                }
            }
            Usuario.usuario.ResultadoLinea = score * 2;
            res.lblScore.Text = "Tuviste "+score+" aciertos de 5";
            res.boolaneos = new bool[5];
            for(uint i = 0; i < 5; i++)
            {
                for (uint j = 0; j < 5; j++)
                {
                    if (pie[i].Tiempo == Fecha[j])
                    {
                        pie[i].Orden = j;
                    }
                }
            }

            for(int i = 0; i < 5; i++)
            {
                res.boolaneos[pie[i].Orden] = pie[i].Correct;
            }
            this.Hide();
            res.ShowDialog();
            Scripts.Menu.menu.Show();
            this.Dispose();

        }
    }
    public class Pieza 
    {
        //Atributos
        private int tiempo;
        private Bitmap pict;
        private bool correct;
        private uint orden;

        //Propiedades
        public uint Orden
        {
            get { return orden; }
            set { orden = value; }
        }
        public int Tiempo
        {
            get { return tiempo; }
            set { tiempo = value; }
        }
        public Bitmap Pict
        {
            get { return pict; }
            set { pict = value; }
        }
        public bool Correct
        {
            get { return correct; }
            set { correct = value; }
        }
        public Pieza()//Constructor vacio
        {
            this.Tiempo = 0;
            this.Pict = null;
            this.Correct = false;
            this.Orden = 0;
        }
        public Pieza(int tiempx, Bitmap pictx)//Constructor usado para instanciar los objetos
        {
            
            this.Tiempo = tiempx;
            this.Pict = pictx;
            this.Correct = false;
            this.Orden = 0;
        }

        
    }

}
