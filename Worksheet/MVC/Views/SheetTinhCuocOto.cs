using modBL;
using Syncfusion.Windows.Forms.Spreadsheet.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Worksheet.modDisplay;
using Worksheet.MVC.Controllers;
using Worksheet.MVC.Presenters;
using Worksheet.MVC.Presenters.SheetTemplate;
using Worksheet.Util;

namespace Worksheet.MVC.Views
{
    public partial class SheetTinhCuocOto : AView
    {
        private CuocOtoP cuocOtoP;

        public SheetTinhCuocOto()
        {
            registerPresenters(true);
            InitializeComponent();
        }
        public override void registerPresenters(bool init)
        {
            if (init)
            {
                Publisher.register("CuocOto", "CuocOto");
            }
            else
            {
                if (null == cuocOtoP) cuocOtoP = new CuocOtoP(this);
                Publisher.register("CuocOto", cuocOtoP);
            }
        }
        private void CuocOto_Load(object sender, EventArgs e)
        {
            cbb_CachTinh.Items.Clear();
            foreach (string name in Option.DanhSachPPTCuocOto.Values)
            {
                cbb_CachTinh.Items.Add(name);
            }
            cbb_CachTinh.Text = Option.DanhSachPPTCuocOto[Option.PPTCuocOto];
            cuocOtoP = (CuocOtoP)Publisher.get("CuocOto");
            cuocOtoP.Setup();
            sheet_CuocOto.WorkbookLoaded += AfterLoad;
            sheet_CuocOto.PropertyChanged += Spreadsheet_PropertyChanged;
        }

        private void AfterLoad(object sender, WorkbookLoadedEventArgs args)
        {
            // sau khi load workbook thì mới tiếp cận được activesheet và activegrid
            switch (Option.PPTCuocOto)
            {
                case PPTCuocOto.TheoTongCuLy:
                    Display.setup(sheet_CuocOto, AppConst.templateFolder + "cuocoto/theotongculy");
                    break;
                case PPTCuocOto.TheoLoaiPhuongTien:
                    Display.setup(sheet_CuocOto, AppConst.templateFolder + "cuocoto/theoloaiphuongtien");
                    break;
                default:
                    MessageBox.Show("Chưa làm template này");
                    break;
            }
            Display.hook("LoadData");
        }

        private void Spreadsheet_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
        }

        private void cbb_CachTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Option.DanhSachPPTCuocOto.FirstOrDefault(x => x.Value == cbb_CachTinh.Text).Key)
            {
                case PPTCuocOto.TheoTongCuLy:
                    sheet_CuocOto.Open(AppConst.contentFolder + "Template/cuocoto/theotongculy.xlsx");
                    Option.PPTCuocOto = PPTCuocOto.TheoTongCuLy;
                    break;
                case PPTCuocOto.TheoLoaiPhuongTien:
                    sheet_CuocOto.Open(AppConst.contentFolder + "Template/cuocoto/theoloaiphuongtien.xlsx");
                    Option.PPTCuocOto = PPTCuocOto.TheoLoaiPhuongTien;
                    break;
                default:
                    MessageBox.Show("Chưa làm template này");
                    break;
            }
        }

       

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Files|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        sheet_CuocOto.Open(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Mở thất bại! " + ex);
                        Console.WriteLine($"The decryption failed. {ex}");
                    }
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Backbone.Run("DemoSyncfusion", "ReLoad");
        }
    }
}
