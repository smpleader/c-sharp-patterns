using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.tongculy.row.additional
{
    /// <summary>
    /// Hệ số phương tiện
    /// </summary>
    public class CellJ : ACell
    {
        public override string UniqueName { get { return "CuocOto_TongCuLy_HeSoPhuongTien"; } }
        public override string Col { get { return "J"; } }
        public CellJ(AdditionalRow r) : base(r)
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
