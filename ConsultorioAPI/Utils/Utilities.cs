using System.Security.Cryptography;
using System.Text;

namespace ConsultorioAPI.Utils
{
    public class Utilities
    {
        // method to encrypt password
        public string EncriptarSHA256(string text)
        {
            // create instance to create SHA256 ancrypt.
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // create the array of bytes using the text in parameter.
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(text));

                // convert the array in string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString(); // return the text encrypted.
            }
        }
    }
}
