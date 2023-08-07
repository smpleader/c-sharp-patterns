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
        public override string Name { get { return "dongia/tonghop"; } }

        public override void init(string tabName)
        {
            if (Display.WB[tabName] == null)
            {
                ws = Display.WControl.CreateWorksheet(tabName);
            }
            else 
            { 
                ws = Display.WB[tabName];
                // detach from control, need to add back when save
                Display.WControl.RemoveWorksheet(ws);
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

            // attach to control to save into file
            Display.WControl.AddWorksheet(ws);
        }
        public override void afterSave()
        {
            // detach from control
            Display.WControl.RemoveWorksheet(ws);
        }
    }
}
