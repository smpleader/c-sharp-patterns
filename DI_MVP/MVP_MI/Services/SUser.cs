using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.MVP_MI.Models;

namespace DI.MVP_MI.Services
{
    internal class SUser : SIUser
    {
        public MUser GetUser(int Id)
        {
            return new MUser() { Id = Id, Name = "Test John" };
        }
    }
}
