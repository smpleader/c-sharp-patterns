using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.Data.Entities.User
{
    internal class Group
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        public override string ToString() { return Id + " " + Name; }

    }
}
