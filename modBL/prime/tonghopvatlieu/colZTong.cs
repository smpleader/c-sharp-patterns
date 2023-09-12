﻿using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    //Tổng thành tiền chênh lệch giá HT các vật liệu
    internal class colZTong : ACell
    {
        public colZTong(Option opt) : base(opt)
        {
        }

        public override string CName => "Z";
        public override string UName => "THVL_TongThanhTienChenhLechGiaHienTruong";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng bắt đầu bảng THVL</para>
        /// <para> Tham số 2 chỉ số dòng kết thúc bảng THVL</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUMIF(A{args[0]}:A{args[1]};\"VT\";Z{args[0]}:Z{args[1]})";
        }
    }
}
