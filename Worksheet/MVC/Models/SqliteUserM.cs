using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserEntity = Worksheet.Data.Entities.User.WinForm;
using UserCore = Worksheet.Data.Entities.User.Schema;
using Worksheet.DB.SQLite;
using Worksheet.Util;
using SqlDrive = Worksheet.Util.Drivers.Sqlite;

namespace Worksheet.MVC.Models
{
    internal class SqliteUserM
    {
        public User tblUser;
        public SqliteUserM(SqlDrive sqlDriver) 
        {
            tblUser = new User(sqlDriver);
        }

        public User table()
        { 
            return tblUser; 
        }
        public List<UserEntity> ComboboxList()
        {

            List <UserCore> origin = tblUser.List();
            List<UserEntity> combobox = new List<UserEntity>();

            foreach (UserCore item in origin)
            {
                combobox.Add(new UserEntity(item));
            }

            combobox.Insert(0, new UserEntity());

            return combobox;
        }
    }
}
