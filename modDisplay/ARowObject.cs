using Syncfusion.Windows.Forms.Grid;
using Syncfusion.XlsIO;
using Row = modData.Memories.ARecord;

namespace modDisplay
{
    public class ARowObject : Row
    {
        public ARowObject(GridControl gridControl, IWorksheet workingsheet)
        {
            this.gridControl = gridControl;
            this.workingsheet = workingsheet;

            // Lấy hạng mục ID từ tên của workingsheet
            string workingsheetName = workingsheet.Name;
            int indexSub = workingsheetName.IndexOf("_");
            this.HangMucId = workingsheetName.Substring(indexSub+1);
        }
        public GridControl gridControl { get; set; }
        public IWorksheet workingsheet { get; set; }
        public string HangMucId { get; set; }   
        public int start { get; set; }
        public int end { get; set; }
        public int height { get { return end - start; } }
        public void import(int s, int e)
        {
            // todo : asign column from masksheet
        }
        public virtual void style()
        {

        }
    }
}
