using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modDisplay
{
    internal class Container
    {
        private static Dictionary<string, ITpl> _instances;

        public static ITpl instance(string name)
        {
           return _instances[name];
        }

        private static void data(string name)
        {
            Dictionary<string, string> data = new Dictionary<string, string>()
                {
                    { "giá VL", "giavl"},
                    { "thvl", "thvl"},
                    { "THNC", "thnc"}
            
            };
        }

    }
}
