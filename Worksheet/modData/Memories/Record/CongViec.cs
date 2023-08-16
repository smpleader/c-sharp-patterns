using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksheet.modData.Memories.Pointer;

namespace Worksheet.modData.Memories.Record
{
    internal class CongViec : ARecord
    {
        public int HMId { get; }

        public CongViec(int HangMucId)
        {
            HMId = HangMucId;
            //Id = Current.CV.id(true);
            setDefault();
        }
        public override string Path { get { return "HangMuc."+ HMId + ".CongViec."+Id; } }
        public void setDefault()
        { 
            ColText["stt"] = "";
            ColText["ma"] = "";
            ColText["ten"] = "";
            ColText["donVi"] = "";

            ColText["tenCauKien"] = "";
            ColNum["soCauKien"] = 0;
            ColNum["dai"] = 0;
            ColNum["rong"] = 0;
            ColNum["cao"] = 0;
            ColNum["heSoPhu"] = 0;
            ColNum["khoiLuongPhu"] = 0;

            ColText["khoiLuong"] = "0";

            ColNum["donGiaVatLieu"] = 0;
            ColNum["donGiaVatLieuPhu"] = 0;
            ColNum["donGiaNhanCong"] = 0;
            ColNum["donGiaMay"] = 0;

            ColNum["thanhTienVatLieu"] = 0;
            ColNum["thanhTienVatlieuPhu"] = 0;
            ColNum["thanhTienNhanCong"] = 0;
            ColNum["thanhTienMay"] = 0;
            // Hệ số định mức, sheet ở dưới 
            ColNum["hsdmVatLieu"] = 1;
            ColNum["hsdmNhanCong"] = 1;
            ColNum["hsdmMay"] = 1;
            // Hệ số điều chỉnh, trong sheet Tiên lượng
            ColNum["hsdcVatLieu"] = 1;
            ColNum["hsdcNhanCong"] = 1;
            ColNum["hsdcMay"] = 1;
            // TODO: diễn giải khối lượng + KL + KL phụ

            ColText["thongTinDonGia"] = "";

            ColNum["tongGiaVatLieu"] = 0;
            ColNum["tongGiaVatLieuPhu"] = 0;
            ColNum["tongGiaNhanCong"] = 0;
            ColNum["tongGiaMay"] = 0;

        }
    }
}