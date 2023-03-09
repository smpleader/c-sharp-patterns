using SimpleInjector;
using DI_Storage.MVC.Controllers;
using DI_Storage.MVC.Models;

namespace DI_Storage.MVC
{
    internal class SimpleInjectionDI
    {
        public static Container container = new Container();
        public static void ConfigureServices()
        {
            //container.Register<UserC>(Lifestyle.Scoped);
            container.Collection.Register<IController>(new LoaderC(), new StarterC(), new JsonUserC() ); //

            //container.Register<SIUser, SUser>(Lifestyle.Transient);
            // 
            // container.Register<SApplication>(Lifestyle.Singleton); // IApp,

            //Registration registration = container.GetRegistration(typeof(IPeopleManagerService)).Registration;

            //registration.SuppressDiagnosticWarning(DiagnosticType.DisposableTransientComponent,
            //        "Presenters will call Dispose on these services.");

            container.Verify();
        }
    }
}
