using DI_Storage.MVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Storage.MVC.Controllers
{
    internal class UserC : AController
    {
        public override string Name { get { return "User"; } }
        private User _view = new User();
        public override IView View { get { return _view;  } }

        public override void Open()
        {
            if (Closed) _view = new User();
            View.Form.Show();
        }
    }
}
