using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.loaiphuongtien.row.row
{
    /// <summary>
    /// Loại phương tiện
    /// </summary>
    public class CellI : ACell
    {
        public override string UniqueName { get { return "CuocOto_LoaiPhuongTien_LoaiPhuongTien"; } }
        public override string Col { get { return "I"; } }
        public CellI(Row r) : base(r)
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
