using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.tonghopdutoangoithau
{
    /// <summary>
    /// Giá trị trước thuế hạng mục
    /// </summary>
    public class colDHM : ACell
    {
        public colDHM(Option opt) : base(opt)
        {
        }

        public override string CName => "D";
        public override string UName => "GGTXD_ThanhTienGiaTriTruocThueHangMuc";

        /// <summary>
        /// 1 tham số
        /// <para> Chỉ số dòng hạng mục tương ứng trong bảng </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"='{SheetName.DON_GIA_TONG_HOP}'!H{args[0]}/(1+I{args[1]})"; //Cột H: Thành tiền tổng cộng, cột I: Tỷ lệ hạng mục
        }
        public override string formula(string hmId, string[] args)
        {
            return $"='{SheetName.DON_GIA_TONG_HOP}_{hmId}'!H{args[0]}/(1+I{args[1]})"; //Cột H: Thành tiền tổng cộng, cột I: Tỷ lệ hạng mục
        }
    }
}
