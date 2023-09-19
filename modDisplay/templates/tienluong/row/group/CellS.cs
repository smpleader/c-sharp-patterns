using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.group
{
    /// <summary>
    /// Thành tiền vật liệu phụ
    /// </summary>
    public class CellS : ACell
    {
        public override string UniqueName { get { return "NhomCongViec_ThanhTienVatLieuPhu"; } }
        public override string Col { get { return "S"; } }
        public override string[] Params { get { return new string[2] { Row.start.ToString(), Row.end.ToString() }; } }
        public CellS(Group r) : base(r)
        {
        }
    }
}
