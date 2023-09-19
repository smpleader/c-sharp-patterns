﻿using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.row
{
    /// <summary>
    /// Tổng giá của tất cả các nhân công
    /// </summary>
    public class CellAB : ACell
    {
        public override string UniqueName { get { return "CongViec_TongGiaTienCuaTatCaCacNhanCong"; } }
        public override string Col { get { return "AB"; } }
        public CellAB(Row r) : base(r)
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
