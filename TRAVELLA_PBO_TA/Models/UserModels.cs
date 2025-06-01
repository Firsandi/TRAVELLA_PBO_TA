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
                string query = "SELECT password FROM users WHERE username = @username";
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



        public static bool RegisterUser(string nama, string email, string nomorTelepon, string username, string password)
        {
            using (var conn = KoneksiDatabase.GetKoneksi())
            {
                if (conn.State != ConnectionState.Open)  // ✅ Cek status koneksi sebelum dibuka
                {
                    conn.Open();
                }
                // ✅ Cek apakah username sudah digunakan
                string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
                using (var checkCmd = new NpgsqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@username", username);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        return false; // Username sudah ada
                    }
                }

                // ✅ Simpan data jika username belum ada
                string query = "INSERT INTO users (nama, email, no_telepon, username, password) VALUES (@nama, @email, @no_telepon, @username, @password)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@no_telepon", nomorTelepon);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
