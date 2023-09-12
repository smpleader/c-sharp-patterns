namespace modDisplay
{
    public class AGenerator : ISheet
    {
        public virtual string Name { get { return "--"; } }
        public virtual void init(string tabName) { }
        /// <summary>
        /// Sử dụng khi mở file
        /// </summary>
        public virtual void loadData()
        {
            // header define
            // footer define
            // data range process
        }
        public virtual void beforeSave() { }
        public virtual void afterSave() { }
        public virtual void selectCell() { }
        public virtual void afterCellInput() { }
        public virtual void addMenu() { }
        public virtual void cellDataChanged() { }

    }
}
