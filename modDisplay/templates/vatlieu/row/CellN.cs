using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.vatlieu.row
{
    public class CellN : ACell
    {
        public override string UniqueName { get { return "VatLieu_TongCuoc"; } }
        public override string Col { get { return "N"; } }
        public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

        public CellN(Row r) : base(r)
        {
        }
    }

}
