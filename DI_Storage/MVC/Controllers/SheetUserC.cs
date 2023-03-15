﻿using DI_Storage.MVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Storage.MVC.Controllers
{
    internal class SheetUserC : AController
    {
        public override string Name { get { return "SheetUser"; } }

        protected override IView _view { get; set; } = new SheetUser();
    }
}
