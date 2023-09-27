using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.group
{
    /// <summary>
    /// Thành tiền máy
    /// </summary>
    public class CellU : ACell
    {
        public override string UniqueName { get { return "NhomCongViec_ThanhTienMay"; } }
        public override string Col { get { return "U"; } }
        public override string[] Params { get { return new string[2] { Row.start.ToString(), Row.end.ToString() }; } }
        public CellU(Group r) : base(r)
        {
            HasFormula = true;
        }
    }
}
