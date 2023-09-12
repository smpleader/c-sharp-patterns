using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;

namespace modDisplay
{
    public class APosition : IPosition
    {
        public virtual string Name { get { return "--"; } }
        public SpreadsheetGrid spreadsheetGrid { get; set; }
        public IWorksheet masksheet { get; set; }
        public IWorksheet workingsheet { get; set; }
        public int Id { get; set; }

        public virtual void bind(bool maskToWorking = true) { }

        public virtual void render(bool maskToWorking = true) { }
        public APosition(SpreadsheetGrid spreadsheetGrid, IWorksheet worksheet, IWorksheet workingsheet)
        {
            this.spreadsheetGrid = spreadsheetGrid;
            this.masksheet = worksheet;
            this.workingsheet = workingsheet;
        }
    }
}
