using modDisplay.row;
namespace modDisplay.templates.cuocoto.tongculy.row.additional
{
    /// <summary>
    /// Thành tiền hao hụt
    /// </summary>
    public class CellV : ACell
    {
        public override string UniqueName { get { return "CuocOto_TongCuLy_ThanhTienHaoHut"; } }
        public override string Col { get { return "V"; } }
        public CellV(AdditionalRow r) : base(r)
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
