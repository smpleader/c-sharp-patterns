﻿using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    internal class colH : ACell
    {
        public colH(Option opt) : base(opt)
        {
        }

        public override string CName => "H";
        public override string UName => "THVL_HeSoCongViec";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng công việc chứa vật liệu trong bảng tiên lượng </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.TIEN_LUONG}'!V{args[0]}";
        }
    }
}