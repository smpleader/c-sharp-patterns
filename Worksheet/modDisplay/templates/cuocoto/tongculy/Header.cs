using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeaderRow = Worksheet.modDisplay.templates.cuocoto.tongculy.row.Header;
namespace Worksheet.modDisplay.templates.cuocoto.tongculy
{
    internal class Header : APosition
    {
        public override string Name { get { return "Header"; } }
        public Header(SpreadsheetGrid spreadsheetGrid, IWorksheet worksheet) : base(spreadsheetGrid, worksheet){ }
        private Dictionary<int, HeaderRow> headers = new Dictionary<int, HeaderRow>();
        public override void bind()
        {
            // todo: Lưu giá trị của header tới global state
            // Tên công trình và hạng mục
            headers[2] = new HeaderRow(spreadsheetGrid, worksheet, 2);
            headers[3] = new HeaderRow(spreadsheetGrid, worksheet, 3);

            // Lương nhân công bốc dỡ
            headers[4] = new HeaderRow(spreadsheetGrid, worksheet, 4);
            // Thuế VAT
            headers[5] = new HeaderRow(spreadsheetGrid, worksheet, 5);
            // Hệ số điều chỉnh
            headers[6] = new HeaderRow(spreadsheetGrid, worksheet, 6);

            foreach (var item in headers)
            {
                item.Value.bind();
            }
        }

        public override void render()
        {
            // todo: render khi thay đổi tên công trình, hạng mục từ 1 số màn hình khác
            foreach (var item in headers)
            {
                item.Value.render();
            }
        }
    }
}
