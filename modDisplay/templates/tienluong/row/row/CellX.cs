using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.row
{
    /// <summary>
    /// Hệ số điều chỉnh máy
    /// </summary>
    public class CellX : ACell
    {
        public override string UniqueName { get { return "CongViec_HeSoDieuChinhMay"; } }
        public override string Col { get { return "X"; } }
        public CellX(Row r) : base(r)
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
