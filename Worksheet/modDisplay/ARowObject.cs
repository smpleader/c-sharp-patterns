using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Row = Worksheet.modData.Memories.ARecord;

namespace Worksheet.modDisplay
{
    class ARowObject: Row
    {
        public int start { get; set; }
        public int end { get; set; }
        public int height { get { return end - start; } }
        public void import(int s, int e)
        {
            // todo : asign column from worksheet
        }
    }
}
