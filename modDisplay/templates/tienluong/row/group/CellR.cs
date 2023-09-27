using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.group
{
    /// <summary>
    /// Thành tiền vật liệu
    /// </summary>
    public class CellR : ACell
    {
        public override string UniqueName { get { return "NhomCongViec_ThanhTienVatLieu"; } }
        public override string Col { get { return "R"; } }
        public override string[] Params { get { return new string[2] { Row.start.ToString(), Row.end.ToString() }; } }
        public CellR(Group r) : base(r)
        {
            HasFormula = true;
        }
    }
}
