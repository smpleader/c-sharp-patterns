using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.vatlieu.row
{
    public class CellL : ACell
    {
        public override string UniqueName { get { return "VatLieu_CuocBien"; } }
        public override string Col { get { return "L"; } }
        // Chưa lấy đúng refer cần xác định refer khi có modData
        public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

        public CellL(Row r) : base(r)
        {
        }
    }

}
