using modDisplay.row;
namespace modDisplay.templates.cuocoto.loaiphuongtien.row.additional
{
    /// <summary>
    /// Tên vật liệu
    /// </summary>
    public class CellC : ACell
    {
        public override string Col { get { return "C"; } }
        public CellC(AdditionalRow r) : base(r)
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
