using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RowCongViec = Worksheet.modData.Memories.Record.CongViec;
using Worksheet.modData.Memories;
using Worksheet.modData.Memories.Pointer;
using Worksheet.modDisplay;
using System.Xml;

namespace Worksheet.modData.Memories.Models
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
            List<ARecord> rows = memories.Storage.FindAll(Current.CV.filterType);
            return rows.Cast<RowCongViec>().ToList();
        }
        public static List<RowCongViec> danhSachCongViecHangMuc()
        {
            List<ARecord> rows = memories.Storage.FindAll(Current.CV.filterSibling);
            return rows.Cast<RowCongViec>().ToList();
        }
        public static RowCongViec? chitiet(string index = "", string? HangMuc = null)
        {
            ARecord? row = memories.Storage.Find(Current.CV.filterItem);
            return null == row ? null : (RowCongViec)row;
        }

        public static void them(RowCongViec r)
        {
            //int id = Current.CV.id();
            ////point(id++);
            //r.Id = id;
            memories.Storage.Add(r);
            // recalculate BL
        }
        public static void xoa()
        {
            int id = Current.CV.id();
            point(id--);
            memories.Storage.RemoveAll(Current.CV.filterItem);
            // recalculate BL
        }

        public static void capnhat(modDisplay.templates.tienluong.Row row)
        {
            ARecord? find = Current.CV.load(row.Id);// memories.Storage.Find(r=>r.Path == Current.CV.path(row.Id));
            if(find==null)
            {
                memories.Storage.Add(row);
            }
            else
            {
                find.ColText["stt"] = row.B;
                find.ColText["ma"] = row.C;
                find.ColText["ten"] = row.D;
                find.ColText["donVi"] = row.E;

                find.ColText["tenCauKien"] = row.F;
                find.ColNum["soCauKien"] = row.G;
                find.ColNum["dai"] = row.H;
                find.ColNum["rong"] = row.I;
                find.ColNum["cao"] = row.J;
                find.ColNum["heSoPhu"] = row.K;
                find.ColNum["khoiLuongPhu"] = row.L;

                find.ColNum["khoiLuong"] = row.M;

                //find.ColNum["donGiaVatLieu"] = decimal.Parse(row.N);
                //find.ColNum["donGiaVatLieuPhu"] = decimal.Parse(row.O);
                //find.ColNum["donGiaNhanCong"] = decimal.Parse(row.P);
                //find.ColNum["donGiaMay"] = decimal.Parse(row.Q);

                //find.ColNum["thanhTienVatLieu"] = decimal.Parse(row.R);
                //find.ColNum["thanhTienVatlieuPhu"] = decimal.Parse(row.S);
                //find.ColNum["thanhTienNhanCong"] = decimal.Parse(row.T);
                //find.ColNum["thanhTienMay"] = decimal.Parse(row.U);
                // Hệ số định mức, sheet ở dưới 
                // Hệ số điều chỉnh, trong sheet Tiên lượng
                find.ColNum["hsdcVatLieu"] = row.V;
                find.ColNum["hsdcNhanCong"] = row.W;
                find.ColNum["hsdcMay"] = row.X;

            }
        }
    }
}
