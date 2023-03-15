using DI_Storage.MVC.Models;
using DI_Storage.MVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Storage.MVC.Presenters
{
    abstract class APresenter<IView>
    { 
        IView _view;
        public APresenter(IView view)
        {
            _view = view;
        }
    }
}
