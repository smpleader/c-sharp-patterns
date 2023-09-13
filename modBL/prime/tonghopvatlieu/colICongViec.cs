﻿using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    // Hao phí theo công việc
    internal class colICongViec : ACell
    {
        public colICongViec(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "THVL_HaoPhiCongViecVatLieu";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng công việc trong bảng THVL </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=PRODUCT(F{args[0]};G{args[0]};H{args[0]})";
        }
    }
}