using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worksheet.MVC.Views.BE
{
    public partial class ResourceForm : AView
    {
        public ResourceForm()
        {
            InitializeComponent();
        }

        private void ResourceForm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            // Code
        }
    }
}
