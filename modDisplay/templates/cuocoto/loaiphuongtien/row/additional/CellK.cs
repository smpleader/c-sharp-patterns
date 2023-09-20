using modDisplay.row;
namespace modDisplay.templates.cuocoto.loaiphuongtien.row.additional
{
    /// <summary>
    /// Loại đường
    /// </summary>
    public class CellK : ACell
    {
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
