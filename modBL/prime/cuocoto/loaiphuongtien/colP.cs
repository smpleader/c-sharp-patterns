using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.loaiphuongtien
{
    public class colP : ACell
    {
        public colP(Option opt) : base(opt)
        {
        }
        public override string CName => "P";
        public override string UName => "CuocOto_LoaiPhuongTien_ThanhTienChiPhiBocDo";

        /// <summary>
        /// 1 tham số
        /// <para> Tham số 1 là chỉ số dòng vật liệu tính cước </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=T4*M{args[0]}*(N{args[0]}+O{args[0]})"; // Cột T: lương ngày công, cột M: trọng lượng tấn, cột N: chi phí bốc lên, cột O: chi phí dỡ xuống
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=T4*M{args[0]}*(N{args[0]}+O{args[0]})"; // Cột T: lương ngày công, cột M: trọng lượng tấn, cột N: chi phí bốc lên, cột O: chi phí dỡ xuống
        }
    }
}
