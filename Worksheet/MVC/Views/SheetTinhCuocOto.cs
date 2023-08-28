using modBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Worksheet.Util;

namespace Worksheet.MVC.Views
{
    public partial class SheetTinhCuocOto : Form
    {
        public SheetTinhCuocOto()
        {
            InitializeComponent();
        }
        private void CuocOto_Load(object sender, EventArgs e)
        {
            cbb_CachTinh.Items.Clear();
            foreach (string name in Option.DanhSachPPTCuocOto.Values)
            {
                cbb_CachTinh.Items.Add(name);
            }
            cbb_CachTinh.Text = Option.DanhSachPPTCuocOto[Option.PPTCuocOto];
        }

        private void cbb_CachTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Option.DanhSachPPTCuocOto.FirstOrDefault(x=>x.Value==cbb_CachTinh.Text).Key)
            {
                case PPTCuocOto.TheoTongCuLy:
                    sheet_CuocOto.Open(AppConst.contentFolder + "Template/cuocoto/theotongculy.xlsx");
                    break;
                case PPTCuocOto.TheoLoaiPhuongTien:
                    sheet_CuocOto.Open(AppConst.contentFolder + "Template/cuocoto/theoloaiphuongtien.xlsx");
                    break;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
