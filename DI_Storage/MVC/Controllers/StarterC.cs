using DI_Storage.MVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Storage.MVC.Controllers
{
    internal class StarterC : AController
    {
        public override string Name { get { return "Starter"; } }
        private Starter _view = new Starter();
        public override IView View { get { return _view; } } 
    }
}
