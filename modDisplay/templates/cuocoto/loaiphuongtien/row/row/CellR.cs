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
    public class CellR : ACell
    {
        public override string UniqueName { get { return "CuocOto_LoaiPhuongTien_ThanhTien"; } }
        public override string Col { get { return "R"; } }
        public CellR(Row r) : base(r)
        {
        }
       
        public override void Render()
        {

        }
        public override void Bind()
        {
            base.Bind();
        }
    }
}
