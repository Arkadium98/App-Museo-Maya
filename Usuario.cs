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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSalaMaya
{
    class Usuario
    {

        //Atributos
        private string nombre; 
        private string correo; //QUITAR
        private DateTime nacimiento;
        private int resultadoLinea;
        private string nawualString;
        private Bitmap nawal;
        private int puntajeMaya;
        private string dios;
        private int satisfaccion;
        private string descripcion; //Solo para el archivo para el usuario. No agregar a base de datos
        private bool archivoEnviado; //en caso de que no se pueda enviar el correo automaticamente
        //Propiedades
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Correo { get { return correo; } set { correo = value; } }
        public DateTime Nacimiento { get { return nacimiento; } set { nacimiento = value; } }
        public int ResultadoLinea { get { return resultadoLinea; } set { resultadoLinea = value; } }
        public string NawualString { get { return nawualString; } set { nawualString = value; } }
        public Bitmap Nawal { get { return nawal; } set { nawal = value; } }
        public int PuntajeMaya { get { return puntajeMaya; } set { puntajeMaya = value; } }
        public string Dios { get { return dios; } set { dios = value; } }
        public int Satisfaccion { get { return satisfaccion; } set { satisfaccion = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public bool ArchivoEnviado { get { return archivoEnviado; } set { archivoEnviado = value; } }
        public Usuario() //constructor para instanciar un nuevo usuario
        {
            Nombre = "";
            Correo = "";
            Nacimiento = new DateTime(1001, 1, 1); //para validar en caso de que no haya ingresado una fecha de nacimiento;
            ResultadoLinea = -1;
            NawualString = "";
            Nawal = null;
            PuntajeMaya = -1;
            Dios = "";
            Satisfaccion = -1;
        }

        //Generar un nuevo usuario
        public static Usuario usuario; //variable usuario accesible para todo el ensamblado
        public static void GenerarUsuario()
        {
            usuario = new Usuario();
        } //Metodo para inicializar la varible
    }
}
