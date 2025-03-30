namespace datorium_projekts
{
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
    public class Item
    {
        public int Id;
        public string Type;
        public string Status;
        public string Details;
        public Item(int id, string type, string status, string details = null)
        {
            this.Id = id;
            this.Type = type;
            this.Status = status;
            this.Details = details;
        }
    }
    public class Handout
    {
        public int Id;
        public int ItemId;
        public string Username;
        public DateTime IssuedAt;
        public DateTime DueAt;
        public string Status;
        public Handout(int id, int item_id, string username, DateTime issued_at, DateTime due_at, string status)
        {
            this.Id = id;
            this.ItemId = item_id;
            this.Username = username;
            this.IssuedAt = issued_at;
            this.DueAt = due_at;
            this.Status = status;
        }
    }
    public class Reservation
    {
        public int Id;
        public int ItemId;
        public string Username;
        public DateTime ReservedFrom;
        public DateTime ReservedUntil;
        public string Status;
        public Reservation(int id, int item_id, string username, DateTime reserved_from, DateTime reserved_until, string status)
        {
            this.Id = id;
            this.ItemId = item_id;
            this.Username = username;
            this.ReservedFrom = reserved_from;
            this.ReservedUntil = reserved_until;
            this.Status = status;
        }
    }
}
