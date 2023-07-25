using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RowCongViec = Worksheet.modData.Memories.Row.CongViec;
using Worksheet.modData.Memories;
using Worksheet.modData.Memories.Pointer;

namespace Worksheet.modData.Modelv1
{
    internal class CongViec
    {
        public static string idx(string index, string? HangMuc = null)
        {
            if (null == HangMuc) HangMuc = Current.Hangmuc();
            return "HangMuc." + HangMuc + ".CongViec." + index;
        }
        public static List<RowCongViec> danhsach(string index, string? HangMuc = null)
        {
            List<ARow> rows = Storage.R.FindAll(r => r.Path.Contains(idx(index, HangMuc)));
            return rows.Cast<RowCongViec>().ToList();
        }
        public static RowCongViec? chitiet(string index, string? HangMuc = null)
        {
            ARow? row = Storage.R.Find(r => r.Path == idx(index, HangMuc));
            return null == row ? null : (RowCongViec)row;
        }

        public static void them(RowCongViec r)
        {
            Storage.R.Add(r);
            // recalculate BL
        }
        public static void xoa(string index, string? HangMuc = null)
        {
            Storage.R.RemoveAll(r => r.Path.Contains(idx(index, HangMuc)));
            // recalculate BL
        }
    }
}
