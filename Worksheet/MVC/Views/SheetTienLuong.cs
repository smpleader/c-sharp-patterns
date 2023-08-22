using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using unvell.ReoGrid;
using Worksheet.modBL;
using Worksheet.modData.Memories.Models;
using Worksheet.modData.Memories.Pointer;
using Worksheet.modDisplay;
using Worksheet.MVC.Presenters;
using Worksheet.MVC.Presenters.SheetTemplate;
using Worksheet.Util;

namespace Worksheet.MVC.Views
{
    public partial class SheetTienLuong : AView
    {
        private TienLuongP tienLuongP;
        private VatLieuP vatLieuP;
        private DinhMucVatLieuP dinhMucVatLieuP;
        private DinhMucNhanCongP dinhMucNhanCongP;
        private DinhMucMayP dinhMucMayP;

        public SheetTienLuong()
        {
            registerPresenters(true);
            InitializeComponent();
            Worksheet.modBL.Container.init();
        }

        private void SheetTienLuong_Load(object sender, EventArgs e)
        {
            tienLuongP = (TienLuongP)Publisher.get("SheetTienLuong");
            tienLuongP.Setup();
            vatLieuP = (VatLieuP)Publisher.get("SheetVatLieu");
            vatLieuP.Setup();
            dinhMucVatLieuP = (DinhMucVatLieuP)Publisher.get("SheetChiTietVatLieu");
            dinhMucVatLieuP.Setup();
            dinhMucNhanCongP = (DinhMucNhanCongP)Publisher.get("SheetChiTietNhanCong");
            dinhMucNhanCongP.Setup();
            dinhMucMayP = (DinhMucMayP)Publisher.get("SheetChiTietMay");
            dinhMucMayP.Setup();
            sheet_TienLuong.CurrentWorksheet.SetRows(10000);
            sheet_TienLuong.WorkbookSaved += AfterSave;
            sheet_TienLuong.WorkbookLoaded += AfterLoad;
            sheet_TienLuong.ContextMenuStrip = Display.contextMenu;

            Display.setup(sheet_ChiTietVatLieu, AppConst.templateFolder + "TienLuong");
            Display.setup(sheet_TienLuong, AppConst.templateFolder + "TienLuong");
            Display.hook("LoadData");
        }

        private void btn_ThemCongViec_Click(object sender, EventArgs e)
        {
            ((Worksheet.modDisplay.templates.tienluong.Generator)Display.tab("Tiên lượng")).updateData();
        }
        public void AfterSave(object sender, EventArgs e)
        {
            //Display.hook("AfterSave");
        }
        public async void AfterLoad(object sender, EventArgs e)
        {
            // a little time to be sure file get loaded
            await Task.Delay(500);
            Display.setup(AppConst.templateFolder + "TienLuong");

            Display.hook("LoadData");
        }

        private void btn_BackDemo_Click(object sender, EventArgs e)
        {
            Backbone.Run("SheetDemo");
        }
        public override void registerPresenters(bool init)
        {
            if (init)
            {
                Publisher.register("SheetTienLuong", "TienLuong");
            }
            else
            {
                if (null == tienLuongP) tienLuongP = new TienLuongP(this);
                Publisher.register("SheetTienLuong", tienLuongP);
                if (null == vatLieuP) vatLieuP = new VatLieuP(this);
                Publisher.register("SheetVatLieu", vatLieuP);
                if (null == dinhMucVatLieuP) dinhMucVatLieuP = new DinhMucVatLieuP(this);
                Publisher.register("SheetChiTietVatLieu", dinhMucVatLieuP);
                if (null == dinhMucNhanCongP) dinhMucNhanCongP = new DinhMucNhanCongP(this);
                Publisher.register("SheetChiTietNhanCong", dinhMucNhanCongP);
                if (null == dinhMucMayP) dinhMucMayP = new DinhMucMayP(this);
                Publisher.register("SheetChiTietMay", dinhMucMayP);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Text)
            {
                case "Tiên lượng":
                    Display.setup(sheet_TienLuong);
                    btn_ThemCongViec.Enabled = true;
                    bbtn_ThemVatLieu.Enabled = false;
                    break;
                case "Vật liệu":
                    Display.setup(sheet_VatLieu);
                    switch (Option.PPTGiaVatLieu)
                    {
                        case PPTGiaVatLieu.NhapTay:
                            rdbtn_PPT_NhapTay.Checked = true;
                            break;
                        case PPTGiaVatLieu.CongCuocVanChuyen:
                            rdbtn_PPT_CongCuocVC.Checked = true;
                            break;
                        case PPTGiaVatLieu.NhanHeSo:
                            rdbtn_PPT_NhanHeSo.Checked = true;
                            break;
                        case PPTGiaVatLieu.NhanHeSoCongCuocVanChuyen:
                            rdbtn_PPT_NhanHeSoCongCuocVC.Checked = true;
                            break;
                    }
                    btn_ThemCongViec.Enabled = false;
                    bbtn_ThemVatLieu.Enabled = true;
                    break;
            }
            Display.hook("LoadData");
        }

        private void btn_LuuFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Files|*.xlsx" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Display.WControl.Save(saveFileDialog.FileName, unvell.ReoGrid.IO.FileFormat.Excel2007);
                        MessageBox.Show("Lưu thành công! " + saveFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lưu lỗi. {ex}");
                        MessageBox.Show("Lưu thất bại! " + ex);

                    }
                }
            }
        }

        private void btn_MoFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Files|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        sheet_TienLuong.Load(openFileDialog.FileName, unvell.ReoGrid.IO.FileFormat.Excel2007);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Mở thất bại! " + ex);
                        Console.WriteLine($"The decryption failed. {ex}");
                    }
                }
            }
        }

        private void chkbx_KichThuoc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_KichThuoc.Checked)
            {
                sheet_TienLuong.CurrentWorksheet.ShowColumns(5, 7);
            }
            else
            {
                sheet_TienLuong.CurrentWorksheet.HideColumns(5, 7);
            }
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl2.SelectedTab.Text)
            {
                case "Vật liệu":
                    Display.setup(sheet_ChiTietVatLieu);
                    break;
                case "Nhân công":
                    Display.setup(sheet_ChiTietNhanCong);
                    break;
                case "Máy":
                    Display.setup(sheet_ChiTietMay);
                    break;
            }
        }

        // Xử lý tab vật liệu
        private void rdbtn_PPT_NhapTay_CheckedChanged(object sender, EventArgs e)
        {
            // Hiển thị tất cả các cột
            sheet_VatLieu.CurrentWorksheet.ShowColumns(0, 22);

            sheet_VatLieu.CurrentWorksheet.HideColumns(0, 1);
            sheet_VatLieu.CurrentWorksheet.HideColumns(3, 1);
            sheet_VatLieu.CurrentWorksheet.HideColumns(7, 2);
            sheet_VatLieu.CurrentWorksheet.HideColumns(10, 9);
            sheet_VatLieu.CurrentWorksheet.HideColumns(20, 1);

            Option.PPTGiaVatLieu = PPTGiaVatLieu.NhapTay;
            ((Worksheet.modDisplay.templates.vatlieu.Generator)Display.tab("Giá vật liệu")).ThayDoiPPT();
        }

        private void rdbtn_PPT_CongCuocVC_CheckedChanged(object sender, EventArgs e)
        {
            // Hiển thị tất cả các cột
            sheet_VatLieu.CurrentWorksheet.ShowColumns(0, 22);

            sheet_VatLieu.CurrentWorksheet.HideColumns(0, 1);
            sheet_VatLieu.CurrentWorksheet.HideColumns(3, 1);
            sheet_VatLieu.CurrentWorksheet.HideColumns(7, 2);
            sheet_VatLieu.CurrentWorksheet.HideColumns(10, 2);
            sheet_VatLieu.CurrentWorksheet.HideColumns(13, 1);
            sheet_VatLieu.CurrentWorksheet.HideColumns(16, 2);
            sheet_VatLieu.CurrentWorksheet.HideColumns(19, 1);

            Option.PPTGiaVatLieu = PPTGiaVatLieu.CongCuocVanChuyen;
            ((Worksheet.modDisplay.templates.vatlieu.Generator)Display.tab("Giá vật liệu")).ThayDoiPPT();

        }

        private void rdbtn_PPT_NhanHeSo_CheckedChanged(object sender, EventArgs e)
        {
            // Hiển thị tất cả các cột
            sheet_VatLieu.CurrentWorksheet.ShowColumns(0, 22);

            sheet_VatLieu.CurrentWorksheet.HideColumns(0, 1);
            sheet_VatLieu.CurrentWorksheet.HideColumns(3, 1);
            sheet_VatLieu.CurrentWorksheet.HideColumns(7, 2);
            sheet_VatLieu.CurrentWorksheet.HideColumns(11, 9);
            sheet_VatLieu.CurrentWorksheet.HideColumns(20, 1);

            Option.PPTGiaVatLieu = PPTGiaVatLieu.NhanHeSo;
            ((Worksheet.modDisplay.templates.vatlieu.Generator)Display.tab("Giá vật liệu")).ThayDoiPPT();
        }

        private void rdbtn_PPT_NhanHeSoCongCuocVC_CheckedChanged(object sender, EventArgs e)
        {
            // Hiển thị tất cả các cột
            sheet_VatLieu.CurrentWorksheet.ShowColumns(0, 22);

            sheet_VatLieu.CurrentWorksheet.HideColumns(0, 1);
            sheet_VatLieu.CurrentWorksheet.HideColumns(3, 1);
            sheet_VatLieu.CurrentWorksheet.HideColumns(7, 2);
            sheet_VatLieu.CurrentWorksheet.HideColumns(12, 8);

            Option.PPTGiaVatLieu = PPTGiaVatLieu.NhanHeSoCongCuocVanChuyen;
            ((Worksheet.modDisplay.templates.vatlieu.Generator)Display.tab("Giá vật liệu")).ThayDoiPPT();
        }

        private void bbtn_ThemVatLieu_Click(object sender, EventArgs e)
        {
            ((Worksheet.modDisplay.templates.vatlieu.Generator)Display.tab("Giá vật liệu")).updateData();
        }
    }
}
