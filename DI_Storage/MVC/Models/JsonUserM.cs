using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserEntity = DI_Storage.Entities.User;
using DI_Storage.DB.Json;

namespace DI_Storage.MVC.Models
{
    internal class JsonUserM
    {
        public static string GetInfo()
        {
            User user = new User("Data/users.json");
            // Id can achieve from View request
            return user.ById(10).ToString();
        }
    }
}
