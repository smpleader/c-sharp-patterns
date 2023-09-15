using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Spreadsheet;
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
        public static int FindIndexRowFooter(this Footer footer, GridControl ws, IWorksheet worksheet, int start)
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

        public static bool IsRowObject( IWorksheet worksheet, int indexRow)
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
        public static IRange Cell(this ARowObject aRowObject, string colName)
        {
            IRange cell = aRowObject.masksheet.Range[colName + aRowObject.Id];
            return cell;
        }
        public static IRange Cell(this ARowObject aRowObject, string colName, string row)
        {
            IRange cell = aRowObject.masksheet.Range[colName + row];
            return cell;
        }
    }
}
