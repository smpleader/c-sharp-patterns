using Worksheet.MVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.MVC.Controllers
{
    internal class SheetDemoC : AController
    {
        public override string Name { get { return "SheetDemo"; } }

        protected override IView _view { get; set; } = new SheetDemo();
    }
}
