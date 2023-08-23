namespace Worksheet.MVC.Views
{
    partial class SheetTienLuong
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
            panel1 = new Panel();
            chkbx_KichThuoc = new CheckBox();
            btn_LuuFile = new Button();
            btn_MoFile = new Button();
            btn_BackDemo = new Button();
            btn_ThemCongViec = new Button();
            sheet_TienLuong = new unvell.ReoGrid.ReoGridControl();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel4 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            sheet_ChiTietVatLieu = new unvell.ReoGrid.ReoGridControl();
            tabPage4 = new TabPage();
            sheet_ChiTietNhanCong = new unvell.ReoGrid.ReoGridControl();
            tabPage5 = new TabPage();
            sheet_ChiTietMay = new unvell.ReoGrid.ReoGridControl();
            formulaBarControl1 = new EtaDt.MVCP.Views.Common.FormulaBarControl();
            tabPage2 = new TabPage();
            panel8 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            sheet_VatLieu = new unvell.ReoGrid.ReoGridControl();
            formulaBarControl2 = new EtaDt.MVCP.Views.Common.FormulaBarControl();
            panel7 = new Panel();
            bbtn_ThemVatLieu = new Button();
            rdbtn_PPT_NhanHeSoCongCuocVC = new RadioButton();
            rdbtn_PPT_NhanHeSo = new RadioButton();
            rdbtn_PPT_CongCuocVC = new RadioButton();
            rdbtn_PPT_NhapTay = new RadioButton();
            label1 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage2.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(chkbx_KichThuoc);
            panel1.Controls.Add(btn_LuuFile);
            panel1.Controls.Add(btn_MoFile);
            panel1.Controls.Add(btn_BackDemo);
            panel1.Controls.Add(btn_ThemCongViec);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1586, 42);
            panel1.TabIndex = 0;
            // 
            // chkbx_KichThuoc
            // 
            chkbx_KichThuoc.AutoSize = true;
            chkbx_KichThuoc.Location = new Point(330, 8);
            chkbx_KichThuoc.Name = "chkbx_KichThuoc";
            chkbx_KichThuoc.Size = new Size(101, 24);
            chkbx_KichThuoc.TabIndex = 4;
            chkbx_KichThuoc.Text = "Kích thước";
            chkbx_KichThuoc.UseVisualStyleBackColor = true;
            chkbx_KichThuoc.CheckedChanged += chkbx_KichThuoc_CheckedChanged;
            // 
            // btn_LuuFile
            // 
            btn_LuuFile.Location = new Point(212, 5);
            btn_LuuFile.Name = "btn_LuuFile";
            btn_LuuFile.Size = new Size(94, 29);
            btn_LuuFile.TabIndex = 3;
            btn_LuuFile.Text = "Lưu file";
            btn_LuuFile.UseVisualStyleBackColor = true;
            btn_LuuFile.Click += btn_LuuFile_Click;
            // 
            // btn_MoFile
            // 
            btn_MoFile.Location = new Point(112, 5);
            btn_MoFile.Name = "btn_MoFile";
            btn_MoFile.Size = new Size(94, 29);
            btn_MoFile.TabIndex = 2;
            btn_MoFile.Text = "Mở file";
            btn_MoFile.UseVisualStyleBackColor = true;
            btn_MoFile.Click += btn_MoFile_Click;
            // 
            // btn_BackDemo
            // 
            btn_BackDemo.Location = new Point(12, 5);
            btn_BackDemo.Name = "btn_BackDemo";
            btn_BackDemo.Size = new Size(94, 29);
            btn_BackDemo.TabIndex = 1;
            btn_BackDemo.Text = "<<";
            btn_BackDemo.UseVisualStyleBackColor = true;
            btn_BackDemo.Click += btn_BackDemo_Click;
            // 
            // btn_ThemCongViec
            // 
            btn_ThemCongViec.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_ThemCongViec.Location = new Point(1426, 5);
            btn_ThemCongViec.Name = "btn_ThemCongViec";
            btn_ThemCongViec.Size = new Size(148, 29);
            btn_ThemCongViec.TabIndex = 0;
            btn_ThemCongViec.Text = "Thêm công việc";
            btn_ThemCongViec.UseVisualStyleBackColor = true;
            btn_ThemCongViec.Click += btn_ThemCongViec_Click;
            // 
            // sheet_TienLuong
            // 
            sheet_TienLuong.BackColor = Color.FromArgb(255, 255, 255);
            sheet_TienLuong.ColumnHeaderContextMenuStrip = null;
            sheet_TienLuong.Dock = DockStyle.Fill;
            sheet_TienLuong.LeadHeaderContextMenuStrip = null;
            sheet_TienLuong.Location = new Point(0, 0);
            sheet_TienLuong.Name = "sheet_TienLuong";
            sheet_TienLuong.RowHeaderContextMenuStrip = null;
            sheet_TienLuong.Script = null;
            sheet_TienLuong.SheetTabContextMenuStrip = null;
            sheet_TienLuong.SheetTabNewButtonVisible = true;
            sheet_TienLuong.SheetTabVisible = true;
            sheet_TienLuong.SheetTabWidth = 60;
            sheet_TienLuong.ShowScrollEndSpacing = true;
            sheet_TienLuong.Size = new Size(1572, 280);
            sheet_TienLuong.TabIndex = 1;
            sheet_TienLuong.Text = "reoGridControl1";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 42);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1586, 656);
            tabControl1.TabIndex = 2;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(formulaBarControl1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1578, 623);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tiên lượng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 39);
            panel4.Name = "panel4";
            panel4.Size = new Size(1572, 280);
            panel4.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(sheet_TienLuong);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1572, 280);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(tabControl2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 319);
            panel3.Name = "panel3";
            panel3.Size = new Size(1572, 301);
            panel3.TabIndex = 4;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Controls.Add(tabPage5);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new Point(0, 0);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(1572, 301);
            tabControl2.TabIndex = 0;
            tabControl2.SelectedIndexChanged += tabControl2_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(sheet_ChiTietVatLieu);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1564, 268);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Vật liệu";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // sheet_ChiTietVatLieu
            // 
            sheet_ChiTietVatLieu.BackColor = Color.FromArgb(255, 255, 255);
            sheet_ChiTietVatLieu.ColumnHeaderContextMenuStrip = null;
            sheet_ChiTietVatLieu.Dock = DockStyle.Fill;
            sheet_ChiTietVatLieu.LeadHeaderContextMenuStrip = null;
            sheet_ChiTietVatLieu.Location = new Point(3, 3);
            sheet_ChiTietVatLieu.Name = "sheet_ChiTietVatLieu";
            sheet_ChiTietVatLieu.RowHeaderContextMenuStrip = null;
            sheet_ChiTietVatLieu.Script = null;
            sheet_ChiTietVatLieu.SheetTabContextMenuStrip = null;
            sheet_ChiTietVatLieu.SheetTabNewButtonVisible = true;
            sheet_ChiTietVatLieu.SheetTabVisible = true;
            sheet_ChiTietVatLieu.SheetTabWidth = 60;
            sheet_ChiTietVatLieu.ShowScrollEndSpacing = true;
            sheet_ChiTietVatLieu.Size = new Size(1558, 262);
            sheet_ChiTietVatLieu.TabIndex = 0;
            sheet_ChiTietVatLieu.Text = "reoGridControl1";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(sheet_ChiTietNhanCong);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1564, 268);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Nhân công";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // sheet_ChiTietNhanCong
            // 
            sheet_ChiTietNhanCong.BackColor = Color.FromArgb(255, 255, 255);
            sheet_ChiTietNhanCong.ColumnHeaderContextMenuStrip = null;
            sheet_ChiTietNhanCong.Dock = DockStyle.Fill;
            sheet_ChiTietNhanCong.LeadHeaderContextMenuStrip = null;
            sheet_ChiTietNhanCong.Location = new Point(3, 3);
            sheet_ChiTietNhanCong.Name = "sheet_ChiTietNhanCong";
            sheet_ChiTietNhanCong.RowHeaderContextMenuStrip = null;
            sheet_ChiTietNhanCong.Script = null;
            sheet_ChiTietNhanCong.SheetTabContextMenuStrip = null;
            sheet_ChiTietNhanCong.SheetTabNewButtonVisible = true;
            sheet_ChiTietNhanCong.SheetTabVisible = true;
            sheet_ChiTietNhanCong.SheetTabWidth = 60;
            sheet_ChiTietNhanCong.ShowScrollEndSpacing = true;
            sheet_ChiTietNhanCong.Size = new Size(1558, 262);
            sheet_ChiTietNhanCong.TabIndex = 0;
            sheet_ChiTietNhanCong.Text = "reoGridControl1";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(sheet_ChiTietMay);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1564, 268);
            tabPage5.TabIndex = 2;
            tabPage5.Text = "Máy";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // sheet_ChiTietMay
            // 
            sheet_ChiTietMay.BackColor = Color.FromArgb(255, 255, 255);
            sheet_ChiTietMay.ColumnHeaderContextMenuStrip = null;
            sheet_ChiTietMay.Dock = DockStyle.Fill;
            sheet_ChiTietMay.LeadHeaderContextMenuStrip = null;
            sheet_ChiTietMay.Location = new Point(0, 0);
            sheet_ChiTietMay.Name = "sheet_ChiTietMay";
            sheet_ChiTietMay.RowHeaderContextMenuStrip = null;
            sheet_ChiTietMay.Script = null;
            sheet_ChiTietMay.SheetTabContextMenuStrip = null;
            sheet_ChiTietMay.SheetTabNewButtonVisible = true;
            sheet_ChiTietMay.SheetTabVisible = true;
            sheet_ChiTietMay.SheetTabWidth = 60;
            sheet_ChiTietMay.ShowScrollEndSpacing = true;
            sheet_ChiTietMay.Size = new Size(1564, 268);
            sheet_ChiTietMay.TabIndex = 0;
            sheet_ChiTietMay.Text = "reoGridControl1";
            // 
            // formulaBarControl1
            // 
            formulaBarControl1.BackColor = SystemColors.Window;
            formulaBarControl1.Dock = DockStyle.Top;
            formulaBarControl1.FocusToGridAfterInputValue = false;
            formulaBarControl1.GridControl = sheet_TienLuong;
            formulaBarControl1.Location = new Point(3, 3);
            formulaBarControl1.Margin = new Padding(4, 5, 4, 5);
            formulaBarControl1.Name = "formulaBarControl1";
            formulaBarControl1.Size = new Size(1572, 36);
            formulaBarControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel8);
            tabPage2.Controls.Add(panel7);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1578, 623);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Vật liệu";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel5);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(3, 37);
            panel8.Name = "panel8";
            panel8.Size = new Size(1572, 583);
            panel8.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(formulaBarControl2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1572, 583);
            panel5.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.Controls.Add(sheet_VatLieu);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 36);
            panel6.Name = "panel6";
            panel6.Size = new Size(1572, 547);
            panel6.TabIndex = 5;
            // 
            // sheet_VatLieu
            // 
            sheet_VatLieu.BackColor = Color.FromArgb(255, 255, 255);
            sheet_VatLieu.ColumnHeaderContextMenuStrip = null;
            sheet_VatLieu.Dock = DockStyle.Fill;
            sheet_VatLieu.LeadHeaderContextMenuStrip = null;
            sheet_VatLieu.Location = new Point(0, 0);
            sheet_VatLieu.Name = "sheet_VatLieu";
            sheet_VatLieu.RowHeaderContextMenuStrip = null;
            sheet_VatLieu.Script = null;
            sheet_VatLieu.SheetTabContextMenuStrip = null;
            sheet_VatLieu.SheetTabNewButtonVisible = true;
            sheet_VatLieu.SheetTabVisible = true;
            sheet_VatLieu.SheetTabWidth = 60;
            sheet_VatLieu.ShowScrollEndSpacing = true;
            sheet_VatLieu.Size = new Size(1572, 547);
            sheet_VatLieu.TabIndex = 2;
            sheet_VatLieu.Text = "reoGridControl1";
            // 
            // formulaBarControl2
            // 
            formulaBarControl2.BackColor = SystemColors.Window;
            formulaBarControl2.Dock = DockStyle.Top;
            formulaBarControl2.FocusToGridAfterInputValue = false;
            formulaBarControl2.GridControl = sheet_VatLieu;
            formulaBarControl2.Location = new Point(0, 0);
            formulaBarControl2.Margin = new Padding(4, 5, 4, 5);
            formulaBarControl2.Name = "formulaBarControl2";
            formulaBarControl2.Size = new Size(1572, 36);
            formulaBarControl2.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(bbtn_ThemVatLieu);
            panel7.Controls.Add(rdbtn_PPT_NhanHeSoCongCuocVC);
            panel7.Controls.Add(rdbtn_PPT_NhanHeSo);
            panel7.Controls.Add(rdbtn_PPT_CongCuocVC);
            panel7.Controls.Add(rdbtn_PPT_NhapTay);
            panel7.Controls.Add(label1);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(1572, 34);
            panel7.TabIndex = 5;
            // 
            // bbtn_ThemVatLieu
            // 
            bbtn_ThemVatLieu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bbtn_ThemVatLieu.Location = new Point(1455, 2);
            bbtn_ThemVatLieu.Name = "bbtn_ThemVatLieu";
            bbtn_ThemVatLieu.Size = new Size(112, 29);
            bbtn_ThemVatLieu.TabIndex = 10;
            bbtn_ThemVatLieu.Text = "Thêm vật liệu";
            bbtn_ThemVatLieu.UseVisualStyleBackColor = true;
            bbtn_ThemVatLieu.Click += bbtn_ThemVatLieu_Click;
            // 
            // rdbtn_PPT_NhanHeSoCongCuocVC
            // 
            rdbtn_PPT_NhanHeSoCongCuocVC.AutoSize = true;
            rdbtn_PPT_NhanHeSoCongCuocVC.Location = new Point(496, 4);
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
            rdbtn_PPT_NhanHeSo.Location = new Point(376, 5);
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
            rdbtn_PPT_CongCuocVC.Location = new Point(247, 5);
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
            rdbtn_PPT_NhapTay.Location = new Point(151, 4);
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
            label1.Location = new Point(6, 7);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 6;
            label1.Text = "Phương pháp tính";
            // 
            // SheetTienLuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1586, 698);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "SheetTienLuong";
            Text = "Demo sheet Tiên lượng";
            Title = "Demo sheet Tiên lượng";
            FormClosed += SheetTienLuong_FormClosed;
            Load += SheetTienLuong_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public unvell.ReoGrid.ReoGridControl sheet_TienLuong;
        private Button btn_ThemCongViec;
        private Button btn_BackDemo;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        public unvell.ReoGrid.ReoGridControl sheet_VatLieu;
        private Button btn_LuuFile;
        private Button btn_MoFile;
        private Panel panel2;
        private EtaDt.MVCP.Views.Common.FormulaBarControl formulaBarControl1;
        private CheckBox chkbx_KichThuoc;
        private Panel panel4;
        private Panel panel3;
        private TabControl tabControl2;
        private TabPage tabPage3;
        public unvell.ReoGrid.ReoGridControl sheet_ChiTietVatLieu;
        private TabPage tabPage4;
        public unvell.ReoGrid.ReoGridControl sheet_ChiTietNhanCong;
        private TabPage tabPage5;
        public unvell.ReoGrid.ReoGridControl sheet_ChiTietMay;
        private Panel panel5;
        private EtaDt.MVCP.Views.Common.FormulaBarControl formulaBarControl2;
        private Panel panel8;
        private Panel panel6;
        private Panel panel7;
        private RadioButton rdbtn_PPT_NhanHeSoCongCuocVC;
        private RadioButton rdbtn_PPT_NhanHeSo;
        private RadioButton rdbtn_PPT_CongCuocVC;
        private RadioButton rdbtn_PPT_NhapTay;
        private Label label1;
        private Button bbtn_ThemVatLieu;
    }
}