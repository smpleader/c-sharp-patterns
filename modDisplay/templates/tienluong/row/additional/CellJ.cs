using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.additional
{
    /// <summary>
    /// Cao
    /// </summary>
    public class CellJ : ACell
    {
        public override string UniqueName { get { return "CongViec_Cao"; } }
        public override string Col { get { return "J"; } }
        public CellJ(AdditionalRow r) : base(r)
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
