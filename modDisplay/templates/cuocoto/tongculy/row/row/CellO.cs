using modDisplay.row;
namespace modDisplay.templates.cuocoto.tongculy.row.row
{
    /// <summary>
    /// Chi phí vận chuyển sau thuế
    /// </summary>
    public class CellO : ACell
    {
        public override string UniqueName { get { return "CuocOto_TongCuLy_ChiPhiVanChuyenSauThue"; } }
        public override string Col { get { return "O"; } }
        // Chưa lấy đúng refer cần xác định refer khi có modData
        public override string[] Params { get { return new string[2] { Row.Id.ToString(), Row.Id.ToString() }; } }

        public CellO(Row r) : base(r)
        {
        }
    }
}
