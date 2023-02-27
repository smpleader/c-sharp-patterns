using DI_MVC.MVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_MVC.MVC.Controllers
{
    internal interface IController
    {
        string Name { get; }
        public IView View { get; }

        void Fire( string command) { } 
    }
}
