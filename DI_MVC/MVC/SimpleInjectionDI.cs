using SimpleInjector;
using DI_MVC.MVC.Controllers;
using DI_MVC.MVC.Models;

namespace DI_MVC.MVC
{
    internal class SimpleInjectionDI
    {
        public static Container container;
        public static void ConfigureServices()
        {
            container = new Container();

            //container.Register<UserC>(Lifestyle.Scoped);
            container.Collection.Register<IController>(new LoaderC(), new StarterC(), new UserC(), new PostC() ); //

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
