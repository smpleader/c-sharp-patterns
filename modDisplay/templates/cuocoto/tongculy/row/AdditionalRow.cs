using modDisplay.row;
using modDisplay.templates.tienluong.row;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;

namespace modDisplay.templates.cuocoto.tongculy.row
{
    internal class AdditionalRow : ARowObject
    {
        public AdditionalRow(SpreadsheetGrid spreadsheetGrid, IWorksheet worksheet, IWorksheet workingsheet, int id, int parentId) : base(spreadsheetGrid, worksheet, workingsheet)
        {
            Id = id;
            ParentId = parentId;
        }
        public int ParentId { get; set; }
        /// <summary>
        /// Nguồn mua
        /// </summary>
        public IRange H { get { return this.Cell("H"); } }
        /// <summary>
        /// Phương tiện
        /// </summary>
        public IRange I { get { return this.Cell("I"); } }
        /// <summary>
        /// Hệ số phương tiện
        /// </summary>
        public IRange J { get { return this.Cell("J"); } }
        /// <summary>
        /// Loại đường
        /// </summary>
        public IRange K { get { return this.Cell("K"); } }
        /// <summary>
        /// Cự ly (km)
        /// </summary>
        public IRange L { get { return this.Cell("L"); } }
        /// <summary>
        /// Tổng cự ly
        /// </summary>
        public IRange M { get { return this.Cell("M"); } }
        /// <summary>
        /// Cước cơ bản
        /// </summary>
        public IRange N { get { return this.Cell("N"); } }
        /// <summary>
        /// Cước sau thuế
        /// </summary>
        public IRange O { get { return this.Cell("O"); } }
        /// <summary>
        /// Trước thuế
        /// </summary>
        public IRange P { get { return this.Cell("P"); } }
        /// <summary>
        /// Định mức bốc dỡ
        /// </summary>
        public IRange Q { get { return this.Cell("Q"); } }
        /// <summary>
        /// Cước nâng hạ
        /// </summary>
        public IRange R { get { return this.Cell("R"); } }
        /// <summary>
        /// Thành tiền vật
        /// </summary>
        public IRange S { get { return this.Cell("S"); } }
        /// <summary>
        /// Giá TB
        /// </summary>
        public IRange T { get { return this.Cell("T"); } }
        /// <summary>
        /// Định mức hao hụt
        /// </summary>
        public IRange U { get { return this.Cell("U"); } }
        /// <summary>
        /// Thành tiền hao hụt
        /// </summary>
        public IRange V { get { return this.Cell("V"); } }
        /// <summary>
        /// Chi phí khác
        /// </summary>
        public IRange W { get { return this.Cell("W"); } }

        class ColO : ACell
        {
            public override string UniqueName { get { return "CuocOto_ChiPhiVanChuyenSauThue"; } }
            public override string Col { get { return "O"; } }
            // Chưa lấy đúng refer cần xác định refer khi có modData
            /// Dòng cước thêm
            public override string[] Params { get { return new string[2] { (Row as AdditionalRow).ParentId.ToString(), Row.Id.ToString() }; } }

            public ColO(ARowObject r) : base(r)
            {
            }
        }
        class ColP : ACell
        {
            public override string UniqueName { get { return "CuocOto_ChiPhiVanChuyenTruocThue"; } }
            public override string Col { get { return "P"; } }
            // Chưa lấy đúng refer cần xác định refer khi có modData
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

            public ColP(ARowObject r) : base(r)
            {
            }
        }

        /// <summary>
        /// Lấy công thức cho các cột R, S, T, U
        /// </summary>
        /// <param name="col"></param>
        /// <returns></returns>
        public string GetFormula(string col)
        {
            string[] parameters = new string[1] { Id.ToString() };
            BaseInterface.IModBL modBLContainer = SimpleInjectionDI.dynamicContainer.GetInstance<BaseInterface.IModBL>();
            return string.Format(modBLContainer.Get("CongViec_KhoiLuongPhu").formula(parameters));
        }
        public void bind()
        {
            string A = masksheet.Range["A" + Id].Value;
            if (string.IsNullOrWhiteSpace(A))
            {
                // todo: detect an additional line
            }
        }

        internal void render()
        {
            ColO colO = new ColO(this);
            colO.Render();
            ColP colP = new ColP(this);
            colP.Render();
        }
    }
}
