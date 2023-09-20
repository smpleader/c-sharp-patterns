using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.tongculy.row.row
{
    /// <summary>
    /// Tổng cước
    /// </summary>
    public class CellX : ACell
    {
        public override string UniqueName { get { return "CuocOto_TongCuoc"; } }
        public override string Col { get { return "X"; } }
        public override string[] Params { get { return new string[2] { Row.Id.ToString(), Row.end.ToString() }; } }

        public CellX(Row r) : base(r)
        {
        }
    }
}
