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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSalaMaya
{
    class GeneradorDeArchivos
    {
        public const string declaracion = @"{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang2058{\fonttbl{\f0\fnil\fcharset0 Arial;}{\f1\fnil\fcharset0 Calibri;}{\f2\fswiss\fprq2\fcharset0 Calibri;}{\f3\fnil\fcharset2 Symbol;}}\viewkind4\uc1";
        public const string header = @"\pard\sa200\sl240\slmult1\qc\fs24 Sala Maya, Museo de Antropología e Historia de la Ciudad de México\par\par";
        public const string imagePrep = @"\trowd\trgaph70\trleft-108\trqc\trrh1725\trbrdrl\brdrs\brdrw10 \trbrdrt\brdrs\brdrw10 \trbrdrr\brdrs\brdrw10 \trbrdrb\brdrs\brdrw10 \trpaddl70\trpaddr70\trpaddfl3\trpaddfr3\clvertalc\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx2048\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx5976 \pard\intbl\widctlpar\qc\b0\f0\fs24{\pict{\*\picprop{\sp{\sn wzDescription}{\sv Image}}{\sp{\sn posv}{\sv 1}}}\pngblip\picw3029\pich2986\picwgoal1717\pichgoal1693 ";
        public const string resultados = @" Resultados:\par\pard{\pntext\f3\'B7\tab}{\*\pn\pnlvlblt\pnf3\pnindent0{\pntxtb\'B7}}\fi-360\li720\sa200\sl276\slmult1";
        public const string pie = @"\pard\sa200\sl276\slmult1\par\par\pard\sl240\slmult1\qr\f1\fs22 Gracias por usar nuestra app,\par Atentamente UPSolutions.\par\par salamaya.upsolutions@gmail.com\par\pard\sl240\slmult1\par}";
        public static void GenerarArchivo()
        {
            StringBuilder contenido = new StringBuilder();
            contenido.Append(declaracion);
            if (Usuario.usuario.Nombre != "")
            {
                contenido.Append(string.Format(@"\pard\sl240\slmult1\qc\b\fs40\lang10 {0}\par", Usuario.usuario.Nombre));
            }
            contenido.Append(header);
            if (Usuario.usuario.Dios != "")
            {
                contenido.Append(string.Format(@"\b0 Tú serías: \b\fs28 {0}\fs24\par\f1\fs22\par", Usuario.usuario.Dios));
            }
            if(Usuario.usuario.NawualString != "")
            {
                ImageConverter converter = new ImageConverter();
                byte[] bytes = (byte[])converter.ConvertTo(Usuario.usuario.Nawal, typeof(byte[])); //Convierte la imagen del nawal a formato Hexadecimal para adjuntarlo al .rtf
                string imagen = BitConverter.ToString(bytes).Replace("-", string.Empty);
                contenido.Append(imagePrep);
                contenido.Append(imagen);
                contenido.Append("}" + string.Format(@"\f2\fs22\par\lang2058\cell \pard\intbl\widctlpar\b\fs40 {0}\b0\fs22\par {1}\cell\row \pard\sa200\sl276\slmult1\f0\fs24\lang10\par", Usuario.usuario.NawualString, Usuario.usuario.Descripcion));
            }
            if(Usuario.usuario.ResultadoLinea != -1 || Usuario.usuario.PuntajeMaya != -1)
            {
                contenido.Append(resultados);
                if(Usuario.usuario.ResultadoLinea != -1)
                {
                    contenido.Append(@"Línea del tiempo:  \b " + Usuario.usuario.ResultadoLinea + @"\b0\par{\pntext\f3\'B7\tab}");
                }
                if(Usuario.usuario.PuntajeMaya != -1)
                {
                    contenido.Append(string.Format(@"\'bfEs maya? :\b  {0}\b0\par", Usuario.usuario.PuntajeMaya));
                }
                contenido.Append(pie);
            }

            StreamWriter writer = new StreamWriter(Usuario.usuario.Nombre + "_Resultados.rtf", false, Encoding.GetEncoding(1252));
            writer.Write(contenido);
            writer.Flush();
            writer.Close();
            writer.Dispose();
        }
    }
}
