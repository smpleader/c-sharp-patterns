
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Design;
using Syncfusion.Collections;
using Syncfusion.ComponentModel;
using System.Drawing.Design;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Reflection;
using Syncfusion.Runtime.Serialization;

using Syncfusion.Windows.Forms.Grid;

using Syncfusion.Windows.Forms.Tools;
using Syncfusion.GridHelperClasses;
using Syncfusion.WinForms.Controls;
using Syncfusion.XlsIO;
using Syncfusion.Linq;

namespace modDisplay.CustomGrid
{
    public partial class DemoWorkbook : Form
    {
        public WorkBook workBook = null;

        #region [private Variables ]
        List<IWorksheet> worksheets;
        List<string> worksheetNames = new List<string>();
        ExcelEngine excelEngine;
        IApplication application;
        IWorkbook workbook;
        IWorksheet activeSheet;
        #endregion

        #region [Constructor]
        public DemoWorkbook()
        {
            InitializeComponent();
        }

        public void MainForm_OnButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Form3 is triggered");
        }
        #endregion

        #region[Form Load]
        private void Form1_Load(object sender, EventArgs e)
        {
            #region [WorkBook]
            // Create a new child
            WorkBook workBook = new WorkBook();
            Panel TabBarPane = new Panel();
            Panel formulaPanel = new Panel();
            workBook.OnButtonClick += MainForm_OnButtonClick;
            workBook.OnRowDeleted += WorkBook_OnRowDeleted;
            workBook.OnRowInserted += WorkBook_OnRowInserted;
            workBook.OnContentDeleted += WorkBook_OnContentDeleted;
            workBook.OnCellValueChanged += WorkBook_OnCellValueChanged;
            this.workBook = workBook;

            // load sheet vào 1 panel chỉ định
            workBook.LoadWorkbook(pnl_Body);

            // sự kiện click vào 1 ô
            workBook._grid.CurrentCellActivated += _grid_CurrentCellActivated;

            workBook._grid.CurrentCellControlKeyMessage += _grid_CurrentCellControlKeyMessage;

            // sự kiện dữ liệu 1 ô đã thay đổi
            workBook._grid.CurrentCellEditingComplete += new EventHandler(_grid_CurrentCellEditingComplete);
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    MdiClient mdiClient = (MdiClient)ctrl;
                    mdiClient.BackColor = Color.FromArgb(165, 195, 239);
                }
            }
            #endregion
        }

        private void WorkBook_OnCellValueChanged(object sender, EventArgs e)
        {
        }

        private void WorkBook_OnContentDeleted(GridRangeInfoList ranges)
        {
           
        }

        private void WorkBook_OnRowInserted(int insertAt, int count)
        {
            
        }

        private void WorkBook_OnRowDeleted(int rowIndex, int count)
        {
           
        }

        void _grid_CurrentCellControlKeyMessage(object sender, GridCurrentCellControlKeyMessageEventArgs e)
        {
            Keys keyCode = (Keys)((int)e.Msg.WParam) & Keys.KeyCode;
            Debug.WriteLine(keyCode);
            Debug.WriteLine(e.Msg);
            // lấy ký tự được gõ vào ô active 
            // gợi ý cho việc tìm kiếm công việc
        }
        void _grid_CurrentCellActivated(object sender, EventArgs e)
        {
            //this.UpdateFontStyles(workBook._grid);
            string row = workBook._grid.CurrentCell.RowIndex.ToString();
            string col = workBook._grid.CurrentCell.ColIndex.ToString();
            // hook để lấy sự kiện cell click
        }
        private void _grid_CurrentCellEditingComplete(object? sender, EventArgs e)
        {
            // hook để lấy sự kiện cell value changed
        }
        #endregion

        private void btn_setup_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Files(*.xlsx)|*.xlsx";
            openFileDialog.DefaultExt = ".xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                excelEngine = new ExcelEngine();

                application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Xlsx;

                workbook = application.Workbooks.Open(openFileDialog.FileName);
                worksheets = workbook.Worksheets.Select(item => item).ToList();
                cbb_SheetActive.Items.Clear();
                foreach (var worksheet in worksheets)
                {
                    worksheetNames.Add(worksheet.Name);
                    cbb_SheetActive.Items.Add(worksheet.Name);
                }
                cbb_SheetActive.Text = worksheetNames[0];
            }
        }

        private void chbk_Anhien_CheckedChanged(object sender, EventArgs e)
        {
            this.workBook._grid.Cols.Hidden.SetRange(5, 11, chbk_Anhien.Checked);
        }
        private void cbb_SheetActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (activeSheet != null)
            {
                // Get the row and column indexes from the IRange
                int startRow = activeSheet.UsedRange.Row;
                int endRow = activeSheet.UsedRange.Row + activeSheet.UsedRange.Rows.Length - 1;
                int startColumn = activeSheet.UsedRange.Column;
                int endColumn = activeSheet.UsedRange.Column + activeSheet.UsedRange.Columns.Length - 1;
                GridRangeInfo gridRangeInfo = GridRangeInfo.Cells(startRow, startColumn, endRow, endColumn);
                this.workBook._grid.Model.ClearCells(gridRangeInfo, true);
            }
            Syncfusion.GridExcelConverter.GridExcelConverterControl gecc = new Syncfusion.GridExcelConverter.GridExcelConverterControl();
            activeSheet = worksheets.FirstOrDefault(item => item.Name == cbb_SheetActive.Text);
            gecc.ExcelToGrid(activeSheet, this.workBook._grid.Model);
            this.workBook._grid.Refresh();
        }
    }

}
