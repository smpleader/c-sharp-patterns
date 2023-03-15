namespace DI_Storage.MVC.Views
{
    partial class SheetUser
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
            reoGridControl1 = new unvell.ReoGrid.ReoGridControl();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // reoGridControl1
            // 
            reoGridControl1.BackColor = Color.FromArgb(255, 255, 255);
            reoGridControl1.ColumnHeaderContextMenuStrip = null;
            reoGridControl1.LeadHeaderContextMenuStrip = null;
            reoGridControl1.Location = new Point(12, 55);
            reoGridControl1.Name = "reoGridControl1";
            reoGridControl1.RowHeaderContextMenuStrip = null;
            reoGridControl1.Script = null;
            reoGridControl1.SheetTabContextMenuStrip = null;
            reoGridControl1.SheetTabNewButtonVisible = true;
            reoGridControl1.SheetTabVisible = true;
            reoGridControl1.SheetTabWidth = 60;
            reoGridControl1.ShowScrollEndSpacing = true;
            reoGridControl1.Size = new Size(776, 383);
            reoGridControl1.TabIndex = 0;
            reoGridControl1.Text = "reoGridControl1";
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(129, 29);
            button1.TabIndex = 1;
            button1.Text = "Back Starter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(172, 12);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(684, 12);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "Load";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(494, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(174, 28);
            comboBox1.TabIndex = 4;
            // 
            // SheetUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(reoGridControl1);
            Name = "SheetUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SheetUser";
            Title = "SheetUser";
            Load += SheetUser_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;

        // public for presenter
        public ComboBox comboBox1;
        public unvell.ReoGrid.ReoGridControl reoGridControl1;
    }
}