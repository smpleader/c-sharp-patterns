using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.row
{
    public class ACellBl : IColBL
    {
        private ACell Col;
        private ICell BL;
        public ACellBl(ACell col)
        {
            Col = col;
            IModBL modBLContainer = SimpleInjectionDI.dynamicContainer.GetInstance<IModBL>();
            BL = modBLContainer.Get(Col.UniqueName);
        }

        public string UniqueName { get { return Col.UniqueName; } }

        public virtual string GetFormulaCalculate()
        {
            // render trên working sheet
            return BL.formula(Col.HangMucId, Col.Params);
        }
        public virtual string GetFormulaDisplay()
        {
            //todo: hiển thị lên mark sheet
            return BL.formula(Col.Params);
        }
    }
}
