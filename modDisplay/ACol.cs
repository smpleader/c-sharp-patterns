
namespace modDisplay
{
    public class ACol
    {
        public ACol(ARowObject r)
        {
            Row = r;
        }
        public ARowObject Row { get; set; }
        public virtual string UniqueName { get { return ""; } }
        public virtual string Col { get { return "A"; } }
        public virtual string TongTienVatTu { get { return ""; } }
        public virtual string[] Params { get { return new string[2] { Row.Id.ToString(), TongTienVatTu }; } }
        public virtual void render()
        {
            var range = Row.worksheet.Range[Col + Row.Id];
            BaseInterface.IModBL modBLContainer = SimpleInjectionDI.dynamicContainer.GetInstance<BaseInterface.IModBL>();
            Row.spreadsheetGrid.SetCellValue(range, string.Format(modBLContainer.Get(UniqueName).formula(Params)));
            Row.worksheet.AutofitRow(Row.Id);
        }
    }
}
