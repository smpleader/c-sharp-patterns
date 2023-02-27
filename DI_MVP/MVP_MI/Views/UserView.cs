using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI.MVP_MI.Views
{
    public partial class UserView : Form, IView
    {
        private Presenters.PUser _presenter;
        public UserView()
        {
            InitializeComponent();
            _presenter = new Presenters.PUser(this);
        }
        public void JustDoIt(string message)
        {
            label1.Text = message;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var user = _presenter.GetUserModel();
            MessageBox.Show(user.Name);
        }
    }
}
