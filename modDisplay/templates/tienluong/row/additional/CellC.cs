using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.additional
{
    /// <summary>
    /// MSCV
    /// </summary>
    public class CellC : ACell
    {
        public override string UniqueName { get { return "CongViec_MaSoCongViec"; } }
        public override string Col { get { return "C"; } }
        public CellC(AdditionalRow r) : base(r)
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
