using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.tongculy.row.additional
{
    /// <summary>
    /// Đơn giá cước nâng hạ
    /// </summary>
    public class CellR : ACell
    {
        public override string UniqueName { get { return "CuocOto_TongCuLy_CuocNangHa"; } }
        public override string Col { get { return "R"; } }
        public CellR(AdditionalRow r) : base(r)
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
