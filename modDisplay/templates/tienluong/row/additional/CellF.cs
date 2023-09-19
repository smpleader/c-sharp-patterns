using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.additional
{
    /// <summary>
    /// Tên CK
    /// </summary>
    public class CellF : ACell
    {
        public override string UniqueName { get { return "CongViec_TenCauKien"; } }
        public override string Col { get { return "F"; } }
        public CellF(AdditionalRow r) : base(r)
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
