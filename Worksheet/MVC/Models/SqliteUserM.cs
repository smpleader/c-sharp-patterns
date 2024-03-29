﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserEntity = Worksheet.modData.Entities.User.WinForm;
using UserCore = Worksheet.modData.Entities.User.Schema;

using Worksheet.Util;
using SqlDrive = Worksheet.modData.Drivers.Sqlite;

namespace Worksheet.MVC.Models
{
    internal class SqliteUserM
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
