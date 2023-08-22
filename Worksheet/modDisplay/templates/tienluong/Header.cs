using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeaderRow = Worksheet.modDisplay.templates.tienluong.row.Header;
namespace Worksheet.modDisplay.templates.tienluong
{
    internal class Header : APosition
    {
        public override string Name { get { return "Header"; } }
        public Header(unvell.ReoGrid.Worksheet worksheet) : base(worksheet) { }
        private Dictionary<int, HeaderRow> headers = new Dictionary<int, HeaderRow>();
        public override void bind()
        {
            // todo: Lưu giá trị của header tới global state
            headers[2] = new HeaderRow(ws,2);
            headers[3] = new HeaderRow(ws, 3);
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
