using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.tongculy.row.row
{
    /// <summary>
    /// Chi phí vận chuyển trước thuế
    /// </summary>
    public class CellP : ACell
    {
        public override string UniqueName { get { return "CuocOto_ChiPhiVanChuyenTruocThue"; } }
        public override string Col { get { return "P"; } }
        // Chưa lấy đúng refer cần xác định refer khi có modData
        public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

        public CellP(Row r) : base(r)
        {
        }
    }
}
