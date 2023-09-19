using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.row
{
    /// <summary>
    /// Ký hiệu bản vẽ
    /// </summary>
    public class CellA : ACell
    {
        public override string UniqueName { get { return "CongViec_KyHieuBanVe"; } }
        public override string Col { get { return "A"; } }
        public CellA(Row r) : base(r)
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
