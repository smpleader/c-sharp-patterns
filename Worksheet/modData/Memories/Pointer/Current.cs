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

        public static Other HSCP = new Other("HeSoChiPhi");
        public static Other LoaiCT = new Other("LoaiCongTrinh");
        public static Other NguonBG = new Other("NguonBaoGia");
        public static Other BG = new Other("BaoGia");
        public static Other NguonDG = new Other("NguonDonGia");
        public static Other DG = new Other("DonGia");
        public static Other ThongTu = new Other("ThongTu");
        public static unvell.ReoGrid.ReoGridControl WControl;
        public static unvell.ReoGrid.WorksheetCollection WB;
        public static unvell.ReoGrid.Worksheet WS;
        public static unvell.ReoGrid.Cell Cell;
        public static string Col;
        public static int Row;

        public void point (string name, int id)
        {
            switch(name) {
                case "VL":
                case "VatLieu":
                    VL.id(id); break;
                case "NC":
                case "NhanCong":
                    NC.id(id); break;
                case "CM":
                case "CaMay":
                    CM.id(id); break;
                case "CV":
                case "CongViec":
                    CV.id(id);
                    VL.id(-1);
                    CM.id(-1);
                    NC.id(-1);
                    break;
                case "HM":
                case "HangMuc":
                    HM.id(id);
                    CV.id(-1);
                    VL.id(-1);
                    CM.id(-1);
                    NC.id(-1);
                    break;
                case "HSCP":
                case "HeSoChiPhi":
                    HSCP.id(id);
                    break;
                case "LoaiCT":
                case "LoaiCongTrinh":
                    LoaiCT.id(id);
                    break;
                case "NguonBaoGia":
                    NguonBG.id(id);
                    break;
                case "NguonDonGia":
                    NguonDG.id(id);
                    break;
                case "ThongTu":
                    ThongTu.id(id);
                    break;
            }
        }
    }
}
