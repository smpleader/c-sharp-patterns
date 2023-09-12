using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tinhgiacamay
{
    // Tính tổng thành tiền máy
    public class colITong : ACell
    {
        public colITong(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "TinhGiaCM_ThanhTienTinhGiaMay";

        /// <summary>
        /// 3 tham số
        /// <para> Tham số 1 chỉ số dòng tính thành tiền chỉ tiêu sử dụng</para>
        /// <para> Tham số 2 chỉ số dòng tính thành tiền tổng nhân công</para>
        /// <para> Tham số 3 chỉ số dòng tính thành tiền tổng nhiên liệu</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=I{args[0]}+I{args[1]}+I{args[2]}";
        }
    }
}
