using DI_Storage.MVC.Models;
using DI_Storage.MVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User = DI_Storage.Entities.User.WinForm;
using UserCore = DI_Storage.Entities.User.Schema;
using View = DI_Storage.MVC.Views.SqliteUser;

namespace DI_Storage.MVC.Presenters.SqliteUser
{
    internal class UserP
    {
        private long currentId; 
        private SqliteUserM userModel;

        private View _view;

        public UserP(View view)
        {
            _view = view;
            // Notice: do not assign Model here
        }

        public void test()
        {
            _view.SetText("label1", "ehhee");
        }
        public void bindData(User usr)
        {
            _view.SetText("txtName", usr.Name);
            _view.SetText("txtEmail", usr.Email);
            _view.SetText("txtUserName", usr.UserName);
            currentId = usr.Id;
        }

        private UserCore getData()
        {
            // TODO filter value to prevent wrong values
            return new UserCore() { Id = currentId, UserName = _view.GetText("txtUserName"), Name = _view.GetText("txtName"), Email = _view.GetText("txtEmail") };
        }

        public void initUserForm()
        {
            userModel = SimpleInjectionDI.container.GetInstance<SqliteUserM>();

            User defaultUsr = new User(userModel.table().ById("first"));

            _view.comboBox1.DataSource = userModel.ComboboxList();
            _view.comboBox1.DisplayMember = "ComboBoxDisplay";
            _view.comboBox1.SelectedIndex = _view.comboBox1.FindStringExact(defaultUsr.ComboBoxDisplay);
            bindData(defaultUsr);
        }

        public void Save()
        {
            long Id = userModel.table().Save(getData());
            MessageBox.Show(Id.ToString());
            User editedUser =   new User(userModel.table().ById(Id));

            _view.comboBox1.DataSource = null;
            _view.comboBox1.DataSource = userModel.ComboboxList();
            _view.comboBox1.SelectedIndex = _view.comboBox1.FindStringExact(editedUser.ComboBoxDisplay);
        }
    }
}
