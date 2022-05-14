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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            string fecha = "";
            TimerDialog.segundos = -1;
            dataGridView1.Rows.Clear();
            Conexion.callReader(Querries.SELECT("TRegistro", "*"));
            while (Conexion.reader.Read())
            {
                fecha = "";
                if (Conexion.reader.GetDateTime(3) != new DateTime(1001, 1, 1)) fecha = Conexion.reader.GetDateTime(3).ToShortDateString();
                dataGridView1.Rows.Add(Conexion.reader.GetValue(0), Conexion.reader.GetValue(1), Conexion.reader.GetValue(2), fecha, 
                    Conexion.reader.GetValue(4), Conexion.reader.GetValue(5), Conexion.reader.GetValue(6), Conexion.reader.GetValue(7), Conexion.reader.GetValue(8), Conexion.reader.GetBoolean(9));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null) continue;
                Conexion.Ejecutar(Querries.UPDATE("TRegistro",  "CorreoEnviado", row.Cells[9].Value, "ID = " + row.Cells[0].Value));
            }
            MessageBox.Show("Base de datos actualizada correctamente");
        }
    }
}
