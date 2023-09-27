
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Syncfusion.Windows.Forms.Grid;

namespace modDisplay.CustomGrid
{
    public partial class WorkBook : Form
    {
        #region Public
        // đăng ký sự kiện 
        public delegate void EventButtonClicked(object sender, EventArgs e);
        public delegate void EventRowDeleted(int rowIndex, int count);
        public delegate void EventRowInserted(int insertAt, int count);
        public delegate void EventContentDeleted(GridRangeInfoList ranges);
        public delegate void EventCurrentCellChanged(GridCurrentCell currentCell);
        public delegate void EventCellValueChanged(object sender, EventArgs e);
        public delegate void EventRowsHidden(int from, int count, bool hide);
        public delegate void EventColsHidden(int from, int count, bool hide);
        public delegate void EventCellValueChanging(string edittingText);

        public event EventButtonClicked OnButtonClick;
        public event EventRowDeleted OnRowDeleted;
        public event EventRowInserted OnRowInserted;
        public event EventContentDeleted OnContentDeleted;
        public event EventCurrentCellChanged OnCurrentCellChanged;
        public event EventCellValueChanged OnCellValueChanged;
        public event EventRowsHidden OnRowsHidden;
        public event EventColsHidden OnColsHidden;
        public event EventCellValueChanging OnCellValueChanging;

        public Panel pnl_FormulaBar;
        public Panel pnl_ActiveSheet;
        public GridAwareTextBox AddressTextBox;
        public GridAwareTextBox FormulaTextBox;

        /// <summary>
        /// GridControl hiển thị
        /// </summary>
        public GridControl _grid = null;

        /// <summary>
        /// Chứa data của grid đang hiển thị
        /// </summary>
        public GridModel Model { get { return _grid.Model; } }

        /// <summary>
        /// Chứa thông tin danh sách phạm vi được chọn hiện tại
        /// </summary>
        GridRangeInfoList GridSelectionRangeInfoList { get { return _grid.Selections.Ranges; } }

        /// <summary>
        /// Model xử lý copy, cut, paste
        /// </summary>
        public GridModelCutPaste ModelCutPaste { get { return Model.CutPaste ; } }

        /// <summary>
        /// Chỉ số hàng của current cell
        /// </summary>
        public int RowIndex { get { return _grid.CurrentCell.RowIndex; } }

        /// <summary>
        /// Chỉ số cột của current cell
        /// </summary>
        public int CollIndex { get { return _grid.CurrentCell.ColIndex; } }

        /// <summary>
        /// Load workbook vào panel
        /// </summary>
        /// <param name="control"></param>
        public void LoadWorkbook(Control control)
        {
            control.Controls.Add(pnl_ActiveSheet);
            control.Controls.Add(pnl_FormulaBar);
            control.Resize += TrackResize;
            FormulaTxt.MinWidth = this.pnl_FormulaBar.Width - (AddressTxt.MinWidth + 28);
        }
        #endregion

        #region Private
        private Button btn_TinhLaiDonGia;
        private void TrackResize(object? sender, EventArgs e)
        {
            FormulaTxt.MinWidth = this.pnl_FormulaBar.Width - (AddressTxt.MinWidth + 28);
        }
        #endregion

        #region Constructor
        public WorkBook()
        {
            InitializeComponent();
            InitGrid();
        }
        #endregion

        #region Methods
        public void Paste()
        {
            _grid.Focus();
            ModelCutPaste.Paste();
        }

        public void Cut()
        {
            _grid.Focus();
            ModelCutPaste.Cut();
        }
        public void Copy()
        {
            _grid.Focus();
            ModelCutPaste.Copy();
        }

        public void FontNameChanged(string fontName)
        {
            GridStyleInfo style = new GridStyleInfo();
            style.Font.Facename = fontName;
            if (GridSelectionRangeInfoList.Count != 0)
                _grid.ChangeCells(GridSelectionRangeInfoList.ActiveRange, style);
            else
                _grid.ChangeCells(GridRangeInfo.Cell(RowIndex, CollIndex), style);
        }

        public void FontSizeChanged(string fontSize)
        {
            GridStyleInfo style = new GridStyleInfo();
            style.Font.Size = Convert.ToInt64(fontSize);
            if (GridSelectionRangeInfoList.Count != 0)
                _grid.ChangeCells(GridSelectionRangeInfoList.ActiveRange, style);
            else
                _grid.ChangeCells(GridRangeInfo.Cell(RowIndex, CollIndex), style);
        }

        public float FontSizeIncrease()
        {
            GridStyleInfo style = new GridStyleInfo();
            style.Font.Size = _grid[RowIndex, CollIndex].Font.Size;
            style.Font.Size += 2;
            if (GridSelectionRangeInfoList.Count != 0)
            {
                _grid.ChangeCells(GridSelectionRangeInfoList.ActiveRange, style);
            }
            else
            {
                _grid.ChangeCells(GridRangeInfo.Cell(RowIndex, CollIndex), style);
            }
            return _grid[RowIndex, CollIndex].Font.Size;
        }

        public float FontSizeDecrease()
        {
            if (_grid[RowIndex, CollIndex].Font.Size > 2)
            {
                GridStyleInfo style = new GridStyleInfo();
                style.Font.Size = _grid[RowIndex, CollIndex].Font.Size;
                style.Font.Size -= 2;
                if (GridSelectionRangeInfoList.Count != 0)
                {
                    _grid.ChangeCells(GridSelectionRangeInfoList.ActiveRange, style);
                }
                else
                {
                    _grid.ChangeCells(GridRangeInfo.Cell(RowIndex, CollIndex), style);
                }
            }
            return _grid[RowIndex, CollIndex].Font.Size;
        }

        public void UnderLine(bool underLine)
        {
            GridStyleInfo style = new GridStyleInfo();
            if (underLine)
                style.Font.Underline = true;
            else
                style.Font.Underline = false;
            if (GridSelectionRangeInfoList.Count != 0)
                _grid.ChangeCells(GridSelectionRangeInfoList.ActiveRange, style);
            else
                _grid.ChangeCells(GridRangeInfo.Cell(RowIndex, CollIndex), style);
        }

        public void Italic(bool italic)
        {
            GridStyleInfo style = new GridStyleInfo();
            if (italic)
                style.Font.Italic = true;
            else
                style.Font.Italic = false;
            if (GridSelectionRangeInfoList.Count != 0)
                _grid.ChangeCells(GridSelectionRangeInfoList.ActiveRange, style);
            else
                _grid.ChangeCells(GridRangeInfo.Cell(RowIndex, CollIndex), style);
        }

        public void Bold(bool bold)
        {
            GridStyleInfo style = new GridStyleInfo();
            if (bold)
                style.Font.Bold = true;
            else
                style.Font.Bold = false;

            if (GridSelectionRangeInfoList.Count != 0)
                _grid.ChangeCells(GridSelectionRangeInfoList.ActiveRange, style);
            else
                _grid.ChangeCells(GridRangeInfo.Cell(RowIndex, CollIndex), style);
        }

        public void TopBorder()
        {
            GridStyleInfo style = new GridStyleInfo();
            style.Borders.Top = new GridBorder(GridBorderStyle.Solid);

            if (GridSelectionRangeInfoList.Count != 0)
                _grid.ChangeCells(GridRangeInfo.Cells(
                    GridSelectionRangeInfoList.ActiveRange.Top,
                    GridSelectionRangeInfoList.ActiveRange.Left,
                    GridSelectionRangeInfoList.ActiveRange.Top,
                    GridSelectionRangeInfoList.ActiveRange.Right),
                    style);
            else
                _grid.ChangeCells(GridRangeInfo.Cell(RowIndex, CollIndex), style);
        }

        public void BottomBorder()
        {
            GridStyleInfo style = new GridStyleInfo();
            style.Borders.Bottom = new GridBorder(GridBorderStyle.Solid);

            if (GridSelectionRangeInfoList.Count != 0)
                _grid.ChangeCells(GridRangeInfo.Cells(
                    GridSelectionRangeInfoList.ActiveRange.Bottom,
                    GridSelectionRangeInfoList.ActiveRange.Left,
                    GridSelectionRangeInfoList.ActiveRange.Bottom,
                    GridSelectionRangeInfoList.ActiveRange.Right),
                    style);
            else
                _grid.ChangeCells(GridRangeInfo.Cell(RowIndex, CollIndex), style);
        }

        public void NoBorder()
        {
            GridStyleInfo style = new GridStyleInfo();
            style.Borders.All = new GridBorder(GridBorderStyle.Standard);

            if (GridSelectionRangeInfoList.Count != 0)
                _grid.ChangeCells(GridSelectionRangeInfoList.ActiveRange, style);
            else
                _grid.ChangeCells(GridRangeInfo.Cell(RowIndex, CollIndex), style);
        }

        public void LeftBorder()
        {
            GridStyleInfo style = new GridStyleInfo();
            style.Borders.Left = new GridBorder(GridBorderStyle.Solid);

            if (GridSelectionRangeInfoList.Count != 0)
                _grid.ChangeCells(GridRangeInfo.Cells(
                    GridSelectionRangeInfoList.ActiveRange.Top,
                    GridSelectionRangeInfoList.ActiveRange.Left,
                    GridSelectionRangeInfoList.ActiveRange.Bottom,
                    GridSelectionRangeInfoList.ActiveRange.Left),
                    style);
            else
                _grid.ChangeCells(GridRangeInfo.Cell(RowIndex, CollIndex), style);
        }

        public void RightBorder()
        {
            GridStyleInfo style = new GridStyleInfo();
            style.Borders.Right = new GridBorder(GridBorderStyle.Solid);

            if (GridSelectionRangeInfoList.Count != 0)
                _grid.ChangeCells(GridRangeInfo.Cells(
                    GridSelectionRangeInfoList.ActiveRange.Top,
                    GridSelectionRangeInfoList.ActiveRange.Right,
                    GridSelectionRangeInfoList.ActiveRange.Bottom,
                    GridSelectionRangeInfoList.ActiveRange.Right),
                    style);
            else
                _grid.ChangeCells(GridRangeInfo.Cell(RowIndex, CollIndex), style);
        }

        public void WrapText(bool wrapText)
        {
            GridStyleInfo style = new GridStyleInfo();
            if (wrapText)
                style.WrapText = true;
            else
                style.WrapText = false;

            if (GridSelectionRangeInfoList.Count != 0)
                _grid.ChangeCells(GridSelectionRangeInfoList.ActiveRange, style);
            else
                _grid.ChangeCells(GridRangeInfo.Cell(RowIndex, CollIndex), style);
        }

        public void MergeCells(bool merge)
        {
            if (merge)
            {
                if (GridSelectionRangeInfoList.Count != 0)
                    _grid.CoveredRanges.Add(GridSelectionRangeInfoList.ActiveRange);
                else
                    _grid.CoveredRanges.Add(GridRangeInfo.Cell(RowIndex, CollIndex));
                _grid.CurrentCell.MoveTo(RowIndex, CollIndex);
            }
            else
            {
                foreach (GridRangeInfo range in Model.CoveredRanges.Ranges)
                {
                    if (range.Top == RowIndex && range.Left == CollIndex)
                    {
                        _grid.CoveredRanges.Remove(range);
                        break;
                    }
                }
            }
        }

        public void TopAlign(bool topAlign)
        {
            GridStyleInfo style = new GridStyleInfo();
            style.VerticalAlignment = GridVerticalAlignment.Top;
            if (GridSelectionRangeInfoList.Count != 0)
                _grid.ChangeCells(GridSelectionRangeInfoList.ActiveRange, style);
            else
                _grid.ChangeCells(GridRangeInfo.Cell(RowIndex, CollIndex), style);
        }

        public void MiddleAlign(bool middleAlign)
        {
            GridStyleInfo style = new GridStyleInfo();
            if (middleAlign)
                style.VerticalAlignment = GridVerticalAlignment.Middle;
            else

                style.VerticalAlignment = GridVerticalAlignment.Top;
            if (GridSelectionRangeInfoList.Count != 0)
                _grid.ChangeCells(GridSelectionRangeInfoList.ActiveRange, style);
            else
                _grid.ChangeCells(GridRangeInfo.Cell(RowIndex, CollIndex), style);
        }

        public void BottomAlign(bool bottomAlign)
        {
            GridStyleInfo style = new GridStyleInfo();
            if (bottomAlign)
                style.VerticalAlignment = GridVerticalAlignment.Bottom;
            else
                style.VerticalAlignment = GridVerticalAlignment.Top;
            if (GridSelectionRangeInfoList.Count != 0)
                _grid.ChangeCells(GridSelectionRangeInfoList.ActiveRange, style);
            else
                _grid.ChangeCells(GridRangeInfo.Cell(RowIndex, CollIndex), style);
        }

        public void LeftAlign(bool leftAlign)
        {
            GridStyleInfo style = new GridStyleInfo();
            style.HorizontalAlignment = GridHorizontalAlignment.Left;
            if (GridSelectionRangeInfoList.Count != 0)
                _grid.ChangeCells(GridSelectionRangeInfoList.ActiveRange, style);
            else
                _grid.ChangeCells(GridRangeInfo.Cell(RowIndex, CollIndex), style);
        }

        public void RightAlign(bool rightAlign)
        {
            GridStyleInfo style = new GridStyleInfo();
            if (rightAlign)
                style.HorizontalAlignment = GridHorizontalAlignment.Right;
            else
                style.HorizontalAlignment = GridHorizontalAlignment.Left;
            if (GridSelectionRangeInfoList.Count != 0)
                _grid.ChangeCells(GridSelectionRangeInfoList.ActiveRange, style);
            else
                _grid.ChangeCells(GridRangeInfo.Cell(RowIndex, CollIndex), style);
        }

        public void CenterAlign(bool centerAlign)
        {
            GridStyleInfo style = new GridStyleInfo();
            if (centerAlign)
                style.HorizontalAlignment = GridHorizontalAlignment.Center;
            else
                style.HorizontalAlignment = GridHorizontalAlignment.Left;
            if (GridSelectionRangeInfoList.Count != 0)
                _grid.ChangeCells(GridSelectionRangeInfoList.ActiveRange, style);
            else
                _grid.ChangeCells(GridRangeInfo.Cell(RowIndex, CollIndex), style);
        }

        public void PageLayout(bool pageLayout)
        {
            if (layoutHelper != null)
                layoutHelper.ShowLayoutLines = pageLayout;
        }

        public void ShowLines(bool showLines)
        {
            if (showLines)
            {
                _grid.DisplayHorizontalLines = true;
                _grid.DisplayVerticalLines = true;
            }
            else
            {
                _grid.DisplayHorizontalLines = false;
                _grid.DisplayVerticalLines = false;
            }
        }

        public void ShowRowHeader(bool showHeader)
        {
            if (showHeader)
            {
                _grid.ShowRowHeaders = true;
                _grid.ShowColumnHeaders = true;
            }
            else
            {
                _grid.ShowRowHeaders = false;
                _grid.ShowColumnHeaders = false;
            }
        }

        public void Freeze(bool freeze)
        {
            if (freeze)
            {
                _grid.Cols.FrozenCount = CollIndex - 1;
                _grid.Rows.FrozenCount = RowIndex - 1;
            }
            else
            {
                _grid.Cols.FrozenCount = 0;
                _grid.Rows.FrozenCount = 0;
            }
        }

        public void TextColorChanged(Color color)
        {
            GridStyleInfo style = new GridStyleInfo();
            style.TextColor = color;
            if (GridSelectionRangeInfoList.Count != 0)
                _grid.ChangeCells(GridSelectionRangeInfoList.ActiveRange, style);
            else
                _grid.ChangeCells(GridRangeInfo.Cell(RowIndex, CollIndex), style);
        }

        public void BackColorChanged(Color color)
        {
            GridStyleInfo style = new GridStyleInfo();
            style.BackColor = color;
            if (GridSelectionRangeInfoList.Count != 0)
                _grid.ChangeCells(GridSelectionRangeInfoList.ActiveRange, style);
            else
                _grid.ChangeCells(GridRangeInfo.Cell(RowIndex, CollIndex), style);

        }

        public void RejectChanges()
        {
            _grid.CurrentCell.Renderer.ControlText = "";
        }

        public void AcceptChanges()
        {
            _grid.CurrentCell.EndEdit();
        }

        public ArrayList HiddenSheets = new ArrayList();

        public void InvalidateFormulaCell()
        {
            GridRangeInfo range = new GridRangeInfo();
            range = _grid.RectangleToRangeInfo(_grid.Bounds);
            for (int r = range.Top; r < range.Bottom; r++)
                for (int c = range.Left; c < range.Right; c++)
                    if (_grid[r, c].HasFormulaTag)
                        _grid[r, c].FormulaTag = null;
        }

        /// <summary>
        /// Xóa 'count' dòng từ dòng 'from'
        /// </summary>
        /// <param name="from"></param>
        /// <param name="count"></param>
        public void DeleteRow(int startRowIndex, int count)
        {
            _grid.Rows.RemoveRange(startRowIndex, startRowIndex + count - 1);
            // hook event delete row
            OnRowDeleted?.Invoke(startRowIndex, count);
        }

        /// <summary>
        /// Chèn 'count' dòng sau dòng 'insertAt'
        /// </summary>
        /// <param name="insertAt"></param>
        /// <param name="count"></param>
        public void InsertRow(int insertAt, int count)
        {
            _grid.Rows.InsertRange(insertAt, count);
            // hook event insert row
            OnRowInserted?.Invoke(insertAt, count);
            // todo: style cho inserted row
        }

        /// <summary>
        /// Xóa nội dung của selectionRange
        /// </summary>
        public void DeleteContent()
        {
            if (_grid.Selections.GetSelectedRanges(out var ranges, considerCurrentCell: true))
            {
                _grid.ClearCells(ranges, false);
            }
            // hook event delete content
            OnContentDeleted?.Invoke(ranges);
        }

        /// <summary>
        /// Ẩn/hiện (hide) dòng từ "from" đến "from+count-1" 
        /// </summary>
        /// <param name="from"></param>
        /// <param name="count"></param>
        /// <param name="hide"></param>
        public void HideRows(int from, int count, bool hide)
        {
            _grid.Rows.Hidden.SetRange(from, from + count -1, hide);
            OnRowsHidden?.Invoke(from, count,hide);
        }
        /// <summary>
        /// Ẩn/hiện (hide) cột từ "from" đến "from+count-1" 
        /// </summary>
        /// <param name="from"></param>
        /// <param name="count"></param>
        /// <param name="hide"></param>
        public void HideCols(int from, int count, bool hide)
        {
            _grid.Cols.Hidden.SetRange(from, from + count - 1, hide);
            OnColsHidden?.Invoke(from, count, hide);
        }

        #endregion

        #region Events
        private void _grid_CurrentCellActivated(object sender, EventArgs e)
        {
            OnCurrentCellChanged?.Invoke(_grid.CurrentCell);
        }

        void _grid_CurrentCellMoved(object sender, GridCurrentCellMovedEventArgs e)
        {
            GridCurrentCell cc = _grid.CurrentCell;
            _grid.RefreshRange(GridRangeInfo.Cell(0, cc.MoveFromColIndex));
            _grid.RefreshRange(GridRangeInfo.Cell(0, cc.MoveToColIndex));
            _grid.RefreshRange(GridRangeInfo.Cell(cc.MoveFromRowIndex, 0));
            _grid.RefreshRange(GridRangeInfo.Cell(cc.MoveToRowIndex, 0));
        }

        void _grid_PrepareViewStyleInfo(object sender, GridPrepareViewStyleInfoEventArgs e)
        {
            GridControl grid = (GridControl)sender;
            GridCurrentCell cc = grid.CurrentCell;
            if (grid.Selections.Ranges.Count != 0)
            {
                for (int i = 0; i < grid.Selections.Ranges.Count; i++)
                {
                    GridRangeInfo gri = grid.Selections.Ranges[i];
                    if (e.ColIndex >= gri.Left && e.ColIndex <= gri.Right && e.RowIndex == 0 ||
                            e.RowIndex >= gri.Top && e.RowIndex <= gri.Bottom && e.ColIndex == 0)
                    {
                        e.Style.BackColor = Color.LightBlue;
                        break;
                    }
                }
            }
            else if (cc != null)
            {
                if (e.ColIndex == cc.ColIndex && e.RowIndex == 0 || e.RowIndex == cc.RowIndex && e.ColIndex == 0)
                {
                    e.Style.BackColor = Color.LightBlue;
                }
            }
        }

        void _grid_SelectionChanged(object sender, GridSelectionChangedEventArgs e)
        {
            if (sender is GridControl)
            {
                GridControl grid = (GridControl)sender;
                grid.RefreshRange(GridRangeInfo.Row(0));
                grid.RefreshRange(GridRangeInfo.Col(0));
            }
        }
        void _grid_VisibleChanged(object sender, EventArgs e)
        {
            InvalidateFormulaCell();
        }

        private void _grid_CurrentCellChanged(object sender, EventArgs e)
        {
            OnCellValueChanged?.Invoke(sender, e);
        }

        void Model_SelectionChanging(object sender, GridSelectionChangingEventArgs e)
        {
            // Checking mouse right button.
            if (e.Reason == Syncfusion.Windows.Forms.Grid.GridSelectionReason.MouseDown && Control.MouseButtons == System.Windows.Forms.MouseButtons.Right)
            {
                // giữ lại selection range khi nhấn chuột phải
                e.Cancel = true;
            }
        }
        void _grid_MouseMove(object? sender, MouseEventArgs e)
        {
            GridControl gridControl = sender as GridControl;

            // Use PointToRowCol method to get the row and column under the mouse cursor.
            int row, col;
            if (gridControl.PointToRowCol(e.Location, out row, out col))
            {
                // Kiểm tra điều kiện nhận biết cần show popup
                if (gridControl[row, col].BackColor == Color.LightPink)
                {
                    // Calculate the cell bounds manually based on row height and column width.
                    int rightEdge = 0; 
                    for(int i =1; i <= col; i++)
                    {
                        rightEdge += gridControl.ColWidths[i]; // tính như vậy sẽ bỏ qua cột bị ẩn để hiển thị chính xác vị trí ô
                    }
                    int topEdge = 0;
                    for (int i = 1; i < row; i++)
                    {
                        topEdge += gridControl.RowHeights[i]; // tính như vậy sẽ bỏ qua hàng bị ẩn để hiển thị chính xác vị trí ô
                    }
                    // Set the panel's location and make it visible.
                    panelInfo.Location = new Point(rightEdge + 30, topEdge);

                    // lấy giá trị col,row đang được hover 
                    panelInfo.Tag = new Point(row, col);

                    panelInfo.Visible = true;
                    panelInfo.BringToFront();
                }
                else
                {
                    // ẩn khi k đúng điều kiện
                    panelInfo.Visible = false;
                }
            }
            else
            {
                panelInfo.Visible = false;
            }
        }

        /// <summary>
        /// Lấy giá trị của current cell đang chỉnh sửa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _grid_CurrentCellControlKeyMessage(object sender, GridCurrentCellControlKeyMessageEventArgs e)
        {
            OnCellValueChanging?.Invoke(e.Control.Text);
        }

        #endregion

        #region Extend Events
        void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GridCurrentCell cc = _grid.CurrentCell;
            DeleteRow(cc.RowIndex, 1);
        }
        void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridCurrentCell cc = _grid.CurrentCell;
            InsertRow(cc.RowIndex, 1);
        }
        void deleteContentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteContent();
        }
        void mergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MergeCells(true);
        }

        void Btn_TinhLaiDonGia_Click(object? s, EventArgs e)
        {
            // todo tính lại  đơn giá cho công việc đang bị cảnh báo
            MessageBox.Show("Tính lại đơn giá", panelInfo.Tag.ToString());
            OnButtonClick(s, e);
        }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cut();
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }

        #endregion
    }
}