using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;
using unvell.ReoGrid.IO.OpenXML.Schema;
using unvell.ReoGrid.Utility;
using Worksheet.modData.Memories.Pointer;
using Cell = unvell.ReoGrid.Cell;

namespace Worksheet.modDisplay.templates.tienluong.row
{
    internal class Row : ARowObject
    {
        public Row(unvell.ReoGrid.Worksheet worksheet, int id)
        {
            ws = worksheet;
            Id = id;
        }
        public bool HaveInterpretiveFormula = false;

        /// <summary>
        /// Ký hiệu bản vẽ
        /// </summary>
        public Cell A { get {return GetCell("A");} }
        /// <summary>
        /// STT
        /// </summary>
        public Cell B { get { return GetCell("B"); } }
        /// <summary>
        /// MSCV
        /// </summary>
        public Cell C { get { return GetCell("C"); } }
        /// <summary>
        /// Tên công việc
        /// </summary>
        public Cell D { get { return GetCell("D"); } }
        /// <summary>
        /// Đơn vị
        /// </summary>
        public Cell E { get { return GetCell("E"); } }
        /// <summary>
        /// Tên CK
        /// </summary>
        public Cell F { get { return GetCell("F"); } }
        /// <summary>
        /// Số CK
        /// </summary>
        public Cell G { get { return GetCell("G"); } }
        /// <summary>
        /// Dài
        /// </summary>
        public Cell H { get { return GetCell("H"); } }
        /// <summary>
        /// Rộng
        /// </summary>
        public Cell I { get { return GetCell("I"); } }
        /// <summary>
        /// Cao
        /// </summary>
        public Cell J { get { return GetCell("J"); } }
        /// <summary>
        /// HS phụ
        /// </summary>
        public Cell K { get { return GetCell("K"); } }
        /// <summary>
        /// KL Phụ
        /// </summary>
        public Cell L { get { return GetCell("L"); } }
        /// <summary>
        /// Khối lượng
        /// </summary>
        public Cell M { get { return GetCell("M"); } }
        /// <summary>
        /// Đơn giá vật liệu
        /// </summary>
        public Cell N { get { return GetCell("N"); } }
        /// <summary>
        /// Đơn giá vật liệu phụ
        /// </summary>
        public Cell O { get { return GetCell("O"); } }
        /// <summary>
        /// Đơn giá nhân công
        /// </summary>
        public Cell P { get { return GetCell("P"); } }
        /// <summary>
        /// Đơn giá máy
        /// </summary>
        public Cell Q { get { return GetCell("Q"); } }
        /// <summary>
        /// Thành tiền vật liệu
        /// </summary>
        public Cell R { get { return GetCell("R"); } }
        /// <summary>
        /// Thành tiền vật liệu phụ
        /// </summary>
        public Cell S { get { return GetCell("S"); } }
        /// <summary>
        /// Thành tiền nhân công
        /// </summary>
        public Cell T { get { return GetCell("T"); } }
        /// <summary>
        /// Thành tiền máy
        /// </summary>
        public Cell U { get { return GetCell("U"); } }
        /// <summary>
        /// Hệ số điều chỉnh vật liệu
        /// </summary>
        public Cell V { get { return GetCell("V"); } }
        /// <summary>
        /// Hệ số điều chỉnh nhân công
        /// </summary>
        public Cell W { get { return GetCell("W"); } }
        /// <summary>
        /// Hệ số điều chỉnh máy
        /// </summary>
        public Cell X { get { return GetCell("X"); } }
        /// <summary>
        /// Thông tin đơn giá
        /// </summary>
        public Cell Y { get { return GetCell("Y"); } }
        /// <summary>
        /// Tổng giá của tất cả các vật liệu
        /// </summary>
        public Cell Z { get { return GetCell("Z"); } }
        /// <summary>
        /// Tổng giá của tất cả các vật liệu phụ
        /// </summary>
        public Cell AA { get { return GetCell("AA"); } }
        /// <summary>
        /// Tổng giá của tất cả các nhân công
        /// </summary>
        public Cell AB { get { return GetCell("AB"); } }
        /// Tổng giá của tất cả các máy
        public Cell AC { get { return GetCell("AC"); } }

        /// <summary>
        /// Lấy công thức cho các cột M, N, O, P, Q, R, S, T, U
        /// </summary>
        /// <param name="col"></param>
        /// <returns></returns>
        public override string GetFormula(string col)
        {
            string uniqueName = "";
            string formula;
            string[] parameters = new string[1] { Id.ToString() };
            switch (col)
            {
                case "M":
                    if (HaveInterpretiveFormula)
                    {
                        uniqueName = "CongViec_KhoiLuong";
                        parameters = new string[2] { start.ToString(), end.ToString() };
                        break;
                    }
                    else
                    {
                        return M.GetData<string>();
                    }
                case "N":
                    uniqueName = "CongViec_DonGiaVatLieu";
                    decimal tongGiaVatLieu = Z.GetData<decimal>();
                    parameters = new string[2] { Id.ToString(), tongGiaVatLieu.ToString() };
                    break;
                case "O":
                    uniqueName = "CongViec_DonGiaVatLieuPhu";
                    decimal tongGiaVatLieuPhu = AA.GetData<decimal>();
                    parameters = new string[2] { Id.ToString(), tongGiaVatLieuPhu.ToString() };
                    break;
                case "P":
                    uniqueName = "CongViec_DonGiaNhanCong";
                    decimal tongGiaNhanCong = AB.GetData<decimal>();
                    parameters = new string[2] { Id.ToString(), tongGiaNhanCong.ToString() };
                    break;
                case "Q":
                    uniqueName = "CongViec_DonGiaMay";
                    decimal tongGiaMay = AC.GetData<decimal>();
                    parameters = new string[2] { Id.ToString(), tongGiaMay.ToString() };
                    break;
                case "R":
                    uniqueName = "CongViec_ThanhTienVatLieu";
                    break;
                case "S":
                    uniqueName = "CongViec_ThanhTienVatLieuPhu";
                    break;
                case "T":
                    uniqueName = "CongViec_ThanhTienNhanCong";
                    break;
                case "U":
                    uniqueName = "CongViec_ThanhTienMay";
                    break;
                default: break;
            }
            formula = string.Format(modBL.Container.Get(uniqueName).fml(parameters));
            return formula;
        }

        public void bind()
        {
            
        }
        public void render()
        {
            List<string> colsHaveFormula = new List<string>() { "M", "N", "O", "P", "Q", "R", "S", "T", "U" };
            foreach (string col in colsHaveFormula)
            {
                ws[col +Id] = GetFormula(col);
            }
        }

        public void AddSimpleData()
        {
            // mã công việc
            C.Data = "AG.11111";
            // tên công việc
            D.Data = "Bê tông cọc, cột, bê tông M100, đá 1x2, PCB30 - Đổ bê tông đúc sẵn bằng thủ công (vữa bê tông sản xuất bằng máy trộn)";
            // đơn vị
            E.Data = "m3";

            // HSDC vật liệu
            V.Data = 1;
            // HSDC nhân công
            W.Data = 1;
            // HSDC máy
            X.Data = 1;

            // thông tin đơn giá
            Y.Data = "DinhMuc_2021XD_D12";

            // tổng giá tất cả vật liệu của công việc 
            Z.Data = 685204;
            // tổng giá tất cả vật liệu phụ của công việc 
            AA.Data = 0;
            // tổng giá tất cả nhân công của công việc 
            AB.Data = 288111;
            // tổng giá tất cả máy của công việc 
            AC.Data = 70230;

            // set màu chữ thành không màu
            ws.SetRangeStyles(Z.Position.ToAddress() + ":" + AC.Position.ToAddress(), new WorksheetRangeStyle()
            {
                Flag = PlainStyleFlag.TextColor,
                TextColor = Color.Transparent,
            });
        }
    }
}
