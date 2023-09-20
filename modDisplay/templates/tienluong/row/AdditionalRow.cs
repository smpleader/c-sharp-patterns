using Syncfusion.XlsIO;
using System.Data;
using Syncfusion.Windows.Forms.Grid;
using modDisplay.templates.tienluong.row.additional;

namespace modDisplay.templates.tienluong.row
{
    public class AdditionalRow : ARowObject
    {
        public AdditionalRow(GridControl gridControl, IWorksheet workingsheet, int id) : base(gridControl, workingsheet)
        {
            Id = id;
            cellB = new CellB(this);
            cellC = new CellC(this);
            cellD = new CellD(this);
            cellF = new CellF(this);
            cellG = new CellG(this);
            cellH = new CellH(this);
            cellI = new CellI(this);
            cellJ = new CellJ(this);
            cellK = new CellK(this);
            cellL = new CellL(this);
        }
        public bool IsInterpretiveFormula { get; set; } = true;
        public CellB cellB { get; set; }
        public CellC cellC { get; set; }
        public CellD cellD { get; set; }
        public CellF cellF { get; set; }
        public CellG cellG { get; set; }
        public CellH cellH { get; set; }
        public CellI cellI { get; set; }
        public CellJ cellJ { get; set; }
        public CellK cellK { get; set; }
        public CellL cellL { get; set; }

        public void bind()
        {
            // check group object khi mở từ file excel ( bind)
            if (!cellB.IsCellMerged)
            {
                // check group object khi nhập vào
                string C = cellC.ValueOnMask.ToString();
                if (string.IsNullOrWhiteSpace(C))
                {
                    // check công thức diễn giải khi nhập vào
                    string ColValueD = cellD.ValueOnMask.ToString();
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
                                cellD.Range.Value = segment[1].Trim().Split("=").Length > 1 ? interpretiveFormula : interpretiveFormula + " = " + FormatResult(result);

                                string formulaL = "=" + segment[1].Trim().Split("=")[0];
                                cellL.Range.Formula = formulaL;
                                IsInterpretiveFormula = true;
                            }
                            else
                            {
                                cellD.Range.Value = interpretiveFormula + " :";
                                IsInterpretiveFormula = true;
                            }
                        }
                        else
                        {
                            cellD.Range.Value = interpretiveFormula + " :";
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
                // Sử dụng thư viện DataTable để thử tính toán biểu thức.
                DataTable table = new DataTable();
                table.Compute(expression, "");

                // Nếu không có lỗi nào xảy ra, biểu thức là hợp lệ.
                return true;
            }
            catch (Exception)
            {
                // Nếu có lỗi xảy ra, biểu thức không hợp lệ.
                return false;
            }
        }

        static double EvaluateExpression(string expression)
        {
            // Sử dụng DataTable.Compute để tính toán giá trị biểu thức
            DataTable table = new DataTable();
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
