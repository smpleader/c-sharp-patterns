using Syncfusion.Licensing;
using Worksheet.MVC;

namespace Worksheet
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //Register Syncfusion license
            SyncfusionLicenseProvider.RegisterLicense("MjY1Mjc3M0AzMjMyMmUzMDJlMzBLam56RC9nbDVOR2N2aGVjQ3djTGdEdGRzU3lSN0FmZFlKWE4reHNBQjhnPQ==");
            ApplicationConfiguration.Initialize();
            SimpleInjectionDI.ConfigureServices();
            Backbone.StartCurrentThread();
        }
    }
}