using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksheet.MVC.Views;

namespace Worksheet.MVC.Controllers
{
    internal class SyncfusionC : AController
    {
        public override string Name { get { return "DemoSyncfusion"; } }

        protected override IView _view { get; set; } = new SheetSyncfusion();
    }
}
