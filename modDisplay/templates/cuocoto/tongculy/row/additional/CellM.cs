using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.tongculy.row.additional
{
    /// <summary>
    /// Tổng cự ly
    /// </summary>
    public class CellM : ACell
    {
        public override string UniqueName { get { return "CuocOto_TongCuLy_TongCuLy"; } }
        public override string Col { get { return "M"; } }
        public override string[] Params { get { return new string[2] { Row.Id.ToString(), Row.end.ToString() }; } }
        public CellM(AdditionalRow r) : base(r)
        {
        }
    }
}
