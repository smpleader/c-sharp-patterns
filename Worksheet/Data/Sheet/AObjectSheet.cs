using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.Data.Sheet
{
    abstract class AObjectSheet
    {
        protected SheetRange range { get; set; }
        protected string objecttype { get; set; }
        protected string id { get; set; }

        protected List<string> value = new List<string>();
        public virtual List<string> getValue()
        {
            return value;
        }
    }
}
