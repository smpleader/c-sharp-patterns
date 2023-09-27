using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.footer
{
    /// <summary>
    /// Tổng thành tiền nhân công
    /// </summary>
    public class CellT : ACell
    {
        public override string UniqueName { get { return "CongViec_TongThanhTienNhanCong"; } }
        public override string Col { get { return "T"; } }
        public override string[] Params { get { return new string[2] { Row.start.ToString(), Row.end.ToString() }; } }
        public CellT(Footer r) : base(r)
        {
            HasFormula = true;
        }
    }
}
