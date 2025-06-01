using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRAVELLA_PBO_TA.Database;

namespace TRAVELLA_PBO_TA.Models
{
    internal class AdminModels
    {
            public int Id { get; set; }
            public string Nama { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            
            public AdminModels(int id, string nama, string email, string password, string role)
            {
                Id = id;
                Nama = nama;
                Email = email;
                Password = password;
            }

        public static bool ValidateAdmin(string username, string password)
        {
            using (var conn = KoneksiDatabase.GetKoneksi())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                string query = "SELECT password FROM admins WHERE username = @username";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedPassword = reader.GetString(0);
                            return storedPassword == password;
                        }
                    }
                }
            }
            return false;
        }



     

          
        
    }
}
