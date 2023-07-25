using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserEntity = Worksheet.Data.Entities.User.WinForm;
using UserSchema = Worksheet.Data.Entities.User.Schema;
using Worksheet.DB.Json;
using Worksheet.Util;

namespace Worksheet.MVC.Models
{
    internal class JsonUserM
    {
        public User userDB = new User( AppConst.contentFolder + "/users.json");  

        public User db()
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
