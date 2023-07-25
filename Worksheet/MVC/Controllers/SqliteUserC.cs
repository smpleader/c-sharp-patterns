using Worksheet.MVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.MVC.Controllers
{
    internal class SqliteUserC : AController
    {
        public override string Name { get { return "SqliteUser"; } }

        protected override IView _view { get; set; } = new SqliteUser();
    }
}
