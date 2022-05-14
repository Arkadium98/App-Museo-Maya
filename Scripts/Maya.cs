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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSalaMaya
{
    class Maya
    {
        //Random
        int Img;
        Random random = new Random();

        //ArrayList
        ArrayList arraylist = new ArrayList{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30};

        //Atributos
        private int score;
        private bool bip;
        private int contador;

        //Propiedades
        public int Score
        { get { return score; } set { score = value; } }
        public bool Bip
        { get { return bip; } set { bip = value; } }
        public int Contador
        { get { return contador; } set { contador = value; } }

        //Constructor vacío
        public Maya()
        {
            Score = 0;
            Bip = false;
            Contador = 5;
        }

        //Constructor
        public Maya(int Score, bool Bip)
        {
            this.Score = Score;
            this.Bip = Bip;
        }

        //Función que delimitea la imagen que aparecerá sin repetir otras 
        public int Picture()
        {
            bool brk = true;
            do
            {
                Img = random.Next(1, 31);
                for (int i = 0; i < arraylist.Count; i++)
                {
                    if (int.Parse(arraylist[i].ToString()) == Img)
                    {
                        arraylist.Remove(Img);
                        brk = false;
                        break;
                    }
                }
            } while (brk == true);

            return Img;
        }

    }
}
