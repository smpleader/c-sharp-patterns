using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.loaiphuongtien.row.row
{
    /// <summary>
    /// Đơn vị nhóm hàng	
    /// </summary>
    public class CellF : ACell
    {
        public override string UniqueName { get { return "CuocOto_LoaiPhuongTien_DonViNhomHang"; } }
        public override string Col { get { return "F"; } }
        public CellF(Row r) : base(r)
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
