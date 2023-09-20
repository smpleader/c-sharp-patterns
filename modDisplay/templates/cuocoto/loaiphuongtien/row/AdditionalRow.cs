using modDisplay.row;
using modDisplay.templates.tienluong.row;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.XlsIO;

namespace modDisplay.templates.cuocoto.loaiphuongtien.row
{
    internal class AdditionalRow : ARowObject
    {
        public AdditionalRow(GridControl gridControl, IWorksheet worksheet, IWorksheet workingsheet, int id, int parentId) : base(gridControl, worksheet, workingsheet)
        {
            Id = id;
            ParentId = parentId;
        }
        public int ParentId { get; set; }

        /// <summary>
        /// Tên vật liệu
        /// </summary>
        public IRange C { get { return this.Cell("C"); } }
        /// <summary>
        /// Cự ly (km)
        /// </summary>
        public IRange J { get { return this.Cell("J"); } }
        /// <summary>
        /// Giá cước
        /// </summary>
        public IRange K { get { return this.Cell("K"); } }
        /// <summary>
        /// Thành tiền
        /// </summary>
        public IRange L { get { return this.Cell("L"); } }

        class ColL : ACell
        {
            public override string UniqueName { get { return "CuocOto_LoaiPhuongTien_ThanhTienCuLyNhoHonBang1000M"; } }
            public override string Col { get { return "L"; } }
            public override string[] Params { get { return new string[2] { (Row as AdditionalRow).ParentId.ToString(), Row.Id.ToString() }; } }

            public ColL(ARowObject r) : base(r)
            {
            }
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
            ColL colL = new ColL(this);
            colL.Render();
        }
    }
}
