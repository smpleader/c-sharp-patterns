using modDisplay.CustomGrid;
using Syncfusion.GridHelperClasses;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modDisplay.CustomGrid
{
    public partial class WorkBook
    {
        #region Override Methods
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            if (_grid != null)
            {
                _grid.CurrentCellMoved -= _grid_CurrentCellMoved;
                _grid.SelectionChanged -= _grid_SelectionChanged;
                _grid.VisibleChanged -= new EventHandler(_grid_VisibleChanged);
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(WorkBook));
            panelInfo = new Panel();
            AddressTextBox = new GridAwareTextBox();
            FormulaTextBox = new GridAwareTextBox();
            gridCMStrip = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            insertToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            deleteContentToolStripMenuItem = new ToolStripMenuItem();
            mergeToolStripMenuItem = new ToolStripMenuItem();
            pnl_FormulaBar = new Panel();
            pnl_ActiveSheet = new Panel();
            pnl_Workbook = new Panel();
            gridCMStrip.SuspendLayout();
            pnl_Workbook.SuspendLayout();
            SuspendLayout();
            // 
            // panelInfo
            // 
            panelInfo.Location = new Point(745, 532);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(250, 125);
            panelInfo.TabIndex = 1;
            // 
            // AddressTextBox
            // 
            AddressTextBox.AutoSuggestFormula = false;
            AddressTextBox.BorderStyle = BorderStyle.FixedSingle;
            AddressTextBox.DisabledBackColor = SystemColors.Window;
            AddressTextBox.EnabledBackColor = SystemColors.Window;
            AddressTextBox.Location = new Point(208, 5);
            AddressTextBox.Margin = new Padding(4, 5, 4, 5);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(133, 27);
            AddressTextBox.TabIndex = 1;
            AddressTextBox.Visible = false;
            // 
            // FormulaTextBox
            // 
            FormulaTextBox.AutoSuggestFormula = false;
            FormulaTextBox.BorderStyle = BorderStyle.FixedSingle;
            FormulaTextBox.DisabledBackColor = SystemColors.Window;
            FormulaTextBox.EnabledBackColor = SystemColors.Window;
            FormulaTextBox.Location = new Point(34, 5);
            FormulaTextBox.Margin = new Padding(4, 5, 4, 5);
            FormulaTextBox.Name = "FormulaTextBox";
            FormulaTextBox.Size = new Size(133, 27);
            FormulaTextBox.TabIndex = 2;
            FormulaTextBox.Visible = false;
            // 
            // gridCMStrip
            // 
            gridCMStrip.ImageScalingSize = new Size(20, 20);
            gridCMStrip.Items.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator1, insertToolStripMenuItem, deleteToolStripMenuItem1, deleteContentToolStripMenuItem, mergeToolStripMenuItem });
            gridCMStrip.MetroColor = Color.FromArgb(17, 158, 218);
            gridCMStrip.Name = "gridCMStrip";
            gridCMStrip.Size = new Size(177, 178);
            gridCMStrip.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Default;
            gridCMStrip.ThemeName = "Default";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(176, 24);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(176, 24);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(176, 24);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(173, 6);
            // 
            // insertToolStripMenuItem
            // 
            insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            insertToolStripMenuItem.Size = new Size(176, 24);
            insertToolStripMenuItem.Text = "Insert row";
            insertToolStripMenuItem.Click += insertToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(176, 24);
            deleteToolStripMenuItem1.Text = "Delete row";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem1_Click;
            // 
            // deleteContentToolStripMenuItem
            // 
            deleteContentToolStripMenuItem.Name = "deleteContentToolStripMenuItem";
            deleteContentToolStripMenuItem.Size = new Size(176, 24);
            deleteContentToolStripMenuItem.Text = "Delete content";
            deleteContentToolStripMenuItem.Click += deleteContentToolStripMenuItem_Click;
            // 
            // mergeToolStripMenuItem
            // 
            mergeToolStripMenuItem.Name = "mergeToolStripMenuItem";
            mergeToolStripMenuItem.Size = new Size(176, 24);
            mergeToolStripMenuItem.Text = "Merge";
            mergeToolStripMenuItem.Click += mergeToolStripMenuItem_Click;
            // 
            // pnl_FormulaBar
            // 
            pnl_FormulaBar.Dock = DockStyle.Top;
            pnl_FormulaBar.Location = new Point(0, 0);
            pnl_FormulaBar.Name = "pnl_FormulaBar";
            pnl_FormulaBar.Size = new Size(1033, 50);
            pnl_FormulaBar.TabIndex = 1;
            // 
            // pnl_ActiveSheet
            // 
            pnl_ActiveSheet.Dock = DockStyle.Fill;
            pnl_ActiveSheet.Location = new Point(0, 0);
            pnl_ActiveSheet.Name = "pnl_ActiveSheet";
            pnl_ActiveSheet.Size = new Size(1033, 125);
            pnl_ActiveSheet.TabIndex = 2;
            // 
            // pnl_Workbook
            // 
            pnl_Workbook.Controls.Add(pnl_FormulaBar);
            pnl_Workbook.Controls.Add(pnl_ActiveSheet);
            pnl_Workbook.Dock = DockStyle.Bottom;
            pnl_Workbook.Location = new Point(0, 481);
            pnl_Workbook.Name = "pnl_Workbook";
            pnl_Workbook.Size = new Size(1033, 125);
            pnl_Workbook.TabIndex = 3;
            // 
            // WorkBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 606);
            ControlBox = false;
            Controls.Add(pnl_Workbook);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(794, 590);
            Name = "WorkBook";
            Text = "WorkbookOneSheet";
            WindowState = FormWindowState.Maximized;
            gridCMStrip.ResumeLayout(false);
            pnl_Workbook.ResumeLayout(false);
            ResumeLayout(false);
        }

        //Add the sheet 
        int i = 0;
        private void InitGrid()
        {
            # region Initial Settings
            SuspendLayout();
            GridControl _grid;
            GridModel model = new GridModel();
            SampleGrid.SetupGridModel(model);
            _grid = new SampleGrid(model);
            // 
            // _grid
            // 
            _grid.ContextMenuStrip = gridCMStrip;
            _grid.Location = new Point(0, 0);
            _grid.Name = string.Format("gridControl{0}", i + 1);
            _grid.SmartSizeBox = false;
            _grid.Text = string.Format("gridControl{0}", i + 1);
            _grid.FillSplitterPane = true;
            _grid.PersistAppearanceSettings = false;
            _grid.ThemesEnabled = false;
            _grid.GridVisualStyles = GridVisualStyles.Metro;
            model.Options.GridVisualStyles = GridVisualStyles.Metro;
            _grid.VerticalThumbTrack = true;
            _grid.VerticalScrollTips = true;
            _grid.HorizontalThumbTrack = true;
            _grid.HorizontalScrollTips = true;
            _grid.AutoScrolling = ScrollBars.Both;
            _grid.BringToFront();
            _grid.Size = new Size(1000, 1000);
            _grid.Dock = DockStyle.Fill;
            _grid.Visible = true;

            GridMetroColors grid = new GridMetroColors();
            grid.HeaderColor.NormalColor = Color.Red;
            _grid.SetMetroStyle(grid);
            _grid.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;

            this._grid = _grid;
            AddressTextBox.WireGrid(_grid);
            FormulaTextBox.WireGrid(_grid);
            layoutHelper = new LayoutSupportHelper(_grid);
            _grid.VisibleChanged += new EventHandler(_grid_VisibleChanged);

            _grid.Model.Properties.MarkColHeader = true;
            _grid.Model.Properties.MarkRowHeader = true;

            _grid.CurrentCellMoved += _grid_CurrentCellMoved;
            _grid.CurrentCellActivated += _grid_CurrentCellActivated;
            _grid.SelectionChanged += _grid_SelectionChanged;
            _grid.PrepareViewStyleInfo += _grid_PrepareViewStyleInfo;
            _grid.CurrentCellChanged += _grid_CurrentCellChanged;


            // maintain the selected cells when right click 
            _grid.Model.SelectionChanging += Model_SelectionChanging;

            _grid.MouseMove += _grid_MouseMove;

            i++;
            _grid.TableStyle.WrapText = true;
            _grid.TableStyle.AutoSize = true;

            RegisterCellModel.GridCellType(_grid, CustomCellTypes.XhtmlCell);


            pnl_ActiveSheet.Controls.Add(_grid);
            pnl_ActiveSheet.Controls.Add(panelInfo);

            SetUpFormulaBar(this, pnl_FormulaBar);

            // khởi tạo tooltip là popup để tính lại đơn giá cho công việc bị chênh leejhc đơn giá
            InitializePanel();

            ResumeLayout(true);
            #endregion
        }

      
        private void InitializePanel()
        {
            btn_TinhLaiDonGia = new Button();

            // Create a panel to display additional information.
            panelInfo.Visible = false;
            panelInfo.Location = new Point(244, 90);
            panelInfo.Name = "panel1";
            panelInfo.Size = new Size(147, 39);
            panelInfo.TabIndex = 0;
            // 
            // btn_TinhLaiDonGia
            // 
            btn_TinhLaiDonGia.BackColor = SystemColors.Control;
            btn_TinhLaiDonGia.Cursor = Cursors.Hand;
            btn_TinhLaiDonGia.FlatAppearance.BorderSize = 0;
            btn_TinhLaiDonGia.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_TinhLaiDonGia.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_TinhLaiDonGia.FlatStyle = FlatStyle.Flat;
            btn_TinhLaiDonGia.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btn_TinhLaiDonGia.ForeColor = SystemColors.HotTrack;
            btn_TinhLaiDonGia.Location = new Point(3, 3);
            btn_TinhLaiDonGia.Name = "btn_TinhLaiDonGia";
            btn_TinhLaiDonGia.Size = new Size(142, 29);
            btn_TinhLaiDonGia.TabIndex = 0;
            btn_TinhLaiDonGia.Text = "Tính lại đơn giá";
            btn_TinhLaiDonGia.UseVisualStyleBackColor = false;
            btn_TinhLaiDonGia.Click += Btn_TinhLaiDonGia_Click;

            panelInfo.Controls.Add(btn_TinhLaiDonGia);
            panelInfo.BringToFront();
        }
        #endregion
        private void SetUpFormulaBar(WorkBook workBook, Panel formulaPanel)
        {
            Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar formulaBar = new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();
            AddressTxt = new GridAwareTextBoxBarItem();
            FormulaTxt = new GridAwareTextBoxBarItem();
            Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem(); // icon x
            Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem(); // icon v

            // Đăng ký formulabar với gridcontrol
            AddressTxt.WireGridAwareTextBox(workBook.AddressTextBox, workBook._grid, true);
            FormulaTxt.WireGridAwareTextBox(workBook.FormulaTextBox, workBook._grid, false);

            // 
            // AddressTxt
            // 
            AddressTxt.BarName = "AddressTxt";
            AddressTxt.CategoryIndex = 12;
            AddressTxt.CustomTextFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddressTxt.ID = "GridAwareTextBox1";
            AddressTxt.MinWidth = 200;
            AddressTxt.ShowToolTipInPopUp = false;
            AddressTxt.SizeToFit = true;
            AddressTxt.Text = "GridAwareTextBox1";
            AddressTxt.TextBoxValue = null;
            AddressTxt.Value = null;

            // 
            // FormulaTxt
            // 
            FormulaTxt.BarName = "FormulaTxt";
            FormulaTxt.CategoryIndex = 12;
            FormulaTxt.CustomTextFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormulaTxt.ID = "GridAwareTextBox2";
            FormulaTxt.MinWidth = 600;
            FormulaTxt.ShowToolTipInPopUp = false;
            FormulaTxt.SizeToFit = true;
            FormulaTxt.Text = "GridAwareTextBox2";
            FormulaTxt.TextBoxValue = null;
            FormulaTxt.Value = null;

            formulaBar.Dock = DockStyle.Fill;
            formulaBar.Padding = new Padding(0, 5, 0, 5);
            formulaBar.Bar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            AddressTxt,
            barItem1,
            barItem2,
            FormulaTxt});

            formulaPanel.BorderStyle = BorderStyle.None;
            //formulaPanel.Size = formulaBar.Size;
            formulaPanel.Size = new Size(formulaBar.Size.Width, formulaBar.Size.Height);
            formulaPanel.Controls.Add(formulaBar);
        }
        #region Private Variables
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx gridCMStrip;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private IContainer components = null;
        LayoutSupportHelper layoutHelper;
        private ToolStripMenuItem insertToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripMenuItem deleteContentToolStripMenuItem;
        private ToolStripMenuItem mergeToolStripMenuItem;

        #endregion
        public Panel panelInfo;
        private SampleGrid sampleGrid1;
        private Panel pnl_Workbook;
        GridAwareTextBoxBarItem AddressTxt;
        GridAwareTextBoxBarItem FormulaTxt;
    }
}
