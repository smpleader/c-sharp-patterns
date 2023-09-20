using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.tongculy.row.additional
{
    /// <summary>
    /// Giá thông báo
    /// </summary>
    public class CellT : ACell
    {
        public override string UniqueName { get { return "CuocOto_TongCuLy_GiaThongBao"; } }
        public override string Col { get { return "T"; } }
        public CellT(AdditionalRow r) : base(r)
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
