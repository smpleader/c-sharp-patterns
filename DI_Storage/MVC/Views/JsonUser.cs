
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DI_Storage.MVC.Views
{
    public partial class JsonUser : AView
    {
        public JsonUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Backbone.Run("Starter");
        }

        private void JsonUser_Load(object sender, EventArgs e)
        { 
            initUserForm();
        }
    }
}
