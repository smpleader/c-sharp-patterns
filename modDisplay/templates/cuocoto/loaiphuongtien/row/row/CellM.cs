using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.loaiphuongtien.row.row
{
    /// <summary>
    /// Trọng lượng tấn
    /// </summary>
    public class CellM : ACell
    {
        public override string UniqueName { get { return "CuocOto_LoaiPhuongTien_TrongLuongTan"; } }
        public override string Col { get { return "M"; } }
        public CellM(Row r) : base(r)
        {
        }
        public override void Render()
        {

        }
        public override void Bind()
        {

        }
    }
}
