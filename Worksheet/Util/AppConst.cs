using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.Util
{
    internal class AppConst
    {
        public static readonly string path = Path.GetDirectoryName(Application.ExecutablePath);
        public static readonly string sqliteConnect = "Data Source=" + path + "/Content/database.dat;Version=3;New=True";
        public static readonly string contentFolder = path + "/Content/";
        public static readonly string templateFolder = contentFolder + "Template/";
        public static readonly string formulaFolder = contentFolder + "Formulation/";
        public static readonly string DonGiaFolder = contentFolder + "Dongia/";
        public static readonly string BaoGiaFolder = contentFolder + "Baogia/";
        public static readonly string autosaveFolder = contentFolder + "Tmp/";
        public static readonly string licenseServer = "http://";
        public static readonly string dataServer = "http://";
        public static readonly string versionServer = "http://";
    }
}
