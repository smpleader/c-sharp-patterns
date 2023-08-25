
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
using HeaderGroup = Worksheet.modDisplay.templates.tienluong.Header;
using FooterGroup = Worksheet.modDisplay.templates.tienluong.Footer;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;

namespace Worksheet.modDisplay.templates.tienluong
{
    internal class Generator : AGenerator
    {
        public override string Name { get { return "templates/tienluong"; } }
        public SpreadsheetGrid ws;
        public IWorksheet worksheet;

        bool DangThemCongViec = false;
        HeaderGroup header;
        FooterGroup footer;
        Body body;

        public override void init(string tabName)
        {
            if (Display.WorkSheets[tabName] != null)
            {
                worksheet = Display.WorkSheets[tabName];
                ws = Display.WS;
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
            //DangThemCongViec = true;
            ws.ColumnWidths.SetHidden(6, 12, true);
            // bind

            // header
            header = new HeaderGroup(ws,worksheet);
            header.bind();
            header.render();

            // footer
            footer = new FooterGroup(ws, worksheet);
            footer.bind();
            footer.render();

            // body 
            body = new Body(ws, worksheet);
            body.end = footer.Id - 1;
            body.bind();
            body.render();

            //DangThemCongViec = false;
        }
        public void updateData()
        {
            // thêm công việc vào dòng đang chọn
            int selectedIndexRow = Display.Row;
            if (selectedIndexRow >= body.start && selectedIndexRow <= body.end)
            {
                // bắt đầu thêm công việc
                //DangThemCongViec = true;
                body.rows[selectedIndexRow] = new Row(ws, worksheet, selectedIndexRow);
                Row selectedRow = body.rows[selectedIndexRow];
                selectedRow.AddSimpleData();
                body.bind();
                body.render();

                //DangThemCongViec = false;
            }
        }
       
        public override void selectCell()
        {
            switch (Display.Col)
            {
                case "B":
                    if (!(body.groups.Keys.Contains(Display.Row)))
                    {
                        //Display.Cell.IsReadOnly = true;
                    }
                    break;
                case "R":
                case "S":
                case "T":
                case "U":
                    //Display.Cell.IsReadOnly = true;
                    break;
            }
        }
        public override void cellDataChanged()
        {
            if (!DangThemCongViec)
            {
                //DangThemCongViec = true;
                body.bind();
                body.render();
                //DangThemCongViec = false;
            }
        }
    }
}
