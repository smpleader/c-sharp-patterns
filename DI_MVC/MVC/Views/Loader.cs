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
    public partial class Loader : Form, IView
    {
        public Loader()
        {
            InitializeComponent();
            /* Await for some seconds 
             * */
        }
        public string Title { get { return Text; } set { Text = value; } }

        public Form Form { get { return this; } }

        private void Loader_Load(object sender, EventArgs e)
        {
            // Do some check asynchonize:
            // - Crashed file
            // - Setup ready
            // - Library ready
            checkCrash();

            gi
            Thread.Sleep(1000);
            Backbone.Start("Starter");
        }

        private string Msg;

        private void checkCrash()
        {
            ShowAfter("Start Crash Check", 1);
            ShowAfter("Checking Crash..", 2);
            ShowAfter("Nothing Crash!!", 1);
        }

        private void ShowAfter(string msg, int sec) {
            var tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate {
                label1.Text = msg;
            };
            tmr.Interval = (int)TimeSpan.FromMinutes(sec).TotalMilliseconds;
            tmr.Start();
        }
    }
}
