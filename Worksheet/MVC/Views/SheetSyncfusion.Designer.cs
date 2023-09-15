namespace Worksheet.MVC.Views
{
    partial class SheetSyncfusion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste spreadsheetCopyPaste1 = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste();
            Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController formulaRangeSelectionController1 = new Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController();
            pnl_Header = new Panel();
            btn_ShowDebug = new Button();
            pnl_ChucNangBasic = new FlowLayoutPanel();
            btn_MoFile = new Button();
            btn_LuuFile = new Button();
            btn_ThemCongViec = new Button();
            chkbx_KichThuoc = new CheckBox();
            pnl_VatLieu = new Panel();
            btn_SaveWS = new Button();
            btn_TinhCuocOto = new Button();
            bbtn_ThemVatLieu = new Button();
            rdbtn_PPT_NhanHeSoCongCuocVC = new RadioButton();
            rdbtn_PPT_NhanHeSo = new RadioButton();
            rdbtn_PPT_CongCuocVC = new RadioButton();
            rdbtn_PPT_NhapTay = new RadioButton();
            label1 = new Label();
            cbb_SheetActive = new ComboBox();
            pnl_Working = new Panel();
            pnl_Body = new Panel();
            splitter1 = new Splitter();
            pnl_Bottom = new Panel();
            sheet_working = new Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet();
            pnl_Header.SuspendLayout();
            pnl_ChucNangBasic.SuspendLayout();
            pnl_VatLieu.SuspendLayout();
            pnl_Working.SuspendLayout();
            pnl_Body.SuspendLayout();
            pnl_Bottom.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Header
            // 
            pnl_Header.Controls.Add(btn_ShowDebug);
            pnl_Header.Controls.Add(pnl_ChucNangBasic);
            pnl_Header.Controls.Add(pnl_VatLieu);
            pnl_Header.Controls.Add(cbb_SheetActive);
            pnl_Header.Dock = DockStyle.Top;
            pnl_Header.Location = new Point(0, 0);
            pnl_Header.Name = "pnl_Header";
            pnl_Header.Size = new Size(1777, 46);
            pnl_Header.TabIndex = 0;
            // 
            // btn_ShowDebug
            // 
            btn_ShowDebug.Location = new Point(12, 9);
            btn_ShowDebug.Name = "btn_ShowDebug";
            btn_ShowDebug.Size = new Size(103, 29);
            btn_ShowDebug.TabIndex = 16;
            btn_ShowDebug.Text = "ShowDebug";
            btn_ShowDebug.UseVisualStyleBackColor = true;
            btn_ShowDebug.Click += btn_ShowDebug_Click;
            // 
            // pnl_ChucNangBasic
            // 
            pnl_ChucNangBasic.Controls.Add(btn_MoFile);
            pnl_ChucNangBasic.Controls.Add(btn_LuuFile);
            pnl_ChucNangBasic.Controls.Add(btn_ThemCongViec);
            pnl_ChucNangBasic.Controls.Add(chkbx_KichThuoc);
            pnl_ChucNangBasic.Location = new Point(287, 5);
            pnl_ChucNangBasic.Name = "pnl_ChucNangBasic";
            pnl_ChucNangBasic.Size = new Size(486, 33);
            pnl_ChucNangBasic.TabIndex = 15;
            // 
            // btn_MoFile
            // 
            btn_MoFile.Location = new Point(3, 3);
            btn_MoFile.Name = "btn_MoFile";
            btn_MoFile.Size = new Size(94, 29);
            btn_MoFile.TabIndex = 7;
            btn_MoFile.Text = "Mở file";
            btn_MoFile.UseVisualStyleBackColor = true;
            btn_MoFile.Click += btn_MoFile_Click;
            // 
            // btn_LuuFile
            // 
            btn_LuuFile.Location = new Point(103, 3);
            btn_LuuFile.Name = "btn_LuuFile";
            btn_LuuFile.Size = new Size(94, 29);
            btn_LuuFile.TabIndex = 8;
            btn_LuuFile.Text = "Lưu file";
            btn_LuuFile.UseVisualStyleBackColor = true;
            btn_LuuFile.Click += btn_LuuFile_Click;
            // 
            // btn_ThemCongViec
            // 
            btn_ThemCongViec.Location = new Point(203, 3);
            btn_ThemCongViec.Name = "btn_ThemCongViec";
            btn_ThemCongViec.Size = new Size(130, 29);
            btn_ThemCongViec.TabIndex = 5;
            btn_ThemCongViec.Text = "Thêm công việc";
            btn_ThemCongViec.UseVisualStyleBackColor = true;
            btn_ThemCongViec.Click += btn_ThemCongViec_Click;
            // 
            // chkbx_KichThuoc
            // 
            chkbx_KichThuoc.AutoSize = true;
            chkbx_KichThuoc.Location = new Point(339, 3);
            chkbx_KichThuoc.Name = "chkbx_KichThuoc";
            chkbx_KichThuoc.Size = new Size(101, 24);
            chkbx_KichThuoc.TabIndex = 9;
            chkbx_KichThuoc.Text = "Kích thước";
            chkbx_KichThuoc.UseVisualStyleBackColor = true;
            chkbx_KichThuoc.CheckedChanged += chkbx_KichThuoc_CheckedChanged;
            // 
            // pnl_VatLieu
            // 
            pnl_VatLieu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnl_VatLieu.Controls.Add(btn_SaveWS);
            pnl_VatLieu.Controls.Add(btn_TinhCuocOto);
            pnl_VatLieu.Controls.Add(bbtn_ThemVatLieu);
            pnl_VatLieu.Controls.Add(rdbtn_PPT_NhanHeSoCongCuocVC);
            pnl_VatLieu.Controls.Add(rdbtn_PPT_NhanHeSo);
            pnl_VatLieu.Controls.Add(rdbtn_PPT_CongCuocVC);
            pnl_VatLieu.Controls.Add(rdbtn_PPT_NhapTay);
            pnl_VatLieu.Controls.Add(label1);
            pnl_VatLieu.Location = new Point(701, 3);
            pnl_VatLieu.Name = "pnl_VatLieu";
            pnl_VatLieu.Size = new Size(1076, 40);
            pnl_VatLieu.TabIndex = 10;
            pnl_VatLieu.Visible = false;
            // 
            // btn_SaveWS
            // 
            btn_SaveWS.Location = new Point(790, 6);
            btn_SaveWS.Name = "btn_SaveWS";
            btn_SaveWS.Size = new Size(158, 29);
            btn_SaveWS.TabIndex = 13;
            btn_SaveWS.Text = "Save workingsheet";
            btn_SaveWS.UseVisualStyleBackColor = true;
            btn_SaveWS.Click += btn_SaveWS_Click;
            // 
            // btn_TinhCuocOto
            // 
            btn_TinhCuocOto.Location = new Point(690, 7);
            btn_TinhCuocOto.Name = "btn_TinhCuocOto";
            btn_TinhCuocOto.Size = new Size(94, 29);
            btn_TinhCuocOto.TabIndex = 12;
            btn_TinhCuocOto.Text = "Tính cước ô tô";
            btn_TinhCuocOto.UseVisualStyleBackColor = true;
            btn_TinhCuocOto.Visible = false;
            btn_TinhCuocOto.Click += btn_TinhCuocOto_Click;
            // 
            // bbtn_ThemVatLieu
            // 
            bbtn_ThemVatLieu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bbtn_ThemVatLieu.Location = new Point(954, 6);
            bbtn_ThemVatLieu.Name = "bbtn_ThemVatLieu";
            bbtn_ThemVatLieu.Size = new Size(112, 29);
            bbtn_ThemVatLieu.TabIndex = 11;
            bbtn_ThemVatLieu.Text = "Thêm vật liệu";
            bbtn_ThemVatLieu.UseVisualStyleBackColor = true;
            bbtn_ThemVatLieu.Click += bbtn_ThemVatLieu_Click;
            // 
            // rdbtn_PPT_NhanHeSoCongCuocVC
            // 
            rdbtn_PPT_NhanHeSoCongCuocVC.AutoSize = true;
            rdbtn_PPT_NhanHeSoCongCuocVC.Location = new Point(496, 9);
            rdbtn_PPT_NhanHeSoCongCuocVC.Name = "rdbtn_PPT_NhanHeSoCongCuocVC";
            rdbtn_PPT_NhanHeSoCongCuocVC.Size = new Size(178, 24);
            rdbtn_PPT_NhanHeSoCongCuocVC.TabIndex = 9;
            rdbtn_PPT_NhanHeSoCongCuocVC.Text = "Nhân hệ số + Cước VC";
            rdbtn_PPT_NhanHeSoCongCuocVC.UseVisualStyleBackColor = true;
            rdbtn_PPT_NhanHeSoCongCuocVC.CheckedChanged += rdbtn_PPT_NhanHeSoCongCuocVC_CheckedChanged;
            // 
            // rdbtn_PPT_NhanHeSo
            // 
            rdbtn_PPT_NhanHeSo.AutoSize = true;
            rdbtn_PPT_NhanHeSo.Location = new Point(376, 10);
            rdbtn_PPT_NhanHeSo.Name = "rdbtn_PPT_NhanHeSo";
            rdbtn_PPT_NhanHeSo.Size = new Size(104, 24);
            rdbtn_PPT_NhanHeSo.TabIndex = 8;
            rdbtn_PPT_NhanHeSo.Text = "Nhân hệ số";
            rdbtn_PPT_NhanHeSo.UseVisualStyleBackColor = true;
            rdbtn_PPT_NhanHeSo.CheckedChanged += rdbtn_PPT_NhanHeSo_CheckedChanged;
            // 
            // rdbtn_PPT_CongCuocVC
            // 
            rdbtn_PPT_CongCuocVC.AutoSize = true;
            rdbtn_PPT_CongCuocVC.Location = new Point(247, 10);
            rdbtn_PPT_CongCuocVC.Name = "rdbtn_PPT_CongCuocVC";
            rdbtn_PPT_CongCuocVC.Size = new Size(123, 24);
            rdbtn_PPT_CongCuocVC.TabIndex = 7;
            rdbtn_PPT_CongCuocVC.Text = "Cộng cước VC";
            rdbtn_PPT_CongCuocVC.UseVisualStyleBackColor = true;
            rdbtn_PPT_CongCuocVC.CheckedChanged += rdbtn_PPT_CongCuocVC_CheckedChanged;
            // 
            // rdbtn_PPT_NhapTay
            // 
            rdbtn_PPT_NhapTay.AutoSize = true;
            rdbtn_PPT_NhapTay.Location = new Point(151, 9);
            rdbtn_PPT_NhapTay.Name = "rdbtn_PPT_NhapTay";
            rdbtn_PPT_NhapTay.Size = new Size(90, 24);
            rdbtn_PPT_NhapTay.TabIndex = 6;
            rdbtn_PPT_NhapTay.Text = "Nhập tay";
            rdbtn_PPT_NhapTay.UseVisualStyleBackColor = true;
            rdbtn_PPT_NhapTay.CheckedChanged += rdbtn_PPT_NhapTay_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 12);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 6;
            label1.Text = "Phương pháp tính";
            // 
            // cbb_SheetActive
            // 
            cbb_SheetActive.FormattingEnabled = true;
            cbb_SheetActive.Location = new Point(121, 10);
            cbb_SheetActive.Name = "cbb_SheetActive";
            cbb_SheetActive.Size = new Size(151, 28);
            cbb_SheetActive.TabIndex = 14;
            cbb_SheetActive.SelectedIndexChanged += cbb_SheetActive_SelectedIndexChanged;
            // 
            // pnl_Working
            // 
            pnl_Working.Controls.Add(pnl_Body);
            pnl_Working.Controls.Add(pnl_Bottom);
            pnl_Working.Dock = DockStyle.Fill;
            pnl_Working.Location = new Point(0, 46);
            pnl_Working.Name = "pnl_Working";
            pnl_Working.Size = new Size(1777, 730);
            pnl_Working.TabIndex = 1;
            // 
            // pnl_Body
            // 
            pnl_Body.AutoScroll = true;
            pnl_Body.BorderStyle = BorderStyle.FixedSingle;
            pnl_Body.Controls.Add(splitter1);
            pnl_Body.Dock = DockStyle.Fill;
            pnl_Body.Location = new Point(0, 0);
            pnl_Body.Name = "pnl_Body";
            pnl_Body.Padding = new Padding(2);
            pnl_Body.Size = new Size(1777, 391);
            pnl_Body.TabIndex = 4;
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Bottom;
            splitter1.Location = new Point(2, 383);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(1771, 4);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // pnl_Bottom
            // 
            pnl_Bottom.Controls.Add(sheet_working);
            pnl_Bottom.Dock = DockStyle.Bottom;
            pnl_Bottom.Location = new Point(0, 391);
            pnl_Bottom.Name = "pnl_Bottom";
            pnl_Bottom.Size = new Size(1777, 339);
            pnl_Bottom.TabIndex = 2;
            // 
            // sheet_working
            // 
            sheet_working.AllowCellContextMenu = true;
            sheet_working.AllowExtendRowColumnCount = true;
            sheet_working.AllowFiltering = false;
            sheet_working.AllowFormulaRangeSelection = true;
            sheet_working.AllowTabItemContextMenu = true;
            sheet_working.AllowZooming = true;
            sheet_working.BaseThemeName = "";
            spreadsheetCopyPaste1.AllowPasteOptionPopup = true;
            spreadsheetCopyPaste1.DefaultPasteOption = Syncfusion.Windows.Forms.Spreadsheet.PasteOptions.Paste;
            sheet_working.CopyPaste = spreadsheetCopyPaste1;
            sheet_working.DefaultColumnCount = 101;
            sheet_working.DefaultRowCount = 101;
            sheet_working.DisplayAlerts = true;
            sheet_working.Dock = DockStyle.Fill;
            sheet_working.FileName = "Book2";
            sheet_working.FormulaBarVisibility = true;
            formulaRangeSelectionController1.AllowMouseSelection = true;
            formulaRangeSelectionController1.AllowSelectionOnEditing = true;
            sheet_working.FormulaRangeSelectionController = formulaRangeSelectionController1;
            sheet_working.IsCustomTabItemContextMenuEnabled = false;
            sheet_working.Location = new Point(0, 0);
            sheet_working.Name = "sheet_working";
            sheet_working.SelectedTabIndex = 0;
            sheet_working.SelectedTabItem = null;
            sheet_working.ShowBusyIndicator = true;
            sheet_working.Size = new Size(1777, 339);
            sheet_working.TabIndex = 0;
            sheet_working.TabItemContextMenu = null;
            sheet_working.Text = "spreadsheet1";
            sheet_working.ThemeName = "Default";
            // 
            // SheetSyncfusion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1777, 776);
            Controls.Add(pnl_Working);
            Controls.Add(pnl_Header);
            Name = "SheetSyncfusion";
            Text = "Sheet Demo Syncfusion";
            Title = "Sheet Demo Syncfusion";
            WindowState = FormWindowState.Maximized;
            Load += SheetSyncfusion_Load;
            pnl_Header.ResumeLayout(false);
            pnl_ChucNangBasic.ResumeLayout(false);
            pnl_ChucNangBasic.PerformLayout();
            pnl_VatLieu.ResumeLayout(false);
            pnl_VatLieu.PerformLayout();
            pnl_Working.ResumeLayout(false);
            pnl_Body.ResumeLayout(false);
            pnl_Bottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Header;
        private Panel pnl_Working;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel pnl_Bottom;
        private Panel pnl_Body;
        private Splitter splitter1;
        private CheckBox chkbx_KichThuoc;
        private Button btn_LuuFile;
        private Button btn_MoFile;
        private Button btn_ThemCongViec;
        private Panel pnl_VatLieu;
        private RadioButton rdbtn_PPT_NhanHeSoCongCuocVC;
        private RadioButton rdbtn_PPT_NhanHeSo;
        private RadioButton rdbtn_PPT_CongCuocVC;
        private RadioButton rdbtn_PPT_NhapTay;
        private Label label1;
        private Button bbtn_ThemVatLieu;
        private Button btn_TinhCuocOto;
        public Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet sheet_working;
        private Button btn_SaveWS;
        private ComboBox cbb_SheetActive;
        private Button btn_ShowDebug;
        private FlowLayoutPanel pnl_ChucNangBasic;
    }
}