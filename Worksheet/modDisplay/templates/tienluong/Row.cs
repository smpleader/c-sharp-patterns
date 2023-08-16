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
    internal class Row : ARowObject
    {
        public Row(int id)
        {
            Id = id;
            HMId = Current.HM.id();
        }
        public int HMId { get; }

        public override string Path { get { return "HangMuc." + HMId + ".CongViec." + Id; } }

        public string A { get { return txt("kiHieuBanVe"); } set { txt("kiHieuBanVe", value); } }
        public string B { get { return txt("stt"); } set { txt("stt", value); } }
        public string C { get { return txt("ma"); } set { txt("ma", value); } }
        public string D { get { return txt("ten"); } set { txt("ten", value); } }
        public string E { get { return txt("donVi"); } set { txt("donVi", value); } }
        public string F { get { return txt("tenCauKien"); } set { txt("tenCauKien", value); } }
        public decimal G { get { return num("soCauKien"); } set { num("soCauKien", value); } }
        public decimal H { get { return num("dai"); } set { num("dai", value); } }
        public decimal I { get { return num("rong"); } set { num("rong", value); } }
        public decimal J { get { return num("cao"); } set { num("cao", value); } }
        public decimal K { get { return num("heSoPhu"); } set { num("heSoPhu", value); } }
        public decimal L { get { return num("khoiLuongPhu"); } set { num("khoiLuongPhu", value); } }
        public string M { 
            get 
            {
                if(HaveInterpretiveFormula)
                {
                    return string.Format(modBL.Container.Get("CongViec_KhoiLuong").fml(),start + 1, end);
                }    
                else
                {
                    if (txt("khoiLuong")=="-")
                    {
                        return "0";
                    }    
                    return txt("khoiLuong");
                }    
            } 
            set { txt("khoiLuong", value); } }
        public string N { 
            get 
            {
                Current.CV.id(Id);
                var congViec = Worksheet.modData.Memories.Models.CongViec.chitiet();
                string formula = string.Format(modBL.Container.Get("CongViec_DonGiaVatLieu").fml(),Id, congViec.num("tongGiaVatLieu"));
                return formula;
            } 
            set { txt("donGiaVatLieu", value); } 
        }

        public string O
        {
            get
            {
                Current.CV.id(Id);
                var congViec = Worksheet.modData.Memories.Models.CongViec.chitiet();
                string formula = string.Format(modBL.Container.Get("CongViec_DonGiaVatLieuPhu").fml(), Id, congViec.num("tongGiaVatLieuPhu"));
                return formula;
            }
            set { txt("donGiaVatLieuPhu", value); }
        }

        public string P
        {
            get
            {
                Current.CV.id(Id);
                var congViec = Worksheet.modData.Memories.Models.CongViec.chitiet();
                string formula = string.Format(modBL.Container.Get("CongViec_DonGiaNhanCong").fml(), Id, congViec.num("tongGiaNhanCong"));
                return formula;
            }
            set { txt("donVidonGiaNhanCong", value); }
        }

        public string Q
        {
            get
            {
                Current.CV.id(Id);
                var congViec = Worksheet.modData.Memories.Models.CongViec.chitiet();
                string formula = string.Format(modBL.Container.Get("CongViec_DonGiaMay").fml(), Id, congViec.num("tongGiaMay"));
                return formula;
            }
            set { txt("donGiaMay", value); }
        }

        public string R
        {
            get
            {
                string formula = isGroup ? string.Format(modBL.Container.Get("NhomCongViec_ThanhTienVatLieu").fml(), start + 1, end) : 
                    (isInterpretiveFormula ? "": string.Format(modBL.Container.Get("CongViec_ThanhTienVatLieu").fml(), Id, Id));
                return formula;
            }
            set { txt("thanhTienVatLieu", value); }
        }
        public string S
        {
            get
            {
                string formula = isGroup ? string.Format(modBL.Container.Get("NhomCongViec_ThanhTienVatLieuPhu").fml(), start + 1, end) :
                    (isInterpretiveFormula ? "" : string.Format(modBL.Container.Get("CongViec_ThanhTienVatLieuPhu").fml(), Id, Id));
                return formula;
            }
            set { txt("thanhTienVatLieuPhu", value); }
        }
        public string T
        {
            get
            {
                string formula = isGroup ? string.Format(modBL.Container.Get("NhomCongViec_ThanhTienNhanCong").fml(), start + 1, end) :
                    (isInterpretiveFormula ? "" : string.Format(modBL.Container.Get("CongViec_ThanhTienNhanCong").fml(), Id, Id));
                return formula;
            }
            set { txt("thanhTienNhanCong", value); }
        }
        public string U
        {
            get
            {
                string formula = isGroup ? string.Format(modBL.Container.Get("NhomCongViec_ThanhTienMay").fml(), start + 1, end) :
                    (isInterpretiveFormula ? "" : string.Format(modBL.Container.Get("CongViec_ThanhTienMay").fml(), Id, Id));
                return formula;
            }
            set { txt("thanhTienMay", value); }
        }

        public decimal V { get { return num("hsdcVatLieu"); } set { num("hsdcVatLieu", value); } }
        public decimal W { get { return num("hsdcNhanCong"); } set { num("hsdcNhanCong", value); } }
        public decimal X { get { return num("hsdcMay"); } set { num("hsdcMay", value); } }
        public string Y { get { return txt("thongTinDonGia"); } set { txt("thongTinDonGia", value); } }

        public bool isGroup = false;
        public bool isInterpretiveFormula = false;
        public bool HaveInterpretiveFormula = false;
        public decimal tongGiaVatLieu;
        public decimal tongGiaVatLieuPhu;
        public decimal tongGiaNhanCong;
        public decimal tongGiaMay;

        public void bind(unvell.ReoGrid.Worksheet data)
        {
            
            if(data.IsMergedCell("B" + Id))
            {
                if(data["B" + Id] != null && data["B" + Id] != "")
                {
                    isGroup = true;
                }
            }
            else
            {
                C = CellUtility.ConvertData<string>(data["C" + Id]);
                if (C != null && C.StartsWith("*"))
                {
                    isGroup = true;
                    string nameGroup = C.Substring(1);
                    if (nameGroup.Length == 0)
                    {
                        nameGroup = "(Nhóm không tên)";
                    }
                    data.MergeRange("B" + Id + ":" + "Q" + Id);
                    data["B" + Id] = nameGroup;
                    data.SetRangeStyles("B" + Id, new WorksheetRangeStyle
                    {
                        Flag = PlainStyleFlag.AlignAll,
                        HAlign = ReoGridHorAlign.Left,
                    });
                    data.SetRangeStyles("A" + Id + ":" + "X" + Id, new WorksheetRangeStyle
                    {
                        // style item flag
                        Flag = PlainStyleFlag.BackColor,
                        // style item
                        BackColor = Color.FromArgb(213, 247, 183),
                    });
                    data.SetRangeBorders("A" + Id + ":" + "X" + Id, BorderPositions.InsideHorizontal,
                    new RangeBorderStyle
                    {
                        Color = Color.Black,
                        Style = BorderLineStyle.Dotted,
                    });
                    data.SetRangeBorders("A" + Id + ":" + "X" + Id, BorderPositions.Left,
                    new RangeBorderStyle
                    {
                        Color = Color.Black,
                        Style = BorderLineStyle.Solid,
                    });
                    data.SetRangeBorders("A" + Id + ":" + "X" + Id, BorderPositions.Right,
                    new RangeBorderStyle
                    {
                        Color = Color.Black,
                        Style = BorderLineStyle.Solid,
                    });
                    data.SetRangeBorders("A" + Id + ":" + "X" + Id, BorderPositions.InsideVertical,
                    new RangeBorderStyle
                    {
                        Color = Color.Black,
                        Style = BorderLineStyle.Solid,
                    });
                    data.SetRangeBorders("A" + Id + ":" + "X" + Id, BorderPositions.Outside,
                    new RangeBorderStyle
                    {
                        Color = Color.Black,
                        Style = BorderLineStyle.Solid,
                    });
                }
                if ((data["C" + Id] == null || data["C" + Id] == "") && (data["D" + Id] != null && data["D" + Id] != ""))
                {
                    string interpretiveFormula = CellUtility.ConvertData<string>(data["D" + Id]);
                    var segment = interpretiveFormula.Split(":").ToList();
                    if(segment.Count>1)
                    {
                        // check segment 2 
                        if (segment[1].Trim() != "" && IsValidExpression(segment[1].Trim())) 
                        {
                            double result = EvaluateExpression(segment[1].Trim());
                            data["D" + Id] = interpretiveFormula + " = " + FormatResult(result);
                            data["L" + Id] = "=" + segment[1].Trim();
                        }
                        else
                        {
                            data["D" + Id] = interpretiveFormula + " :";
                        }
                    }
                    else
                    {
                        data["D" + Id] = interpretiveFormula + " :";
                    }    
                    isInterpretiveFormula = true;
                }
            }
            if(!isGroup && !isInterpretiveFormula)
            {
                N = CellUtility.ConvertData<string>(data["N" + Id]);
                O = CellUtility.ConvertData<string>(data["O" + Id]);
                P = CellUtility.ConvertData<string>(data["P" + Id]);
                Q = CellUtility.ConvertData<string>(data["Q" + Id]);

                var cellN = data.Cells["N" + Id];
                tongGiaVatLieu = cellN.HasFormula ? decimal.Parse(data.GetCellFormula("N" + Id).Split("*").ToList()[1]) : (cellN.Data == null ? 0 : decimal.Parse((string)cellN.Data));

                var cellO = data.Cells["O" + Id];
                tongGiaVatLieuPhu = cellO.HasFormula ? decimal.Parse(data.GetCellFormula("O" + Id).Split("*").ToList()[1]) : (cellO.Data == null ? 0 : decimal.Parse((string)cellO.Data));

                var cellP = data.Cells["P" + Id];
                tongGiaNhanCong = cellP.HasFormula ? decimal.Parse(data.GetCellFormula("P" + Id).Split("*").ToList()[1]) : (cellP.Data == null ? 0 : decimal.Parse((string)cellP.Data));

                var cellQ = data.Cells["Q" + Id];
                tongGiaMay = cellQ.HasFormula ? decimal.Parse(data.GetCellFormula("Q" + Id).Split("*").ToList()[1]) : (cellQ.Data == null ? 0 : decimal.Parse((string)cellQ.Data));
                
            }
            B = CellUtility.ConvertData<string>(data["B"+Id]);
            D = CellUtility.ConvertData<string>(data["D" + Id]);
            E = CellUtility.ConvertData<string>(data["E" + Id]);
            F = CellUtility.ConvertData<string>(data["F" + Id]);
            G = CellUtility.ConvertData<decimal>(data["G" + Id]);
            H = CellUtility.ConvertData<decimal>(data["H" + Id]);
            I = CellUtility.ConvertData<decimal>(data["I" + Id]);
            J = CellUtility.ConvertData<decimal>(data["J" + Id]);
            K = CellUtility.ConvertData<decimal>(data["K" + Id]);
            L = CellUtility.ConvertData<decimal>(data["L" + Id]);

            M = CellUtility.ConvertData<string>(data["M" + Id]);

            R = CellUtility.ConvertData<string>(data["R" + Id]);
            S = CellUtility.ConvertData<string>(data["S" + Id]);
            T = CellUtility.ConvertData<string>(data["T" + Id]);
            U = CellUtility.ConvertData<string>(data["U" + Id]);

            V = CellUtility.ConvertData<decimal>(data["V" + Id]);
            W = CellUtility.ConvertData<decimal>(data["W" + Id]);
            X = CellUtility.ConvertData<decimal>(data["X" + Id]);
            Y = CellUtility.ConvertData<string>(data["Y" + Id]);
            modData.Memories.Models.CongViec.capnhat(this);
        }
        static string FormatResult(double number)
        {
            int decimalPlaces = 3;
            if (Math.Abs(number - Math.Floor(number)) < double.Epsilon)
            {
                // Kết quả là số nguyên, định dạng với 1 chữ số sau dấu thập phân
                return number.ToString("0.0");
            }
            else
            {
                // Kết quả có phần thập phân, định dạng với tối đa 3 chữ số sau dấu thập phân
                return number.ToString($"0.{new string('0', decimalPlaces)}");
            }
        }
        static bool IsValidExpression(string expression)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        static double EvaluateExpression(string expression)
        {
            // Sử dụng DataTable.Compute để tính toán giá trị biểu thức
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }
    }
}
