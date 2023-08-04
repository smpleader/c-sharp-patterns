using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RowCongViec = Worksheet.modData.Memories.Record.CongViec;
using Worksheet.modData.Memories;
using Worksheet.modData.Memories.Pointer;

namespace Worksheet.modData.Modelv1
{
    internal class CongViec
    {
        public static void point(int id)
        {
            Current.CV.id(id);
            // reset pointer
            Current.NC = new modData.Memories.Pointer.NhanCong();
            Current.VL = new modData.Memories.Pointer.VatLieu();
            Current.CM = new modData.Memories.Pointer.CaMay();
        }
        public static List<RowCongViec> danhsach(string index, string? HangMuc = null)
        {
            List<ARecord> rows = DB.Storage.FindAll(Current.CV.filterType);
            return rows.Cast<RowCongViec>().ToList();
        }
        public static RowCongViec? chitiet(string index, string? HangMuc = null)
        {
            ARecord? row = DB.Storage.Find(Current.CV.filterItem);
            return null == row ? null : (RowCongViec)row;
        }

        public static void them(RowCongViec r)
        {
            int id = Current.CV.id();
            point(id++);
            r.Id = id;
            DB.Storage.Add(r);
            // recalculate BL
        }
        public static void xoa()
        {
            int id = Current.CV.id();
            point(id--);
            DB.Storage.RemoveAll(Current.CV.filterItem);
            // recalculate BL
        }
    }
}
