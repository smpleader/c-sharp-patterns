using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modBL.prime.tienluong
{
    internal class colU : ICell
    {
        public string option { get { return ""; } }
        // return forumalation of cell
        public string fml()
        {
            return "=M{0}*Q{1}";
        }

        /// <summary>
        /// chỉ có 1 phần từ
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public string fml(string[] args)
        {
            return $"=M{args[0]}*Q{args[0]}";
        }

        // return value of cell
        public decimal val()
        {
            return 0;
        }
    }
}
