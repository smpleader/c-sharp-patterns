﻿
using BaseInterface;
using Syncfusion.XlsIO;

namespace modDisplay
{
    public class ACol
    {
        public ACol(ARowObject r)
        {
            Row = r;
            BL = new AColBl(this);
            Data = new AColDt(this, "");
        }
        public ARowObject Row { get; set; }
        public virtual string UniqueName { get { return ""; } }
        public virtual string Col { get { return "A"; } }
        public virtual string TongTienVatTu { get { return ""; } }
        public virtual string[] Params { get { return new string[2] { Row.Id.ToString(), TongTienVatTu }; } }

        /// <summary>
        /// IRange của cột trong row object
        /// </summary>
        public virtual IRange Range { 
            get 
            {
                return Row.worksheet.Range[Col + Row.Id];
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

        public virtual void render()
        {
            Row.spreadsheetGrid.SetCellValue(Range, BL.Calculate());
            Row.worksheet.AutofitRow(Row.Id);
        }
    }
    public class AColBl : IColBL
    {
        private ACol Col;
        private ICell CellBL;
        public AColBl(ACol col)
        {
            Col = col;
            BaseInterface.IModBL modBLContainer = SimpleInjectionDI.dynamicContainer.GetInstance<BaseInterface.IModBL>();
            CellBL = modBLContainer.Get(Col.UniqueName);
        }

        public string UniqueName { get { return Col.UniqueName; } }

        public string Calculate()
        {
            // render trên working sheet
            return CellBL.formula(Col.Params);
        }

        public string Display()
        {
            //todo: hiển thị lên mark sheet
            return CellBL.formula(Col.Params);
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
