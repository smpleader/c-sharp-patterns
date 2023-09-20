using modDisplay.row;
namespace modDisplay.templates.cuocoto.tongculy.row.row
{
    /// <summary>
    /// Tên vật liệu
    /// </summary>
    public class CellC : ACell
    {
        public override string UniqueName { get { return "CuocOto_TongCuLy_TenVatLieu"; } }
        public override string Col { get { return "C"; } }
        public CellC(Row r) : base(r)
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
