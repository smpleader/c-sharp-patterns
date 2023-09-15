using System.Drawing;
using System;
namespace modDisplay.CustomGrid
{
    partial class DemoWorkbook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_Body = new Panel();
            panel1 = new Panel();
            cbb_SheetActive = new ComboBox();
            chbk_Anhien = new CheckBox();
            btn_setup = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Body
            // 
            pnl_Body.Dock = DockStyle.Fill;
            pnl_Body.Location = new Point(0, 0);
            pnl_Body.Name = "pnl_Body";
            pnl_Body.Padding = new Padding(0, 5, 0, 0);
            pnl_Body.Size = new Size(1511, 503);
            pnl_Body.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbb_SheetActive);
            panel1.Controls.Add(chbk_Anhien);
            panel1.Controls.Add(btn_setup);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1511, 35);
            panel1.TabIndex = 3;
            // 
            // cbb_SheetActive
            // 
            cbb_SheetActive.FormattingEnabled = true;
            cbb_SheetActive.Location = new Point(83, 3);
            cbb_SheetActive.Name = "cbb_SheetActive";
            cbb_SheetActive.Size = new Size(172, 28);
            cbb_SheetActive.TabIndex = 1;
            cbb_SheetActive.SelectedIndexChanged += cbb_SheetActive_SelectedIndexChanged;
            // 
            // chbk_Anhien
            // 
            chbk_Anhien.AutoSize = true;
            chbk_Anhien.Location = new Point(469, 6);
            chbk_Anhien.Name = "chbk_Anhien";
            chbk_Anhien.Size = new Size(106, 24);
            chbk_Anhien.TabIndex = 0;
            chbk_Anhien.Text = "Ẩn hiện cột";
            chbk_Anhien.UseVisualStyleBackColor = true;
            chbk_Anhien.CheckedChanged += chbk_Anhien_CheckedChanged;
            // 
            // btn_setup
            // 
            btn_setup.Location = new Point(329, 3);
            btn_setup.Name = "btn_setup";
            btn_setup.Size = new Size(94, 29);
            btn_setup.TabIndex = 0;
            btn_setup.Text = "Open File";
            btn_setup.UseVisualStyleBackColor = true;
            btn_setup.Click += btn_setup_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pnl_Body);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(1511, 503);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 6);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 2;
            label1.Text = "Sheets";
            // 
            // DemoWorkbook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1511, 538);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DemoWorkbook";
            Text = "Demo one sheet";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

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
            workBook._grid.CurrentCellActivated -= _grid_CurrentCellActivated;
            base.Dispose(disposing);
        }
        private Panel pnl_Body;
        private Panel panel2;
        private Panel panel1;
        private Button btn_setup;
        private CheckBox chbk_Anhien;
        private ComboBox cbb_SheetActive;
        private Label label1;
    }
}

