using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tinhgiacamay
{
    
    // Tính thành tiền tổng nhân công
    public class colINCTong : ACell
    {
        public colINCTong(Option opt) : base(opt)
        {
        }

        public override string CName => "I";
        public override string UName => "TinhGiaCM_TongThanhTienTinhGiaNhanCong";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng bắt đầu tính thành tiền giá NC</para>
        /// <para> Tham số 2 chỉ số dòng kết thúc tính thành tiền giá NC</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=SUM(I{args[0]}:I{args[1]})";
        }
    }
}
