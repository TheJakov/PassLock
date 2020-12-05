using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassLock.Klase
{
    public static class Sesija
    {
        public static string Putanja { get; set; }
        public static string Lozinka { get; set; }

        public static void InicijalizirajNovuSesiju()
        {
            if (Putanja != null)
                Putanja = null;
            if (Lozinka != null)
                Lozinka = null;
        }

        public static void ObrisiPodatkeOSesiji()
        {
            Putanja = null;
            Lozinka = null;
        }
    }
}
