﻿using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.row
{
    /// <summary>
    /// Dài
    /// </summary>
    public class CellH : ACell
    {
        public override string UniqueName { get { return "CongViec_Dai"; } }
        public override string Col { get { return "H"; } }
        public CellH(Row r) : base(r)
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
