using modDisplay.row;
namespace modDisplay.templates.cuocoto.tongculy.row.additional
{
    /// <summary>
    /// Chi phí vận chuyển sau thuế
    /// </summary>
    public class CellO : ACell
    {
            public override string UniqueName { get { return "CuocOto_ChiPhiVanChuyenSauThue"; } }
            public override string Col { get { return "O"; } }
            // Chưa lấy đúng refer cần xác định refer khi có modData
            /// Dòng cước thêm
            public override string[] Params { get { return new string[2] { (Row as AdditionalRow).ParentId.ToString(), Row.Id.ToString() }; } }

            public CellO(AdditionalRow r) : base(r)
            {
            }
    }
}
