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
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;

namespace AppSalaMaya.Scripts
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }


        bool validar = false;
        private void RadioButtonCheckedChanged(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;
            validar = true;
            Usuario.usuario.Satisfaccion = int.Parse((string)((RadioButton)sender).Tag);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;
            //Presion hidrostatica, centros de masa
            Usuario.usuario.Nombre = tbNombre.Text;
            if (validar == true)
            {
                
                if (SendMessage(tbNombre.Text, tbCorreo.Text))
                {
                    /*Correo enviado --> Usuario.usuario.archivoEnviado*/
                    Conexion.Ejecutar(Querries.INSERT("TRegistro", "(Nombre, Correo, Nacimiento, ResultadoLineaTiempo, NawalString, PuntajeEsMaya, Dios, Satisfaccion, CorreoEnviado)", new dynamic[9]
                { tbNombre.Text, tbCorreo.Text , Usuario.usuario.Nacimiento.ToShortDateString(), Usuario.usuario.ResultadoLinea, Usuario.usuario.NawualString, Usuario.usuario.PuntajeMaya, Usuario.usuario.Dios, Usuario.usuario.Satisfaccion, Usuario.usuario.ArchivoEnviado }));

                    if (Usuario.usuario.ArchivoEnviado)
                    {
                        MessageBox.Show("Archivo enviado. Gracias.", "e-mail", MessageBoxButtons.OK);
                    }
                    Scripts.Menu.menu.Show();
                    Usuario.GenerarUsuario();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Antes de enviar tu archivo, tómate \nla molestia de calificar nuestra app.\n¡Muchas gracias!");
                groupBox1.ForeColor = Color.Salmon;
            }
        }
        public bool SendMessage(string nombre, string correo)
        {
            if (nombre == "")
                nombre = GetID();
            MailMessage message = new MailMessage();
            message.Subject = "Resultados de la Sala Maya - " + nombre;
            message.Body = "";

            message.From = new MailAddress("salamaya.upSolutions@gmail.com");
            try
            {
                message.To.Add(tbCorreo.Text);
                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential("salamaya.upSolutions@gmail.com", "salamaya1234");
                client.Port = 587;
                client.EnableSsl = true;
                client.Host = "smtp.gmail.com";
                GeneradorDeArchivos.GenerarArchivo();
                Attachment attachment = new Attachment(nombre + "_Resultados.rtf");
                message.Attachments.Add(attachment);
                client.Send(message);
                attachment.Dispose();
                Usuario.usuario.ArchivoEnviado = true; //Para guardar en la base de datos que si se envió el correo.
            }
            
            catch (FormatException)
            {
                CorreoIncorrecto();
                return false; //Para que no se guarde nada en la base de datos por error de usuario.
            }
            catch (ArgumentException)
            {
                CorreoIncorrecto();
                return false; //Para que no se guarde nada en la base de datos por error de usuario.
            }
            catch (System.Net.Mail.SmtpException)
            {
                MessageBox.Show("Nuestro servidor no responde. \n Te enviaremos tus resultados lo antes posible.\n Lamentamos los inconvenientes.", "Server not responding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Usuario.usuario.ArchivoEnviado = false; //Para guardar en la base de datos que no se envió el correo por error de sistema.
            }
            catch (AggregateException)
            {
                MessageBox.Show("Nuestro servidor no responde. \n Te enviaremos tus resultados lo antes posible.\n Lamentamos los inconvenientes.", "Server not responding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Usuario.usuario.ArchivoEnviado = false; //Para guardar en la base de datos que no se envió el correo por error de sistema.
            }
            catch (Exception)
            {
                MessageBox.Show("¡Ups! Esto no debió haber pasado", "Error desconocido",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                Usuario.usuario.ArchivoEnviado = false; //Para guardar en la base de datos que no se envió el correo por error de sistema.

            }
            if (File.Exists(nombre + "_Resultados.rtf") && Usuario.usuario.ArchivoEnviado) File.Delete(nombre + "_Resultados.rtf");
            return true;
        }
        public string GetID()
        {
            return "";
        }
        public async void CorreoIncorrecto()
        {
            Color aux = tbCorreo.BackColor;
            for(int i = 0; i < 3; i++)
            {
                tbCorreo.BackColor = Color.LightPink;
                await Task.Delay(300);
                tbCorreo.BackColor = aux;
                await Task.Delay(300);
            }
            tbCorreo.BackColor = Color.LightPink;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;
            this.Hide();
            Scripts.Menu.menu.Show();
        }
        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            TimerDialog.segundos = 0;
        }
    }
}
