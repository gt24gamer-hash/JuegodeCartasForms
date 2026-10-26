using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace JuegodeCartasForms
{
    internal class RegistrodeBatalla
    {

        public void RegistrarTurno(string accion)
        {

            string rutaArchivo = "RegistrodeBatalla.txt";
            string rutaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string rutaCarpeta = Path.Combine(rutaDocumentos, "registrosArena");

            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }

            string rutaCompleta= Path.Combine(rutaCarpeta, rutaArchivo);

            using (StreamWriter e = new StreamWriter(rutaCompleta, true))
            {
                e.WriteLine(accion);
                e.WriteLine("////////////////////////////////////////////");
            }
        }
    }
} 