using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.footer
{
    /// <summary>
    /// Tổng thành tiền vật liệu
    /// </summary>
    public class CellR : ACell
    {
        public override string UniqueName { get { return "CongViec_TongThanhTienVatLieu"; } }
        public override string Col { get { return "R"; } }
        public override string[] Params { get { return new string[2] { Row.start.ToString(), Row.end.ToString() }; } }
        public CellR(Footer r) : base(r)
        {
        }
    }
}
