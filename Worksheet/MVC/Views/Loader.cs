using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worksheet.MVC.Views
{
    public partial class Loader : Form, IView
    {
        public Loader()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }
        public string Title { get { return Text; } set { Text = value; } }

        public Form Form { get { return this; } }

        private async void Loader_Load(object sender, EventArgs e)
        {
            // Do some check asynchonize:

            //await checkCrash();
            //await checkSetup();
            await Task.Delay(1000);
            Backbone.Run("SheetDemo");
        }

        private async Task checkCrash()
        {
            label1.Text = "Start Crash Check..";
            await Task.Delay(3000);
            label1.Text = "Nothing Crash!!";
        }

        private async Task checkSetup()
        {
            // WARNING: this demo for a new thread, which won't use current object access
            await Task.Run(() =>
            {
                // new thread here
                // THIS DO NOT SUPPORT CLOSURE !!!!
            });
        }

    }
}
