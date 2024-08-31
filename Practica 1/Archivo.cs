using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1;

public class Archivo
{
    //Guardamos la ruta del archivo
    private string rutaArchivoLectura;
    private string rutaArchivoEscritura;
    //Iniciamos el objeto con la ruta del archivo
    public Archivo(string rutaLectura, string rutaEscritura) {
        rutaArchivoLectura = rutaLectura;
        rutaArchivoEscritura = rutaEscritura;
        if (File.Exists(rutaEscritura))
        {
            File.Delete(rutaEscritura);
        }
    }
    //Leemos el archivo
    public string leerArchivo()
    {
        try
        {
            if (File.Exists(rutaArchivoLectura))
            {
                return File.ReadAllText(rutaArchivoLectura);
            }
            else
            {
                throw new FileNotFoundException("Archivo no encontrado");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return string.Empty;
        }
    }

    public void escribirArchivo(string linea)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(rutaArchivoEscritura, append: true))
            {
                sw.WriteLine(linea);
            }
        }
        catch (Exception ex) { 
            Console.WriteLine (ex.ToString());
        }
    }
}
