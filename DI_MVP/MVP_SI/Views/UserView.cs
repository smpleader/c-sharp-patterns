using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI.MVP_SI.Views
{
    public partial class UserView : Form, IView
    {
        private Presenters.PMain _presenter;
        public UserView()
        {
            InitializeComponent();
            _presenter = new Presenters.PMain(this);
        }
        public Form Form
        {
            get { return this; }
        }
        public void JustDoIt(string message)
        {
            label1.Text = message;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var user = _presenter.GetUserData();
            MessageBox.Show(user.Name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var post = _presenter.GetPostData();
            MessageBox.Show(post.ToString());
        }
    }
}
