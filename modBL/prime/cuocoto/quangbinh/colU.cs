﻿using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.quangbinh
{
    public class colU : ACell
    {
        public colU(Option opt) : base(opt)
        {
        }
        public override string CName => "U";
        public override string UName => "CuocOto_QuangBinh_ThanhTienChiPhiBocDoTrungChuyenTrungChuyen";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số là chỉ số dòng tính cước cho vật liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=D4*T{args[0]}";
        }
    }
}
