using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.tongculy.row.row
{
    /// <summary>
    /// Cước cơ bản	
    /// </summary>
    public class CellN : ACell
    {
        public override string UniqueName { get { return "CuocOto_TongCuLy_CuocCoBan"; } }
        public override string Col { get { return "N"; } }
        public CellN(Row r) : base(r)
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
