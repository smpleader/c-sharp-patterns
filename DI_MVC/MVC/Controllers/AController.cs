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
        public virtual bool Closed { get; set; } = false;
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

        public virtual void Open()
        {
            // TODO: check Closed to reassign view in child
            View.Form.Show();
        }
        public void Close()
        {
            Closed = true;
            View.Close();
            View.Form.Dispose();
        }
    }
}
