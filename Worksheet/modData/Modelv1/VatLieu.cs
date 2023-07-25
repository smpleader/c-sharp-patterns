using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RowVatLieu = Worksheet.modData.Memories.Row.VatLieu;
using Worksheet.modData.Memories;
using System.Reflection;
using Worksheet.modData.Memories.Pointer;

namespace Worksheet.modData.Modelv1
{
    internal class VatLieu
    {
        public static string idx(string? index = null, string? HangMuc = null, string? CongViec = null)
        {
            if (null == index) index = Current.Vatlieu();
            if (null == HangMuc) HangMuc = Current.Hangmuc();
            if (null == CongViec) CongViec = Current.Congviec();
            return "HangMuc." + HangMuc + ".CongViec." + CongViec + ".Vatlieu." + index;
        }
        public static List<RowVatLieu> danhsach(string? index = null, string? HangMuc = null)
        {
            List<ARow> rows = Storage.R.FindAll(r => r.Path.Contains(idx(index, HangMuc)));
            return rows.Cast<RowVatLieu>().ToList();
        }
        public static RowVatLieu? chitiet(string? index = null, string? HangMuc = null)
        {
            ARow? row = Storage.R.Find(r => r.Path == idx(index, HangMuc));
            return null == row ? null : (RowVatLieu)row;
        }

        public static void them(RowVatLieu r)
        {
            Storage.R.Add(r);
            // recalculate BL
        }
        public static bool capnhat(RowVatLieu r)
        {
            int index = Storage.R.FindIndex(x => x.Path == r.Path);
            if (index == -1)
            {
                MessageBox.Show(r.Path + " not found.");
                return false;
            }
            else
            {
                Storage.R.ElementAt(index).ColText = r.ColText;
                Storage.R.ElementAt(index).ColNum = r.ColNum;
                // recalculate BL
                return true;
            }
        }
        public static void xoa(string index, string? HangMuc = null)
        {
            Storage.R.RemoveAll(r => r.Path.Contains(idx(index, HangMuc)));
            // recalculate BL
        }

    }
}
