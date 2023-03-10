using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI_Storage.MVC.Models;
using DI_Storage.Entities;

namespace DI_Storage.MVC.Views
{
    partial class JsonUser : AView
	{
		private int currentId;
		private TestM testModel;
		private JsonUserM userModel;
        private void bindData(User usr)
		{
			txtEmail.Text = usr.Email;
			txtName.Text = usr.Name;
			txtUserName.Text = usr.UserName;
            currentId = usr.Id;
        }

		private User getData()
		{
			// TODO filter value to prevent wrong values
			return new User() { Id = currentId, UserName = txtUserName.Text, Name = txtName.Text,  Email = txtEmail.Text };
		}

		private void initUserForm()
        {
            testModel = SimpleInjectionDI.container.GetInstance<TestM>();
            userModel = SimpleInjectionDI.container.GetInstance<JsonUserM>();

            User defaultUsr = userModel.db().ById("first");
			

            comboBox1.DataSource = userModel.ComboboxList();
            comboBox1.DisplayMember = "ComboBoxDisplay";
			comboBox1.SelectedIndex = comboBox1.FindStringExact(defaultUsr.ComboBoxDisplay);
            bindData(defaultUsr);
        }
		private void initComboBox(User usr)
        {
            List<User> users = userModel.db().List();

        }

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.SelectedItem == null) return;
			var b = (User)comboBox1.SelectedItem;
			bindData(b); 
		}

        private void btnSave_Click(object sender, EventArgs e)
        {
			User editedUser = userModel.db().Save(getData());

			MessageBox.Show("Saved: "+ editedUser.ToString());
            comboBox1.DataSource = null;
			comboBox1.DataSource = userModel.ComboboxList();
            comboBox1.SelectedIndex = comboBox1.FindStringExact(editedUser.ComboBoxDisplay);

        }
    }
}
