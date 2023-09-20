using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.loaiphuongtien.row.row
{
    /// <summary>
    /// Tổng cước	
    /// </summary>
    public class CellT : ACell
    {
        public override string UniqueName { get { return "CuocOto_LoaiPhuongTien_TongCuoc"; } }
        public override string Col { get { return "T"; } }
        public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

        public CellT(Row r) : base(r)
        {
        }
    }
}
