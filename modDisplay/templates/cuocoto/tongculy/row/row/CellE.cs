using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.tongculy.row.row
{
    /// <summary>
    /// Khối lượng đơn vị
    /// </summary>
    public class CellE : ACell
    {
        public override string UniqueName { get { return "CuocOto_TongCuLy_KhoiLuongDonVi"; } }
        public override string Col { get { return "E"; } }
        public CellE(Row r) : base(r)
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
