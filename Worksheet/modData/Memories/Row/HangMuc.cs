using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modData.Memories.Row
{
    internal class HangMuc : ARow
    {
        public HangMuc(int index)
        {
            Path = "HangMuc." + index;
            Index = index;

            ColText["kieuhangmuc"] = "";
        }
    }
}