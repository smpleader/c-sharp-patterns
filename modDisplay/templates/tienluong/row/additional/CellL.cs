using modDisplay.row;

namespace modDisplay.templates.tienluong.row.additional
{
    /// <summary>
    /// KL Phụ
    /// </summary>
    public class CellL: ACell
    {
        public override string UniqueName { get { return "CongViec_KhoiLuongPhu"; } }
        public override string Col { get { return "L"; } }
        public CellL(AdditionalRow r) : base(r)
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
