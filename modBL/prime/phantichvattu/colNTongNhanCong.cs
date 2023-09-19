﻿using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.phantichvattu
{
    /// <summary>
    /// Tổng thành tiền đơn giá HT nhân công
    /// </summary>
    public class colNTongNhanCong : ACell
    {
        public colNTongNhanCong(Option opt) : base(opt)
        {
        }

        public override string CName => "N";
        public override string UName => "PTVT_TongThanhTienGiaHienTruongNhanCong";

        // <summary>
        /// 2 tham số
        /// <para> Chỉ số dòng nhân công đầu tiên trong bảng PTVT theo công việc</para>
        /// <para> Chỉ số dòng nhân công cuối cùng trong bảng PTVT theo công việc</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(N{args[0]}:N{args[1]})"; // Cột N: Thành tiền giá HT nhân công
        }
    }
}
