﻿using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopmay
{
    // Tính thành tiền giá TB cho một máy
    public class colM : ACell
    {
        public colM(Option opt) : base(opt)
        {
        }

        public override string CName => "M";
        public override string UName => "THM_ThanhTienGiaThongBao";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số chỉ số dòng tính thành tiền giá TB trong bảng THM</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=I{args[0]}*L{args[0]}"; // Cột I: hao phí máy, cột L: giá TB
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=I{args[0]}*L{args[0]}"; // Cột I: hao phí máy, cột L: giá TB
        }
    }
}
