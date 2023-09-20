using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.loaiphuongtien.row.row
{
    /// <summary>
    /// Mã vật liệu
    /// </summary>
    public class CellB : ACell
    {
        public override string UniqueName { get { return "CuocOto_LoaiPhuongTien_MaVatLieu"; } }
        public override string Col { get { return "B"; } }
        public CellB(Row r) : base(r)
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
