using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeaderRow = Worksheet.modDisplay.templates.tienluong.row.Header;
namespace Worksheet.modDisplay.templates.tienluong
{
    internal class Header
    {
        public unvell.ReoGrid.Worksheet ws;

        public Header(unvell.ReoGrid.Worksheet worksheet)
        {
            ws = worksheet;
        }
        private Dictionary<int, HeaderRow> headers = new Dictionary<int, HeaderRow>();
        public void bind()
        {
            // todo: Lưu giá trị của header tới global state
            headers[2] = new HeaderRow(2);
            headers[3] = new HeaderRow(3);
            foreach (var item in headers)
            {
                item.Value.bind(ws);
            }
        }

        public void render()
        {
            // todo: render khi thay đổi tên công trình, hạng mục từ 1 số màn hình khác
            foreach (var item in headers)
            {
                item.Value.render(ws);
            }
        }
    }
}
