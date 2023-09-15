#region Copyright Syncfusion Inc. 2001 - 2023
//
//  Copyright Syncfusion Inc. 2001 - 2023. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

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
using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.Windows.Forms.Grid;

namespace modDisplay.CustomGrid
{
    /// <summary>
    /// Summary description for GridAwareTextBoxBarItem.
    /// </summary>
    public class GridAwareTextBoxBarItem : TextBoxBarItem, IDisposable
    {
        #region [private Variables]
        private GridAwareTextBox gridAwareTextBox = null;
        private GridControlBase _grid = null;
        private bool rangeofgrid = false;
        private bool ignoreSync = false;
        #endregion

        #region[Constructor]
        public GridAwareTextBoxBarItem() : base()
        {

        }
        #endregion

        #region [GridAwareTextBox]
        public void WireGridAwareTextBox(GridAwareTextBox gridAwareTextBox, GridControlBase grid, bool range)
        {
            _grid = grid;
            this.gridAwareTextBox = gridAwareTextBox;
            this.gridAwareTextBox.BorderStyle = BorderStyle.FixedSingle;
            rangeofgrid = range;

            //Assign the current selection range to NameBox
            if (rangeofgrid)
                TextBoxValue = string.Format("R{0}C{0}", grid.CurrentCell.RowIndex, grid.CurrentCell.ColIndex);

            #region [Events]
            _grid.Model.SelectionChanged += new GridSelectionChangedEventHandler(Model_SelectionChanged);
            _grid.CurrentCellMoved += new GridCurrentCellMovedEventHandler(_grid_CurrentCellMoved);
            this.gridAwareTextBox.TextChanged += new EventHandler(gridAwareTextBox_TextChanged);
            #endregion
        }

        public void UnwireGrid(GridControlBase grid)
        {
            gridAwareTextBox.UnwireGrid(grid);
        }
        #endregion

        #region [Events]
        void _grid_CurrentCellMoved(object sender, GridCurrentCellMovedEventArgs e)
        {
            if (rangeofgrid)
                TextBoxValue = string.Format("R{0}C{0}", _grid.CurrentCell.RowIndex, _grid.CurrentCell.ColIndex);
        }

        public override string TextBoxValue
        {
            get
            {
                return base.TextBoxValue;
            }
            set
            {
                if (rangeofgrid || ignoreSync)
                    base.TextBoxValue = value;
                else
                {
                    if (_grid != null)
                    {
                        //Set textbox value to current cell value
                        GridCurrentCell cc = GetCurrentCell();
                        cc.MoveTo(cc.RowIndex, cc.ColIndex, GridSetCurrentCellOptions.ScrollInView);
                        gridAwareTextBox.Text = value;
                        base.TextBoxValue = value;
                    }
                }
            }
        }

        private void gridAwareTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!rangeofgrid)
            {
                ignoreSync = true;
                TextBoxValue = gridAwareTextBox.Text;
                ignoreSync = false;
            }
        }

        private void Model_SelectionChanged(object sender, GridSelectionChangedEventArgs e)
        {
            //Change the NameBox value to reflect the current selection range
            if (rangeofgrid)
                TextBoxValue = e.Range.ToString();
        }
        #endregion

        #region [Get CurrentCell]
        GridCurrentCell GetCurrentCell()
        {
            GridCurrentCell cc = null;
            if (_grid.Parent is SplitterControl)
            {
                Control c = ((SplitterControl)_grid.Parent).ActivePane;
                if (c is GridControlBase)
                    cc = ((GridControlBase)c).CurrentCell;
            }
            if (cc == null)
            {
                if (_grid.Model.ActiveGridView != null)
                    cc = _grid.Model.ActiveGridView.CurrentCell;
                if (cc == null)
                    cc = _grid.CurrentCell;
            }
            return cc;
        }
        #endregion

        #region [Disopose]
        protected override void Dispose(bool disposing)
        {
            if (_grid != null)
            {
                _grid.Model.SelectionChanged -= new GridSelectionChangedEventHandler(Model_SelectionChanged);
                _grid.CurrentCellMoved -= new GridCurrentCellMovedEventHandler(_grid_CurrentCellMoved);
            }
            if (gridAwareTextBox != null)
                gridAwareTextBox.TextChanged -= new EventHandler(gridAwareTextBox_TextChanged);
        }
        #endregion
    }
}
