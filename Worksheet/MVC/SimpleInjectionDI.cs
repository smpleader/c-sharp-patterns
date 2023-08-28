using SimpleInjector;
using Worksheet.MVC.Controllers;
using Worksheet.MVC.Models;
using Worksheet.MVC.Views;
using Worksheet.Util;
using Worksheet.modData.Drivers;

namespace Worksheet.MVC
{
    internal class SimpleInjectionDI
    {
        public static Container container = new Container();
        public static void ConfigureServices()
        {
            // CONTROLLERS
            container.Collection.Register<IController>(new LoaderC(), new StarterC(), new SheetDemoC(),  new SyncfusionC());

            // DRIVERs
            Sqlite sqlDriver = new Sqlite( AppConst.sqliteConnect );
            container.RegisterInstance<Sqlite>(sqlDriver);

            // MODELS
            container.Register<TestM>(Lifestyle.Transient);
            container.Register<JsonUserM>();
            container.RegisterInstance<SqliteUserM>(new SqliteUserM(sqlDriver));
            container.Register<DemoM>();
         
            container.Verify();
        }
    }
}
