﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserEntity = modData.Sqlite.Entities.User.WinForm;
using UserSchema = modData.Sqlite.Entities.User.Schema;
using modData.Drivers;
using Util;

namespace Worksheet.MVC.Models
{
    internal class JsonUserM
    {
        public modData.Json.User userDB = new modData.Json.User( AppConst.contentFolder + "/users.json");  

        public modData.Json.User db()
        { 
            return userDB; 
        }
        public List<UserEntity> ComboboxList()
        {

            List<UserSchema> origin = userDB.List();
            List<UserEntity> combobox = new List<UserEntity>();

            //origin.Select(item => (UserEntity)item.Clone()).ToList();
            foreach (UserSchema item in origin)
            {
                UserEntity newOne = new UserEntity(item);
                combobox.Add(newOne);
            }

            combobox.Insert(0, new UserEntity());

            return combobox;
        }
    }
}
