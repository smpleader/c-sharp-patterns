﻿using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    public class colS : ACell
    {
        public colS(Option opt) : base(opt)
        {
        }

        public override string CName => "S";
        public override string UName => "THVL_ChenhLechGiaThongBaoxHeSo";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng tính chênh lệch giá TBxHS trong bảng THVL</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=Q{args[0]}-J{args[0]}"; // Cột Q đơn giá TBxHS, cột J: đơn giá gốc
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=Q{args[0]}-J{args[0]}"; // Cột Q đơn giá TBxHS, cột J: đơn giá gốc
        }
    }
}
