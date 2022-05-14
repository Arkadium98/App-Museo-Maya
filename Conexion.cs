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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AppSalaMaya
{
    class Conexion
    {

        public static OleDbConnection conexion = null;

        public static OleDbConnection getCon()
        {
            if (conexion == null)
            {
                try
                {
                    OleDbConnectionStringBuilder csb = new OleDbConnectionStringBuilder(); 
                    csb.Provider = "Microsoft.ACE.OLEDB.12.0";//Microsoft Provider
                    csb.DataSource = "Registro.accdb"; //nombre de nuestra base de datos
                    conexion = new OleDbConnection(csb.ToString());
                    conexion.Open();
                    ;
                }
                catch (OleDbException e)
                {
                    MessageBox.Show("Error de la base de datos: " + e.Message);
                    if (System.Windows.Forms.Application.MessageLoop)
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                    else
                    {
                        System.Environment.Exit(1);
                    }

                }
            }
            return conexion;
        }
        public static void Ejecutar(String sql)//Acción
        {
            OleDbCommand cmd = new OleDbCommand(sql, getCon());
            cmd.ExecuteReader();
        }
        public static OleDbDataReader Leer(String sql)  //Lectura
        {

            OleDbCommand cmd = new OleDbCommand(sql, getCon());
            return cmd.ExecuteReader();
        }
        public static OleDbDataReader reader;
        public static void callReader(String sql)
        {
            reader = Leer(sql);
        }
    }
    class Querries
    {
        public static string INSERT(string tabla, string campos, dynamic[] valores)
        {
            string salida = String.Format("INSERT INTO {0} {1} VALUES (", tabla, campos);
            for(int i = 0; i < valores.Length; i++)
            {
                if (valores[i] is string s) salida += String.Format(@"""{0}""", valores[i]);
                else salida += valores[i];
                if (i == valores.Length -1)  salida += ");";
                else salida += ", ";
            }
            return salida;
        }
        public static string UPDATE(string tabla, string campo, dynamic valor, string condicion)
        {
            string salida = String.Format("UPDATE {0} SET ", tabla);
            if (valor is string s) valor = String.Format(@"""{0}""", valor);
            salida += String.Format("{0} = {1} WHERE {2}", campo, valor, condicion);
            return salida + ";";
        }
        public static string UPDATE(string tabla, string[] campos, dynamic[] valores, string condicion)
        {
            string salida = String.Format("UPDATE {0} SET ", tabla);
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] is string s) valores[i] = String.Format(@"""{0}""", valores[i]);
                salida += String.Format("{0} = {1}", campos[i], valores[i]);
                if (i != valores.Length - 1) salida += ", ";
            }
            salida += String.Format(" WHERE {0};", condicion);
            return salida;
        }
        public static string SELECT(string tabla, string campos, string condicion)
        {
            return String.Format("SELECT {0} FROM {1} WHERE {2};", campos, tabla, condicion);
        }
        public static string SELECT(string tabla, string campos)
        {
            return String.Format("SELECT {0} FROM {1};", campos, tabla);
        }
    }
}
