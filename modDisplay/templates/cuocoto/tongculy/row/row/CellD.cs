using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.tongculy.row.row
{
    /// <summary>
    /// Đơn vị
    /// </summary>
    public class CellD : ACell
    {
        public override string UniqueName { get { return "CuocOto_TongCuLy_DonVi"; } }
        public override string Col { get { return "D"; } }
        public CellD(Row r) : base(r)
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
