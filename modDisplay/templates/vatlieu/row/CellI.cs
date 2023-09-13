using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.vatlieu.row
{
    public class CellI : ACell
    {
        public override string UniqueName { get { return "VatLieu_CuocOto"; } }
        public override string Col { get { return "I"; } }
        // Chưa lấy đúng refer cần xác định refer khi có modData
        public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }
        public CellI(Row r) : base(r)
        {
        }
    }

}
