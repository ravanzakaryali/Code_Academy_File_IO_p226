using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace LabTask333.Models
{
    public class User
    {
        private static IEnumerable<string> lines;
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public string Username { get; set; }
        public string Password { get; set; }
        private User()
        {
        }
        public User(string name, string surname, string username, string password) : this()
        {
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
            lines = Program.GetFile("database");
            foreach (var item in lines)
            {
                if (item != null)
                {
                    User user = JsonSerializer.Deserialize<User>(item);
                    if (user.Username == username)
                    {
                        throw new Exception("Bu username isledilir");
                    }
                }
            }
        }
        public override string ToString()
        {
            return $"\n {Name} {Surname} {DateTime:dddd, dd MMMM yyyy}\n";
        }
    }
}
