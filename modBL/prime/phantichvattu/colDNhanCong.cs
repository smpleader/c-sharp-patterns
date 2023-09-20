﻿using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Đơn vị nhân công
    /// </summary>
    public class colDNhanCong : ACell
    {
        public colDNhanCong(Option opt) : base(opt)
        {
        }

        public override string CName => "D";
        public override string UName => "PTVT_DonViNhanCong";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng nhân công trong bảng giá nhân công</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.NHAN_CONG}'!D{args[0]}"; // Cột D: Đơn vị nhân công
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.NHAN_CONG}_{hmId}'!D{args[0]}";
        }
    }
}