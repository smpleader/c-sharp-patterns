﻿using DI_Storage.MVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Storage.MVC.Controllers
{
    internal class JsonUserC : AController
    {
        public override string Name { get { return "JsonUser"; } }
        //protected override string DefaultView { get { return "JsonUser"; } }
        protected JsonUser _view = new JsonUser();
        public override IView View { get { return _view;  } }

        /*public override void Open()
        {
            if (Closed)
            {
                _view = new JsonUser();
                Closed = false;
            }
            View.Form.Show();
        }*/
    }
}
