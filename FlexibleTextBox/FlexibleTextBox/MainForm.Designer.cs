namespace FlexibleTextBox
{
    partial class MainForm
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
            this.Pad = new System.Windows.Forms.Panel();
            this.ToolBox = new System.Windows.Forms.GroupBox();
            this.btnSelectMode = new System.Windows.Forms.Button();
            this.btnAddTextBox = new System.Windows.Forms.Button();
            this.ToolBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pad
            // 
            this.Pad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pad.Location = new System.Drawing.Point(12, 75);
            this.Pad.Name = "Pad";
            this.Pad.Size = new System.Drawing.Size(760, 475);
            this.Pad.TabIndex = 0;
            this.Pad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pad_MouseClick);
            // 
            // ToolBox
            // 
            this.ToolBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolBox.Controls.Add(this.btnAddTextBox);
            this.ToolBox.Controls.Add(this.btnSelectMode);
            this.ToolBox.Location = new System.Drawing.Point(12, 1);
            this.ToolBox.Name = "ToolBox";
            this.ToolBox.Size = new System.Drawing.Size(760, 68);
            this.ToolBox.TabIndex = 1;
            this.ToolBox.TabStop = false;
            // 
            // btnSelectMode
            // 
            this.btnSelectMode.Location = new System.Drawing.Point(6, 11);
            this.btnSelectMode.Name = "btnSelectMode";
            this.btnSelectMode.Size = new System.Drawing.Size(126, 51);
            this.btnSelectMode.TabIndex = 0;
            this.btnSelectMode.Text = "Select Mode";
            this.btnSelectMode.UseVisualStyleBackColor = true;
            this.btnSelectMode.Click += new System.EventHandler(this.btnSelectMode_Click);
            // 
            // btnAddTextBox
            // 
            this.btnAddTextBox.Location = new System.Drawing.Point(138, 11);
            this.btnAddTextBox.Name = "btnAddTextBox";
            this.btnAddTextBox.Size = new System.Drawing.Size(126, 51);
            this.btnAddTextBox.TabIndex = 1;
            this.btnAddTextBox.Text = "Add TextBox";
            this.btnAddTextBox.UseVisualStyleBackColor = true;
            this.btnAddTextBox.Click += new System.EventHandler(this.btnAddTextBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.ToolBox);
            this.Controls.Add(this.Pad);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flexible TextBox Demo";
            this.ToolBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pad;
        private System.Windows.Forms.GroupBox ToolBox;
        private System.Windows.Forms.Button btnAddTextBox;
        private System.Windows.Forms.Button btnSelectMode;
    }
}

