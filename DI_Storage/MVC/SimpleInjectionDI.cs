using SimpleInjector;
using DI_Storage.MVC.Controllers;
using DI_Storage.MVC.Models;
using DI_Storage.MVC.Views;
using DI_Storage.Util;

namespace DI_Storage.MVC
{
    internal class SimpleInjectionDI
    {
        public static Container container = new Container();
        public static void ConfigureServices()
        {
            // CONTROLLERS
            container.Collection.Register<IController>(new LoaderC(), new StarterC(), new JsonUserC(), new JsonUserPresenterC(), new SqliteUserC());

            // this cause duplicate instance
            //container.Collection.Register<IController>(typeof( LoaderC ), typeof( StarterC), typeof( JsonUserC));

            // DRIVERs
            Drivers.Sqlite sqlDriver = new Drivers.Sqlite( AppConst.sqliteConnect );
            container.RegisterInstance<Drivers.Sqlite>(sqlDriver);

            // MODELS
            container.Register<TestM>(Lifestyle.Transient);
            container.Register<JsonUserM>();

            container.RegisterInstance<SqliteUserM>(new SqliteUserM(sqlDriver));
            //container.Register<SqliteUserM>();



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
