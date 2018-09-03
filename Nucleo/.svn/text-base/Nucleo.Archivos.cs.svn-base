using System.IO;

namespace Nucleo.Archivos
{

    //
    // Funciones de manejo de archivos de CONEAU Global Core
    //
    public static class Funciones
    {
        //
        // Devuelve la ruta base de ejecución de CONEAU Global
        //
        public static string RutaBase()
        {
            return "E:\\CONEAU Global\\";
        }

        //
        // Devuelve la ruta privada base de CONEAU Global
        //
        public static string RutaPrivada()
        {
            return RutaBase() + "Privado\\";
        }

        //
        // Devuelve la ruta pública base de CONEAU Global
        //
        public static string RutaPublica()
        {
            return RutaBase() + "Público\\";
        }

        //
        // Devuelve un array de bytes con el contenido de un archivo local
        // o ubicado en la red interna del dominio
        // En caso de un archivo Word, lo convierte a PDF y devuelve la conversión
        //
        public static byte[] ObtenerContenido(string ruta)
        {
            ruta = ruta.ToLower();
            byte[] buffer;

            // Es un archivo ubicado en una ruta de red de dominio
            if (ruta.StartsWith("\\\\"))
            {
                using (Nucleo.Red.Funciones.ConectarDominioCONEAU(Path.GetDirectoryName(ruta)))
                {
                    if (ruta.EndsWith(".doc"))
                    {
                        if (!File.Exists(ruta.Replace(".doc", ".pdf")))
                            Nucleo.Archivos.PDF.Funciones.ConvertirPDF(ruta);
                        ruta = ruta.Replace(".doc", ".pdf");
                    }
                    buffer = File.ReadAllBytes(ruta);
                }
            }
            else

            // Es un archivo del equipo local
            // TODO: Refactorizar para eliminar código duplicado
            {
                if (ruta.EndsWith(".doc"))
                {
                    if (!File.Exists(ruta.Replace(".doc", ".pdf")))
                        Nucleo.Archivos.PDF.Funciones.ConvertirPDF(ruta);
                    ruta = ruta.Replace(".doc", ".pdf");
                }
                buffer = File.ReadAllBytes(ruta);
            }
            return buffer;
        }

    }

}