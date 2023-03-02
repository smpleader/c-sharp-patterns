﻿using DI_Storage.MVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Storage.MVC.Controllers
{
    internal class LoaderC : AController
    {
        public override string Name { get { return "Loader"; } }
        private Loader _view = new Loader();
        public override IView View { get { return _view; } }
    }
}
