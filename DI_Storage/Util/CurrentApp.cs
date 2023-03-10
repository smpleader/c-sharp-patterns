using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Storage.Util
{
    internal class CurrentApp
    {
        public static string path = Path.GetDirectoryName(Application.ExecutablePath);

    }
}
