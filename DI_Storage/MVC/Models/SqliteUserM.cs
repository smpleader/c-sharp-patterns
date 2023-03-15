using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserEntity = DI_Storage.Entities.User.WinForm;
using UserCore = DI_Storage.Entities.User.Schema;
using DI_Storage.DB.SQLite;
using DI_Storage.Util;

namespace DI_Storage.MVC.Models
{
    internal class SqliteUserM
    {
        public User tblUser;
        public SqliteUserM(Drivers.Sqlite sqlDriver) 
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
