using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modDisplay.Tpl.vatlieu
{
    internal class Generator:ISheet
    {
        public Generator() { }
        string Name { get { return ""; } }

        string head(string name)
        {
            return "";
        }
        string foot(string name)
        {
            return "";
        }
        Dictionary<string, ARow> content(string name)
        {
            Dictionary<string, ARow> r = new Dictionary<string, ARow>();

            return r;
        }
    }
}
