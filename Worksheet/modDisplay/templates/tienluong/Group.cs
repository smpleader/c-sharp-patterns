using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;
using unvell.ReoGrid.IO.OpenXML.Schema;
using unvell.ReoGrid.Utility;
using Worksheet.modData.Memories.Pointer;

namespace Worksheet.modDisplay.templates.tienluong
{
    internal class Group : ARowObject
    {
        public Group(int id)
        {
            Id = id;
            HMId = Current.HM.id();
        }
        public int HMId { get; }
        public override string Path { get { return "HangMuc." + HMId + ".CongViec." + Id; } }
        public string A { get { return "A" + Id; } }
        public string B { get { return "B" + Id; } }
        public string C { get { return "C" + Id; } }
        public string Q { get { return "Q" + Id; } }
        public string X { get { return "X" + Id; } }

        public string R
        {
            get
            {
                return string.Format(modBL.Container.Get("NhomCongViec_ThanhTienVatLieu").fml(), start + 1, end); 
            }
        }
        public string S
        {
            get
            {
                return string.Format(modBL.Container.Get("NhomCongViec_ThanhTienVatLieuPhu").fml(), start + 1, end);
            }
        }
        public string T
        {
            get
            {
                return string.Format(modBL.Container.Get("NhomCongViec_ThanhTienNhanCong").fml(), start + 1, end);
            }
        }
        public string U
        {
            get
            {
                return string.Format(modBL.Container.Get("NhomCongViec_ThanhTienMay").fml(), start + 1, end);
            }
        }
       
        public void bind(unvell.ReoGrid.Worksheet data)
        {
            // check group object khi mở từ file excel ( bind)
            if (data.IsMergedCell("B" + Id))
            {
                if(data["B" + Id] != null && data["B" + Id] != "")
                {
                    //isGroup = true;
                }
            }
            else
            {
                // check group object khi nhập vào
                string C = CellUtility.ConvertData<string>(data["C" + Id]);
                if (C != null && C.StartsWith("*"))
                {
                    //isGroup = true;
                    string nameGroup = C.Substring(1);
                    if (nameGroup.Length == 0)
                    {
                        nameGroup = "(Nhóm không tên)";
                    }
                    data.MergeRange(B+ ":" + Q);
                    data[B] = nameGroup;

                    #region style lại cho group object

                    data.SetRangeStyles(B, new WorksheetRangeStyle
                    {
                        Flag = PlainStyleFlag.AlignAll,
                        HAlign = ReoGridHorAlign.Left,
                    });

                    string rangeGroup = A + ":" + X;

                    data.SetRangeStyles(rangeGroup, new WorksheetRangeStyle
                    {
                        // style item flag
                        Flag = PlainStyleFlag.BackColor,
                        // style item
                        BackColor = Color.FromArgb(213, 247, 183),
                    });

                    var blackDottedBoder = new RangeBorderStyle
                    {
                        Color = Color.Black,
                        Style = BorderLineStyle.Dotted,
                    };
                    data.SetRangeBorders(rangeGroup, BorderPositions.InsideHorizontal, blackDottedBoder);

                    var blackSolidBoder = new RangeBorderStyle
                    {
                        Color = Color.Black,
                        Style = BorderLineStyle.Solid,
                    };
                    data.SetRangeBorders(rangeGroup, BorderPositions.Left, blackSolidBoder);
                    data.SetRangeBorders(rangeGroup, BorderPositions.Right, blackSolidBoder);
                    data.SetRangeBorders(rangeGroup, BorderPositions.InsideVertical, blackSolidBoder);
                    data.SetRangeBorders(rangeGroup, BorderPositions.Outside, blackSolidBoder);

                    #endregion
                }
               
            }
            //modData.Memories.Models.CongViec.capnhat(this);
        }
       
    }
}
