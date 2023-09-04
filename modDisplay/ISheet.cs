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
    }
}
