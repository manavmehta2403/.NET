using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlexibleTextBox
{
    public partial class MainForm : Form
    {
        /// <summary> Select Mode : Select Controls on Panel ; TextBox Mode : Click on Panel to add TextBox
        /// </summary>
        private EnumClass.Mode Mode = EnumClass.Mode.Select;

        /// <summary> Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary> Change Mode to Select Mode
        /// </summary>
        /// <param name="sender"> Control</param>
        /// <param name="e"> Event Info </param>
        private void btnSelectMode_Click(object sender, EventArgs e)
        {
            Mode = EnumClass.Mode.Select;
        }

        /// <summary> Change Mode to TextBox Mode
        /// </summary>
        /// <param name="sender"> Control</param>
        /// <param name="e"> Event Info </param>
        private void btnAddTextBox_Click(object sender, EventArgs e)
        {
            Mode = EnumClass.Mode.TextBox;
        }

        /// <summary> If Mode is TextBox Mode, insert new FlexibleTextBox at click point
        /// </summary>
        /// <param name="sender"> Control</param>
        /// <param name="e"> Event Info </param>
        private void Pad_MouseClick(object sender, MouseEventArgs e)
        {
            if (Mode == EnumClass.Mode.TextBox)
            {
                FlexibleTextBoxControl textbox = new FlexibleTextBoxControl();
                textbox.Location = e.Location;
                Pad.Controls.Add(textbox);

                // Return to Select Mode
                btnSelectMode.PerformClick();
                btnSelectMode.Select();
            }
        }

    }
}
