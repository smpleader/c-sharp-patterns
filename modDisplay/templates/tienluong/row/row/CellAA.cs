using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.row
{
    /// <summary>
    /// Tổng giá của tất cả các vật liệu phụ
    /// </summary>
    public class CellAA : ACell
    {
        public override string UniqueName { get { return "CongViec_TongGiaTienCuaTatCaCacVatLieuPhu"; } }
        public override string Col { get { return "AA"; } }
        public CellAA(Row r) : base(r)
        {
        }
        public override void Render()
        {
        }
        public override void Bind()
        {
            base.Bind();
        }
    }
}
