using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid.Utility;
using Worksheet.modData.Memories.Pointer;

namespace Worksheet.modDisplay.templates.tienluong
{
    internal class Row : ARowObject
    {
        public Row(int id)
        {
            Id = id;
            HMId = Current.HM.id();
        }
        public int HMId { get; }

    
        public override string Path { get { return "HangMuc." + HMId + ".CongViec." + Id; } }

        public string A { get { return txt("kiHieuBanVe"); } set { txt("kiHieuBanVe", value); } }
        public string B { get { return txt("stt"); } set { txt("stt", value); } }
        public string C { get { return txt("ma"); } set { txt("ma", value); } }
        public string D { get { return txt("ten"); } set { txt("ten", value); } }
        public string E { get { return txt("donVi"); } set { txt("donVi", value); } }
        public string F { get { return txt("tenCauKien"); } set { txt("tenCauKien", value); } }
        public decimal G { get { return num("soCauKien"); } set { num("soCauKien", value); } }
        public decimal H { get { return num("dai"); } set { num("dai", value); } }
        public decimal I { get { return num("rong"); } set { num("rong", value); } }
        public decimal J { get { return num("cao"); } set { num("cao", value); } }
        public decimal K { get { return num("heSoPhu"); } set { num("heSoPhu", value); } }
        public decimal L { get { return num("khoiLuongPhu"); } set { num("khoiLuongPhu", value); } }
        public decimal M { get { return num("khoiLuong"); } set { num("khoiLuong", value); } }
        public string N { 
            get 
            {
                Current.CV.id(Id);
                var congViec = Worksheet.modData.Memories.Models.CongViec.chitiet();
                string formula = string.Format(modBL.Container.Get("CongViec_DonGiaVatLieu").fml(),Id, congViec.ColNum["tongGiaVatLieu"]);
                return formula;
            } 
            set { txt("donGiaVatLieu", value); } 
        }

        public string O
        {
            get
            {
                Current.CV.id(Id);
                var congViec = Worksheet.modData.Memories.Models.CongViec.chitiet();
                string formula = string.Format(modBL.Container.Get("CongViec_DonGiaVatLieuPhu").fml(), Id, congViec.ColNum["tongGiaVatLieuPhu"]);
                return formula;
            }
            set { txt("donGiaVatLieuPhu", value); }
        }

        public string P
        {
            get
            {
                Current.CV.id(Id);
                var congViec = Worksheet.modData.Memories.Models.CongViec.chitiet();
                string formula = string.Format(modBL.Container.Get("CongViec_DonGiaNhanCong").fml(), Id, congViec.ColNum["tongGiaNhanCong"]);
                return formula;
            }
            set { txt("donVidonGiaNhanCong", value); }
        }

        public string Q
        {
            get
            {
                Current.CV.id(Id);
                var congViec = Worksheet.modData.Memories.Models.CongViec.chitiet();
                string formula = string.Format(modBL.Container.Get("CongViec_DonGiaMay").fml(), Id, congViec.ColNum["tongGiaMay"]);
                return formula;
            }
            set { txt("donGiaMay", value); }
        }

        public string R
        {
            get
            {
                Current.CV.id(Id);
                var congViec = Worksheet.modData.Memories.Models.CongViec.chitiet();
                string formula = string.Format(modBL.Container.Get("CongViec_ThanhTienVatLieu").fml(), Id, Id);
                return formula;
            }
            set { txt("thanhTienVatLieu", value); }
        }
        public string S
        {
            get
            {
                Current.CV.id(Id);
                var congViec = Worksheet.modData.Memories.Models.CongViec.chitiet();
                string formula = string.Format(modBL.Container.Get("CongViec_ThanhTienVatLieuPhu").fml(), Id, Id);
                return formula;
            }
            set { txt("thanhTienVatLieuPhu", value); }
        }
        public string T
        {
            get
            {
                Current.CV.id(Id);
                var congViec = Worksheet.modData.Memories.Models.CongViec.chitiet();
                string formula = string.Format(modBL.Container.Get("CongViec_ThanhTienNhanCong").fml(), Id, Id);
                return formula;
            }
            set { txt("thanhTienNhanCong", value); }
        }
        public string U
        {
            get
            {
                Current.CV.id(Id);
                var congViec = Worksheet.modData.Memories.Models.CongViec.chitiet();
                string formula = string.Format(modBL.Container.Get("CongViec_ThanhTienMay").fml(), Id, Id);
                return formula;
            }
            set { txt("thanhTienMay", value); }
        }

        public decimal V { get { return num("hsdcVatLieu"); } set { num("hsdcVatLieu", value); } }
        public decimal W { get { return num("hsdcNhanCong"); } set { num("hsdcNhanCong", value); } }
        public decimal X { get { return num("hsdcMay"); } set { num("hsdcMay", value); } }
        public string Y { get { return txt("thongTinDonGia"); } set { txt("thongTinDonGia", value); } }

        public void bind(unvell.ReoGrid.Worksheet data)
        {
            B = CellUtility.ConvertData<string>(data["B"+Id]);
            C = CellUtility.ConvertData<string>(data["C" + Id]);
            D = CellUtility.ConvertData<string>(data["D" + Id]);
            E = CellUtility.ConvertData<string>(data["E" + Id]);
            F = CellUtility.ConvertData<string>(data["F" + Id]);
            G = CellUtility.ConvertData<decimal>(data["G" + Id]);
            H = CellUtility.ConvertData<decimal>(data["H" + Id]);
            I = CellUtility.ConvertData<decimal>(data["I" + Id]);
            J = CellUtility.ConvertData<decimal>(data["J" + Id]);
            K = CellUtility.ConvertData<decimal>(data["K" + Id]);
            L = CellUtility.ConvertData<decimal>(data["L" + Id]);
            M = CellUtility.ConvertData<decimal>(data["M" + Id]);
            N = CellUtility.ConvertData<string>(data["N" + Id]);
            O = CellUtility.ConvertData<string>(data["O" + Id]);
            P = CellUtility.ConvertData<string>(data["P" + Id]);
            Q = CellUtility.ConvertData<string>(data["Q" + Id]);
            R = CellUtility.ConvertData<string>(data["R" + Id]);
            S = CellUtility.ConvertData<string>(data["S" + Id]);
            T = CellUtility.ConvertData<string>(data["T" + Id]);
            U = CellUtility.ConvertData<string>(data["U" + Id]);
            V = CellUtility.ConvertData<decimal>(data["V" + Id]);
            W = CellUtility.ConvertData<decimal>(data["W" + Id]);
            X = CellUtility.ConvertData<decimal>(data["X" + Id]);
            Y = CellUtility.ConvertData<string>(data["Y" + Id]);
            modData.Memories.Models.CongViec.capnhat(this);
        }
    }
}
