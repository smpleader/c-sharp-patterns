using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.tongculy.row.row
{
    /// <summary>
    /// Hệ số phương tiện
    /// </summary>
    public class CellJ : ACell
    {
        public override string UniqueName { get { return "CuocOto_LoaiPhuongTien_TongCuLy"; } }
        public override string Col { get { return "J"; } }
        public override string[] Params { get { return new string[2] { Row.Id.ToString(), Row.end.ToString() }; } }

        public CellJ(Row r) : base(r)
        {
        }
    }
}
