using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.row
{
    /// <summary>
    /// Thành tiền vật liệu phụ
    /// </summary>
    public class CellS : ACell
    {
        public override string UniqueName { get { return "CongViec_ThanhTienVatLieuPhu"; } }
        public override string Col { get { return "S"; } }
        public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }
        public CellS(Row r) : base(r)
        {
        }
    }
}
