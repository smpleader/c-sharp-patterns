using DI_Storage.MVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Storage.MVC.Controllers
{
    internal class PostC : AController
    {
        public string Name { get { return "Post"; } }
        private User _view;
        public IView View { get { return _view;  } }
        //public PostC(User aView) : base( aView) { _view = aView; }
    }
}
