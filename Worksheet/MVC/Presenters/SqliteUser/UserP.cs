using Worksheet.MVC.Models;
using Worksheet.MVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User = Worksheet.Data.Entities.User.WinForm;
using UserCore = Worksheet.Data.Entities.User.Schema;
using UserView = Worksheet.MVC.Views.SqliteUser;

namespace Worksheet.MVC.Presenters.SqliteUser
{
    internal class UserP : APresenter<UserView>
    {
        private long currentId; 
        private SqliteUserM model;

        private UserView _view;

        public UserP(UserView view) : base(view)
        {
            _view = view;
            model = SimpleInjectionDI.container.GetInstance<SqliteUserM>();
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
            User defaultUsr = new User(model.table().ById("first"));

            _view.comboBox1.DataSource = model.ComboboxList();
            _view.comboBox1.DisplayMember = "ComboBoxDisplay";
            _view.comboBox1.SelectedIndex = _view.comboBox1.FindStringExact(defaultUsr.ComboBoxDisplay);
            bindData(defaultUsr);
        }

        public void Save()
        {
            long Id = model.table().Save(getData());
            MessageBox.Show(Id.ToString());
            User editedUser =   new User(model.table().ById(Id));

            _view.comboBox1.DataSource = null;
            _view.comboBox1.DataSource = model.ComboboxList();
            _view.comboBox1.SelectedIndex = _view.comboBox1.FindStringExact(editedUser.ComboBoxDisplay);
        }
    }
}
