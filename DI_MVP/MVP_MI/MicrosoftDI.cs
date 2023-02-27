using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using DI.MVP_MI.Services;

namespace DI.MVP_MI
{
    internal class MicrosoftDI
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public static void ConfigureServices()
        {
            var services = new ServiceCollection();

            //::begin:: User Services
            services.AddScoped<SIUser, SUser>();
            //::end:: User Services

            ServiceProvider = services.BuildServiceProvider();
        }
        public static T? GetService<T>() where T : class
        {
            return (T?)ServiceProvider.GetService(typeof(T));
        }
    }
}
