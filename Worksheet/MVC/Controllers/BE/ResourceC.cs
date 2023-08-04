using Worksheet.MVC.Views;
using Worksheet.MVC.Views.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.MVC.Controllers.BE
{
    internal class ResourceC : AController
    {
        public override string Name { get { return "ResourceForm"; } }

        protected override IView _view { get; set; } = new ResourceForm();
    }
}
