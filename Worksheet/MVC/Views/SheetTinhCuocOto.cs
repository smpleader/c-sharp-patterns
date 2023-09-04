using BaseInterface;
using modDisplay;
using Syncfusion.Windows.Forms.Spreadsheet.Helpers;
using System.ComponentModel;
using Util;
using Worksheet.MVC.Presenters;
using Worksheet.MVC.Presenters.SheetTemplate;

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
            cuocOtoP = (CuocOtoP)Publisher.get("CuocOto");
            cuocOtoP.Setup();
            sheet_CuocOto.Open(AppConst.contentFolder + "Template/cuocoto/cuocoto.xlsx");
            sheet_CuocOto.WorkbookLoaded += AfterLoad;
        }

        private void AfterLoad(object sender, WorkbookLoadedEventArgs args)
        {
            // sau khi load workbook thì mới tiếp cận được activesheet và activegrid
            Display.setup(sheet_CuocOto, AppConst.contentFolder + "Template/cuocoto/cuocoto.xlsx");
            Display.hook("LoadData");
            cbb_CachTinh.Text = Option.DanhSachPPTCuocOto[Option.PPTCuocOto];
        }

        private void Spreadsheet_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
        }
        List<string> HiddenSheets = new List<string>();
        private void cbb_CachTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            sheet_CuocOto.AllowTabItemContextMenu = false;
            if(HiddenSheets.Count > 0 && HiddenSheets.Contains(cbb_CachTinh.Text))
            {
                sheet_CuocOto.UnhideSheet(cbb_CachTinh.Text);
            }
            HiddenSheets = new List<string>();
            foreach (var sheet in sheet_CuocOto.Workbook.Worksheets)
            {
                if(sheet.Name != cbb_CachTinh.Text)
                {
                    //Hide Sheet
                    sheet_CuocOto.HideSheet(sheet.Name);
                    HiddenSheets.Add(sheet.Name);
                }    
            }
            sheet_CuocOto.SetActiveSheet(cbb_CachTinh.Text);
            switch (Option.DanhSachPPTCuocOto.FirstOrDefault(x => x.Value == cbb_CachTinh.Text).Key)
            {
                case PPTCuocOto.TheoTongCuLy:
                    Option.PPTCuocOto = PPTCuocOto.TheoTongCuLy;
                    break;
                case PPTCuocOto.TheoLoaiPhuongTien:
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

        private void btn_Click(object sender, EventArgs e)
        {
            SyncfusionP syncfusionP = (SyncfusionP)Publisher.get("SyncfusionTienLuong");
            Display.changeTab(sheet_CuocOto, syncfusionP.Spreadsheet);
            Close();
        }
    }
}
