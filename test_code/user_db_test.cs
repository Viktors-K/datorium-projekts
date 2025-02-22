using BCrypt.Net;
using System;
using Microsoft.Data.Sqlite;
using System.Text.Json;
using System.Collections.Generic;
public class User
    {
        public int Id;
        public string Username;
        public string Email;
        public string PasswordHash;
        public bool Admin;
        public string Name;
        public string Surname;
        public string StudentClass;
        public User(int id, string username, string email, string password_hash, string name, string surname, string student_class = null, bool admin = false) 
        {
            this.Id = id;
            this.Username = username;
            this.Email = email;
            this.PasswordHash = password_hash;
            this.Name = name;
            this.Surname = surname;
            this.StudentClass = student_class;
            this.Admin = admin;
        }
    }    
public class UserManager
    {
        private readonly string _connectionString;
        public UserManager(string connectionString) 
        {
            _connectionString = connectionString;
            InitUserTable();
        }
        private void InitUserTable() 
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var createTableCmd = connection.CreateCommand();
                createTableCmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        username TEXT NOT NULL UNIQUE,
                        email TEXT UNIQUE NOT NULL,
                        password_hash TEXT NOT NULL,
                        admin BOOLEAN NOT NULL DEFAULT 0,
                        profile_data JSON
                    );
				";
                createTableCmd.ExecuteNonQuery();
            }
        }
        public void AddUser(string username, string email, string password_hash, string name, string surname, string student_class = null, bool admin = false)
        {
            Dictionary<string, string> profile_data = new Dictionary<string, string>
            {
                { "Name", name },
                { "Surname", surname },
                { "StudentClass", student_class }
            };
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var insertCmd = connection.CreateCommand();
                insertCmd.CommandText = @"INSERT INTO Users(username, email, password_hash, admin, profile_data)
                                                      VALUES (@username, @email, @password_hash, @admin, @profile_data)";
                insertCmd.Parameters.AddWithValue("@username", username);
                insertCmd.Parameters.AddWithValue("@email", email);
                insertCmd.Parameters.AddWithValue("@password_hash", password_hash);
                insertCmd.Parameters.AddWithValue("@admin", admin);
                insertCmd.Parameters.AddWithValue("@profile_data", JsonSerializer.Serialize(profile_data));
                insertCmd.ExecuteNonQuery();
            }
        }
        public User GetUser(string username)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                User new_user = null;
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM Users WHERE username = @username";
                selectCmd.Parameters.AddWithValue("@username", username);
                var reader = selectCmd.ExecuteReader();
                while (reader.Read())
                {
                    string json_data = reader["profile_data"].ToString();
                    Dictionary<string, string> user_info = JsonSerializer.Deserialize<Dictionary<string, string>>(json_data);
                    new_user = new User(
                        id: Convert.ToInt32(reader["id"]),
                        username: Convert.ToString(reader["username"]),
                        email: Convert.ToString(reader["email"]),
                        password_hash: Convert.ToString(reader["password_hash"]),
                        name: user_info["Name"],
                        surname: user_info["Surname"],
                        student_class: user_info["StudentClass"],
                        admin: Convert.ToBoolean(reader["admin"])
                    );
                }
                return new_user;
            }
        }
        public void EditUser(User new_user, User old_user)
        {
            Dictionary<string, string> profile_data = new Dictionary<string, string>
            {
                { "Name", new_user.Name },
                { "Surname", new_user.Surname },
                { "StudentClass", new_user.StudentClass }
            };
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var updateCmd = connection.CreateCommand();
                updateCmd.CommandText = @"
					UPDATE Users SET
                        username = @username, 
                        email = @email,
                        password_hash = @password_hash,
                        admin = @admin,
                        profile_data = @profile_data
                    WHERE id = @id;
				";
                updateCmd.Parameters.AddWithValue("@username", new_user.Username);
                updateCmd.Parameters.AddWithValue("@email", new_user.Email);
                updateCmd.Parameters.AddWithValue("@password_hash", new_user.PasswordHash);
                updateCmd.Parameters.AddWithValue("@admin", new_user.Admin);
                updateCmd.Parameters.AddWithValue("@profile_data", JsonSerializer.Serialize(profile_data));
                updateCmd.Parameters.AddWithValue("@id", old_user.Id);
                updateCmd.ExecuteNonQuery();
            }
        }

        public void DeleteUser(string username)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var deleteCmd = connection.CreateCommand();
                deleteCmd.CommandText = "DELETE FROM Users WHERE username = @username;";
                deleteCmd.Parameters.AddWithValue("@username", username);
                deleteCmd.ExecuteNonQuery();
            }
        }
    }
public class Program
{
	private UserManager userManager;
    public static void Main()
    {
		UserManager userManager = new UserManager("Data Source=main.db");
		userManager.AddUser("Vermelis","vikta@info.lv","$2a$11$.gjjfYCnynsxDcbd0Mdcv.FOm5CH2cRdVwgmIqqPWPv3RE70flz9i","Viktors","Kočetoks","12.ei");
		User new_user = userManager.GetUser("Vermelis");
		Console.WriteLine(new_user.Id);
	}
}