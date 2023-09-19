using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.row
{
    /// <summary>
    /// HS phụ
    /// </summary>
    public class CellK : ACell
    {
        public override string UniqueName { get { return "CongViec_HeSoPhu"; } }
        public override string Col { get { return "K"; } }
        public CellK(Row r) : base(r)
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
