using SimpleInjector;
using DI.MVP_SI.Services;
using DI.MVP_SI.Application;

namespace DI.MVP_SI
{
    internal class SimpleInjectionDI
    {
        public static Container container;
        public static void ConfigureServices()
        {
            container = new Container();
            container.Register<SIUser, SUser>(Lifestyle.Transient);
            container.Register<SPost>(Lifestyle.Transient);
            container.Register<SApplication>(Lifestyle.Singleton); // IApp,

            //Registration registration = container.GetRegistration(typeof(IPeopleManagerService)).Registration;

            //registration.SuppressDiagnosticWarning(DiagnosticType.DisposableTransientComponent,
            //        "Presenters will call Dispose on these services.");

            container.Verify();
        }
    }
}
