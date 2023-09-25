using Microsoft.Office.Interop.Excel;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.XlsIO;

namespace modDisplay.templates.tienluong.row
{
    static class Helper
    {
        /// <summary>
        /// Tìm index row của footer của template vật liệu
        /// </summary>
        /// <param name="footer"></param>
        /// <param name="ws">Template</param>
        /// <param name="start">Chỉ số dòng bắt đầu tìm</param>
        /// <returns></returns>
        public static int FindIndexRowFooter(GridControl ws, IWorksheet worksheet, int start)
        {
            for (int indexRow = start; indexRow <= ws.RowCount; indexRow++)
            {
                string A = worksheet.Range["A" + indexRow].Value;
                // Tìm dòng cuối của template
                if (!string.IsNullOrWhiteSpace(A))
                {
                    if (A == "CỘNG HẠNG MỤC")
                    {
                        return indexRow;
                    }
                }
            }
            return -1;
        }
        public static bool IsRowObject(GridControl gridControl, int indexRow)
        {
            if (!gridControl.Model.CoveredRanges.Ranges.Contains(GridRangeInfo.Cell(indexRow,Util.CellUtility.GetExcelColumnNumber("B"))))
            {
                string C = gridControl[indexRow, Util.CellUtility.GetExcelColumnNumber("C")].Text;
                if (!string.IsNullOrWhiteSpace(C) && !C.StartsWith("*"))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsRowObject(IWorksheet worksheet, int indexRow)
        {
            if (!worksheet.Range["B" + indexRow].IsMerged)
            {
                string C = worksheet.Range["C" + indexRow].Value;
                if (!string.IsNullOrWhiteSpace(C) && !C.StartsWith("*"))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsGroupObject(GridControl gridControl, int indexRow)
        {
            if (gridControl.Model.CoveredRanges.Ranges.Contains(GridRangeInfo.Cells(indexRow, Util.CellUtility.GetExcelColumnNumber("B"), indexRow, Util.CellUtility.GetExcelColumnNumber("Q"))))
            {
                return true;
            }
            else
            {
                string C = gridControl[indexRow, Util.CellUtility.GetExcelColumnNumber("C")].Text;
                if (!string.IsNullOrWhiteSpace(C) && C.StartsWith("*"))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsGroupObject( IWorksheet worksheet, int indexRow)
        {
            if (worksheet.Range["B" + indexRow].IsMerged)
            {
                return true;
            }
            else
            {
                string C = worksheet.Range["C" + indexRow].Value;
                if (!string.IsNullOrWhiteSpace(C) && C.StartsWith("*"))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsAdditionalRowObject(GridControl gridControl, int indexRow)
        {
            if (!gridControl.Model.CoveredRanges.Ranges.Contains(GridRangeInfo.Cell(indexRow, Util.CellUtility.GetExcelColumnNumber("B"))))
            {
                string C = gridControl[indexRow, Util.CellUtility.GetExcelColumnNumber("C")].Text;
                string B = gridControl[indexRow, Util.CellUtility.GetExcelColumnNumber("B")].Text;

                if (string.IsNullOrWhiteSpace(C) && string.IsNullOrWhiteSpace(B))
                {
                    string D = gridControl[indexRow, Util.CellUtility.GetExcelColumnNumber("D")].Text;
                    string L = gridControl[indexRow, Util.CellUtility.GetExcelColumnNumber("L")].Text;

                    // check công thức diễn giải khi nhập vào
                    if (!string.IsNullOrWhiteSpace(D) || !string.IsNullOrWhiteSpace(L))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool IsAdditionalRowObject( IWorksheet worksheet, int indexRow)
        {
            if (!worksheet.Range["B" + indexRow].IsMerged)
            {
                string C = worksheet.Range["C" + indexRow].Value;
                string B = worksheet.Range["B" + indexRow].Value;

                if (string.IsNullOrWhiteSpace(C) && string.IsNullOrWhiteSpace(B))
                {
                    string D = worksheet.Range["D" + indexRow].Value;
                    string L = worksheet.Range["L" + indexRow].Value;

                    // check công thức diễn giải khi nhập vào
                    if (!string.IsNullOrWhiteSpace(D) || !string.IsNullOrWhiteSpace(L))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
