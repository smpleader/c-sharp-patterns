using DI_Storage.MVC.Presenters.SqliteUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User = DI_Storage.Entities.User.WinForm;

namespace DI_Storage.MVC.Views
{
    public partial class SqliteUser : AView
    {
        // Presenters
        UserP uform;
        public SqliteUser()
        {
            InitializeComponent();
            uform = new UserP(this);
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

        private void SqliteUser_Load(object sender, EventArgs e)
        {
            uform.initUserForm();
        }

    }
}
