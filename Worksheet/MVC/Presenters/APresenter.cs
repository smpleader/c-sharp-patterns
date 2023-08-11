using Worksheet.MVC.Models;
using Worksheet.MVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.MVC.Presenters
{
    abstract class APresenter<IView> : IPresenter
    { 
        IView _view;
        public APresenter(IView view)
        {
            _view = view;
        }

        public virtual void init() {  }
    }
}
