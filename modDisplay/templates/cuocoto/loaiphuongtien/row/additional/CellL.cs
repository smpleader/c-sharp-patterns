using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.loaiphuongtien.row.additional
{
    /// <summary>
    /// Thành tiền	
    /// </summary>
    public class CellL : ACell
    {
        public override string UniqueName { get { return "CuocOto_LoaiPhuongTien_ThanhTienCuLyNhoHonBang1000M"; } }
        public override string Col { get { return "L"; } }
        public override string[] Params { get { return new string[2] { (Row as AdditionalRow).ParentId.ToString(), Row.Id.ToString() }; } }

        public CellL(AdditionalRow r) : base(r)
        {
        }
    }
}
