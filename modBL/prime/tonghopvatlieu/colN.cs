﻿using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    public class colN : ACell
    {
        public colN(Option opt) : base(opt)
        {
        }

        public override string CName => "N";
        public override string UName => "THVL_ChenhLechGiaThongBao";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng tính chênh lệch giá TB trong bảng THVL</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=L{args[0]}-J{args[0]}"; // Cột L: giá thông báo, cột J: giá gốc
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=L{args[0]}-J{args[0]}"; // Cột L: giá thông báo, cột J: giá gốc
        }
    }
}
