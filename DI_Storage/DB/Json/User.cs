using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserEntity = DI_Storage.Entities.User.Schema;
using DI_Storage.Drivers;
using System.Data.Common;

namespace DI_Storage.DB.Json
{
    internal class User
    {
        private string FilePath;
        private List<UserEntity> Users;
        public User(string filepath) {
            FilePath = filepath;
            Users = JsonFile.load<UserEntity>(FilePath);
        }

        public UserEntity Save(UserEntity usr)
        {
            if(usr.Id > 0)
            {
                var index = Users.FindIndex(r => r.Id == usr.Id);
                if (index != -1)
                {
                    Users[index] = usr;
                }
            }
            else
            {
                usr.Id = Users.Max(r => r.Id);
                usr.Id++;
                Users.Add(usr);
            }

            JsonFile.store(Users, FilePath);

            return usr;
        }

        public UserEntity ById(string id)
        {
            if (id == "first" && Users.Count() > 0)
            {
                return Users.First(); 
            }

            if (id == "last" && Users.Count() > 0)
            {
                return Users.Last();
            }

            return ById(Convert.ToInt32(id)); 
        }
        public UserEntity ById(int id)
        {
            UserEntity user = new UserEntity();
            var find = Users.Find(x => x.Id == id);
            if (find != null) { user = find; }
            return user;
        }

        public List<UserEntity> List()
        {
            return Users;
        }
    }
}
