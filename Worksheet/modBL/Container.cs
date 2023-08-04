using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksheet.modData.Memories.Pointer;

namespace Worksheet.modBL
{
    internal class Container
    {
        private static Dictionary<string, ICell> _instance = new Dictionary<string, ICell>() {
            {"", new DefaultCell() },
            {"test2", new prime.vatlieu.colA() },
        };

        public static bool exist(string name) { return _instance.ContainsKey(name); }
        public static ICell Get(string name) {  return _instance[name]; }

    }
}
