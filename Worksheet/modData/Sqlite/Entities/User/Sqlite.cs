using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Worksheet.modData.Entities.User
{
    internal class Sqlite : Schema
    {
        public Sqlite() { }
        public Sqlite(Schema other)
        {
            Id = other.Id;
            Name = other.Name;
            Email = other.Email;
            Password = other.Password;
            UserName = other.UserName;
        }
        public Sqlite(SQLiteDataReader reader)
        {
            Id = (long)reader["Id"];
            Name = reader["Name"] as string;
            Email = reader["Email"] as string;
            Password = reader["Password"] as string;
            UserName = reader["UserName"] as string;
        }
    }
}
