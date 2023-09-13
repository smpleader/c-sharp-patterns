﻿using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.dongiatonghop
{
    public class colD : ACell
    {
        public colD(Option opt) : base(opt)
        {
        }

        public override string CName => "D";
        public override string UName => "DGTH_TenCongViec";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng công việc trong bảng tiên lượng </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.TIEN_LUONG}'!D{args[0]}"; // Cột D: Tên công việc
        }
    }
}