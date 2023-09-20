using modDisplay.row;

namespace modDisplay.templates.cuocoto.tongculy.row.additional
{
    /// <summary>
    /// Chi phí khác
    /// </summary>
    public class CellW : ACell
    {
        public override string UniqueName { get { return "CuocOto_TongCuLy_ChiPhiKhac"; } }
        public override string Col { get { return "W"; } }
        public CellW(AdditionalRow r) : base(r)
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
