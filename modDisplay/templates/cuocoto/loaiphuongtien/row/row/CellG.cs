using modDisplay.row;
namespace modDisplay.templates.cuocoto.loaiphuongtien.row.row
{
    /// <summary>
    /// Hệ số quy đổi đơn vị
    /// </summary>
    public class CellG : ACell
    {
        public override string UniqueName { get { return "CuocOto_LoaiPhuongTien_HeSoQuyDoiDonVi"; } }
        public override string Col { get { return "G"; } }
        public CellG(Row r) : base(r)
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
