using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace FlexibleTextBox
{
    public class FlexibleTextBoxControl : RichTextBox
    {

        /// <summary> Constuctor
        /// </summary>
        public FlexibleTextBoxControl()
        {
            // Initialize
            this.WordWrap = true;
            this.Multiline = true;
            this.Size = new System.Drawing.Size(200, 100);
            this.ScrollBars = RichTextBoxScrollBars.None;
            this.BorderStyle = BorderStyle.None;
            this.Margin = new Padding(3, 3, 3, 3);

            // Add resize handles
            InitResizeHandles();

            // Ser drag move function
            SetMoveFunction();
        }

        /// <summary> Set IsSelected = false when losing focus
        /// </summary>
        /// <param name="e"> Event Info </param>
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            HideResizeHandles();
        }

        /// <summary> Toggle IsSelected on MouseDown
        /// </summary>
        /// <param name="e"> Event Info </param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            ShowResizeHandles();
        }

        /// <summary> Text Paint event
        /// </summary>
        /// <param name="e"> Event Info </param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        /// <summary> Background Paint event
        /// </summary>
        /// <param name="e"> Event Info </param>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }

        /// <summary> Allow Control to moved by mouse drag
        /// </summary>
        public void SetMoveFunction()
        {
            bool isDragging = false;
            Point StartPoint = Point.Empty;
            this.MouseDown += delegate(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    isDragging = true;
                    StartPoint = new Point(e.X, e.Y);
                    this.Capture = true;
                }
            };
            this.MouseUp += delegate(object sender, MouseEventArgs e)
            {
                this.Cursor = Cursors.Arrow;
                isDragging = false;
                this.Capture = false;
            };
            this.MouseMove += delegate(object sender, MouseEventArgs e)
            {
                if (isDragging)
                {
                    this.Cursor = Cursors.NoMove2D;
                    this.Left = Math.Max(0, e.X + this.Left - StartPoint.X);
                    this.Top = Math.Max(0, e.Y + this.Top - StartPoint.Y);
                }
            };
        }

        #region Resize Methods

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            lbNW.Location = new Point(0, 0);
            lbN.Location = new Point(Width / 2 - lbN.Width / 2 + 1, 0);
            lbNE.Location = new Point(Width - lbNE.Width, 0);
            lbE.Location = new Point(Width - lbE.Width, Height / 2 - lbE.Height / 2 + 1);
            lbSE.Location = new Point(Width - lbNE.Width, Height - lbSE.Height);
            lbS.Location = new Point(Width / 2 - lbN.Width / 2 + 1, Height - lbS.Height);
            lbSW.Location = new Point(0, Height - lbSW.Height);
            lbW.Location = new Point(0, Height / 2 - lbE.Height / 2 + 1);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.Cursor = Cursors.Default;
        }

        private Label lbNW = new Label();
        private Label lbN = new Label();
        private Label lbNE = new Label();
        private Label lbE = new Label();
        private Label lbSE = new Label();
        private Label lbS = new Label();
        private Label lbSW = new Label();
        private Label lbW = new Label();

        private bool isOnResize = false;
        private string labelName = string.Empty;
        private Point pointStart = Point.Empty;
        private Point oriLabelLocation = Point.Empty;
        private Size oriSize = new Size();

        private void InitResizeHandles()
        {
            InitHandles(lbNW);
            lbNW.Name = "lbNW";

            InitHandles(lbN);
            lbN.Name = "lbN";

            InitHandles(lbNE);
            lbNE.Name = "lbNE";

            InitHandles(lbE);
            lbE.Name = "lbE";

            InitHandles(lbSE);
            lbSE.Name = "lbSE";

            InitHandles(lbS);
            lbS.Name = "lbS";

            InitHandles(lbSW);
            lbSW.Name = "lbSW";

            InitHandles(lbW);
            lbW.Name = "lbW";
        }

        private void InitHandles(Label label)
        {
            label.Size = new Size(6, 6);
            label.BackColor = Color.Black;
            label.Visible = false;

            label.MouseMove += new MouseEventHandler(label_MouseMove);
            label.MouseEnter += new EventHandler(label_MouseEnter);
            label.MouseDown += new MouseEventHandler(label_MouseDown);
            label.MouseUp += new MouseEventHandler(label_MouseUp);

            this.Controls.Add(label);
        }

        void label_MouseEnter(object sender, EventArgs e)
        {
            string name = ((Label)sender).Name;
            switch (name)
            {
                case "lbNW":
                    this.Cursor = Cursors.SizeNWSE;
                    break;

                case "lbN":
                    this.Cursor = Cursors.SizeNS;
                    break;

                case "lbNE":
                    this.Cursor = Cursors.SizeNESW;
                    break;

                case "lbE":
                    this.Cursor = Cursors.SizeWE;
                    break;

                case "lbSE":
                    this.Cursor = Cursors.SizeNWSE;
                    break;

                case "lbS":
                    this.Cursor = Cursors.SizeNS;
                    break;

                case "lbSW":
                    this.Cursor = Cursors.SizeNESW;
                    break;

                case "lbW":
                    this.Cursor = Cursors.SizeWE;
                    break;
            }
        }

        void label_MouseUp(object sender, MouseEventArgs e)
        {
            isOnResize = false;
            ((Label)sender).Capture = false;
        }

        void label_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                isOnResize = true;
                pointStart = new Point(e.X, e.Y);
                oriLabelLocation = Parent.PointToClient(PointToScreen(((Label)sender).Location));
                oriSize = this.Size;
                labelName = ((Label)sender).Name;
                ((Label)sender).Capture = true;
            }
        }

        void label_MouseMove(object sender, MouseEventArgs e)
        {
            if (isOnResize)
            {
                Size size = this.Size;
                Point location = Point.Empty;
                int left = this.Left;
                int top = this.Top;

                int X = e.X;
                int Y = e.Y;

                switch (labelName)
                {
                    case "lbNW":
                        left = Math.Max(0, X + this.Left - pointStart.X);
                        top = Math.Max(0, Y + this.Top - pointStart.Y);
                        size = new Size(oriSize.Width - (left - oriLabelLocation.X)
                            , oriSize.Height - (top - oriLabelLocation.Y));
                        break;
                    case "lbSE":
                        size = new Size(this.Width + X, this.Height + Y);
                        break;

                    case "lbN":
                        top = Math.Max(0, Y + this.Top - pointStart.Y);
                        size = new Size(this.Width, oriSize.Height - (top - oriLabelLocation.Y));
                        break;
                    case "lbS":
                        size = new Size(this.Width, this.Height + Y);
                        break;

                    case "lbNE":
                        top = Math.Max(0, Y + this.Top - pointStart.Y);
                        size = new Size(this.Width + X
                            , oriSize.Height - (top - oriLabelLocation.Y));
                        break;
                    case "lbSW":
                        left = Math.Max(0, X + this.Left - pointStart.X);
                        size = new Size(oriSize.Width - (left - oriLabelLocation.X)
                            , this.Height + Y);
                        break;

                    case "lbE":
                        size = new Size(this.Width + X, this.Height);
                        break;
                    case "lbW":
                        left = Math.Max(0, X + this.Left - pointStart.X);
                        size = new Size(oriSize.Width - (left - oriLabelLocation.X), this.Height);
                        break;
                }

                if (size.Width < 17)
                {
                    left = this.Left;
                    size = new Size(17, size.Height);
                }

                if (size.Height < 17)
                {
                    top = this.Top;
                    size = new Size(size.Width, 17);
                }

                if (size.Width + left > Parent.Width - 20)
                {
                    size = new Size(Parent.Width - left - 20, size.Height);
                }

                if (size.Height + top > Parent.Height - 20)
                {
                    size = new Size(size.Width, Parent.Height - top - 20);
                }

                this.Left = left;
                this.Top = top;

                this.MaximumSize = size;
                this.MinimumSize = size;
                this.Size = size;
            }
        }

        public void ShowResizeHandles()
        {
            lbNW.Visible = true;
            lbN.Visible = true;
            lbNE.Visible = true;
            lbE.Visible = true;
            lbSE.Visible = true;
            lbS.Visible = true;
            lbSW.Visible = true;
            lbW.Visible = true;
        }

        public void HideResizeHandles()
        {
            lbNW.Visible = false;
            lbN.Visible = false;
            lbNE.Visible = false;
            lbE.Visible = false;
            lbSE.Visible = false;
            lbS.Visible = false;
            lbSW.Visible = false;
            lbW.Visible = false;
        }

        #endregion Resize Methods

    }
}
