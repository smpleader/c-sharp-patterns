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

namespace Worksheet.modDisplay.templates.tienluong
{
    internal class AdditionalRow : ARow
    {
        public AdditionalRow(int id) : base(id)
        {
            Id = id;
            HMId = Current.HM.id();
        }
        public override int HMId { get; }
        public bool IsInterpretiveFormula { get; set; } = true;
        public override string Path { get { return "HangMuc." + HMId + ".CongViec." + Id; } }

        /// <summary>
        /// Địa chỉ ô cho phép lấy C, D, F, G, H, I, J, K, L
        /// </summary>
        /// <param name="col"></param>
        /// <returns> col + indexRow</returns>
        public string Address(string col)
        {
            return col + Id;
        }

        /// <summary>
        /// Lấy công thức cho các cột R, S, T, U
        /// </summary>
        /// <param name="col"></param>
        /// <returns></returns>
        public string GetFormula(string col)
        {
            string[] parameters = new string[1] { Id.ToString() };
            return string.Format(modBL.Container.Get("CongViec_KhoiLuongPhu").fml(parameters));
        }
        public void bind(unvell.ReoGrid.Worksheet worksheet)
        {
            // check group object khi mở từ file excel ( bind)
            if ( !worksheet.IsMergedCell("B" + Id))
            {
                // check group object khi nhập vào
                string C = CellUtility.ConvertData<string>(worksheet["C" + Id]);
                if (C == null)
                {
                    // check công thức diễn giải khi nhập vào
                    if(worksheet["D" + Id] != null && worksheet["D" + Id] != "")
                    {
                        string interpretiveFormula = CellUtility.ConvertData<string>(worksheet["D" + Id]);
                        var segment = interpretiveFormula.Split(":").ToList();
                        if (segment.Count > 1)
                        {
                            // check segment 2 
                            if (segment[1].Trim() != "" && IsValidExpression(segment[1].Trim().Split("=")[0]))
                            {
                                double result = EvaluateExpression(segment[1].Trim().Split("=")[0]);
                                worksheet["D" + Id] = segment[1].Trim().Split("=").Length > 1? interpretiveFormula: interpretiveFormula + " = " + FormatResult(result);
                                worksheet["L" + Id] = "=" + segment[1].Trim().Split("=")[0];
                                IsInterpretiveFormula = true;
                            }
                            else
                            {
                                worksheet["D" + Id] = interpretiveFormula + " :";
                                IsInterpretiveFormula = true;
                            }
                        }
                        else
                        {
                            worksheet["D" + Id] = interpretiveFormula + " :";
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
    }
}
