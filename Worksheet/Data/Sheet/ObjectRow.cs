using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;

namespace Worksheet.Data.Sheet
{
    internal class ObjectRow : AObjectSheet
    {
        private string col;
        private string referName;

        public ObjectRow(IWorkbook sheet, string objecttype, string start, string end)
        {
            objecttype = objecttype;
            
            range = new SheetRange(start, end);
        }

        public void setValue(List<string> listVal)
        {
            value = listVal;
        }
    }
}
