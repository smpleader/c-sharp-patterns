using DI_Storage.MVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_Storage.MVC.Views
{
    public partial class JsonUser : AView
    {
        public JsonUser()
        {
            InitializeComponent();
            startup();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Backbone.Run("Starter");
        }
        private void startup()
        {
            label1.Text = JsonUserM.GetInfo();
        }
    }
}
