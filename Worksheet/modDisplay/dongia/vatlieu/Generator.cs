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
        public override string Name { get { return "Vật liệu"; } }

        public override void init()
        {
            if (Current.WB[Name] != null)
            {
                ws = Current.WB[Name];

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
