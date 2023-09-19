﻿using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopmay
{
    public class colG : ACell
    {
        public colG(Option opt) : base(opt)
        {
        }

        public override string CName => "G";
        public override string UName => "THM_DinhMucCongViec";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng máy trong bảng phân tích vật tư </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"={SheetName.PHAN_TICH_VAT_TU}!F{args[0]}"; // Cột F: Định mức máy
        }
        public override string formula(string hmId, string[] args)
        {
            return $"={SheetName.PHAN_TICH_VAT_TU}_{hmId}!F{args[0]}"; // Cột F: Định mức máy
        }
    }
}
