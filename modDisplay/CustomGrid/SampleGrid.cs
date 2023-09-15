using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

using Syncfusion.ComponentModel;
using Syncfusion.Drawing;
using Syncfusion.Styles;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.GridHelperClasses;

namespace modDisplay.CustomGrid
{
    /// <summary>
    /// SampleGridModel for Workbook/Worksheet support (see MenuAction.NewWorkbookFile)
    /// </summary>
    public class SampleGridModel : GridModel, ICreateControl
    {
        #region [Override Methods]
        public override Control CreateControl()
        {
            GridControlBase grid = new SampleGrid(this);
            grid.FillSplitterPane = true;
            return grid;
        }
        #endregion
    }

    /// <summary>
    ///    A derived grid component class.
    /// </summary>
    public class SampleGrid : GridControl
    {
        #region [Constructor]
        public SampleGrid()
            : this(null)
        {
        }

        public SampleGrid(GridModel model)
            : base(model)
        {
            ExcelLikeSelectionFrame = true;
            FillSplitterPane = true;
            // transparent
            bool alphablending = false;
            if (alphablending)
            {
                SupportsTransparentBackColor = true;
                BackColor = Color.FromArgb(99, Color.White);
            }
            else
            {
                BackColor = Color.White;
                ForeColor = SystemColors.WindowText;
            }
            VerticalThumbTrack = false;
            VerticalScrollTips = true;
            HorizontalThumbTrack = true;
            HorizontalScrollTips = true;

            //Set properties to get the XP flat look
            ThemesEnabled = true;
            Properties.Buttons3D = false;
            DefaultGridBorderStyle = GridBorderStyle.Solid;
            Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            GridVisualStyles = GridVisualStyles.Metro;
            Model.Options.GridVisualStyles = GridVisualStyles.Metro;
            GridStyleInfo style = new GridStyleInfo();
            GridBorder gb = new GridBorder(GridBorderStyle.Solid, SystemColors.ControlDark);
            style.Borders.Bottom = style.Borders.Right = gb;

            BaseStylesMap["Header"].StyleInfo.BackColor = Color.White;
            BaseStylesMap["Header"].StyleInfo.Font.Facename = "Segoe UI";

            Model.Options.GridVisualStyles = GridVisualStyles.Metro;
            Properties.MarkColHeader = true;
            Properties.MarkRowHeader = true;
            TableStyle.Font.Facename = "Segoe UI";
            TableStyle.Font.Size = 10;
            QueryCellInfo += new GridQueryCellInfoEventHandler(SampleGrid_QueryCellInfo);
        }
        #endregion

        #region [Events]
        void SampleGrid_QueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
        {
            GridBorder gb = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(158, 182, 206));
            if (e.Style.CellType == GridCellTypeName.Header)
            {
                e.Style.Borders.Bottom = e.Style.Borders.Right = gb;
            }
        }
        #endregion

        #region [Override Methods]
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            QueryCellInfo -= new GridQueryCellInfoEventHandler(SampleGrid_QueryCellInfo);
        }

        public override void Initialize()
        {
            base.Initialize();
            TopRowIndex = InternalGetHeaderRows() + 1;
            LeftColIndex = InternalGetHeaderCols() + 1;
            AllowDrop = false;

            ExcelLikeCurrentCell = true;
            ExcelSelectionMarkerMouseController excelMarker = new ExcelSelectionMarkerMouseController(this);
            MouseControllerDispatcher.Add(excelMarker);

            //Make sure there is a current cell
            CurrentCell.Activate(1, 1, GridSetCurrentCellOptions.ScrollInView);
        }
        #endregion 

        #region [Methods]
        public static void SetupGridModel(GridModel model)
        {
            GridFactoryProvider.Init(new GridCellModelFactory());
            model.BeginInit();
            //setting properties.
            GridFormulaCellRenderer.ForceEditWhenActivated = false;
            model.RowCount = 100;
            model.ColCount = 100;
            model.Rows.DefaultSize = 125;
            model.Cols.DefaultSize = 65;
            model.RowHeights[0] = 155;
            model.ColWidths[0] = 45;

            // style chiều cao của từng dòng
            for (int row = 1; row <= 100; row++)
            {
                model.RowHeights[row] = 35;
            }
            // style chiều rộng của từng cột
            for (int col = 1; col <= 100; col++)
            {
                model.ColWidths[col] = 85;
            }

            model.Options.ControllerOptions = GridControllerOptions.All | GridControllerOptions.ExcelLikeSelection;
            model.TableStyle.CellType = "FormulaCell";
            model.Options.ActivateCurrentCellBehavior = GridCellActivateAction.DblClickOnCell;
            model.CommandStack.Enabled = true;
            model.CellModels.Add("LinkLabel", new LinkLabelCellModel(model));
            model.EndInit();
        }
        #endregion
    }
}