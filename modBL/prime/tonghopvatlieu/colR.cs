﻿using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    // Tính thành tiền giá TBxHS cho một vật liệu
    internal class colR : ACell
    {
        public colR(Option opt) : base(opt)
        {
        }

        public override string CName => "R";
        public override string UName => "THVL_ThanhTienGiaThongBaoxHeSo";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng tính thành tiền chênh lệch giá TB trong bảng THVL</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=I{args[0]}*Q{args[0]}";
        }
    }
}