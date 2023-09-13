using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.vatlieu.row
{
    public class CellA : ACell
    {
        public override string UniqueName { get { return "VatLieu_SoThuTu"; } }
        public override string Col { get { return "A"; } }
        public CellA(Row r) : base(r)
        {
        }

        /// <summary>
        /// Hiển thị số thứ tự
        /// </summary>
        public override void Render()
        {
            // todo: bind data to working sheet
        }
        public override void Bind()
        {
            // todo: bind data to working sheet
            base.Bind();
        }
    }
}
