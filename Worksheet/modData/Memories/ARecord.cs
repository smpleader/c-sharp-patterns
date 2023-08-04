using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories
{
    public class ARecord
    {
        // Unique ID of a row
        public virtual int Id { get; set; }
        // Unique code of an object, can be duplicated
        public virtual string Code { get; set; }
        // Search engine
        public virtual string Path { get; }

        public virtual Dictionary<string, string> ColText { get; set; } = new Dictionary<string, string>();
        public virtual Dictionary<string, decimal> ColNum { get; set; } = new Dictionary<string, decimal>();

        public string txt(string name)
        {
            return ColText.ContainsKey(name) ? ColText[name] : "-"; 
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

        public virtual void init() { }
    }
}
