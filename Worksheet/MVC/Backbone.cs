using Worksheet.MVC.Controllers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Worksheet.MVC
{
    internal class Backbone
    {
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
            try
            {
                Application.Run(CurrentController().View.Form);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                        CurrentController().View.Form.Hide();
                    }
                    else
                    {
                        CurrentController().Close();
                    }
                    current = ctrl.Name;
                    CurrentController().Open(); 

                }
                else
                {
                    current = ctrl.Name; //ctrl.GetType().Name   
                    ctrl.Fire(cmd);
                }
            }
        }

        public enum StopOption
        {
            Close,
            Dispose,
            Exit
        }

        public static void Stop(StopOption opt)
        {
            switch(opt)
            {
                default:
                case StopOption.Exit:
                    // This close all methods, Form.Closed + Form.Closing not being fired
                    Application.Exit();
                    break;
                case StopOption.Close:
                    // If we are going to reuse the object
                    CurrentController().View.Form.Hide();
                    break;
                case StopOption.Dispose:
                    // If we are going to free up the resource the object
                    CurrentController().Close();
                    break;
            }
        }

        public static IController CurrentController()
        {
            IController? c = Controller(current);
            if( c == null)
            {
                MessageBox.Show("System Error: Controller not ready");
                Application.Exit();
            }
            return c;
        }
    }
}
