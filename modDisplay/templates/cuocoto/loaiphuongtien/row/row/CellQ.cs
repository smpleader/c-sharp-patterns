using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.loaiphuongtien.row.row
{
    /// <summary>
    /// Định mức hao hụt
    /// </summary>
    public class CellQ : ACell
    {
        public override string UniqueName { get { return "CuocOto_LoaiPhuongTien_DinhMucHaoHut"; } }
        public override string Col { get { return "Q"; } }
        public CellQ(Row r) : base(r)
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
