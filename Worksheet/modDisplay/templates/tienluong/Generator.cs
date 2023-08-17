
using System.Security.Cryptography;
using Worksheet.modData.Memories;
using Worksheet.modData;
using Worksheet.modData.Memories.Pointer;
using unvell.ReoGrid.Utility;
using System.Configuration;
using System.Collections.Generic;
using unvell.ReoGrid;
using Worksheet.modDisplay.templates.tienluong.row;
using Microsoft.Office.Interop.Excel;
using System.Windows.Documents;

namespace Worksheet.modDisplay.templates.tienluong
{
    internal class Generator : AGenerator
    {
        public unvell.ReoGrid.Worksheet ws;

        private const int StartIndexRowBody = 6;
        private int EndIndexRowBody = 16;

        public override string Name { get { return "templates/tienluong"; } }

        private Dictionary<int, Header> headers = new Dictionary<int, Header>();
        
        Footer footer;
        private Body body;

        public override void init(string tabName)
        {
            if (Display.WB[tabName] != null)
            {
                ws = Display.WB[tabName];
            }
        }

        public override void addMenu()
        {
            Display.menuItems = new ToolStripItemCollection(Display.contextMenu,
                new ToolStripItem[]{
                    new ToolStripMenuItem("Congviec 2"),
                });
        }
        public override void loadData()
        {
            DangThemCongViec = true;
            ws.HideColumns(5, 7);
            // bind

            // header
            headers[2] = new Header(2);
            headers[3] = new Header(3);
            foreach(var item in headers)
            {
                item.Value.bind(ws);
                item.Value.render(ws);
            }

            // body 
            body = new Body(ws);
            body.end = EndIndexRowBody - 1;
            body.bind();
            body.render();

            // footer
            footer = new Footer();
            footer.bind(ws);
            footer.render(ws);

            DangThemCongViec = false;
        }
        public void updateData()
        {
            // thêm công việc vào dòng đang chọn
            int selectedIndexRow = Display.Row;
            if (selectedIndexRow >= StartIndexRowBody && selectedIndexRow <= EndIndexRowBody)
            {
                // bắt đầu thêm công việc
                DangThemCongViec = true;
                body.rows[selectedIndexRow] = new Row(selectedIndexRow);
                Row selectedRow = body.rows[selectedIndexRow];
                selectedRow.AddSimpleData(ws);
            }

            body.bind();
            body.render();

            DangThemCongViec = false;
        }
       
        public override void selectCell()
        {
            switch (Display.Col)
            {
                case "B":
                    if (!(body.groups.Keys.Contains(Display.Row)))
                    {
                        Display.Cell.IsReadOnly = true;
                    }
                    break;
                case "R":
                case "S":
                case "T":
                case "U":
                    Display.Cell.IsReadOnly = true;
                    break;
            }
        }
        bool DangThemCongViec = false;
        public override void cellDataChanged()
        {
            if (!DangThemCongViec)
            {
                DangThemCongViec = true;
                body.bind();
                body.render();
                DangThemCongViec = false;
            }
        }

    }
}
