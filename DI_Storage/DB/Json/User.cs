using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserEntity = DI_Storage.Entities.User;
using DI_Storage.Drivers;

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

        public UserEntity ById(string id)
        {
            return ById(Convert.ToInt32(id)); 
        }
        public UserEntity ById(int id)
        {
            UserEntity user = new UserEntity();
            var find = Users.Find(x => x.Id == id);
            if (find != null) { user = find; }
            return user;
        }
    }
}
