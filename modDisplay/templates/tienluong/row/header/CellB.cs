using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.header
{
    public class CellB : ACell
    {
        public override string UniqueName { get { return "TieuDe"; } }
        public override string Col { get { return "B"; } }
        public CellB(Header r) : base(r)
        {
        }
        public override void Render()
        {
        }
        public override void Bind()
        {
            base.Bind();
            // todo: cập nhật tiêu đề tên công trình, tên hạng mục ở tất cả sheet
        }
    }
}
