using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.row
{
    /// <summary>
    /// Số CK
    /// </summary>
    public class CellG : ACell
    {
        public override string UniqueName { get { return "CongViec_SoCauKien"; } }
        public override string Col { get { return "G"; } }
        public CellG(Row r) : base(r)
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
