using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.row
{
    /// <summary>
    /// Thông tin đơn giá
    /// </summary>
    public class CellY : ACell
    {
        public override string UniqueName { get { return "CongViec_ThongTinDonGia"; } }
        public override string Col { get { return "Y"; } }
        public CellY(Row r) : base(r)
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
