using DI_Storage.MVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Storage.MVC.Controllers
{
    internal interface IController
    {
        string Name { get; }

        bool Closed { get; set; }
        public IView View { get; }

        void Fire( string command) { } 
        void Close() { }
        void Open() { }
    }
}
