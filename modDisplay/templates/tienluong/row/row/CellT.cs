using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.row
{
    /// <summary>
    /// Thành tiền nhân công
    /// </summary>
    public class CellT : ACell
    {
        public override string UniqueName { get { return "CongViec_ThanhTienNhanCong"; } }
        public override string Col { get { return "T"; } }
        public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }
        public CellT(Row r) : base(r)
        {
        }
    }
}
