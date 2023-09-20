using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.tongculy.row.additional
{
    /// <summary>
    /// Định mức chi phí bốc dỡ
    /// </summary>
    public class CellQ : ACell
    {
        public override string UniqueName { get { return "CuocOto_TongCuLy_DinhMucChiPhiBocDo"; } }
        public override string Col { get { return "Q"; } }
        public CellQ(AdditionalRow r) : base(r)
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
