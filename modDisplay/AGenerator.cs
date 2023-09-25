using Syncfusion.Windows.Forms.Grid;
using Syncfusion.XlsIO;

namespace modDisplay
{
    public class AGenerator : ISheet
    {
        public virtual string Name { get { return "--"; } }
        public bool IsEditting = false;
        public GridControl gridControl { get; set; }
        public IWorksheet workingsheet { get; set; }

        public Dictionary<string, APosition> Positions;
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
        public virtual void insertRow(int indexRow, int count) { }
        public virtual void deleteRow(int indexRow, int count) { }


        public APosition Position(string name)
        {
            if (!Positions.Keys.Contains(name))
            {
                Positions[name] = new APosition(gridControl, workingsheet);
            }
            return Positions[name];
        }
        public APosition Address(int rowIndex)
        {
            foreach (APosition position in Positions.Values)
            {
                if (position.HasRow(rowIndex))
                {
                    return position;
                }
            }
            return Positions["Body"];
        }
    }
}
