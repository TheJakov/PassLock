using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassLock.Klase
{
    class Konekcija
    {
        public SQLiteConnection conn;
        public void OtvoriKonekciju(string putanja, string lozinka)
        {
            string dataSource = @"Data Source=" + putanja + ";Version=3;Page Size=1024;Password=" + lozinka + ";";
            conn = new SQLiteConnection(dataSource);
            conn.Open();
        }

        public void ZatvoriKonekciju()
        {
            conn.Close();
        }
    }
}
