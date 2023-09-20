using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.tongculy.row.row
{
    /// <summary>
    /// Chi phí khác
    /// </summary>
    public class CellW : ACell
    {
        public override string UniqueName { get { return "CuocOto_TongCuLy_ChiPhiKhac"; } }
        public override string Col { get { return "W"; } }
        public CellW(Row r) : base(r)
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
