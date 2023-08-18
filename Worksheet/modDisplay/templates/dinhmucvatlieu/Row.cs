using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;

namespace Worksheet.modDisplay.templates.dinhmucvatlieu
{
    internal class Row : ARowObject
    {
        public Row(int id)
        {
            Id = id;
        }

        public void bind(unvell.ReoGrid.Worksheet data)
        {
            // TODO: consider a link to cell address, not a data hold
            // Current status: map column to BL/cell
            //  A = data.Cells["A"+Id].Data.ToString();
            // B = data.Cells["B"+Id].Data.ToString();

            // modData.Memories.Models.CongViec.capnhat(this);
        }

        public void AddSimpleData(unvell.ReoGrid.Worksheet ws)
        {
            // mã công việc
            //ws[Address("C")] = "AG.11111";
            //// tên công việc
            //ws[Address("D")] = "Bê tông cọc, cột, bê tông M100, đá 1x2, PCB30 - Đổ bê tông đúc sẵn bằng thủ công (vữa bê tông sản xuất bằng máy trộn)";
            //// đơn vị
            //ws[Address("E")] = "m3";

            //// HSDC vật liệu
            //ws[Address("V")] = 1;
            //// HSDC nhân công
            //ws[Address("W")] = 1;
            //// HSDC máy
            //ws[Address("X")] = 1;

            //// thông tin đơn giá
            //ws[Address("Y")] = "DinhMuc_2021XD_D12";

            //// tổng giá tất cả vật liệu của công việc 
            //ws[Address("Z")] = 685204;
            //// tổng giá tất cả vật liệu phụ của công việc 
            //ws[Address("AA")] = 0;
            //// tổng giá tất cả nhân công của công việc 
            //ws[Address("AB")] = 288111;
            //// tổng giá tất cả máy của công việc 
            //ws[Address("AC")] = 70230;

            //// set màu chữ thành không màu
            //ws.SetRangeStyles(Address("Z") + ":" + Address("AC"), new WorksheetRangeStyle()
            //{
            //    Flag = PlainStyleFlag.TextColor,
            //    TextColor = Color.Transparent,
            //});
        }
    }
}
