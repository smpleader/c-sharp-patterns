using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.row
{
    /// <summary>
    /// Đơn vị
    /// </summary>
    public class CellE : ACell
    {
        public override string UniqueName { get { return "CongViec_DonVi"; } }
        public override string Col { get { return "E"; } }
        public CellE(Row r) : base(r)
        {
        }
        
        public override void Render()
        {
        }
        public override void Bind()
        {
            base.Bind();
        }
    }
}
