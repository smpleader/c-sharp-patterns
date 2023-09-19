using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modBL.prime.cuocoto.loaiphuongtien
{
    // Cột L cho group object dòng cước cự ly nhỏ hơn hoặc bằng 1km
    public class colGLCuLy1 : ACell
    {
        public colGLCuLy1(Option opt) : base(opt)
        {
        }
        public override string CName => "L";
        public override string UName => "CuocOto_LoaiPhuongTien_ThanhTienCuLyNhoHonBang1000M";

        /// <summary>
        /// 2 tham số
        /// <para> Tham số 1 là chỉ số dòng vật liệu </para>
        /// <para> Tham số 2 là chỉ số dòng trong phạm vi <= 1000m vật liệu </para>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override string formula(string[] args)
        {
            return $"=G{args[0]}*J{args[1]}*K{args[1]}"; // Cột G: Hệ số quy đổi đơn vị, cột J: cự ly trong phạm vi <= 1km, cột K: giá cước trong phạm vi <= 1km
        }
        public override string formula(string hmId, string[] args)
        {
            return $"=G{args[0]}*J{args[1]}*K{args[1]}"; // Cột G: Hệ số quy đổi đơn vị, cột J: cự ly trong phạm vi <= 1km, cột K: giá cước trong phạm vi <= 1km
        }
    }
}
