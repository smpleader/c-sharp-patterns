﻿using DI_Storage.MVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Storage.MVC.Controllers
{
    internal class SqliteUserC : AController
    {
        public override string Name { get { return "SqliteUser"; } }

        protected JsonUser _view = new JsonUser();
        public override IView View { get { return _view; } }
    }
}
