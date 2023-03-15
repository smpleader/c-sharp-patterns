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
using DI_Storage.Util;

namespace DI_Storage.MVC.Presenters.SheetUser
{
    internal class SheetP : APresenter<UserView>
    {
        protected UserView _view;
        private SheetUserM model;

        public SheetP(UserView view) : base(view)
        {
            _view = view;
            model = SimpleInjectionDI.container.GetInstance<SheetUserM>();
        }

        public void LoadData()
        {
            if(_view.comboBox1.SelectedValue  != null)
            {
                // TODO check file format
                _view.reoGridControl1.Load(AppConst.dataFolder + "\\" + _view.comboBox1.SelectedValue);
            }
        }


        public void bindData(User usr)
        {
            /*_view.SetText("txtName", usr.Name);
            _view.SetText("txtEmail", usr.Email);
            _view.SetText("txtUserName", usr.UserName);
            currentId = usr.Id;*/
        }

        //private UserCore getData()
        //{
            // TODO filter value to prevent wrong values
            //return new UserCore() { Id = currentId, UserName = _view.GetText("txtUserName"), Name = _view.GetText("txtName"), Email = _view.GetText("txtEmail") };
       // }

        public void initUserForm()
        {
            /*User defaultUsr = new User(model.table().ById("first"));

            _view.comboBox1.DataSource = model.ComboboxList();
            _view.comboBox1.DisplayMember = "ComboBoxDisplay";
            _view.comboBox1.SelectedIndex = _view.comboBox1.FindStringExact(defaultUsr.ComboBoxDisplay);
            bindData(defaultUsr);
            */
        }

        public void Save()
        {
           /* long Id = model.table().Save(getData());
            MessageBox.Show(Id.ToString());
            User editedUser = new User(model.table().ById(Id));

            _view.comboBox1.DataSource = null;
            _view.comboBox1.DataSource = model.ComboboxList();
            _view.comboBox1.SelectedIndex = _view.comboBox1.FindStringExact(editedUser.ComboBoxDisplay);
           */
        }
    }
}
