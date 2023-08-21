using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;
using Row = Worksheet.modData.Memories.ARecord;

namespace Worksheet.modDisplay
{
    class ARowObject: Row
    {
        public unvell.ReoGrid.Worksheet ws;
        public int start { get; set; }
        public int end { get; set; }
        public int height { get { return end - start; } }
        public void import(int s, int e)
        {
            // todo : asign column from worksheet
        }
      
        public virtual string GetFormula(string col)
        {
            return "";
        }
        public Cell GetCell(string col)
        {
            Cell cell = ws.Cells[col + Id];
            return cell;
        }
    }
}
