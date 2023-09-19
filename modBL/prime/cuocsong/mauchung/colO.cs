﻿using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocsong.mauchung
{
    public class colO : ACell
    {
        public colO(Option opt) : base(opt)
        {
        }

        public override string CName => "O";
        public override string UName => "CuocSong_MauChung_TongCuoc";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=E{args[0]}*M{args[0]}+N{args[0]}"; // Cột E: khối lượng đơn vị, cột M: giá cước, cột N: chi phí khác
        }
    }
}
