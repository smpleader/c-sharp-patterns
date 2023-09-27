using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.group
{
    /// <summary>
    /// Đơn giá máy
    /// </summary>
    public class CellQ : ACell
    {
        public override string UniqueName { get { return "CongViec_DonGiaMay"; } }
        public override string Col { get { return "Q"; } }
       
        public CellQ(Group r) : base(r)
        {
        }
        public override void Render()
        {
        }
        public override void Bind()
        {
        }
    }
}
