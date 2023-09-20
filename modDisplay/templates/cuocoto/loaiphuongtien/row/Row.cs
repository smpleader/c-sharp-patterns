using modDisplay.row;
using modDisplay.templates.tienluong.row;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.XlsIO;

namespace modDisplay.templates.cuocoto.loaiphuongtien.row
{
    internal class Row : ARowObject
    {
        public Row(GridControl gridControl, IWorksheet worksheet, IWorksheet workingsheet, int id) : base(gridControl, worksheet, workingsheet)
        {
            Id = id;
        }

        /// <summary>
        /// Số thứ tự
        /// </summary>
        public IRange A { get { return this.Cell("A"); } }
        /// <summary>
        /// Mã vật liệu
        /// </summary>
        public IRange B { get { return this.Cell("B"); } }
        /// <summary>
        /// Tên vật liệu
        /// </summary>
        public IRange C { get { return this.Cell("C"); } }
        /// <summary>
        /// Đơn vị
        /// </summary>
        public IRange D { get { return this.Cell("D"); } }
        /// <summary>
        /// Nhóm hàng
        /// </summary>
        public IRange E { get { return this.Cell("E"); } }
        /// <summary>
        /// Đơn vị nhóm hàng	
        /// </summary>
        public IRange F { get { return this.Cell("F"); } }
        /// <summary>
        /// Hệ số quy đổi đơn vị
        /// </summary>
        public IRange G { get { return this.Cell("G"); } }
        /// <summary>
        /// Nguồn hàng
        /// </summary>
        public IRange H { get { return this.Cell("H"); } }
        /// <summary>
        /// Loại phương tiện
        /// </summary>
        public IRange I { get { return this.Cell("I"); } }
        /// <summary>
        /// Tổng cự ly
        /// </summary>
        public IRange J { get { return this.Cell("J"); } }
        /// <summary>
        /// Giá cước cự ly 
        /// </summary>
        public IRange K { get { return this.Cell("K"); } }
        /// <summary>
        /// Thành tiền chi phí vận chuyển
        /// </summary>
        public IRange L { get { return this.Cell("L"); } }
        /// <summary>
        /// Trọng lượng tấn
        /// </summary>
        public IRange M { get { return this.Cell("M"); } }
        /// <summary>
        /// Định mức bốc lên
        /// </summary>
        public IRange N { get { return this.Cell("N"); } }
        /// <summary>
        /// Định mức dỡ xuống
        /// </summary>
        public IRange O { get { return this.Cell("O"); } }
        /// <summary>
        /// Thành tiền chi phí bốc dỡ
        /// </summary>
        public IRange P { get { return this.Cell("P"); } }
        /// <summary>
        /// Định mức hao hụt
        /// </summary>
        public IRange Q { get { return this.Cell("Q"); } }
        /// <summary>
        /// Thành tiền
        /// </summary>
        public IRange R { get { return this.Cell("R"); } }
        /// <summary>
        /// Cước khác	
        /// </summary>
        public IRange S { get { return this.Cell("S"); } }
        /// <summary>
        /// Tổng cước
        /// </summary>
        public IRange T { get { return this.Cell("T"); } }

        class ColJ : ACell
        {
            public override string UniqueName { get { return "CuocOto_LoaiPhuongTien_TongCuLy"; } }
            public override string Col { get { return "J"; } }
            public override string[] Params { get { return new string[2] { Row.Id.ToString(), Row.end.ToString() }; } }

            public ColJ(Row r) : base(r)
            {
            }
        }
        class ColL : ACell
        {
            public override string UniqueName { get { return "CuocOto_LoaiPhuongTien_ThanhTienChiPhiVanChuyen"; } }
            public override string Col { get { return "L"; } }
            public override string[] Params { get { return new string[2] { Row.Id.ToString(), Row.end.ToString() }; } }

            public ColL(Row r) : base(r)
            {
            }
        }
        class ColP : ACell
        {
            public override string UniqueName { get { return "CuocOto_LoaiPhuongTien_ThanhTienChiPhiBocDo"; } }
            public override string Col { get { return "P"; } }
            // Chưa lấy đúng refer cần xác định refer khi có modData
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

            public ColP(Row r) : base(r)
            {
            }
        }

        class ColT : ACell
        {
            public override string UniqueName { get { return "CuocOto_LoaiPhuongTien_TongCuoc"; } }
            public override string Col { get { return "T"; } }
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

            public ColT(Row r) : base(r)
            {
            }
        }

        internal void bind()
        {
            // todo: khi thay đổi thì cập nhật giá các công việc có chứa vật tư
        }
        internal void render()
        {
            ColJ colJ = new ColJ(this);
            colJ.Render();
            ColL colL = new ColL(this);
            colL.Render();
            ColP colP = new ColP(this);
            colP.Render();
            ColT colT = new ColT(this);
            colT.Render();
        }
        public void AddSimpleData()
        {
            //gridControl.SetCellValue(C, "V01897");
            //gridControl.SetCellValue(E, "Cát vàng");
            //gridControl.SetCellValue(F, "m3");

            //gridControl.SetCellValue(K, "1");
            //gridControl.SetCellValue(G, "389809");
            //gridControl.SetCellValue(J, "389809");
        }
    }
}
