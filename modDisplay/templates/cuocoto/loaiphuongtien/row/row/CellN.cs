using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.loaiphuongtien.row.row
{
    /// <summary>
    /// Định mức bốc lên
    /// </summary>
    public class CellN : ACell
    {
        public override string UniqueName { get { return "CuocOto_LoaiPhuongTien_DinhMucBocLen"; } }
        public override string Col { get { return "N"; } }
        public CellN(Row r) : base(r)
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
