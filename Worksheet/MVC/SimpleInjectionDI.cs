using SimpleInjector;
using Worksheet.MVC.Controllers;
using Worksheet.MVC.Models;
using modData.Drivers;
using System.Reflection;
using Util;

namespace Worksheet.MVC
{
    public class SimpleInjectionDI
    {
        public static Container container = new Container();

        public static void ConfigureServices()
        {
            // CONTROLLERS
            container.Collection.Register<IController>(new LoaderC(), new StarterC(), new SheetDemoC(),  new SyncfusionC(), new CuocOtoC());

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
