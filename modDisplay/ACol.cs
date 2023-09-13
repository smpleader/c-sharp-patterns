﻿
using BaseInterface;
using Syncfusion.XlsIO;
using static modDisplay.templates.vatlieu.Row;

namespace modDisplay
{
    public class ACol
    {
        protected BaseInterface.IModBL modBLContainer;
        public ACol(ARowObject r)
        {
            Row = r;
            modBLContainer = SimpleInjectionDI.dynamicContainer.GetInstance<BaseInterface.IModBL>();
            BL = new AColBl(this);
            Data = new AColDt(this, "");
            HangMucId = r.HangMucId;
        }
        public ARowObject Row { get; set; }
        public string HangMucId { get; set; }

        public virtual string UniqueName { get { return ""; } }
        public virtual string Col { get { return "A"; } }
        public virtual string TongTienVatTu { get { return ""; } }
        public virtual string[] Params { get { return new string[2] { Row.Id.ToString(), TongTienVatTu }; } }

        /// <summary>
        /// IRange cột trong mask sheet
        /// </summary>
        public virtual IRange RangeDisplay
        { 
            get 
            {
                return Row.masksheet.Range[Col + Row.Id];
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
        public virtual IColBL BL { get; set; }

        /// <summary>
        /// Xử lý dữ liệu
        /// </summary>
        public virtual IData Data { get; set; }

        /// <summary>
        /// Cập nhật data vào working sheet
        /// <para>Hiển thị dữ liệu ra mark sheet</para>
        /// </summary>
        public virtual void Render()
        {
            string formula = modBLContainer.Get(UniqueName).formula(HangMucId, Params);
            //Row.spreadsheetGrid.SetCellValue(RangeDisplay, formula); // bỏ set công thức cho masksheet
            Range.Formula = formula;
            Row.masksheet.AutofitRow(Row.Id);
        }
        public virtual void Bind()
        {
            // override to validate data before updating workingsheet
            Row.spreadsheetGrid.SetCellValue(Range, RangeDisplay.Value);
        }
    }
    public class AColBl : IColBL
    {
        private ACol Col;
        private ICell BL;
        public AColBl(ACol col)
        {
            Col = col;
            BaseInterface.IModBL modBLContainer = SimpleInjectionDI.dynamicContainer.GetInstance<BaseInterface.IModBL>();
            BL = modBLContainer.Get(Col.UniqueName);
        }

        public string UniqueName { get { return Col.UniqueName; } }

        public virtual string GetFormulaCalculate()
        {
            // render trên working sheet
            return BL.formula(Col.HangMucId,Col.Params);
        }
        public virtual string GetFormulaDisplay()
        {
            //todo: hiển thị lên mark sheet
            return BL.formula(Col.Params);
        }
    }
    public class AColDt : IData
    {
        private ACol Col;
        public AColDt(ACol col, string name)
        {
            Col = col;
            Name = name;
        }
        public string Name { get; set; } = "--";
    }
}
