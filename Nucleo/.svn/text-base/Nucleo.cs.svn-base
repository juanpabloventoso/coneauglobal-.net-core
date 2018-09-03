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
            return Math.Abs(DateTime.Now.Ticks - Convert.ToInt64(ts)) <= 2000000000;
        }

        //
        // Validar un token a partir de una cadena
        //
        public static bool ValidarToken(string token, string cadena)
        {
            return MD5Hash(cadena) == token.ToLower();
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