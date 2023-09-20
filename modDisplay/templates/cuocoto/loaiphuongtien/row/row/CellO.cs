using modDisplay.row;
namespace modDisplay.templates.cuocoto.loaiphuongtien.row.row
{
    /// <summary>
    /// Định mức dỡ xuống
    /// </summary>
    public class CellO : ACell
    {
        public override string UniqueName { get { return "CuocOto_LoaiPhuongTien_DinhMucDoXuong"; } }
        public override string Col { get { return "O"; } }

        public CellO(Row r) : base(r)
        {
        }
        public override void Render()
        {

        }
        public override void Bind()
        {
            base.Bind();
        }
    }
}
