using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeaderRow = modDisplay.templates.tienluong.row.Header;
namespace modDisplay.templates.tienluong
{
    internal class Header : APosition
    {
        public override string Name { get { return "Header"; } }
        public Header(SpreadsheetGrid spreadsheetGrid, IWorksheet worksheet, IWorksheet workingsheet, string hangMucId) : base(spreadsheetGrid, worksheet, workingsheet, hangMucId) { }
        private Dictionary<int, HeaderRow> headers = new Dictionary<int, HeaderRow>();
        public override void bind(bool maskToWorking = true)
        {
            // todo: Lưu giá trị của header tới global state
            headers[2] = new HeaderRow(spreadsheetGrid, masksheet, workingsheet, Display.HangMucId, 2);
            headers[3] = new HeaderRow(spreadsheetGrid, masksheet, workingsheet, Display.HangMucId, 3);
            foreach (var item in headers)
            {
                item.Value.bind();
            }
        }

        public override void render(bool maskToWorking = true)
        {
            // todo: render khi thay đổi tên công trình, hạng mục từ 1 số màn hình khác
            foreach (var item in headers)
            {
                item.Value.render();
            }
        }
    }
}
