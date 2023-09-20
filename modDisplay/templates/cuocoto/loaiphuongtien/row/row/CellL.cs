using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.loaiphuongtien.row.row
{
    /// <summary>
    /// Thành tiền	
    /// </summary>
    public class CellL : ACell
    {
        public override string UniqueName { get { return "CuocOto_LoaiPhuongTien_ThanhTienChiPhiVanChuyen"; } }
        public override string Col { get { return "L"; } }
        public override string[] Params { get { return new string[2] { Row.Id.ToString(), Row.end.ToString() }; } }

        public CellL(Row r) : base(r)
        {
        }
    }
}
