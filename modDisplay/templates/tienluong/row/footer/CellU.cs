using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.footer
{
    /// <summary>
    /// Tổng thành tiền máy
    /// </summary>
    public class CellU : ACell
    {
        public override string UniqueName { get { return "CongViec_TongThanhTienMay"; } }
        public override string Col { get { return "U"; } }
        public override string[] Params { get { return new string[2] { Row.start.ToString(), Row.end.ToString() }; } }
        public CellU(Footer r) : base(r)
        {
        }
    }
}
