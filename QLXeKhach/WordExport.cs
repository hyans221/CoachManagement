using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using Word = Microsoft.Office.Interop.Word;

namespace QLXeKhach
{
    public class WordExport
    {
        public Word.Application _app;
        public Word.Document _doc;
        public object _pathFile;
        private object missing = System.Reflection.Missing.Value;

        public WordExport(string vPath, bool vCreateApp = true)
        {
            _pathFile = vPath;
            if (vCreateApp)
            {
                _app = new Word.Application();
            }
            if (!File.Exists(vPath))
            {
                throw new FileNotFoundException("Template file not found: " + vPath);
            }
            object readOnly = true;
            object fileName = _pathFile;
            _doc = _app.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
        }

        public void WriteFields(Dictionary<string, string> fieldValues)
        {
            foreach (var item in fieldValues)
            {
                Word.Find find = _app.Selection.Find;
                find.Text = "{" + item.Key + "}";
                find.Replacement.Text = item.Value;
                find.Wrap = Word.WdFindWrap.wdFindContinue;
                find.Execute(Replace: Word.WdReplace.wdReplaceAll);
            }
        }

        public void SaveAs(string outputPath)
        {
            object fileFormat = Word.WdSaveFormat.wdFormatXMLDocument;
            object fileName = outputPath;
            _doc.SaveAs2(ref fileName, ref fileFormat);
        }

        public void Close()
        {
            if (_doc != null)
            {
                _doc.Close(false);
            }
            if (_app != null)
            {
                _app.Quit();
            }
        }
    }
}