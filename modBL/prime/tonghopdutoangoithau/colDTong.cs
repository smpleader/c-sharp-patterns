using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopdutoangoithau
{
    /// <summary>
    /// Tổng cộng giá trị trước thuế
    /// </summary>
    public class colDTong : ACell
    {
        public colDTong(Option opt) : base(opt)
        {
        }

        public override string CName => "D";
        public override string UName => "GGTXD_TongThanhTienGiaTriTruocThue";

        /// <summary>
        /// 3 tham số
        /// <para> Tham số 1 chỉ số dòng chí phí xây dựng của gói thầu</para>
        /// <para> Tham số 2 chỉ số dòng chí phí hạng mục chung</para>
        /// <para> Tham số 3 chỉ số dòng chí phí chi phí dự phòng</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=D{args[0]}+D{args[1]}+D{args[2]}"; //Cột D: Chi phí xây dựng của gói thầu, chi phí hạng mục chung, chi phí dự phòng
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=D{args[0]}+D{args[1]}+D{args[2]}"; //Cột D: Chi phí xây dựng của gói thầu, chi phí hạng mục chung, chi phí dự phòng
        }
    }
}
