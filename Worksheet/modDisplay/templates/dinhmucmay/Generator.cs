using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksheet.modDisplay.templates.tienluong.dinhmucmay;

namespace Worksheet.modDisplay.templates.dinhmucmay
{ 
    internal class Generator : AGenerator
    {
        public unvell.ReoGrid.Worksheet ws;
        public override string Name { get { return "templates/dinhmucmay"; } }
        Body body { get; set; }

        public override void init(string tabName)
        {
            if (Display.WB[tabName] != null)
            {
                ws = Display.WB[tabName];

                ws.SetCols(11);
                ws.ColumnHeaders[0].Text = "STT";
                ws.ColumnHeaders[1].Text = "Mã máy";
                ws.ColumnHeaders[2].Text = "Tên máy";
                ws.ColumnHeaders[3].Text = "Đơn vị";
                ws.ColumnHeaders[4].Text = "Hao phí";
                ws.ColumnHeaders[5].Text = "Giá gốc";
                ws.ColumnHeaders[6].Text = "Giá TB";
                ws.ColumnHeaders[7].Text = "Giá HT";
                ws.ColumnHeaders[8].Text = "HP khác";
                ws.ColumnHeaders[9].Text = "";
                ws.ColumnHeaders[10].Text = "Hao phí gốc";// ẩn không hiển thị
            }
        }

        public override void loadData()
        {
            body = new Body(ws);
            body.bind();
            body.render();
        }

        public override void selectCell()
        {
            switch (Display.Col)
            {
                case "D":
                    Display.Cell.IsReadOnly = true;
                    break;
            }
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
