using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.vatlieu.row
{
    public class CellG : ACell
    {
        public override string UniqueName { get { return "VatLieu_HeSo"; } }
        public override string Col { get { return "G"; } }
        public CellG(Row r) : base(r)
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
