using SimpleInjector;
using DI_Storage.MVC.Controllers;
using DI_Storage.MVC.Models;
using DI_Storage.MVC.Views;

namespace DI_Storage.MVC
{
    internal class SimpleInjectionDI
    {
        public static Container container = new Container();
        public static void ConfigureServices()
        {
            // CONTROLLERS
            container.Collection.Register<IController>(new LoaderC(), new StarterC(), new JsonUserC(), new JsonUserPresenterC());
            
            // this cause duplicate instance
            //container.Collection.Register<IController>(typeof( LoaderC ), typeof( StarterC), typeof( JsonUserC));

            // MODELS
            //container.RegisterInstance<TestM>(new TestM());
            //container.RegisterInstance<JsonUserM>(new JsonUserM());
            container.Register<TestM>(Lifestyle.Transient);
            container.Register<JsonUserM>();


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
