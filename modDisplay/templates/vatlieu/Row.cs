using modDisplay.templates.tienluong.row;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;

namespace modDisplay.templates.vatlieu
{
    internal class Row : ARowObject
    {
        public Row(SpreadsheetGrid spreadsheetGrid, IWorksheet worksheet, int id) : base(spreadsheetGrid, worksheet)
        {
            Id = id;
        }

        /// <summary>
        /// Ký hiệu bản vẽ
        /// </summary>
        public IRange A { get { return this.Cell("A"); } }
        /// <summary>
        /// STT
        /// </summary>
        public IRange B { get { return this.Cell("B"); } }
        /// <summary>
        /// MSCV
        /// </summary>
        public IRange C { get { return this.Cell("C"); } }
        /// <summary>
        /// Tên công việc
        /// </summary>
        public IRange D { get { return this.Cell("D"); } }
        /// <summary>
        /// Đơn vị
        /// </summary>
        public IRange E { get { return this.Cell("E"); } }
        /// <summary>
        /// Tên CK
        /// </summary>
        public IRange F { get { return this.Cell("F"); } }
        /// <summary>
        /// Số CK
        /// </summary>
        public IRange G { get { return this.Cell("G"); } }
        /// <summary>
        /// Dài
        /// </summary>
        public IRange H { get { return this.Cell("H"); } }
        /// <summary>
        /// Rộng
        /// </summary>
        public IRange I { get { return this.Cell("I"); } }
        /// <summary>
        /// Cao
        /// </summary>
        public IRange J { get { return this.Cell("J"); } }
        /// <summary>
        /// HS phụ
        /// </summary>
        public IRange K { get { return this.Cell("K"); } }
        /// <summary>
        /// KL Phụ
        /// </summary>
        public IRange L { get { return this.Cell("L"); } }
        /// <summary>
        /// Khối lượng
        /// </summary>
        public IRange M { get { return this.Cell("M"); } }
        /// <summary>
        /// Đơn giá vật liệu
        /// </summary>
        public IRange N { get { return this.Cell("N"); } }
        /// <summary>
        /// Đơn giá vật liệu phụ
        /// </summary>
        public IRange O { get { return this.Cell("O"); } }
        /// <summary>
        /// Đơn giá nhân công
        /// </summary>
        public IRange P { get { return this.Cell("P"); } }
        /// <summary>
        /// Đơn giá máy
        /// </summary>
        public IRange Q { get { return this.Cell("Q"); } }
        /// <summary>
        /// Thành tiền vật liệu
        /// </summary>
        public IRange R { get { return this.Cell("R"); } }
        /// <summary>
        /// Thành tiền vật liệu phụ
        /// </summary>
        public IRange S { get { return this.Cell("S"); } }
        /// <summary>
        /// Thành tiền nhân công
        /// </summary>
        public IRange T { get { return this.Cell("T"); } }
        /// <summary>
        /// Thành tiền máy
        /// </summary>
        public IRange U { get { return this.Cell("U"); } }
        /// <summary>
        /// Hệ số điều chỉnh vật liệu
        /// </summary>
        public IRange V { get { return this.Cell("V"); } }
        /// <summary>
        /// Hệ số điều chỉnh nhân công
        /// </summary>
        public IRange W { get { return this.Cell("W"); } }
        /// <summary>
        /// Hệ số điều chỉnh máy
        /// </summary>
        public IRange X { get { return this.Cell("X"); } }
        /// <summary>
        /// Thông tin đơn giá
        /// </summary>
        public IRange Y { get { return this.Cell("Y"); } }
        /// <summary>
        /// Tổng giá của tất cả các vật liệu
        /// </summary>
        public IRange Z { get { return this.Cell("Z"); } }
        /// <summary>
        /// Tổng giá của tất cả các vật liệu phụ
        /// </summary>
        public IRange AA { get { return this.Cell("AA"); } }
        /// <summary>
        /// Tổng giá của tất cả các nhân công
        /// </summary>
        public IRange AB { get { return this.Cell("AB"); } }
        /// Tổng giá của tất cả các máy
        public IRange AC { get { return this.Cell("AC"); } }
        class ColO : ACol
        {
            public override string UniqueName { get { return "VatLieu_GiaHienTruong"; } }
            public override string Col { get { return "O"; } }
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }
            public ColO(Row r) : base(r)
            {
            }
        }
        class ColI : ACol
        {
            public override string UniqueName { get { return "VatLieu_CuocOto"; } }
            public override string Col { get { return "I"; } }
            // Chưa lấy đúng refer cần xác định refer khi có modData
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }
            public ColI(Row r) : base(r)
            {
            }
        }
        class ColJ : ACol
        {
            public override string UniqueName { get { return "VatLieu_CuocSong"; } }
            public override string Col { get { return "J"; } }
            // Chưa lấy đúng refer cần xác định refer khi có modData
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

            public ColJ(Row r) : base(r)
            {
            }
        }
        class ColK : ACol
        {
            public override string UniqueName { get { return "VatLieu_CuocThuCong"; } }
            public override string Col { get { return "K"; } }
            // Chưa lấy đúng refer cần xác định refer khi có modData
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

            public ColK(Row r) : base(r)
            {
            }
        }
        class ColL : ACol
        {
            public override string UniqueName { get { return "VatLieu_CuocBien"; } }
            public override string Col { get { return "L"; } }
            // Chưa lấy đúng refer cần xác định refer khi có modData
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

            public ColL(Row r) : base(r)
            {
            }
        }
        class ColN : ACol
        {
            public override string UniqueName { get { return "VatLieu_TongCuoc"; } }
            public override string Col { get { return "N"; } }
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

            public ColN(Row r) : base(r)
            {
            }
        }
        class ColH : ACol
        {
            public override string UniqueName { get { return "VatLieu_GiaTBxHS"; } }
            public override string Col { get { return "H"; } }
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

            public ColH(Row r) : base(r)
            {
            }
        }
        internal void bind()
        {
            // todo: khi thay đổi thì cập nhật giá các công việc có chứa vật tư
        }
        internal void render()
        {
            ColH colH = new ColH(this);
            colH.render();
            ColI colI = new ColI(this);
            colI.render();
            ColJ colJ = new ColJ(this);
            colJ.render();
            ColK colK = new ColK(this);
            colK.render();
            ColL colL = new ColL(this);
            colL.render();
            ColN colN = new ColN(this);
            colN.render();
            ColO colO = new ColO(this);
            colO.render();
        }
        public void AddSimpleData()
        {
            spreadsheetGrid.SetCellValue(B, "V01897");
            spreadsheetGrid.SetCellValue(C, "Cát vàng");
            spreadsheetGrid.SetCellValue(D, "m3");

            spreadsheetGrid.SetCellValue(G, "1");
            spreadsheetGrid.SetCellValue(E, "389809");
            spreadsheetGrid.SetCellValue(F, "389809");

        }
    }
}
