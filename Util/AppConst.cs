using System.Reflection;


namespace Util
{
    public class AppConst
    {
        public static readonly string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
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
