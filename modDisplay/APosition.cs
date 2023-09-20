using Syncfusion.Windows.Forms.Grid;
using Syncfusion.XlsIO;

namespace modDisplay
{
    public class APosition : IPosition
    {
        public virtual string Name { get { return "--"; } }
        public GridControl gridControl { get; set; }
        public IWorksheet workingsheet { get; set; }
        public int Id { get; set; }
        public int start { get; set; }
        public int end { get; set; }

        /// <summary>
        /// Check if row belongs to range of the position
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public virtual bool HasRow(int row)
        {
            return start <= row && row <= end;
        }
        public string HangMucId { get; set; }
        public virtual void bind(bool maskToWorking = true) { }
        public virtual void render(bool maskToWorking = true) { }
        public virtual void bindInMaskSheet(int row)
        {
            // should override bindInMaskSheet
        }
        public virtual void renderInWorkingsheet()
        {
            // should override renderInWorkingsheet
        }
        public virtual void bindInWoringsheet()
        {
            // should override bindInWoringsheet
        }
        public APosition(GridControl gridControl, IWorksheet workingsheet)
        {
            this.gridControl = gridControl;
            this.workingsheet = workingsheet;

            // Lấy hạng mục ID từ tên của workingsheet
            string workingsheetName = workingsheet.Name;
            int indexSub = workingsheetName.IndexOf("_");
            this.HangMucId = workingsheetName.Substring(indexSub + 1);  
        }
    }
}
