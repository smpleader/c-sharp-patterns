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

        // NOTICE: has to overwrite this function in child
        public virtual void Open()
        {
            // check Closed to reassign view in child
            // if( Closed ) _view = new A_VIEW_TYPE();
            // View.Form.Show();
            MessageBox.Show("You did not overwrite function Open of Controller");
        }
        public void Close()
        {
            
            Closed = true;
            View.Close();
            View.Form.Dispose();
        }
    }
}
