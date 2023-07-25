using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using PointerHangMuc = Worksheet.modData.Memories.Pointer.HangMuc;

namespace Worksheet.modData.Memories.Pointer
{
    /*
     Lưu tình trạng sử dụng tài nguyên đầu vào ( Đơn giá + Báo giá ) 
    và vị trí dữ liệu
     */
    internal class Current
    {
        public static HangMuc HM = new HangMuc();
        public static CongViec CV = new CongViec();
        public static VatLieu VL = new VatLieu();
        public static NhanCong NC = new NhanCong();
        public static CaMay CM = new CaMay(); 
    }
}
