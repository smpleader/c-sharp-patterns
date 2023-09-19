using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.row
{
    /// <summary>
    /// Thành tiền máy
    /// </summary>
    public class CellU : ACell
    {
        public override string UniqueName { get { return "CongViec_ThanhTienMay"; } }
        public override string Col { get { return "U"; } }
        public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }
        public CellU(Row r) : base(r)
        {
        }
    }
}
