using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.vatlieu.row
{
    public class CellJ : ACell
    {
        public override string UniqueName { get { return "VatLieu_CuocSong"; } }
        public override string Col { get { return "J"; } }
        // Chưa lấy đúng refer cần xác định refer khi có modData
        public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

        public CellJ(Row r) : base(r)
        {
        }
    }

}
