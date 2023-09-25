namespace modDisplay
{
    public interface ISheet
    {
        string Name { get; }
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

    }
}
