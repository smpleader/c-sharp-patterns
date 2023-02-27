using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.MVP_SI.Models;

namespace DI.MVP_SI.Services
{
    internal class SUser : SIUser
    {
        public MUser GetUser(int Id)
        {
            return new MUser() { Id = Id, Name = "Test Marry" };
        }
    }
}
