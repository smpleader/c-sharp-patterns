using BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.row
{
    public class ACellDt : IData
    {
        private ACell Col;
        public ACellDt(ACell col, string name)
        {
            Col = col;
            Name = name;
        }
        public string Name { get; set; } = "--";
    }
}
