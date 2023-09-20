using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.tongculy.row.row
{
    /// <summary>
    /// Cự ly	
    /// </summary>
    public class CellL : ACell
    {
        public override string UniqueName { get { return "CuocOto_TongCuLy_CuLy"; } }
        public override string Col { get { return "L"; } }
        public CellL(Row r) : base(r)
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
