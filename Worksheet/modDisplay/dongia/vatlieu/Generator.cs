using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;
using Worksheet.modData.Memories.Pointer;

namespace Worksheet.modDisplay.dongia.vatlieu
{
    internal class Generator : AGenerator
    {
        public unvell.ReoGrid.Worksheet ws;
        public override string Name { get { return "dongia/vatlieu"; } }

        public override void init(string tabName)
        {
            if (Display.WB[tabName] != null)
            {
                ws = Display.WB[tabName];

                ws.SetCols(5);
                ws.ColumnHeaders[0].Text = "Mã";
                ws.ColumnHeaders[1].Text = "Tên";
                ws.ColumnHeaders[2].Text = "Đơn vị";
                ws.ColumnHeaders[3].Text = "Định mức";
                ws.ColumnHeaders[4].Text = "Giá";
            }
        }
    }
}
