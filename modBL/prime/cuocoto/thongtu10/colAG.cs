﻿using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.thongtu10
{
    public class colAG : ACell
    {
        public colAG(Option opt) : base(opt)
        {
        }

        public override string CName => "AG";
        public override string UName => "CuocOto_TT10_ThanhTienBocXuong";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=ROUND(AF{args[0]}*AG3;0)";
        }
    }
}