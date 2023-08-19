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
            sheet_VatLieu = new unvell.ReoGrid.ReoGridControl();
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
            panel1.Size = new Size(1517, 42);
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
            btn_ThemCongViec.Location = new Point(1357, 5);
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
            sheet_TienLuong.Size = new Size(1503, 237);
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
            tabControl1.Size = new Size(1517, 656);
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
            tabPage1.Size = new Size(1509, 623);
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
            panel4.Size = new Size(1503, 237);
            panel4.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(sheet_TienLuong);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1503, 237);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(tabControl2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 276);
            panel3.Name = "panel3";
            panel3.Size = new Size(1503, 344);
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
            tabControl2.Size = new Size(1503, 344);
            tabControl2.TabIndex = 0;
            tabControl2.SelectedIndexChanged += tabControl2_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(sheet_ChiTietVatLieu);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1495, 311);
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
            sheet_ChiTietVatLieu.Size = new Size(1489, 305);
            sheet_ChiTietVatLieu.TabIndex = 0;
            sheet_ChiTietVatLieu.Text = "reoGridControl1";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(sheet_ChiTietNhanCong);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1495, 368);
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
            sheet_ChiTietNhanCong.Size = new Size(1489, 362);
            sheet_ChiTietNhanCong.TabIndex = 0;
            sheet_ChiTietNhanCong.Text = "reoGridControl1";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(sheet_ChiTietMay);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1495, 368);
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
            sheet_ChiTietMay.Size = new Size(1495, 368);
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
            formulaBarControl1.Size = new Size(1503, 36);
            formulaBarControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(sheet_VatLieu);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1509, 623);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Vật liệu";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // sheet_VatLieu
            // 
            sheet_VatLieu.BackColor = Color.FromArgb(255, 255, 255);
            sheet_VatLieu.ColumnHeaderContextMenuStrip = null;
            sheet_VatLieu.Dock = DockStyle.Fill;
            sheet_VatLieu.LeadHeaderContextMenuStrip = null;
            sheet_VatLieu.Location = new Point(3, 3);
            sheet_VatLieu.Name = "sheet_VatLieu";
            sheet_VatLieu.RowHeaderContextMenuStrip = null;
            sheet_VatLieu.Script = null;
            sheet_VatLieu.SheetTabContextMenuStrip = null;
            sheet_VatLieu.SheetTabNewButtonVisible = true;
            sheet_VatLieu.SheetTabVisible = true;
            sheet_VatLieu.SheetTabWidth = 60;
            sheet_VatLieu.ShowScrollEndSpacing = true;
            sheet_VatLieu.Size = new Size(1503, 617);
            sheet_VatLieu.TabIndex = 2;
            sheet_VatLieu.Text = "reoGridControl1";
            // 
            // SheetTienLuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1517, 698);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "SheetTienLuong";
            Text = "Demo sheet Tiên lượng";
            Title = "Demo sheet Tiên lượng";
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
    }
}