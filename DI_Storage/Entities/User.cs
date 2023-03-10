using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Storage.Entities
{
    internal class User : ICloneable
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
        public string UserName { get; set; } = "";

        public override string ToString() { return ComboBoxDisplay; }// Name + " " + Email ; }
        public User()
        { }
        public string ComboBoxDisplay { get { return Id > 0 ? ( Id + " - " + Name ) : ("New"); } }
            
        public User Clone() { return new User(this); }

        public User(User other)
        {
            Id = other.Id;
            Name = other.Name;
            Email = other.Email;
            Password = other.Password;
            UserName = other.UserName;
           // ComboBoxDisplay = other.ComboBoxDisplay;
        }

        object ICloneable.Clone(){ return Clone();}



    }
}
