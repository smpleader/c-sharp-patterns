using modDisplay.row;
namespace modDisplay.templates.cuocoto.tongculy.row.row
{
    /// <summary>
    /// Thành tiền chi phí bốc dỡ
    /// </summary>
    public class CellS : ACell
    {
        public override string UniqueName { get { return "CuocOto_ThanhTienChiPhiBocDo"; } }
        public override string Col { get { return "S"; } }
        // Chưa lấy đúng refer cần xác định refer khi có modData
        public override string[] Params { get { return new string[1] { Row.Id.ToString() }; } }

        public CellS(Row r) : base(r)
        {
        }
    }
}
