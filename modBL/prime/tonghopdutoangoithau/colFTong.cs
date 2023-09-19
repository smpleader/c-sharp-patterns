using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopdutoangoithau
{
    /// <summary>
    /// Tổng cộng giá trị sau thuế
    /// </summary>
    public class colFTong : ACell
    {
        public colFTong(Option opt) : base(opt)
        {
        }

        public override string CName => "F";
        public override string UName => "GGTXD_TongThanhTienGiaTriSauThue";

        /// <summary>
        /// 3 tham số
        /// <para> Chỉ số dòng chí phí xây dựng của gói thầu</para>
        /// <para> Chỉ số dòng chí phí hạng mục chung</para>
        /// <para> Chỉ số dòng chí phí chi phí dự phòng</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=F{args[0]}+F{args[1]}+F{args[2]}"; //Cột F: Giá trị sau thuế chi phí xây dựng của gói thầu, chi phí hạng mục chung, chi phí dự phòng
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=F{args[0]}+F{args[1]}+F{args[2]}"; //Cột D: Giá trị sau thuế chi phí xây dựng của gói thầu, chi phí hạng mục chung, chi phí dự phòng
        }
    }
}
