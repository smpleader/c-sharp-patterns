using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modData.Sqlite.Entities.User
{
    public class WinForm : Schema
    {
        public override string ToString() { return ComboBoxDisplay; }

        public string ComboBoxDisplay { get { return Id > 0 ? Id + " - " + Name : "New"; } }

        public WinForm() { }
        public WinForm(WinForm other)
        {
            Id = other.Id;
            Name = other.Name;
            Email = other.Email;
            Password = other.Password;
            UserName = other.UserName;
        }
        public WinForm(Schema other)
        {
            Id = other.Id;
            Name = other.Name;
            Email = other.Email;
            Password = other.Password;
            UserName = other.UserName;
        }

    }
}
