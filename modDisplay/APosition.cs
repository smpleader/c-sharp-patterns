using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;

namespace modDisplay
{
    public class APosition : IPosition
    {
        public virtual string Name { get { return "--"; } }
        public SpreadsheetGrid spreadsheetGrid { get; set; }
        public IWorksheet worksheet { get; set; }

        public int Id { get; set; }

        public virtual void bind() { }

        public virtual void render() { }
        public APosition(SpreadsheetGrid spreadsheetGrid, IWorksheet worksheet)
        {
            this.spreadsheetGrid = spreadsheetGrid;
            this.worksheet = worksheet;
        }
    }
}
