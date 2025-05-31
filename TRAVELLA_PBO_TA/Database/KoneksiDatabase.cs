using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAVELLA_PBO_TA.Database
{
    internal class KoneksiDatabase
    {
        private static readonly string connString = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=TRAVELLA";

        public static NpgsqlConnection GetKoneksi()
        {
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            return conn;
        }
    }
}
