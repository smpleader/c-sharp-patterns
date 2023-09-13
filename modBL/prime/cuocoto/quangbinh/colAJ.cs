﻿using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.quangbinh
{
    public class colAJ : ACell
    {
        public colAJ(Option opt) : base(opt)
        {
        }
        public override string CName => "AJ";
        public override string UName => "CuocOto_QuangBinh_CongChiPhiTaiHienTruong";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng tính cước cho vật liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=AB{args[0]}+AD{args[0]}+AI{args[0]}";
        }
    }
}