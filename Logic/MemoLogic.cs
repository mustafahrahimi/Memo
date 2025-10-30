using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memo.Logic
{
    public class MemoLogic
    {
        public MemoLogic() { }
        public string UpdateTitle(string currentFileName, bool isTextChanged)
        {
            string fileName = string.IsNullOrEmpty(currentFileName) ? "Untitled.txt" : Path.GetFileName(currentFileName);
            return (isTextChanged ? "*" : "") + fileName + " - Memo";
        }

        public (int charCount, int charCountExcludingSpaces, int lineCount, int wordCount) GetStatusBarInfo(string text)
        {
            int charCount = text.Length;
            int charCountExcludingSpaces = text.Replace(" ", "").Length;
            int lineCount = text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int wordCount = text.Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
            return (charCount, charCountExcludingSpaces, lineCount, wordCount);
        }   
    }
}
