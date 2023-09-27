using Syncfusion.Windows.Forms.Grid;
using Syncfusion.XlsIO;

namespace modDisplay
{
    public interface ISheet
    {
        string Name { get; }
        GridControl gridControl { get; set; }
        IWorksheet workingsheet { get; set; }
        Dictionary<string, APosition> Positions { get; set; }
        void init(string tabName);
        void loadData();
        void beforeSave();
        void afterSave();
        void selectCell();
        void afterCellInput();
        void addMenu();
        void cellDataChanged();
        void insertRow(int indexRow, int count);
        void deleteRow(int indexRow, int count);
        string GetFormula(int row, int col);
    }
}
