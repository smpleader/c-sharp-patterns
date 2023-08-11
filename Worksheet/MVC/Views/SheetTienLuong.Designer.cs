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
            btn_BackDemo = new Button();
            btn_ThemCongViec = new Button();
            sheet_TienLuong = new unvell.ReoGrid.ReoGridControl();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            sheet_VatLieu = new unvell.ReoGrid.ReoGridControl();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_BackDemo);
            panel1.Controls.Add(btn_ThemCongViec);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1517, 62);
            panel1.TabIndex = 0;
            // 
            // btn_BackDemo
            // 
            btn_BackDemo.Location = new Point(12, 12);
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
            btn_ThemCongViec.Location = new Point(1357, 12);
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
            sheet_TienLuong.Location = new Point(3, 3);
            sheet_TienLuong.Name = "sheet_TienLuong";
            sheet_TienLuong.RowHeaderContextMenuStrip = null;
            sheet_TienLuong.Script = null;
            sheet_TienLuong.SheetTabContextMenuStrip = null;
            sheet_TienLuong.SheetTabNewButtonVisible = true;
            sheet_TienLuong.SheetTabVisible = true;
            sheet_TienLuong.SheetTabWidth = 60;
            sheet_TienLuong.ShowScrollEndSpacing = true;
            sheet_TienLuong.Size = new Size(1503, 597);
            sheet_TienLuong.TabIndex = 1;
            sheet_TienLuong.Text = "reoGridControl1";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 62);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1517, 636);
            tabControl1.TabIndex = 2;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(sheet_TienLuong);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1509, 603);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tiên lượng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(sheet_VatLieu);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1509, 603);
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
            sheet_VatLieu.Size = new Size(1503, 597);
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
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
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
    }
}