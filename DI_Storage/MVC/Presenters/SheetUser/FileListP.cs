using DI_Storage.MVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using UserView = DI_Storage.MVC.Views.SheetUser;
using User = DI_Storage.Entities.User.WinForm;
using UserCore = DI_Storage.Entities.User.Schema;
using DI_Storage.MVC.Models;

namespace DI_Storage.MVC.Presenters.SheetUser
{
    internal class FileListP : APresenter<UserView>
    {
        protected UserView _view;
        private SheetUserM model;

        public FileListP(UserView view) : base(view)
        {
            _view = view;
            model = SimpleInjectionDI.container.GetInstance<SheetUserM>();
        } 

        public void SetupCombo()
        {
            _view.comboBox1.DataSource = model.ComboboxList();
        }
    }
}
