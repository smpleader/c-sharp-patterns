using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Worksheet.MVC.Presenters.JsonUser;
using User = Worksheet.Data.Entities.User.WinForm;

namespace Worksheet.MVC.Views
{
    public partial class JsonUserPresenter : AView
    {
        // Presenters
        UserFormP uform;

        public JsonUserPresenter()
        {
            InitializeComponent();
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
            uform = new UserFormP(this);
            uform.initUserForm();
        }

    }
}
