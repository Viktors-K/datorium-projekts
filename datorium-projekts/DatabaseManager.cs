using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.VisualBasic;
using System.Security.Permissions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace datorium_projekts
{
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
                    Dictionary<string, string> profile_data = JsonSerializer.Deserialize<Dictionary<string, string>>(json_data);
                    new_user = new User(
                        id: Convert.ToInt32(reader["id"]),
                        username: Convert.ToString(reader["username"]),
                        email: Convert.ToString(reader["email"]),
                        password_hash: Convert.ToString(reader["password_hash"]),
                        name: profile_data["Name"],
                        surname: profile_data["Surname"],
                        student_class: profile_data["StudentClass"],
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
        public bool UsernameExists(string username)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                User new_user = null;
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT 1 FROM Users WHERE username = @username";
                selectCmd.Parameters.AddWithValue("@username", username);
                var reader = selectCmd.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                return false;
            }
        }
        public bool EmailExists(string email)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                User new_user = null;
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT 1 FROM Users WHERE email = @email";
                selectCmd.Parameters.AddWithValue("@email", email);
                var reader = selectCmd.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                return false;
            }
        }
        public List<User> GetAllUsers()
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                List<User> user_list = new List<User>();
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM Users";
                var reader = selectCmd.ExecuteReader();
                while (reader.Read())
                {
                    string json_data = reader["profile_data"].ToString();
                    Dictionary<string, string> profile_data = JsonSerializer.Deserialize<Dictionary<string, string>>(json_data);
                    User new_user = new User(
                        id: Convert.ToInt32(reader["id"]),
                        username: Convert.ToString(reader["username"]),
                        email: Convert.ToString(reader["email"]),
                        password_hash: Convert.ToString(reader["password_hash"]),
                        name: profile_data["Name"],
                        surname: profile_data["Surname"],
                        student_class: profile_data["StudentClass"],
                        admin: Convert.ToBoolean(reader["admin"])
                    );
                    user_list.Add(new_user);
                }
                return user_list;
            }
        }
    }
    public class ItemManager
    {
        private readonly string _connectionString;
        public ItemManager(string connectionString)
        {
            _connectionString = connectionString;
            InitItemTable();
            UpdateStatuses();
        }
        private void InitItemTable()
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var createTableCmd = connection.CreateCommand();
                createTableCmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Items (
                          id INTEGER PRIMARY KEY AUTOINCREMENT,
                          type TEXT NOT NULL,
                          status TEXT NOT NULL,
                          details TEXT
                    );
				";
                createTableCmd.ExecuteNonQuery();
            }
        }
        public void AddItem(string type, string status = "available", string details = null)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var insertCmd = connection.CreateCommand();
                insertCmd.CommandText = @"INSERT INTO Items(type, status, details)
                                                      VALUES (@type, @status, @details)";
                insertCmd.Parameters.AddWithValue("@type", type);
                insertCmd.Parameters.AddWithValue("@status", status);
                insertCmd.Parameters.AddWithValue("@details", details);
                insertCmd.ExecuteNonQuery();
            }
        }
        public Item GetItem(int id)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                Item new_item = null;
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM Items WHERE id = @id";
                selectCmd.Parameters.AddWithValue("@id", id);
                var reader = selectCmd.ExecuteReader();
                while (reader.Read())
                {
                    new_item = new Item(
                        id: Convert.ToInt32(reader["id"]),
                        type: Convert.ToString(reader["type"]),
                        status: Convert.ToString(reader["status"]),
                        details: Convert.ToString(reader["details"])
                    );
                }
                return new_item;
            }
        }
        public void EditItem(Item new_item, Item old_item)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var updateCmd = connection.CreateCommand();
                updateCmd.CommandText = @"
					UPDATE Items SET
                        type = @type, 
                        status = @status,
                        details = @details
                    WHERE id = @id;
				";
                updateCmd.Parameters.AddWithValue("@type", new_item.Type);
                updateCmd.Parameters.AddWithValue("@status", new_item.Status);
                updateCmd.Parameters.AddWithValue("@details", new_item.Details);
                updateCmd.Parameters.AddWithValue("@id", old_item.Id);
                updateCmd.ExecuteNonQuery();
            }
        }
        public void DeleteItem(int id)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var deleteCmd = connection.CreateCommand();
                deleteCmd.CommandText = "DELETE FROM Handouts WHERE item_id = @item_id;";
                deleteCmd.Parameters.AddWithValue("@item_id", id);
                deleteCmd.ExecuteNonQuery();
                deleteCmd = connection.CreateCommand();
                deleteCmd.CommandText = "DELETE FROM Reservations WHERE item_id = @item_id;";
                deleteCmd.Parameters.AddWithValue("@item_id", id);
                deleteCmd.ExecuteNonQuery();
                deleteCmd = connection.CreateCommand();
                deleteCmd.CommandText = "DELETE FROM Items WHERE id = @id;";
                deleteCmd.Parameters.AddWithValue("@id", id);
                deleteCmd.ExecuteNonQuery();
            }
        }
        public List<Item> GetAllItems()
        {
            UpdateStatuses();
            using (var connection = new SqliteConnection(_connectionString))
            {
                List<Item> item_list = new List<Item>();
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM Items";
                var reader = selectCmd.ExecuteReader();
                while (reader.Read())
                {
                    Item new_item = new Item(
                        id: Convert.ToInt32(reader["id"]),
                        type: Convert.ToString(reader["type"]),
                        status: Convert.ToString(reader["status"]),
                        details: Convert.ToString(reader["details"])
                    );
                    item_list.Add(new_item);
                }
                return item_list;
            }
        }
        public void UpdateStatuses()
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT Id FROM Items";
                var reader = selectCmd.ExecuteReader();

                // goes through all items
                while (reader.Read())
                {
                    // get item id
                    int item_id = reader.GetInt32(0);

                    // create status string based on availability 
                    string new_status = "available";
                    if (IsTaken(item_id)) new_status = "taken";
                    else if (IsReserved(item_id)) new_status = "reserved";

                    // update item with new status
                    var updateCmd = connection.CreateCommand();
                    updateCmd.CommandText = @"
					            UPDATE Items SET
                                    status = @status
                                WHERE id = @id;
				            ";
                    updateCmd.Parameters.AddWithValue("@status", new_status);
                    updateCmd.Parameters.AddWithValue("@id", item_id);
                    updateCmd.ExecuteNonQuery();
                }
            }
        }
        public Boolean IsTaken(int item_id)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                // check if table Handouts has an active or late handout on item
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT 1 FROM Handouts WHERE item_id = @item_id AND status IN ('active', 'late')";
                selectCmd.Parameters.AddWithValue("@item_id", item_id);
                var reader = selectCmd.ExecuteReader();

                return reader.HasRows;
            }
        }
        public Boolean IsReserved(int item_id)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                // check if table Reservations has an active reservation on item
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT 1 FROM Reservations WHERE item_id = @item_id AND status IN ('active', 'upcoming', 'late')";
                selectCmd.Parameters.AddWithValue("@item_id", item_id);
                var reader = selectCmd.ExecuteReader();

                return reader.HasRows;
            }
        }
    }
    public class HandoutManager
    {
        private readonly string _connectionString;
        public HandoutManager(string connectionString)
        {
            _connectionString = connectionString;
            InitHandoutTable();
            UpdateStatuses();
        }
        private void InitHandoutTable()
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var createTableCmd = connection.CreateCommand();
                createTableCmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Handouts (
                          id INTEGER PRIMARY KEY AUTOINCREMENT,
                          item_id INTEGER NOT NULL,
                          username TEXT NOT NULL,
                          issued_at TEXT NOT NULL,
                          due_at TEXT NOT NULL,
                          status TEXT NOT NULL,
                          FOREIGN KEY (item_id) REFERENCES Items(id),
                          FOREIGN KEY (username) REFERENCES Users(username)
                    );
				";
                createTableCmd.ExecuteNonQuery();
            }
        }
        public void AddHandout(int item_id, string username, DateTime due_at)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var insertCmd = connection.CreateCommand();
                insertCmd.CommandText = @"INSERT INTO Handouts(item_id, username, issued_at, due_at, status)
                                                      VALUES (@item_id, @username, @issued_at, @due_at, @status)";
                insertCmd.Parameters.AddWithValue("@item_id", item_id);
                insertCmd.Parameters.AddWithValue("@username", username);
                insertCmd.Parameters.AddWithValue("@issued_at", DateTime.Now.ToString());
                insertCmd.Parameters.AddWithValue("@due_at", due_at.ToString());
                insertCmd.Parameters.AddWithValue("@status", "active");
                insertCmd.ExecuteNonQuery();
            }
        }
        public Handout GetHandout(int id)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                Handout new_handout = null;
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM Handouts WHERE id = @id";
                selectCmd.Parameters.AddWithValue("@id", id);
                var reader = selectCmd.ExecuteReader();
                while (reader.Read())
                {
                    new_handout = new Handout(
                        id: Convert.ToInt32(reader["id"]),
                        item_id: Convert.ToInt32(reader["item_id"]),
                        username: Convert.ToString(reader["username"]),
                        issued_at: Convert.ToDateTime(reader["issued_at"]),
                        due_at: Convert.ToDateTime(reader["due_at"]),
                        status: Convert.ToString(reader["status"])
                    );
                }
                return new_handout;
            }
        }
        public void EditHandout(Handout new_handout, Handout old_handout)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var updateCmd = connection.CreateCommand();
                updateCmd.CommandText = @"
					UPDATE Handouts SET
                        item_id = @item_id, 
                        username = @username,
                        issued_at = @issued_at,
                        due_at = @due_at,
                        status = @status
                    WHERE id = @id;
				";
                updateCmd.Parameters.AddWithValue("@item_id", new_handout.ItemId);
                updateCmd.Parameters.AddWithValue("@username", new_handout.Username);
                updateCmd.Parameters.AddWithValue("@issued_at", new_handout.IssuedAt.ToString());
                updateCmd.Parameters.AddWithValue("@due_at", new_handout.DueAt.ToString());
                updateCmd.Parameters.AddWithValue("@status", new_handout.Status);
                updateCmd.Parameters.AddWithValue("@id", old_handout.Id);
                updateCmd.ExecuteNonQuery();
            }
        }
        public void DeleteHandout(int id)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var deleteCmd = connection.CreateCommand();
                deleteCmd.CommandText = "DELETE FROM Handouts WHERE id = @id;";
                deleteCmd.Parameters.AddWithValue("@id", id);
                deleteCmd.ExecuteNonQuery();
            }
        }
        public void UpdateStatuses()
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM Handouts";
                var reader = selectCmd.ExecuteReader();

                // goes through all handouts
                while (reader.Read())
                {
                    // get handout id
                    int handout_id = Convert.ToInt32(reader["id"]);
                    string old_status = Convert.ToString(reader["status"]);
                    DateTime due_time = Convert.ToDateTime(reader["due_at"]);
                    DateTime current_time = DateTime.Now;

                    // check if active handouts are late, if so change them to late
                    if (old_status == "active")
                    {
                        if (due_time < current_time)
                        {
                            // update handout with new status
                            var updateCmd = connection.CreateCommand();
                            updateCmd.CommandText = @"
					            UPDATE Handouts SET
                                    status = @status
                                WHERE id = @id;
				            ";
                            updateCmd.Parameters.AddWithValue("@status", "late");
                            updateCmd.Parameters.AddWithValue("@id", handout_id);
                            updateCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
    }
    public class ReservationManager
    {
        private readonly string _connectionString;
        public ReservationManager(string connectionString)
        {
            _connectionString = connectionString;
            InitReservationTable();
            UpdateStatuses();
        }
        private void InitReservationTable()
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var createTableCmd = connection.CreateCommand();
                createTableCmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Reservations (
                          id INTEGER PRIMARY KEY AUTOINCREMENT,
                          item_id INTEGER NOT NULL,
                          username TEXT NOT NULL,
                          reserved_from TEXT NOT NULL,
                          reserved_until TEXT NOT NULL,
                          status TEXT NOT NULL,
                          FOREIGN KEY (item_id) REFERENCES Items(id),
                          FOREIGN KEY (username) REFERENCES Users(username)
                    );
				";
                createTableCmd.ExecuteNonQuery();
            }
        }
        public void AddReservation(int item_id, string username, DateTime reserved_from, DateTime reserved_until)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                DateTime current_time = DateTime.Now;
                connection.Open();
                var insertCmd = connection.CreateCommand();
                insertCmd.CommandText = @"INSERT INTO Handouts(item_id, username, reserved_from, reserved_until, status)
                                                      VALUES (@item_id, @username, @reserved_from, @reserved_until, @status)";
                insertCmd.Parameters.AddWithValue("@item_id", item_id);
                insertCmd.Parameters.AddWithValue("@username", username);
                insertCmd.Parameters.AddWithValue("@reserved_from", reserved_from.ToString());
                insertCmd.Parameters.AddWithValue("@reserved_until", reserved_until.ToString());

                // status setter based on current time
                if (current_time < reserved_from)
                {
                    insertCmd.Parameters.AddWithValue("@status", "upcoming");
                } else
                {
                    if (current_time < reserved_until)
                    {
                        insertCmd.Parameters.AddWithValue("@status", "active");
                    } else
                    {
                        insertCmd.Parameters.AddWithValue("@status", "late");
                    }
                }

                insertCmd.ExecuteNonQuery();
            }
        }
        public Reservation GetReservation(int id)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                Reservation new_reservation = null;
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM Reservations WHERE id = @id";
                selectCmd.Parameters.AddWithValue("@id", id);
                var reader = selectCmd.ExecuteReader();
                while (reader.Read())
                {
                    new_reservation = new Reservation(
                        id: Convert.ToInt32(reader["id"]),
                        item_id: Convert.ToInt32(reader["item_id"]),
                        username: Convert.ToString(reader["username"]),
                        reserved_from: Convert.ToDateTime(reader["reserved_from"]),
                        reserved_until: Convert.ToDateTime(reader["reserved_until"]),
                        status: Convert.ToString(reader["status"])
                    );
                }
                return new_reservation;
            }
        }
        public void EditReservation(Reservation new_reservation, Reservation old_reservation)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var updateCmd = connection.CreateCommand();
                updateCmd.CommandText = @"
					UPDATE Reservations SET
                        item_id = @item_id, 
                        username = @username,
                        reserved_from = @reserved_from,
                        reserved_until = @reserved_until,
                        status = @status
                    WHERE id = @id;
				";
                updateCmd.Parameters.AddWithValue("@item_id", new_reservation.ItemId);
                updateCmd.Parameters.AddWithValue("@username", new_reservation.Username);
                updateCmd.Parameters.AddWithValue("@reserved_from", new_reservation.ReservedFrom.ToString());
                updateCmd.Parameters.AddWithValue("@reserved_until", new_reservation.ReservedUntil.ToString());
                updateCmd.Parameters.AddWithValue("@status", new_reservation.Status);
                updateCmd.Parameters.AddWithValue("@id", old_reservation.Id);
                updateCmd.ExecuteNonQuery();
            }
        }
        public void DeleteReservation(int id)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var deleteCmd = connection.CreateCommand();
                deleteCmd.CommandText = "DELETE FROM Reservations WHERE id = @id;";
                deleteCmd.Parameters.AddWithValue("@id", id);
                deleteCmd.ExecuteNonQuery();
            }
        }
        public void UpdateStatuses()
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT Id FROM Reservations";
                var reader = selectCmd.ExecuteReader();

                // goes through all reservations
                while (reader.Read())
                {
                    // get reservation id
                    int reservation_id = reader.GetInt32(0);
                    string old_status = Convert.ToString(reader["status"]);
                    DateTime reserved_from = Convert.ToDateTime(reader["reserved_from"]);
                    DateTime reserved_until = Convert.ToDateTime(reader["reserved_until"]);
                    DateTime current_time = DateTime.Now;
                    string new_status = old_status;
                    bool updated_needed = false;

                    // status setter based on current time, if already completed or late do nothing
                    if (old_status != "completed")
                    {
                        if (old_status != "late")
                        {
                            updated_needed = true;
                            if (current_time < reserved_from) new_status = "upcoming";
                            else
                            {
                                if (current_time < reserved_until) new_status = "active";
                                else new_status = "late";
                            }
                        }
                    }
                    // update reservation with new status
                    if (updated_needed)
                    {
                        var updateCmd = connection.CreateCommand();
                        updateCmd.CommandText = @"
					            UPDATE Reservations SET
                                    status = @status
                                WHERE id = @id;
				            ";
                        updateCmd.Parameters.AddWithValue("@status", new_status);
                        updateCmd.Parameters.AddWithValue("@id", reservation_id);
                        updateCmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
