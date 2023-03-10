using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Storage.Entities.User
{
    internal class Core
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
        public string UserName { get; set; } = "";

        public Core() { }
        public Core(WinForm other)
        {
            Id = other.Id;
            Name = other.Name;
            Email = other.Email;
            Password = other.Password;
            UserName = other.UserName;
        }
    }
}
