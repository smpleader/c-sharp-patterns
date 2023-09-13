using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.vatlieu.row
{
    public class CellF : ACell
    {
        public override string UniqueName { get { return "VatLieu_GiaThongBao"; } }
        public override string Col { get { return "F"; } }
        public CellF(Row r) : base(r)
        {
        }
        public override void Render()
        {
            // todo: bind data to working sheet
        }
        public override void Bind()
        {
            base.Bind();
        }
    }

}
