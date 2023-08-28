using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;
using Worksheet.modDisplay.templates.tienluong.row;

namespace Worksheet.modDisplay.templates.cuocoto.tongculy.row
{
    internal class Row : ARowObject
    {
        public Row(SpreadsheetGrid spreadsheetGrid, IWorksheet worksheet, int id) : base(spreadsheetGrid, worksheet)
        {
            Id = id;
        }

        /// <summary>
        /// STT
        /// </summary>
        public IRange A { get { return this.Cell("A"); } }
        /// <summary>
        /// MSCV
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
        /// Khối lượng đơn vị
        /// </summary>
        public IRange E { get { return this.Cell("E"); } }
        /// <summary>
        /// Bậc hàng
        /// </summary>
        public IRange F { get { return this.Cell("F"); } }
        /// <summary>
        /// Hệ số bậc hàng
        /// </summary>
        public IRange G { get { return this.Cell("G"); } }
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
        /// <summary>
        /// Tổng cước trước thuế
        /// </summary>
        public IRange X { get { return this.Cell("X"); } }

        class ColM : ACol
        {
            public override string UniqueName { get { return "CuocOto_TongCuLy"; } }
            public override string Col { get { return "M"; } }
            public override string[] Params { get { return new string[2] { Row.Id.ToString(), Row.end.ToString() }; } }
            public ColM(Row r) : base(r)
            {
            }
        }

        class ColO : ACol
        {
            public override string UniqueName { get { return "CuocOto_ChiPhiVanChuyenSauThue"; } }
            public override string Col { get { return "O"; } }
            // Chưa lấy đúng refer cần xác định refer khi có modData
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

            public ColO(Row r) : base(r)
            {
            }
        }
        class ColP : ACol
        {
            public override string UniqueName { get { return "CuocOto_ChiPhiVanChuyenTruocThue"; } }
            public override string Col { get { return "P"; } }
            // Chưa lấy đúng refer cần xác định refer khi có modData
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

            public ColP(Row r) : base(r)
            {
            }
        }
        class ColS : ACol
        {
            public override string UniqueName { get { return "CuocOto_ThanhTienChiPhiBocDo"; } }
            public override string Col { get { return "S"; } }
            // Chưa lấy đúng refer cần xác định refer khi có modData
            public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

            public ColS(Row r) : base(r)
            {
            }
        }
        class ColX : ACol
        {
            public override string UniqueName { get { return "CuocOto_TongCuoc"; } }
            public override string Col { get { return "X"; } }
            public override string[] Params { get { return new string[2] { Row.Id.ToString(), Row.end.ToString() }; } }

            public ColX(Row r) : base(r)
            {
            }
        }

        internal void bind()
        {
            // todo: khi thay đổi thì cập nhật giá các công việc có chứa vật tư
        }
        internal void render()
        {
            ColM colM = new ColM(this);
            colM.render();
            ColO colO = new ColO(this);
            colO.render();
            ColP colP = new ColP(this);
            colP.render();
            ColS colS = new ColS(this);
            colS.render();
            ColX colX = new ColX(this);
            colX.render();
        }
        public void AddSimpleData()
        {
            spreadsheetGrid.SetCellValue(B, "V01897");
            spreadsheetGrid.SetCellValue(C, "Cát vàng");
            spreadsheetGrid.SetCellValue(D, "m3");
            spreadsheetGrid.SetCellValue(E, "1.45");
            spreadsheetGrid.SetCellValue(F, "Bậc 1");
            spreadsheetGrid.SetCellValue(G, "1.0");
            spreadsheetGrid.SetCellValue(I, "Ô tô");
            spreadsheetGrid.SetCellValue(J, "1.0");
            spreadsheetGrid.SetCellValue(K, "Loại 1");

            spreadsheetGrid.SetCellValue(N, "2984");
        }
    }
}
