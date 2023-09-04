using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
namespace modDisplay.templates.cuocoto.tongculy.row
{
    internal class Helper
    {
        public static bool IsRowObject(SpreadsheetGrid spreadsheetGrid, IWorksheet worksheet, int indexRow)
        {
            string B = worksheet.Range["B" + indexRow].Value;
            if (!string.IsNullOrWhiteSpace(B))
            {
                return true;
            }
            return false;
        }
    }
}
