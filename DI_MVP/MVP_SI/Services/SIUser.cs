using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.MVP_SI.Services
{
    internal interface SIUser
    {
        Models.MUser GetUser(int Id);
    }
}
