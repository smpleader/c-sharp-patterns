using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories
{
    class ARow
    {
        // Ordering in a sheet
        public int Id { get; set; }
        // Unique code of an object
        public string Code { get; set; }
        // Search engine
        public string Path { get; set; }

        public Dictionary<string, string> ColText { get; set; }
        public Dictionary<string, decimal> ColNum { get; set; }

        public string? txt(string name, string? str = null)
        {
            if (str == null)
            {
                str = ColNum.ContainsKey(name) ? ColText[name] : "";
            }
            else
            {
                ColText[name] = str;
            }
            return str;
        }
        public decimal? num(string name, decimal? val = null)
        {
            if (val == null)
            {
                val = ColNum.ContainsKey(name) ? ColNum[name] : 0;
            }
            else
            {
                ColNum[name] = (decimal)val;
            }

            return val;
        }

        protected void init()
        {

        }
    }
}
