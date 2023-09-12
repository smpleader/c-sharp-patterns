using Syncfusion.Windows.Forms.Spreadsheet;

namespace modDisplay
{
    public interface IPosition
    {
        SpreadsheetGrid spreadsheetGrid { get; set; }
        string Name { get; }
        int Id { get; set; }
        void bind(bool maskToWorking = true);
        void render(bool maskToWorking = true);
    }
}
