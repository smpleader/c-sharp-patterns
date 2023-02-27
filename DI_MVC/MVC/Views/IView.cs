using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_MVC.MVC.Views
{
    internal interface IView
    {
        string Title { get; set; }

        Form Form { get; }

        void Close();
    }
}
