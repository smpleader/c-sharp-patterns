using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.tongculy.row.additional
{
    /// <summary>
    /// Định mức hao hụt
    /// </summary>
    public class CellU : ACell
    {
        public override string UniqueName { get { return "CuocOto_TongCuLy_DinhMucHaoHut"; } }
        public override string Col { get { return "U"; } }
        public CellU(AdditionalRow r) : base(r)
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
