using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksheet.MVC.Views;

namespace Worksheet.MVC.Controllers
{
    internal class TienLuongC : AController
    {
        public override string Name { get { return "TienLuong"; } }

        protected override IView _view { get; set; } = new SheetTienLuong();
    }

}
