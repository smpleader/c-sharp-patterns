using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.additional
{
    /// <summary>
    /// STT
    /// </summary>
    public class CellB : ACell
    {
        public override string UniqueName { get { return "CongViec_SoThuTu"; } }
        public override string Col { get { return "B"; } }
        public CellB(AdditionalRow r) : base(r)
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
