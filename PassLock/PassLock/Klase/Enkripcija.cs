using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PassLock.Klase
{
    public class Enkripcija
    {
        public string Enkriptiraj(string lozinka, int duljinaLozinke)
        {
            string obradbeniPodatak = lozinka + DateTime.Now.ToString();

            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(obradbeniPodatak));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                string finalLozinka = builder.ToString().Substring(0, duljinaLozinke);
                return finalLozinka;
            }
        }
    }
}
