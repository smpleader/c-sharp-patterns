using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksheet.MVC.Controllers;
using Worksheet.MVC.Views;

namespace Worksheet.MVC.Presenters
{
    internal class Publisher
    {
        static Dictionary<string, IPresenter> _registers = new Dictionary<string, IPresenter>();
        static Dictionary<string, string> _map = new Dictionary<string, string>();
        public static void register(string uniquename, string controllername)
        {
            _map[uniquename] = controllername;
        }
        public static void register(string uniquename, IPresenter p)
        {
            if( _registers.ContainsKey(uniquename) )
            {
                throw new Exception("The presenter "+ uniquename +" existed");
            }
            _registers[uniquename] = p;
        }
        public static IPresenter get(string name)
        {
            if (!_registers.ContainsKey(name))
            {
                if (!_map.ContainsKey(name))
                {
                    throw new Exception("Invalid alias presenter name");
                }

                Backbone.Controller(_map[name]).View.registerPresenters(false);
            }

            if (!_registers.ContainsKey(name))
            {
                throw new Exception("Presenter " +name+" not found");
            }
            
            return _registers[name];
        }
    }
}
