using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.vatlieu.row
{
    public class CellM : ACell
    {
        public override string UniqueName { get { return "VatLieu_CuocKhac"; } }
        public override string Col { get { return "M"; } }
        public CellM(Row r) : base(r)
        {
        }
        public override void Render()
        {
            // todo: bind data to working sheet
        }
        public override void Bind()
        {
            // todo: bind data to working sheet
        }
    }

}
