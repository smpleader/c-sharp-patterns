using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserEntity = DI_Storage.Entities.User.WinForm;
using UserCore = DI_Storage.Entities.User.Core;
using DI_Storage.DB.Json;
using DI_Storage.Util;

namespace DI_Storage.MVC.Models
{
    internal class JsonUserM
    {
        public User userDB = new User(CurrentApp.path+"/Data/users.json");  

        public User db()
        { 
            return userDB; 
        }
        public List<UserEntity> ComboboxList()
        {

            List <UserCore> origin = userDB.List();
            List<UserEntity> combobox = new List<UserEntity>();

            //origin.Select(item => (UserEntity)item.Clone()).ToList();
            foreach (UserCore item in origin)
            {
                UserEntity newOne = new UserEntity(item);
                combobox.Add(newOne);
            }

            combobox.Insert(0, new UserEntity());

            return combobox;
        }
    }
}
