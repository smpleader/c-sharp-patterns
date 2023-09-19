using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.row
{
    /// <summary>
    /// KL Phụ
    /// </summary>
    public class CellL: ACell
    {
        public override string UniqueName { get { return "CongViec_KhoiLuongPhu"; } }
        public override string Col { get { return "L"; } }
        public CellL(Row r) : base(r)
        {
        }
        
        public override void Render()
        {
            base.Render();

        }
        public override void Bind()
        {
            base.Bind();
        }
    }
}
