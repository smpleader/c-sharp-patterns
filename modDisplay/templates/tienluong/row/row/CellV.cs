using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.row
{
    /// <summary>
    /// Hệ số điều chỉnh vật liệu
    /// </summary>
    public class CellV : ACell
    {
        public override string UniqueName { get { return "CongViec_HeSoDieuChinhVatLieu"; } }
        public override string Col { get { return "V"; } }
        public CellV(Row r) : base(r)
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
