
namespace Memo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainTextBox = new RichTextBox();
            MainMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutMemoToolStripMenuItem = new ToolStripMenuItem();
            MainStatusBar = new StatusStrip();
            numOfCharsPlusSpaceLabel = new ToolStripStatusLabel();
            numOfCharsMinusSpaceLabel = new ToolStripStatusLabel();
            numOfWordsLabel = new ToolStripStatusLabel();
            numOfLinesLabel = new ToolStripStatusLabel();
            MainMenuStrip.SuspendLayout();
            MainStatusBar.SuspendLayout();
            SuspendLayout();
            // 
            // MainTextBox
            // 
            MainTextBox.BorderStyle = BorderStyle.None;
            MainTextBox.Dock = DockStyle.Fill;
            MainTextBox.Location = new Point(0, 33);
            MainTextBox.Name = "MainTextBox";
            MainTextBox.Size = new Size(800, 417);
            MainTextBox.TabIndex = 0;
            MainTextBox.Text = "";
            MainTextBox.TextChanged += MainTextBox_TextChanged;
            MainTextBox.AllowDrop = true;
            MainTextBox.DragEnter += new DragEventHandler(MainTextBox_DragEnter);
            MainTextBox.DragDrop += new DragEventHandler(MainTextBox_DragDrop);
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.ImageScalingSize = new Size(24, 24);
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new Size(800, 33);
            MainMenuStrip.TabIndex = 1;
            MainMenuStrip.Text = "MenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(173, 34);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(173, 34);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(173, 34);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(173, 34);
            saveAsToolStripMenuItem.Text = "Save as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(173, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(158, 34);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(158, 34);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(158, 34);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(158, 34);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutMemoToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMemoToolStripMenuItem
            // 
            aboutMemoToolStripMenuItem.Name = "aboutMemoToolStripMenuItem";
            aboutMemoToolStripMenuItem.Size = new Size(221, 34);
            aboutMemoToolStripMenuItem.Text = "About Memo";
            aboutMemoToolStripMenuItem.Click += aboutMemoToolStripMenuItem_Click;
            // 
            // MainStatusBar
            // 
            MainStatusBar.ImageScalingSize = new Size(24, 24);
            MainStatusBar.Items.AddRange(new ToolStripItem[] { numOfCharsPlusSpaceLabel, numOfCharsMinusSpaceLabel, numOfWordsLabel, numOfLinesLabel });
            MainStatusBar.Location = new Point(0, 418);
            MainStatusBar.Name = "MainStatusBar";
            MainStatusBar.Size = new Size(800, 32);
            MainStatusBar.TabIndex = 2;
            MainStatusBar.Text = "StatusBar";
            // 
            // numOfCharsPlusSpaceLabel
            // 
            numOfCharsPlusSpaceLabel.Name = "numOfCharsPlusSpaceLabel";
            numOfCharsPlusSpaceLabel.Size = new Size(196, 25);
            numOfCharsPlusSpaceLabel.Spring = true;
            numOfCharsPlusSpaceLabel.Text = "Chars (incl. spaces): 0";
            // 
            // numOfCharsMinusSpaceLabel
            // 
            numOfCharsMinusSpaceLabel.Name = "numOfCharsMinusSpaceLabel";
            numOfCharsMinusSpaceLabel.Size = new Size(196, 25);
            numOfCharsMinusSpaceLabel.Spring = true;
            numOfCharsMinusSpaceLabel.Text = "Chars (excl. spaces): 0";
            // 
            // numOfWordsLabel
            // 
            numOfWordsLabel.Name = "numOfWordsLabel";
            numOfWordsLabel.Size = new Size(196, 25);
            numOfWordsLabel.Spring = true;
            numOfWordsLabel.Text = "0 words";
            // 
            // numOfLinesLabel
            // 
            numOfLinesLabel.Name = "numOfLinesLabel";
            numOfLinesLabel.Size = new Size(196, 25);
            numOfLinesLabel.Spring = true;
            numOfLinesLabel.Text = "0 lines";
            // 
            // MainForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainStatusBar);
            Controls.Add(MainTextBox);
            Controls.Add(MainMenuStrip);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MainForm";
            Text = "Memo";
            FormClosing += MainForm_FormClosing;
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            MainStatusBar.ResumeLayout(false);
            MainStatusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox MainTextBox;
        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem aboutMemoToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private StatusStrip MainStatusBar;
        private ToolStripStatusLabel numOfCharsPlusSpaceLabel;
        private ToolStripStatusLabel numOfCharsMinusSpaceLabel;
        private ToolStripStatusLabel numOfWordsLabel;
        private ToolStripStatusLabel numOfLinesLabel;
    }
}
