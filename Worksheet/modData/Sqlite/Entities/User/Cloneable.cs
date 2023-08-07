using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Entities.User
{
    internal class Cloneable : Schema, ICloneable
    {
        public Cloneable() { }
        public Cloneable Clone() { return new Cloneable(this); }

        public Cloneable(Cloneable other)
        {
            Id = other.Id;
            Name = other.Name;
            Email = other.Email;
            Password = other.Password;
            UserName = other.UserName;
        }

        object ICloneable.Clone() { return Clone(); }
    }
}
