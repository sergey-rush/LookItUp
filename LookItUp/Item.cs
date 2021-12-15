using System.Collections.Generic;
using System.IO;
using Lucene.Net.Documents;

namespace LookItUp
{
    public class Item
    {
        public string FileName { get; set; }
        public FileInfo FileInfo { get; set; }
        public string[] Lines { get; set; }
        public string Line { get; set; }
        public string Path { get; set; }
        public string Num { get; set; }

        public Document GetDocument(int num, string line)
        {
            Num = (num+1).ToString();
            Line = line.Trim();
            Document document = new Document();
            document.Add(new Field("num", Num, Field.Store.YES, Field.Index.NOT_ANALYZED_NO_NORMS));
            document.Add(new Field("fileName", FileName, Field.Store.YES, Field.Index.NOT_ANALYZED_NO_NORMS));
            document.Add(new Field("path", FileInfo.FullName, Field.Store.YES, Field.Index.NOT_ANALYZED_NO_NORMS));
            document.Add(new Field("line", Line, Field.Store.YES, Field.Index.ANALYZED));
            return document;
        }
    }
}