using DI_MVC.MVC.Controllers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DI_MVC.MVC
{
    internal class Backbone
    {
        public static int count()
        {
            IEnumerable<IController> lc = SimpleInjectionDI.container.GetAllInstances<IController>();
    return lc.Count();
        }
        public static IController? Controller(string name)
        {
            IEnumerable<IController> lc = SimpleInjectionDI.container.GetAllInstances<IController>();
            try
            {
                return lc.FirstOrDefault(x => x.Name == name);
            }
            catch(Exception ex)
            {
                MessageBox.Show("INVALID CONTROLLER: " + ex.Message);
                return null;
            }
        }

        private static string current = "Loader";

        public static void NewThread()
        {    
            Thread th = new Thread(StartCurrentThread);
            th.SetApartmentState(ApartmentState.STA);
            th.Start(); 
        }

        public static void StartCurrentThread()
        {
            Application.Run(Controller(current).View.Form);
        }

        public static void Run(string obj = "Starter", string cmd = "Open")
        {
            var ctrl = (obj == "Loader" ) ? null : Controller(obj);
            if ( null == ctrl)
            {
                MessageBox.Show("Controller not found");
                Application.Exit();
            }
            else
            {
                if ( cmd == "Open")
                {
                    if (current == "Loader" )
                    {
                        Controller(current).View.Form.Hide();
                    }
                    else
                    {
                        Controller(current).Close();
                    }
                    current = ctrl.Name;
                    Controller(current).Open(); 

                }
                else
                {
                    current = ctrl.Name; //ctrl.GetType().Name   
                    ctrl.Fire(cmd);
                }
            }
        }
    }
}
