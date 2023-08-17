using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.modDisplay.templates.tienluong.row
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
        public void bind(unvell.ReoGrid.Worksheet worksheet)
        {
            // todo: Lưu giá trị của header tới global state
           
        }

        public void render(unvell.ReoGrid.Worksheet worksheet)
        {
            // todo: render khi thay đổi tên công trình, hạng mục từ 1 số màn hình khác
        }
    }
}
