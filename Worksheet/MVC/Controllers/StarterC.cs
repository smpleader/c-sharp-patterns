using Worksheet.MVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.MVC.Controllers
{
    internal class StarterC : AController
    {
        public override string Name { get { return "Starter"; } }
        protected override IView _view { get; set; } = new Starter();
    }
}
