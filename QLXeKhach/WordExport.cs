using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using DataTable = System.Data.DataTable;
using System.IO;
//using System.Data;

namespace QLXeKhach
{
    public class WordExport
    {
        public Word.Application _app;
        public Word.Document _doc;
        public object _pathFile;

        public WordExport(string vPath, bool vCreateApp = true)
        {
            _pathFile = vPath;

            // Create a new Word application instance if required
            if (vCreateApp)
            {
                _app = new Word.Application();
            }

            // Check if the template file exists
            if (!File.Exists(vPath))
            {
                throw new FileNotFoundException("Template file not found: " + vPath);
            }

            // Open the Word document template
            _doc = _app.Documents.Open(_pathFile);
        }

        // Method to write values to placeholders in the Word template
        public void WriteFields(Dictionary<string, string> fieldValues)
        {
            foreach (var item in fieldValues)
            {
                // Search for placeholders in the format of {key}
                Word.Find find = _app.Selection.Find;
                find.Text = "{" + item.Key + "}";
                find.Replacement.Text = item.Value;
                find.Wrap = Word.WdFindWrap.wdFindContinue;
                find.Execute(Replace: Word.WdReplace.wdReplaceAll);
            }
        }

        // Save the document to a specified path
        public void SaveAs(string outputPath)
        {
            _doc.SaveAs2(outputPath);
        }

        // Close the document and the application
        public void Close()
        {
            _doc.Close();
            _app.Quit();
        }
    }
}
