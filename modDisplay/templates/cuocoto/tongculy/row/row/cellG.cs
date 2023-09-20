using modDisplay.row;
namespace modDisplay.templates.cuocoto.tongculy.row.row
{
    /// <summary>
    /// Hệ số bậc hàng
    /// </summary>
    public class CellG : ACell
    {
        public override string UniqueName { get { return "CuocOto_TongCuLy_HeSoBacHang"; } }
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
