﻿using System;
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
            point(r.Id);
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
            ARecord? find = Current.CV.load(row.Id);
            if(find == null)
            {
                RowCongViec rowCongViec = new RowCongViec(Current.HM.id());
                rowCongViec.ColText = row.ColText;
                rowCongViec.ColNum = row.ColNum;
                rowCongViec.Id = row.Id;
               
                memories.Storage.Add(rowCongViec);
            }
            else
            {
                
            }
        }
    }
}
