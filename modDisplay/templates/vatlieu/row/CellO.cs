using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.vatlieu.row
{
    public class CellO : ACell
    {
        public override string UniqueName { get { return "VatLieu_GiaHienTruong"; } }
        public override string Col { get { return "O"; } }
        public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }
        public CellO(Row r) : base(r)
        {
        }
    }

}
