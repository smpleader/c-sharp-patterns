using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modDisplay.templates.tienluong
{
    internal class Row : ARowObject
    {
        //public Row(VatLieu r) { ColNum = r.ColNum; ColText = r.ColText; }
        public Row(int id)
        {
            Id = id;
        }

        Button btnVL = new Button("VL");
        Button btnNC = new Button("NC");
        Button btnCM = new Button("CM");

        public string A { get { return txt("kiHieuBanVe"); } set { txt("kiHieuBanVe", value); } }
        public string B { get { return txt("stt"); } set { txt("stt", value); } }
        public string C { get { return txt("maSoCongViec"); } set { txt("maSoCongViec", value); } }
        public string D { get { return txt("tenCongViec"); } set { txt("tenCongViec", value); } }
        public string E { get { return txt("donVi"); } set { txt("donVi", value); } }
        public string F { get { return txt("tenCauKien"); } set { txt("tenCauKien", value); } }
        public string G { get { return txt("soCauKien"); } set { txt("soCauKien", value); } }
        public string H { get { return txt("dai"); } set { txt("dai", value); } }
        public string I { get { return txt("rong"); } set { txt("rong", value); } }
        public string J { get { return txt("cao"); } set { txt("cao", value); } }
        public string K { get { return txt("heSoPhu"); } set { txt("heSoPhu", value); } }
        public string L { get { return txt("khoiLuongPhu"); } set { txt("khoiLuongPhu", value); } }
        public string M { get { return txt("khoiLuong"); } set { txt("khoiLuong", value); } }
        public string N { get { return txt("donGiaVatLieu"); } set { txt("donGiaVatLieu", value); } }
        public string O { get { return txt("donGiaVatLieuPhu"); } set { txt("donGiaVatLieuPhu", value); } }
        public string P { get { return txt("donGiaNhanCong"); } set { txt("donVidonGiaNhanCong", value); } }
        public string Q { get { return txt("donGiaMay"); } set { txt("donGiaMay", value); } }
        public string R { get { return txt("thanhTienVatLieu"); } set { txt("thanhTienVatLieu", value); } }
        public string S { get { return txt("thanhTienVatLieuPhu"); } set { txt("thanhTienVatLieuPhu", value); } }
        public string T { get { return txt("thanhTienNhanCong"); } set { txt("thanhTienNhanCong", value); } }
        public string U { get { return txt("thanhTienMay"); } set { txt("thanhTienMay", value); } }
        public string V { get { return txt("heSoDieuChinhVatLieu"); } set { txt("heSoDieuChinhVatLieu", value); } }
        public string W { get { return txt("heSoDieuChinhNhanCong"); } set { txt("heSoDieuChinhNhanCong", value); } }
        public string X { get { return txt("heSoDieuChinhMay"); } set { txt("heSoDieuChinhMay", value); } }
        public string Y { get { return txt("thongTinDonGia"); } set { txt("thongTinDonGia", value); } }
        public Button AA { get { return btnCM; } }

        public void bind(unvell.ReoGrid.Worksheet data)
        {
            // TODO: consider a link to cell address, not a data hold
            // Current status: map column to BL/cell
            //  A = data.Cells["A"+Id].Data.ToString();
            // B = data.Cells["B"+Id].Data.ToString();

            // modData.Memories.Models.CongViec.capnhat(this);
        }
    }
}
