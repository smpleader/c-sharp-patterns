using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.loaiphuongtien.row.additional
{
    /// <summary>
    /// Mã vật liệu
    /// </summary>
    public class CellB : ACell
    {
        public override string Col { get { return "B"; } }
        public CellB(AdditionalRow r) : base(r)
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
