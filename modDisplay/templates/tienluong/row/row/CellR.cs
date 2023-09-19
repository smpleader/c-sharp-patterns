using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.row
{
    /// <summary>
    /// Thành tiền vật liệu
    /// </summary>
    public class CellR : ACell
    {
        public override string UniqueName { get { return "CongViec_ThanhTienVatLieu"; } }
        public override string Col { get { return "R"; } }
        public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }
        public CellR(Row r) : base(r)
        {
        }
    }
}
