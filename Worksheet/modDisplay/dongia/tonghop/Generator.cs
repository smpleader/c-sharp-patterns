using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;
using Worksheet.modData.Memories.Pointer;

namespace Worksheet.modDisplay.dongia.tonghop
{
    internal class Generator : AGenerator
    {
        public unvell.ReoGrid.Worksheet ws;
        public override string Name { get { return "Tong-hop"; } }

        public override void init()
        {
            if (Current.WB[Name] == null)
            {
                ws = Current.WControl.CreateWorksheet(Name);
            }
            else 
            { 
                ws = Current.WB[Name];
                // detach from control, need to add back when save
                Current.WControl.RemoveWorksheet(ws);
            }

            ws.SetCols(5);
            ws.ColumnHeaders[0].Text = "Mã";
            ws.ColumnHeaders[1].Text = "Tên";
            ws.ColumnHeaders[2].Text = "Đơn vị";
            ws.ColumnHeaders[3].Text = "Định mức";
            ws.ColumnHeaders[4].Text = "Giá";
        }

        public override void beforeSave()
        {
            //ws["A1"] = "xxx11x"; test
            Current.WControl.AddWorksheet(ws);
        }
        public override void afterSave()
        {
            Current.WControl.RemoveWorksheet(ws);
        }
    }
}
