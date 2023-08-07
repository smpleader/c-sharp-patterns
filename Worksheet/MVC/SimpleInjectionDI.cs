using SimpleInjector;
using Worksheet.MVC.Controllers;
using Worksheet.MVC.Controllers.BE;
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
            container.Collection.Register<IController>(new LoaderC(), new StarterC(), new JsonUserC(), new SqliteUserC(), new SheetDemoC(), new ResourceC());

            // this cause duplicate instance
            //container.Collection.Register<IController>(typeof( LoaderC ), typeof( StarterC), typeof( JsonUserC));

            // DRIVERs
            Sqlite sqlDriver = new Sqlite( AppConst.sqliteConnect );
            container.RegisterInstance<Sqlite>(sqlDriver);

            // MODELS
            container.Register<TestM>(Lifestyle.Transient);
            container.Register<JsonUserM>();
            container.RegisterInstance<SqliteUserM>(new SqliteUserM(sqlDriver));
            container.Register<DemoM>();



            //container.Register<UserC>(Lifestyle.Scoped);
            //container.Register<SIUser, SUser>(Lifestyle.Transient);
            // 
            // container.Register<SApplication>(Lifestyle.Singleton); // IApp,

            //Registration registration = container.GetRegistration(typeof(IPeopleManagerService)).Registration;

            //registration.SuppressDiagnosticWarning(DiagnosticType.DisposableTransientComponent,
            //        "Presenters will call Dispose on these services.");

            // Reverting to the pre-v5 behavior
            //container.Options.ResolveUnregisteredConcreteTypes = true;
            container.Verify();
        }
    }
}
