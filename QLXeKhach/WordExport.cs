using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Word = Microsoft.Office.Interop.Word;

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
            object fileFormat = Word.WdSaveFormat.wdFormatXMLDocument; // Correct format for .docx
            object fileName = outputPath;
            _doc.SaveAs2(ref fileName, ref fileFormat);
        }

        // Close the document and the application
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


//namespace QLXeKhach
//{
//    public class WordExport
//    {
//        private Application _app;
//        private Document _doc;
//        private object _pathFile;

//        public WordExport(string vPath, bool vCreateApp = true)
//        {
//            _pathFile = vPath;

//            try
//            {
//                if (vCreateApp)
//                {
//                    _app = new Application();
//                }
//                else
//                {
//                    _app = Marshal.GetActiveObject("Word.Application") as Application;
//                    if (_app == null)
//                    {
//                        throw new InvalidOperationException("Word application is not running and vCreateApp is false.");
//                    }
//                }

//                if (!File.Exists(vPath))
//                {
//                    throw new FileNotFoundException("Template file not found: " + vPath);
//                }

//                _doc = _app.Documents.Open(ref _pathFile);
//                if (_doc == null)
//                {
//                    throw new InvalidOperationException("Failed to open the Word document.");
//                }
//            }
//            catch (COMException ex)
//            {
//                throw new Exception("Error initializing Word application: " + ex.Message, ex);
//            }
//            catch (Exception ex)
//            {
//                throw new Exception("An error occurred: " + ex.Message, ex);
//            }
//        }

//        public void WriteFields(Dictionary<string, string> fieldValues)
//        {
//            foreach (var item in fieldValues)
//            {
//                Find find = _app.Selection.Find;
//                find.Text = "{" + item.Key + "}";
//                find.Replacement.Text = item.Value;
//                find.Wrap = WdFindWrap.wdFindContinue;
//                find.Execute(Replace: WdReplace.wdReplaceAll);
//            }
//        }

//        public void SaveAs(string outputPath)
//        {
//            _doc.SaveAs2(outputPath);
//        }

//        public void Close()
//        {
//            if (_doc != null)
//            {
//                _doc.Close(WdSaveOptions.wdDoNotSaveChanges);
//                Marshal.ReleaseComObject(_doc);
//            }

//            if (_app != null)
//            {
//                _app.Quit();
//                Marshal.ReleaseComObject(_app);
//            }

//            _doc = null;
//            _app = null;
//            GC.Collect();
//            GC.WaitForPendingFinalizers();
//        }
//    }
//}
