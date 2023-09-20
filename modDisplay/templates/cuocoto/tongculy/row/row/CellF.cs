﻿using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.cuocoto.tongculy.row.row
{
    /// <summary>
    /// Bậc hàng
    /// </summary>
    public class CellF : ACell
    {
        public override string UniqueName { get { return "CuocOto_TongCuLy_BacHang"; } }
        public override string Col { get { return "F"; } }
        public CellF(Row r) : base(r)
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
