using modDisplay.row;
namespace modDisplay.templates.cuocoto.tongculy.row.additional
{
    /// <summary>
    /// Loại đường
    /// </summary>
    public class CellK : ACell
    {
        public override string UniqueName { get { return "CuocOto_TongCuLy_LoaiDuong"; } }
        public override string Col { get { return "K"; } }
        public CellK(AdditionalRow r) : base(r)
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
