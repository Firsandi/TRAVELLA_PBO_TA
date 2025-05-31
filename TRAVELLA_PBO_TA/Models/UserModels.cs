using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRAVELLA_PBO_TA.Database;

namespace TRAVELLA_PBO_TA.Models
{
    internal class UserModels
    {
            public int Id { get; set; }
            public string Nama { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string Role { get; set; } // "Admin" atau "User"
            
            public UserModels(int id, string nama, string email, string password, string role)
            {
                Id = id;
                Nama = nama;
                Email = email;
                Password = password;
                Role = role;
            }

        public static bool ValidateUser(string username, string password)
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
                            return storedPassword == password; // ❌ Tidak aman, membandingkan plaintext
                        }
                    }
                }
            }
            return false;
        }



        public static bool RegisterUser(string nama, string email, string password, string role)
            {
                using (var conn = KoneksiDatabase.GetKoneksi())
                {
                    conn.Open();
                    string query = "INSERT INTO users (nama, email, password, role) VALUES (@nama, @email, @password, @role)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.HashPassword(password));
                        cmd.Parameters.AddWithValue("@role", role);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }


    }
}
