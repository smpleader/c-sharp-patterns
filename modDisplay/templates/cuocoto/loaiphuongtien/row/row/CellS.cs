using modDisplay.row;
namespace modDisplay.templates.cuocoto.loaiphuongtien.row.row
{
    /// <summary>
    /// Cước khác	
    /// </summary>
    public class CellS : ACell
    {
        public override string UniqueName { get { return "CuocOto_LoaiPhuongTien_CuocKhac"; } }
        public override string Col { get { return "S"; } }
        // Chưa lấy đúng refer cần xác định refer khi có modData
        public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

        public CellS(Row r) : base(r)
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
