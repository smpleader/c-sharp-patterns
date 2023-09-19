using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.row
{
    /// <summary>
    /// Rộng
    /// </summary>
    public class CellI : ACell
    {
        public override string UniqueName { get { return "CongViec_Rong"; } }
        public override string Col { get { return "I"; } }
        public CellI(Row r) : base(r)
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
