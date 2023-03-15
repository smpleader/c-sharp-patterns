using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Storage.Util
{
    internal class AppConst
    {
        public static readonly string path = Path.GetDirectoryName(Application.ExecutablePath);
        public static readonly string sqliteConnect = "Data Source=" + path + "/Data/database.dat;Version=3;New=True";
        public static readonly string licenseServer = "http://";
        public static readonly string dataServer = "http://";
        public static readonly string versionServer = "http://";
    }
}
