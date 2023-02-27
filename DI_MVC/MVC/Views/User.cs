using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_MVC.MVC.Views
{
    public partial class User : Form, IView
    {
        public User()
        {
            InitializeComponent();
        }

        public string Title { get { return Text; } set { Text = value; } }

        public Form Form { get { return this; } }


        private void button1_Click(object sender, EventArgs e)
        {
            Backbone.Start("Starter"); 
        }
    }
}
