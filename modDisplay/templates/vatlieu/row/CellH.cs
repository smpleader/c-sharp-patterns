using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.vatlieu.row
{
    public class CellH : ACell
    {
        public override string UniqueName { get { return "VatLieu_GiaTBxHS"; } }
        public override string Col { get { return "H"; } }
        public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

        public CellH(Row r) : base(r)
        {
        }
    }

}
