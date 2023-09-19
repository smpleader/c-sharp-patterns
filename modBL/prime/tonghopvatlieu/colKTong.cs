﻿using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopvatlieu
{
    //Tổng thành tiền giá gốc các vật liệu
    public class colKTong : ACell
    {
        public colKTong(Option opt) : base(opt)
        {
        }

        public override string CName => "K";
        public override string UName => "THVL_TongThanhTienGiaGoc";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng bắt đầu bảng THVL</para>
        /// <para> Tham số 2 chỉ số dòng kết thúc bảng THVL</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUMIF(A{args[0]}:A{args[1]};\"VT\";K{args[0]}:K{args[1]})"; // Cột A: chưa có tên cột, cột K: thành tiền giá gốc
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=SUMIF(A{args[0]}:A{args[1]};\"VT\";K{args[0]}:K{args[1]})"; // Cột A: chưa có tên cột, cột K: thành tiền giá gốc
        }
    }
}
