using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopdutoangoithau
{
    /// <summary>
    /// giá trị trước thuế chi phí công tác không xác định
    /// </summary>
    public class colDKXD : ACell
    {
        public colDKXD(Option opt) : base(opt)
        {
        }

        public override string CName => "D";
        public override string UName => "GGTXD_ThanhTienGiaTriTruocThueChiPhiKhongXacDinh";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 chỉ số dòng chí phí xây dựng của gói thầu</para>
        /// <para> Tham số 2 chỉ số dòng chí phí công tác không xác định</para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=D{args[0]}*I{args[1]}"; //Cột D: Chi phí xây dựng của gói thầu, cột I: tỷ lệ chi chi phí công tác không xác định
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=D{args[0]}*I{args[1]}"; //Cột D: Chi phí xây dựng của gói thầu, cột I: tỷ lệ chi chi phí công tác không xác định
        }
    }
}
