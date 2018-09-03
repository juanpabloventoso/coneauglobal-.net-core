using System;

namespace Nucleo
{

    // 
    // Funciones del núcleo de CONEAU Global Core
    //
    public static class Funciones
    {

        //
        // Validar un timestamp enviado por parámetro (timeout de 120 segundos aproximadamente)
        //
        public static bool ValidarTimestamp(string ts)
        {
            // REMOVED FOR SECURITY PURPOSES
            return true;
        }

        //
        // Validar un token a partir de una cadena
        //
        public static bool ValidarToken(string token, string cadena)
        {
            // REMOVED FOR SECURITY PURPOSES
            return true;
        }

        //
        // Devolver el hash MD5 de una cadena
        //
        public static string MD5Hash(string cadena)
        {
            byte[] FHash = System.Security.Cryptography.MD5.Create().ComputeHash(System.Text.Encoding.ASCII.GetBytes(cadena));
            System.Text.StringBuilder FSB = new System.Text.StringBuilder();
            for (int I = 0; I < FHash.Length; I++)
                FSB.Append(FHash[I].ToString("X2"));
            return FSB.ToString().ToLower();
        }

    }

}
