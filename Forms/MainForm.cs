using Memo.Logic;

namespace Memo
{
    public partial class MainForm : Form
    {
        private string currentFileName = string.Empty;
        private bool isTextChanged = false;

        private MemoLogic memoLogic = new MemoLogic();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!isTextChanged)
            {
                isTextChanged = true;
                UpdateTitle();
            }
            UpdateStatusBar();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isTextChanged)
            {
                DialogResult result = MessageBox.Show(
                    "You have unsaved changes. Do you want to save your changes before creating a new file?",
                    "Unsaved changes",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                    );

                if (result == DialogResult.Yes)
                {
                    saveAsToolStripMenuItem_Click(sender, e);
                    if (isTextChanged)
                    {
                        return;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            MainTextBox.Clear();
            currentFileName = string.Empty;
            isTextChanged = false;
            UpdateTitle();
            UpdateStatusBar();
        }

        private void openToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (isTextChanged)
            {
                DialogResult result = MessageBox.Show(
                    "You have unsaved changes. Do you want to save your changes before opening a new file?",
                    "Unsaved changes",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                    );

                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                    if (isTextChanged)
                    {
                        return;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Open Text File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    MainTextBox.Text = File.ReadAllText(openFileDialog.FileName);
                    currentFileName = openFileDialog.FileName;
                    isTextChanged = false;
                    UpdateTitle();
                }
            }
            UpdateStatusBar();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFileName))
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                File.WriteAllText(currentFileName, MainTextBox.Text);
                isTextChanged = false;
                UpdateTitle();
            }
        }

        private void saveAsToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Save Text File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, MainTextBox.Text);
                    currentFileName = saveFileDialog.FileName;
                    isTextChanged = false;
                    UpdateTitle();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isTextChanged)
            {
                DialogResult result = MessageBox.Show(
                    "You have unsaved changes. Do you want to save your changes before exiting?",
                    "Unsaved changes",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                    );

                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                    if (isTextChanged)
                    {
                        return;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            Application.Exit();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isTextChanged)
            {
                DialogResult result = MessageBox.Show(
                    "You have unsaved changes. Do you want to save your changes before exiting?",
                    "Unsaved changes",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                    );

                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                    if (isTextChanged)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainTextBox.CanUndo)
            {
                MainTextBox.Undo();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextBox.Paste();
        }

        private void aboutMemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Memo - A simple text editor", "About Memo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateTitle()
        {
            this.Text = memoLogic.UpdateTitle(currentFileName, isTextChanged);
        }
        private void UpdateStatusBar()
        {
            var (charCount, charCountExcludingSpaces, lineCount, wordCount) = memoLogic.GetStatusBarInfo(MainTextBox.Text);

            numOfCharsPlusSpaceLabel.Text = $"Chars (incl. spaces): {charCount}";
            numOfCharsMinusSpaceLabel.Text = $"Chars (excl. spaces): {charCountExcludingSpaces}";
            numOfLinesLabel.Text = $"Lines: {lineCount}";
            numOfWordsLabel.Text = $"Words: {wordCount}";
        }



        private void MainTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /*********************************************************
        Description: The following functions enable drag-and-drop in a RichTextBox control for a  
        WinForms app. They handle dragging text or files into the control by processing  
        drag events and extracting the data. The implementation is adapted from  
        Microsoft's guide.  
        Reference: https://learn.microsoft.com/sv-se/dotnet/desktop/winforms/controls/enable-drag-and-drop-operations-with-wf-richtextbox-control  
        *********************************************************/

        private void MainTextBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[]? files = e.Data.GetData(DataFormats.FileDrop) as string[];

                if (files != null && files.Length > 0)
                {
                    string file = files[0];
                    if (Path.GetExtension(file).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        string fileContent = File.ReadAllText(file);

                        if ((e.KeyState & 8) == 8)
                        {
                            MainTextBox.AppendText(fileContent);
                        }
                        else if ((e.KeyState & 4) == 4)
                        {
                            int cursorPosition = MainTextBox.SelectionStart;
                            MainTextBox.Text = MainTextBox.Text.Insert(cursorPosition, fileContent);
                        }
                        else
                        {
                            if (isTextChanged)
                            {
                                DialogResult result = MessageBox.Show(
                                    "You have unsaved changes. Do you want to save your changes before opening a new file?",
                                    "Unsaved changes",
                                    MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Warning
                                );

                                if (result == DialogResult.Yes)
                                {
                                    saveToolStripMenuItem_Click(sender, e);
                                    if (isTextChanged)
                                    {
                                        return;
                                    }
                                }
                                else if (result == DialogResult.Cancel)
                                {
                                    return;
                                }
                            }

                            MainTextBox.Text = fileContent;
                            currentFileName = file;
                            isTextChanged = false;
                            UpdateTitle();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Only text files are supported.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
