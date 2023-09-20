using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.loaiphuongtien.row.row
{
    /// <summary>
    /// Số thứ tự
    /// </summary>
    public class CellA : ACell
    {
        public override string UniqueName { get { return "CuocOto_LoaiPhuongTien_SoThuTu"; } }
        public override string Col { get { return "A"; } }
        public CellA(Row r) : base(r)
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
