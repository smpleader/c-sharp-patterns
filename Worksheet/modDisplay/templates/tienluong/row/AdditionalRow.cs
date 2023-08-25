using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
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
        public AdditionalRow(SpreadsheetGrid spreadsheetGrid,IWorksheet worksheet , int id) : base(spreadsheetGrid,worksheet)
        {
            ws = spreadsheetGrid;
            this.worksheet = worksheet;
            Id = id;
        }
        public bool IsInterpretiveFormula { get; set; } = true;
       public IRange C { get { return this.Cell("C"); } }
        /// <summary>
        /// Công thức diễn giả
        /// </summary>
       public IRange D { get { return this.Cell("D"); } }
      
        /// <summary>
        /// Tên CK
        /// </summary>
       public IRange F { get { return this.Cell("F"); } }
        /// <summary>
        /// Số CK
        /// </summary>
       public IRange G { get { return this.Cell("G"); } }
        /// <summary>
        /// Dài
        /// </summary>
       public IRange H { get { return this.Cell("H"); } }
        /// <summary>
        /// Rộng
        /// </summary>
       public IRange I { get { return this.Cell("I"); } }
        /// <summary>
        /// Cao
        /// </summary>
       public IRange J { get { return this.Cell("J"); } }
        /// <summary>
        /// HS phụ
        /// </summary>
       public IRange K { get { return this.Cell("K"); } }
        /// <summary>
        /// KL Phụ
        /// </summary>
       public IRange L { get { return this.Cell("L"); } }
        

        /// <summary>
        /// Lấy công thức cho các cột R, S, T, U
        /// </summary>
        /// <param name="col"></param>
        /// <returns></returns>
        public override string GetFormula(string col)
        {
            string[] parameters = new string[1] { Id.ToString() };
            return string.Format(modBL.Container.Get("CongViec_KhoiLuongPhu").formula(parameters));
        }
        public void bind()
        {
            // check group object khi mở từ file excel ( bind)
            if (!worksheet.Range["B" + Id].IsMerged)
            {
                // check group object khi nhập vào
                string C = worksheet.Range["C" + Id].Value;
                if (string.IsNullOrWhiteSpace(C))
                {
                    // check công thức diễn giải khi nhập vào
                    string ColValueD = worksheet.Range["D" + Id].Value;
                    if (!string.IsNullOrWhiteSpace(ColValueD))
                    {
                        string interpretiveFormula = ColValueD;
                        var segment = interpretiveFormula.Split(":").ToList();
                        if (segment.Count > 1)
                        {
                            // check segment 2 
                            if (segment[1].Trim() != "" && IsValidExpression(segment[1].Trim().Split("=")[0]))
                            {
                                double result = EvaluateExpression(segment[1].Trim().Split("=")[0]);
                                D.Value = segment[1].Trim().Split("=").Length > 1 ? interpretiveFormula : interpretiveFormula + " = " + FormatResult(result);

                                string formulaL = "=" + segment[1].Trim().Split("=")[0];
                                var range = worksheet.Range["L" + Id];
                                ws.SetCellValue(range, formulaL);

                                IsInterpretiveFormula = true;
                            }
                            else
                            {
                                D.Value = interpretiveFormula + " :";
                                IsInterpretiveFormula = true;
                            }
                        }
                        else
                        {
                            D.Value = interpretiveFormula + " :";
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
