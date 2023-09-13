using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseInterface
{
    public interface IColBL
    {
        string UniqueName { get; }
        string GetFormulaCalculate();
        string GetFormulaDisplay();
    }
}
