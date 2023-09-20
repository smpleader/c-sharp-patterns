using modDisplay.row;

namespace modDisplay.templates.cuocoto.tongculy.row.header
{
    /// <summary>
    /// các giá trị bổ sung
    /// </summary>
    public class CellX : ACell
    {
        /// <summary>
        /// <para>X4 : lương công nhân bốc dỡ</para>
        /// <para>X5 : thuế VAT</para>
        /// <para>X6 : hệ số điều chỉnh</para>
        /// </summary>
        public override string Col { get { return "X"; } }

        public CellX(Header r) : base(r)
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
