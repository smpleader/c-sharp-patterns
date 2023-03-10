using DI_Storage.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DI_Storage.MVC.Models;
using User = DI_Storage.Entities.User.WinForm;
using UserCore = DI_Storage.Entities.User.Core;
using DI_Storage.MVC.Views;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DI_Storage.MVC.Presenters.JsonUser
{
    internal class UserFormP
    {
        private int currentId;
        private TestM testModel;
        private JsonUserM userModel;

        private JsonUserPresenter _view;

        public UserFormP(JsonUserPresenter view)
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
            testModel = SimpleInjectionDI.container.GetInstance<TestM>();
            userModel = SimpleInjectionDI.container.GetInstance<JsonUserM>();

            User defaultUsr = new User( userModel.db().ById("first") );

            _view.comboBox1.DataSource = userModel.ComboboxList();
            _view.comboBox1.DisplayMember = "ComboBoxDisplay";
            _view.comboBox1.SelectedIndex = _view.comboBox1.FindStringExact(defaultUsr.ComboBoxDisplay);
            bindData(defaultUsr);
        }

        public void Save()
        {
            User editedUser = new User(userModel.db().Save(getData()));

            MessageBox.Show("Saved: " + editedUser.ToString());
            _view.comboBox1.DataSource = null;
            _view.comboBox1.DataSource = userModel.ComboboxList();
            _view.comboBox1.SelectedIndex = _view.comboBox1.FindStringExact(editedUser.ComboBoxDisplay);
        }
    }
}
