using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.tongculy.row.header
{
    /// <summary>
    /// Tiêu đề cho công trình và hạng mục
    /// </summary>
    public class CellA : ACell
    {
        public override string UniqueName { get { return ""; } }
        public override string Col { get { return "A"; } }
        public CellA(Header r) : base(r)
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
