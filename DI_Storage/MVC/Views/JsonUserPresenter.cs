using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DI_Storage.MVC.Presenters.JsonUser;
using User =  DI_Storage.Entities.User.WinForm;

namespace DI_Storage.MVC.Views
{
    public partial class JsonUserPresenter : AView
    {
        // Presenters
        UserFormP uform;

        public JsonUserPresenter()
        {
            InitializeComponent();
            uform = new UserFormP(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Backbone.Run("Starter");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uform.Save();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;
            var b = (User)comboBox1.SelectedItem;
            uform.bindData(b);
        }

        private void JsonUserPresenter_Load(object sender, EventArgs e)
        {
            uform.initUserForm();
        }

    }
}
