using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.loaiphuongtien.row.additional
{
    /// <summary>
    /// Tổng cự ly
    /// </summary>
    public class CellJ : ACell
    {
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
