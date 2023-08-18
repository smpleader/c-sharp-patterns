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
    internal class AdditionalRow : ARowObject
    {
        public AdditionalRow(unvell.ReoGrid.Worksheet worksheet, int id) 
        {
            ws = worksheet;
            Id = id;
        }
        public bool IsInterpretiveFormula { get; set; } = true;

        /// <summary>
        /// Ký hiệu bản vẽ
        /// </summary>
        public Cell A { get { return GetCell("A"); } }
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
        /// Thành tiền vật liệu
        public Cell R { get { return GetCell("R"); } }
        /// Thành tiền vật liệu phụ
        public Cell S { get { return GetCell("S"); } }
        /// <summary>
        /// Địa chỉ ô cho phép lấy C, D, F, G, H, I, J, K, L
        /// </summary>
        /// <param name="col"></param>
        /// <returns> col + indexRow</returns>
        //public string Address(string col)
        //{
        //    return col + Id;
        //}

        /// <summary>
        /// Lấy công thức cho các cột R, S, T, U
        /// </summary>
        /// <param name="col"></param>
        /// <returns></returns>
        public override string GetFormula(string col)
        {
            string[] parameters = new string[1] { Id.ToString() };
            return string.Format(modBL.Container.Get("CongViec_KhoiLuongPhu").fml(parameters));
        }
        public void bind()
        {
            // check group object khi mở từ file excel ( bind)
            if (!ws.IsMergedCell("B" + Id))
            {
                // check group object khi nhập vào
                string C = this.C.GetData<string>();
                if (C == null)
                {
                    // check công thức diễn giải khi nhập vào
                    if (D.GetData<string>() != null)
                    {
                        string interpretiveFormula = D.GetData<string>();
                        var segment = interpretiveFormula.Split(":").ToList();
                        if (segment.Count > 1)
                        {
                            // check segment 2 
                            if (segment[1].Trim() != "" && IsValidExpression(segment[1].Trim().Split("=")[0]))
                            {
                                double result = EvaluateExpression(segment[1].Trim().Split("=")[0]);
                                D.Data = segment[1].Trim().Split("=").Length > 1 ? interpretiveFormula : interpretiveFormula + " = " + FormatResult(result);
                                L.Data = "=" + segment[1].Trim().Split("=")[0];
                                IsInterpretiveFormula = true;
                            }
                            else
                            {
                                D.Data = interpretiveFormula + " :";
                                IsInterpretiveFormula = true;
                            }
                        }
                        else
                        {
                            D.Data = interpretiveFormula + " :";
                            IsInterpretiveFormula = true;
                        }
                    }
                }
            }
        }
        static string FormatResult(double number)
        {
            int decimalPlaces = 3;
            if (Math.Abs(number - Math.Floor(number)) < double.Epsilon)
            {
                // Kết quả là số nguyên, định dạng với 1 chữ số sau dấu thập phân
                return number.ToString("0.0");
            }
            else
            {
                // Kết quả có phần thập phân, định dạng với tối đa 3 chữ số sau dấu thập phân
                return number.ToString($"0.{new string('0', decimalPlaces)}");
            }
        }
        static bool IsValidExpression(string expression)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        static double EvaluateExpression(string expression)
        {
            // Sử dụng DataTable.Compute để tính toán giá trị biểu thức
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }

        internal void render()
        {
            
        }
    }
}
