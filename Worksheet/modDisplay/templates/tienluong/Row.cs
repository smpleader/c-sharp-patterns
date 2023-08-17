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
    internal class Row : ARow
    {
        public Row(int id) : base(id)
        {
            Id = id;
            HMId = Current.HM.id();
        }
        public override int HMId { get; }
        public override string Path { get { return "HangMuc." + HMId + ".CongViec." + Id; } }

        /// <summary>
        /// Địa chỉ ô cho phép lấy A, B, C, D, E, N, O, P, Q, R, S, T, U, V, W, X, Y
        /// </summary>
        /// <param name="col"></param>
        /// <returns> col + indexRow</returns>
        public string Address(string col)
        {
            return col + Id;
        }

        /// <summary>
        /// Lấy công thức cho các cột M, N, O, P,
        /// </summary>
        /// <param name="col"></param>
        /// <returns></returns>
        public string GetFormula(string col)
        {
            string uniqueName = "";
            string formula;
            Current.CV.id(Id);
            var congViec = modData.Memories.Models.CongViec.chitiet();
            string[] parameters = new string[1] { Id.ToString() };
            switch (col)
            {
                case "M":
                    if (HaveInterpretiveFormula)
                    {
                        uniqueName = "CongViec_KhoiLuong";
                        parameters = new string[2] { (start + 1).ToString(), end.ToString() };
                        break;
                    }
                    else
                    {
                        return "0";
                    }
                case "N":
                    uniqueName = "CongViec_DonGiaVatLieu";
                    parameters = new string[2] { Id.ToString(), congViec.num("tongGiaVatLieu").ToString() };
                    break;
                case "O":
                    uniqueName = "CongViec_DonGiaVatLieuPhu";
                    parameters = new string[2] { Id.ToString(), congViec.num("tongGiaVatLieuPhu").ToString() };
                    break;
                case "P":
                    uniqueName = "CongViec_DonGiaNhanCong";
                    parameters = new string[2] { Id.ToString(), congViec.num("tongGiaNhanCong").ToString() };
                    break;
                case "Q":
                    uniqueName = "CongViec_DonGiaMay";
                    parameters = new string[2] { Id.ToString(), congViec.num("tongGiaMay").ToString() };
                    break;
                case "R":
                    uniqueName = "CongViec_ThanhTienVatLieu";
                    break;
                case "S":
                    uniqueName = "CongViec_ThanhTienVatLieuPhu";
                    break;
                case "T":
                    uniqueName = "CongViec_ThanhTienNhanCong";
                    break;
                case "U":
                    uniqueName = "CongViec_ThanhTienMay";
                    break;
                default:  break;
            }
            formula = string.Format(modBL.Container.Get(uniqueName).fml(parameters));
            return formula;
        }

        public bool isGroup = false;
        public bool isInterpretiveFormula = false;
        public bool HaveInterpretiveFormula = false;
        public decimal tongGiaVatLieu; // Z
        public decimal tongGiaVatLieuPhu; // AA
        public decimal tongGiaNhanCong;  // AB
        public decimal tongGiaMay; // AC

        public void bind(unvell.ReoGrid.Worksheet data)
        {
            // bind thông tin tổng giá vật liệu, tổng giá vật liệu phụ, tổng giá nhân công, tổng giá máy 
            if(!isGroup && !isInterpretiveFormula)
            {

            }
            //B = CellUtility.ConvertData<string>(data["B"+Id]);
            //D = CellUtility.ConvertData<string>(data["D" + Id]);
            //E = CellUtility.ConvertData<string>(data["E" + Id]);
            //F = CellUtility.ConvertData<string>(data["F" + Id]);
            //G = CellUtility.ConvertData<decimal>(data["G" + Id]);
            //H = CellUtility.ConvertData<decimal>(data["H" + Id]);
            //I = CellUtility.ConvertData<decimal>(data["I" + Id]);
            //J = CellUtility.ConvertData<decimal>(data["J" + Id]);
            //K = CellUtility.ConvertData<decimal>(data["K" + Id]);
            //L = CellUtility.ConvertData<decimal>(data["L" + Id]);

            //M = CellUtility.ConvertData<string>(data["M" + Id]);

            //R = CellUtility.ConvertData<string>(data["R" + Id]);
            //S = CellUtility.ConvertData<string>(data["S" + Id]);
            //T = CellUtility.ConvertData<string>(data["T" + Id]);
            //U = CellUtility.ConvertData<string>(data["U" + Id]);

            //V = CellUtility.ConvertData<decimal>(data["V" + Id]);
            //W = CellUtility.ConvertData<decimal>(data["W" + Id]);
            //X = CellUtility.ConvertData<decimal>(data["X" + Id]);
            //Y = CellUtility.ConvertData<string>(data["Y" + Id]);
        }
    }
}
