using System;
using System.Security.Cryptography;
using System.Text;

namespace encripcion
{
    internal class Encryptmd5
    {
        public string Encrypt(string mensaje)
        {
            string hash = "codigo con c";
            byte[] data = UTF8Encoding.UTF8.GetBytes(mensaje);
            MD5 md5 = MD5.Create();
            TripleDES tripledes = TripleDES.Create();
            tripledes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripledes.Mode = CipherMode.ECB;
            tripledes.Padding = PaddingMode.PKCS7; // Añadir modo de relleno

            ICryptoTransform transform = tripledes.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
            return Convert.ToBase64String(result);
        }

        public string Decrypt(string mensajeen)
        {
            string hash = "codigo con c";
            byte[] data = Convert.FromBase64String(mensajeen);
            MD5 md5 = MD5.Create();
            TripleDES tripledes = TripleDES.Create();
            tripledes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripledes.Mode = CipherMode.ECB;
            tripledes.Padding = PaddingMode.PKCS7; // Añadir modo de relleno

            ICryptoTransform transform = tripledes.CreateDecryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
            return UTF8Encoding.UTF8.GetString(result);
        }
    }
}