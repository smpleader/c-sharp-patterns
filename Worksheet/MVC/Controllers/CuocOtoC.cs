using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksheet.MVC.Views;

namespace Worksheet.MVC.Controllers
{
    internal class CuocOtoC : AController
    {
        public override string Name { get { return "CuocOto"; } }

        protected override IView _view { get; set; } = new SheetTinhCuocOto();
        public void ShowDialog()
        {
            ((SheetTinhCuocOto)_view).ShowDialog();
        }
    }
}
