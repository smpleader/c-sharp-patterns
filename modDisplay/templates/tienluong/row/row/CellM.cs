using modDisplay.row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.templates.tienluong.row.row
{
    /// <summary>
    /// Khối lượng
    /// </summary>
    public class CellM : ACell
    {
        public override string UniqueName { get { return "CongViec_KhoiLuong"; } }
        public override string Col { get { return "M"; } }
        public override string[] Params { get { return new string[2] { Row.start.ToString(), Row.end.ToString() }; } }
        public CellM(Row r) : base(r)
        {
        }
        public override void Render()
        {
            //var range = Row.masksheet.Range[Col + Row.Id];
            // xử lý công thức cho cột M
            if (((Row)Row).HaveInterpretiveFormula)
            {
                BaseInterface.IModBL modBLContainer = SimpleInjectionDI.dynamicContainer.GetInstance<BaseInterface.IModBL>();
                Range.Formula = string.Format(modBLContainer.Get(UniqueName).formula(Params));
                HasFormula = true;
            }
            else
            {
                HasFormula = false;
                Range.Value2 = ValueOnMask;
            }
        }
    }
}
