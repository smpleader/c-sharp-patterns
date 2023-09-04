using Syncfusion.Windows.Forms.Spreadsheet;

namespace modDisplay
{
    public interface IPosition
    {
        SpreadsheetGrid spreadsheetGrid { get; set; }
        string Name { get; }
        int Id { get; set; }
        void bind();
        void render();
    }
}
