﻿using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.caobangthem
{
    public class colQ : ACell
    {
        public colQ(Option opt) : base(opt)
        {
        }
        public override string CName => "Q";
        public override string UName => "CuocOto_CaoBangThem_ThanhTienChiPhiVanChuyen";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng vật liệu tính cước</para>
        /// <para> Tham số 2 là chỉ số dòng hiện tại tính cước (dòng bổ sung dòng cước)</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=W6*E{args[0]}*I{args[0]}*K{args[1]}*M{args[1]}*(O{args[1]}+P{args[1]})";
        }
    }
}
