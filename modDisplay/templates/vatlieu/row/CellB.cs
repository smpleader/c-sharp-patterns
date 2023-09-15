using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.vatlieu.row
{
    public class CellB : ACell
    {
        public override string UniqueName { get { return "VatLieu_MaVatLieu"; } }
        public override string Col { get { return "B"; } }
        public CellB(Row r) : base(r)
        {
        }
        public override void Render()
        {
            // todo: bind data to working sheet
        }
        public override void Bind()
        {
            if (ValueOnMask.ToString() == "Invalid")
            {
                MessageBox.Show("Giá trị cột B không được nhập là 'Invalid'");
            }
            else
            {
                base.Bind();
            }
        }
    }
}
