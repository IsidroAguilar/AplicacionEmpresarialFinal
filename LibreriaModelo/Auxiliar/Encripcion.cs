// Autor: Isidro Aguilar
// Fecha: 01/12/2014
// Descripción: Código de Encripción.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaModelo.Auxiliar
{
    public class Encripcion
    {
        /// <summary>
        /// Encripta una cadena con SHA256 para el manejo de contraseñas.
        /// </summary>
        /// <param name="input"> Cadena que se desea encriptar. </param>
        /// <returns> Cadena Encriptada en SHA 256. </returns>
        public static string SHA256Encrypt(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
                output.Append(hashedBytes[i].ToString("x2").ToLower());

            return output.ToString();
        }  
    }
}
