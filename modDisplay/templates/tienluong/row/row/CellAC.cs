using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.row
{
    /// <summary>
    /// Tổng giá của tất cả các ca máy
    /// </summary>
    public class CellAC : ACell
    {
        public override string UniqueName { get { return "CongViec_TongGiaTienCuaTatCaCacCaMay"; } }
        public override string Col { get { return "AC"; } }
        public CellAC(Row r) : base(r)
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
