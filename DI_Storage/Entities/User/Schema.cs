using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Storage.Entities.User
{
    internal class Schema : IEntity
    {
        public long Id { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
        public string UserName { get; set; } = "";

        public Schema() { }
        public Schema(WinForm other)
        {
            Id = other.Id;
            Name = other.Name;
            Email = other.Email;
            Password = other.Password;
            UserName = other.UserName;
        }
        public Schema(Sqlite other)
        {
            Id = other.Id;
            Name = other.Name;
            Email = other.Email;
            Password = other.Password;
            UserName = other.UserName;
        }
    }
}
