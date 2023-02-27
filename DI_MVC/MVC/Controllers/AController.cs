using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DI_MVC.MVC.Views;

namespace DI_MVC.MVC.Controllers
{
    internal class AController : IController
    {
        public virtual string Name { get; }
        public virtual IView View { get; }
        public void Fire(string command) {
            try
            {
                Type thisType = this.GetType();
                MethodInfo theMethod = thisType.GetMethod(command);
                theMethod.Invoke(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        public void Switch()
        {
            //View.Close();
            View.Form.Visible = false; //Hide();
        }
        /*public void Show()
        {
            View.Form.Show();
            //View.Form.Dispose();
        }*/
        public void Close()
        {
            View.Close();
            View.Form.Dispose();
        }
    }
}
