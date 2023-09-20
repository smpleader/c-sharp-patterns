using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.tongculy.row.additional
{
    /// <summary>
    /// Phương tiện
    /// </summary>
    public class CellI : ACell
    {
        public override string UniqueName { get { return "CuocOto_TongCuLy_PhuongTien"; } }
        public override string Col { get { return "I"; } }
        public CellI(AdditionalRow r) : base(r)
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
