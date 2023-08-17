using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modDisplay.templates.tienluong
{
    internal class Header : ARow
    {
        public Header(int id) : base(id)
        {
            Id = id;
        }
        /// <summary>
        /// Địa chỉ ô cho phép lấy B
        /// </summary>
        /// <param name="col"></param>
        /// <returns> col + indexRow</returns>
        //public string Address(string col)
        //{
        //    return col + Id;
        //}

    }
}
