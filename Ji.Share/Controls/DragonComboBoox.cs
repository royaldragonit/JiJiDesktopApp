using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ji.Controls
{
    public partial class DragonComboBoox : UserControl
    {
        ToolStripDropDown _dropDown = new ToolStripDropDown();
        public DragonComboBoox()
        {
            InitializeComponent();
            _dropDown.AutoSize = true;
            ToolStripMenuItem fruitToolStripMenuItem = new ToolStripMenuItem("Long đẹp trai");
            _dropDown.Items.Add(fruitToolStripMenuItem);
            fruitToolStripMenuItem = new ToolStripMenuItem("Long đẹp trai");
            _dropDown.Items.Add(fruitToolStripMenuItem);
            fruitToolStripMenuItem = new ToolStripMenuItem("Long đẹp trai");
            _dropDown.Items.Add(fruitToolStripMenuItem);
            fruitToolStripMenuItem = new ToolStripMenuItem("Long đẹp trai");
            _dropDown.Items.Add(fruitToolStripMenuItem);
            var dropDownControl = new DragonListComboBox();

            var controlHost = new ToolStripControlHost(dropDownControl);
            _dropDown.Items.Add(controlHost);
        }

        private void DragonComboBoox_Click(object sender, EventArgs e)
        {
            DragonComboBoox_SelectedChange();
        }
        public virtual void DragonComboBoox_SelectedChange()
        {
            Point textBoxScreenLocation = txtDragonComboBox.PointToScreen(txtDragonComboBox.Location);

            // try to position _dropDown below textbox
            Point pt = textBoxScreenLocation;
            pt.Offset(0, txtDragonComboBox.Height);

            // determine if it will fit on the screen below the textbox
            Size dropdownSize = _dropDown.GetPreferredSize(Size.Empty);
            Rectangle dropdownBounds = new Rectangle(pt, dropdownSize);

            if (dropdownBounds.Bottom <= Screen.GetWorkingArea(dropdownBounds).Bottom)
            {   // show below
                _dropDown.Show(pt, ToolStripDropDownDirection.BelowRight);
            }
            else
            {   // show above
                _dropDown.Show(textBoxScreenLocation, ToolStripDropDownDirection.AboveRight);
            }
        }
        private void txtDragonComboBox_Click(object sender, EventArgs e)
        {
            DragonComboBoox_SelectedChange();
        }

        private void btnDragonComboBox_Click(object sender, EventArgs e)
        {
            DragonComboBoox_SelectedChange();
        }
    }
}
