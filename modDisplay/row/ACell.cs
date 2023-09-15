
using BaseInterface;
using Syncfusion.XlsIO;

namespace modDisplay.row
{
    public class ACell
    {
        protected IModBL modBLContainer;
        public ACell(ARowObject r)
        {
            Row = r;
            modBLContainer = SimpleInjectionDI.dynamicContainer.GetInstance<IModBL>();
            BL = new ACellBl(this);
            Data = new ACellDt(this, "");
            HangMucId = r.HangMucId;
        }
        public ARowObject Row { get; set; }
        public string HangMucId { get; set; }
        public virtual string UniqueName { get { return ""; } }
        public virtual string Col { get { return "A"; } }
        public virtual int ColIndex { get { return Util.CellUtility.GetExcelColumnNumber(Col); } }

        public virtual string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

        /// <summary>
        /// IRange cột trong mask sheet
        /// </summary>
        public virtual object ValueOnMask
        {
            get
            {
                return Row.gridControl[Row.Id, ColIndex].CellValue;
            }
        }
        /// <summary>
        /// IRange cột trong workingsheet
        /// </summary>
        public virtual IRange Range
        {
            get
            {
                return Row.workingsheet.Range[Col + Row.Id];
            }
        }

        /// <summary>
        /// Xử lý nghiệp vụ
        /// </summary>
        public IColBL BL { get; set; }

        /// <summary>
        /// Xử lý dữ liệu
        /// </summary>
        public IData Data { get; set; }

        /// <summary>
        /// Cập nhật data vào working sheet
        /// <para>Hiển thị dữ liệu ra mark sheet</para>
        /// </summary>
        public virtual void Render()
        {
            string formula = modBLContainer.Get(UniqueName).formula(HangMucId, Params);
            //Row.gridControl.SetCellValue(RangeDisplay, formula); // bỏ set công thức cho masksheet
            Range.Formula = formula;
            Row.masksheet.AutofitRow(Row.Id);
        }
        public virtual void Bind()
        {
            // override to validate data before updating workingsheet
            Range.Value2 = ValueOnMask;
        }
    }
}
