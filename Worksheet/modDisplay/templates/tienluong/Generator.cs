
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

namespace Worksheet.modDisplay.templates.tienluong
{
    internal class Generator : AGenerator
    {
        public unvell.ReoGrid.Worksheet ws;

        private const int StartIndexRowBody = 6;
        private int EndIndexRowBody = 16;

        public override string Name { get { return "templates/tienluong"; } }

        private Dictionary<int, Header> headers = new Dictionary<int, Header>();
        
        private Dictionary<int, Footer> footers = new Dictionary<int, Footer>();
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
            }
            // footer
            for (int indexRow = EndIndexRowBody; indexRow <= ws.RowCount; indexRow++)
            {
                // Tìm dòng cuối của template
                if ( !IsCellEmptyOrNull(ws, "A" + indexRow))
                {
                    if (CellUtility.ConvertData<string>(ws["A" + indexRow]) == "CỘNG HẠNG MỤC")
                    {
                        EndIndexRowBody = indexRow;
                        footers[indexRow] = new Footer(indexRow);
                        footers[indexRow].start = StartIndexRowBody;
                        footers[indexRow].end = EndIndexRowBody - 1;
                        (footers[indexRow]).bind(ws);
                    }
                }
            }

            // body 
            body = new Body(ws);
            body.start = StartIndexRowBody;
            body.end = EndIndexRowBody - 1;
            body.bind();

            // render
            body.render();
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

        /// <summary>
        /// Kiểm tra cell có null hoặc empty không
        /// </summary>
        /// <param name="worksheet"></param>
        /// <param name="cellAddress"></param>
        /// <returns></returns>
        static bool IsCellEmptyOrNull(unvell.ReoGrid.Worksheet worksheet, string cellAddress)
        {
            var cell = CellUtility.ConvertData<string>(worksheet[cellAddress]) ;
            if (cell == null || cell == "")
            {
                return true;
            }

            return string.IsNullOrEmpty(cell);
        }

    }
}
