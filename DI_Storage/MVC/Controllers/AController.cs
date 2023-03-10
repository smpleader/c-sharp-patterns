using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DI_Storage.MVC.Views;

namespace DI_Storage.MVC.Controllers
{
    internal class AController : IController
    {
        public virtual string Name { get; }

        protected virtual IView _view { get; set; }

        //TODO: auto create view from DefaultView
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
        /*
         * A Controller should work with any views
        protected virtual string DefaultView { get; }
        protected virtual IView GetView(string name = "")
        {
            if( name == "")
            {
                name = DefaultView;
            }

            if (name == "" || name == null)
            {
                name = Name;
            }

            if (name == "" || name == null)
            {
                throw new InvalidOperationException("Invalid View Name");
            }

            name = "DI_Storage.MVC.Views." + name;
            Type t = Type.GetType(name);
            //MessageBox.Show("Type view is " + t.ToString());
            if (t == null)
            {
                throw new InvalidOperationException("Invalid View Type " + name);
            }

            IView sth = (IView) Activator.CreateInstance(t);
            //MessageBox.Show("View is " + sth.ToString());
            if (null == sth)
            {
                throw new InvalidOperationException("Invalid View " + name);
            }

            return sth;
        }*/
        public virtual void Open()
        {
            Closed = false;
            View.Form.Show();
        }
        public void Close()
        {
            
            Closed = true;;
            View.Form.Hide();
            // THINKING: hide is enough, recreate composed objet is bad
            //View.Close()
            //View.Form.Dispose();
        }
    }
}
