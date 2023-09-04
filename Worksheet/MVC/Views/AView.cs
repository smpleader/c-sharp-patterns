using Worksheet.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using modData.Drivers;
using System.Security.Policy;
using Worksheet.MVC.Presenters;

namespace Worksheet.MVC.Views
{
    public class AView : Form, IView
    {
        public string Title { get { return Text; } set { Text = value; } }

        public Form Form { get { return this; } }

        public void SetText(string name, string value)
        {
            if(this.Controls[name] == null)
            {
                MessageBox.Show(name + "is not Form Control");
            }
            else
            {
                Control ctn = this.Controls[name];
                ctn.Text = value;
            }
        }
        public string GetText(string name)
        {
            if (this.Controls[name] == null)
            {
                MessageBox.Show(name + "is not Form Control");
                return "";
            }
            else
            {
                Control ctn = this.Controls[name];
                return ctn.Text;
            }
        }
        public void SetValue(string name, string value)
        {
            Control ctn = this.Controls[name];
            ctn.Text = value;
        }
        public string GetValue(string name, string value)
        {
            Control ctn = this.Controls[name];
            return ctn.Text;
        }
        
        public virtual void registerPresenters(bool init){ }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // This is from OS
            // Autosave and clear up ressources
            if (e.CloseReason == CloseReason.WindowsShutDown) { }

            // Prompt user to save his data
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if ( !Backbone.CurrentController().Closed )
                {
                    // Close db connection
                    Sqlite sqlDriver = SimpleInjectionDI.container.GetInstance<Sqlite>();
                    sqlDriver.Disconnect();
                    // Shut down main thread
                    Backbone.Controller("Loader").View.Form.Close();
                }
                else
                {
                    //MessageBox.Show("Continue application");
                }
            }
        }
        /*
        protected override void OnFormClosing( FormClosingEventArgs e)
         { 
             //Dispose();
             MessageBox.Show("closing" + this.GetType().Name);
             Backbone.Stop(Backbone.StopOption.Dispose);
         }
        */

    }
}
