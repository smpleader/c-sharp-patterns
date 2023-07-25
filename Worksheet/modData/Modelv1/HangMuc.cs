using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RowHangMuc = Worksheet.modData.Memories.Row.HangMuc;
using Worksheet.modData.Memories;

namespace Worksheet.modData.Modelv1
{
    internal class HangMuc
    {
        public static string idx(string index)
        {
            return "HangMuc." + index;
        }
        public static List<RowHangMuc> danhsach(string index)
        {
            List<ARow> rows = Storage.R.FindAll(r => r.Path.Contains(idx(index));
            return rows.Cast<RowHangMuc>().ToList();
        }
        public static RowHangMuc? chitiet(string index)
        {
            ARow? row = Storage.R.Find(r => r.Path == idx(index));
            return null == row ? null : (RowHangMuc)row;
        }

        public static void them(RowHangMuc r)
        {
            Storage.R.Add(r);
            // recalculate BL
        }
        public static void xoa(string index)
        {
            Storage.R.RemoveAll(r => r.Path.Contains(idx(index)));
            // recalculate BL
        }
    }
}
