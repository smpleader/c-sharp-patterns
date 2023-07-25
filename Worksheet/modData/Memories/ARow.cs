using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories
{
    class ARow
    {
        public ARow() { init(); }
        // Unique ID of a row
        public int Id { get; set; }
        // Unique code of an object, can be duplicated
        public string Code { get; set; }
        // Search engine
        public string Path { get; set; }

        public Dictionary<string, string> ColText { get; set; }
        public Dictionary<string, decimal> ColNum { get; set; }

        public string txt(string name)
        {
            return ColNum.ContainsKey(name) ? ColText[name] : "-"; 
        }

        public void txt(string name, string str)
        {
            ColText[name] = str;
        }
        public decimal num(string name)
        {
            return ColNum.ContainsKey(name) ? ColNum[name] : -1;
        }
        public void num(string name, decimal val)
        {
            ColNum[name] = val; 
        }

        protected void init() { }
    }
}
