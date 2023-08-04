using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;
using Worksheet.modBL.prime.vatlieu;
using Worksheet.modData.Memories.Pointer;

namespace Worksheet.modDisplay
{
    internal class Display
    {
        private static Dictionary<string, ISheet> _instances = new Dictionary<string, ISheet>()
                {
                    {"default", new AGenerator()  },
                    {"dg/congviec", new dongia.congviec.Generator()  },
                    {"dg/vatlieu", new dongia.vatlieu.Generator()  },
                    {"dg/tonghop", new dongia.tonghop.Generator()  },
                    { "DG", new input_data1.vatlieu.Generator() },
                    { "thvl", new input_data1.vatlieu.Generator()},
                    { "THNC", new input_data1.vatlieu.Generator()}
                };

        static string[] activates;

        public static ISheet tab(string name)
        {
           return _instances.ContainsKey(name) ? _instances[name] : _instances["default"];
        }

        public static void setup(unvell.ReoGrid.ReoGridControl control, string[] str)
        {
            Current.WControl = control;
            Current.WB = control.Worksheets;

            activates = str;

            foreach (string s in str) {
                tab(s).init();
            }
        }

        public Dictionary<String, String> State = new Dictionary<String, String>();
        public string state(string key, string? val = null)
        {
            if(null == val)
            {
                val = null == State[key] ? "- not found -" : State[key];
            }
            return val;
        }

        public static void hook(string name)
        {
            switch (name)
            {
                case "beforeSave":
                case "BeforeSave":

                    foreach (string s in activates)
                    {
                        tab(s).beforeSave();
                    };
                    break;
                case "afterSave":
                case "AfterSave":

                    foreach (string s in activates)
                    {
                        tab(s).afterSave();
                    };
                    break;
                case "selectCell":
                case "SelectCell":

                    Current.Col = new string(Current.Cell.Address.ToString().Where(chr => Char.IsLetter(chr)).ToArray());
                    Current.Row = Int32.Parse(new String(Current.Cell.Address.ToString().Where(chr => Char.IsDigit(chr)).ToArray()));

                    foreach (string s in activates)
                    {
                        if(  tab(s).Name == Current.WControl.CurrentWorksheet.Name)
                        {
                            tab(s).selectCell();
                            return;
                        }
                    };
                    break;
                case "afterCellInput":
                case "AfterCellInput":
                    foreach (string s in activates)
                    {
                        if (tab(s).Name == Current.WControl.CurrentWorksheet.Name)
                        {
                            tab(s).afterCellInput();
                            return;
                        }
                    };
                    break;
            }
        }
    }
}
