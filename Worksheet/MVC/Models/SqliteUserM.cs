using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserEntity = modData.Sqlite.Entities.User.WinForm;
using UserCore = modData.Sqlite.Entities.User.Schema;

using Util;
using SqlDrive = modData.Drivers.Sqlite;

namespace Worksheet.MVC.Models
{
    public class SqliteUserM
    {
        public modData.Sqlite.User tblUser;
        public SqliteUserM(SqlDrive sqlDriver) 
        {
            tblUser = new modData.Sqlite.User(sqlDriver);
        }

        public modData.Sqlite.User table()
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
