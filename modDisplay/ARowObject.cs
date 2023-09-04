using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
using Row = modData.Memories.ARecord;

namespace modDisplay
{
    public class ARowObject : Row
    {
        public ARowObject(SpreadsheetGrid spreadsheetGrid, IWorksheet worksheet)
        {
            this.spreadsheetGrid = spreadsheetGrid;
            this.worksheet = worksheet;
        }
        public SpreadsheetGrid spreadsheetGrid;
        public IWorksheet worksheet;

        public int start { get; set; }
        public int end { get; set; }
        public int height { get { return end - start; } }
        public void import(int s, int e)
        {
            // todo : asign column from worksheet
        }
    }
}
