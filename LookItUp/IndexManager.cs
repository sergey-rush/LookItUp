using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers;
using Lucene.Net.Search;
using Lucene.Net.Store;
using SpellChecker.Net.Search.Spell;
using Version = Lucene.Net.Util.Version;

namespace LookItUp
{
    public class IndexManager
    {
        private static IndexManager _current;

        public static IndexManager Current
        {
            get
            {
                if (_current == null)
                {
                    _current = new IndexManager();
                }
                return _current;
            }
        }

        private static Lucene.Net.Store.Directory indexPath { get; set; }
        private IndexReader reader;
        private StreamReader streamReader;
        private SpellChecker.Net.Search.Spell.SpellChecker speller;
        
        public bool OpenIndex()
        {
            bool output = false;

            try
            {
                string indexFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Index");
                indexPath = new MMapDirectory(new DirectoryInfo(indexFolder));

                reader = IndexReader.Open(indexPath, true);
                streamReader = new StreamReader(Path.Combine(indexFolder, "StopWords.txt"));
                speller = new SpellChecker.Net.Search.Spell.SpellChecker(new RAMDirectory());
                speller.IndexDictionary(new LuceneDictionary(reader, "name"));
                output = true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return output;
        }

        public List<Item> SearchIndex(string userQuery, bool allowLeadingWildcard)
        {
            List<Item> results = new List<Item>();

            if (string.IsNullOrEmpty(userQuery))
            {
                return results;
            }

            if (allowLeadingWildcard)
            {
                userQuery = String.Format("*{0}*", userQuery);
            }

            Debug.WriteLine($"Query: {userQuery} allowLeadingWildcard: {allowLeadingWildcard}");

            try
            {
                Searcher searcher = new IndexSearcher(reader);
                Analyzer analyzer = new StandardAnalyzer(Version.LUCENE_30, streamReader);
                QueryParser queryParser = new QueryParser(Version.LUCENE_30, "line", analyzer);
                queryParser.AllowLeadingWildcard = allowLeadingWildcard;
                queryParser.DefaultOperator = QueryParser.Operator.AND;
                Query query = queryParser.Parse(userQuery);
                TopDocs topDocs = searcher.Search(query, 10000);

                foreach (ScoreDoc scoreDoc in topDocs.ScoreDocs)
                {
                    Lucene.Net.Documents.Document doc = searcher.Doc(scoreDoc.Doc);
                    Item item = new Item();
                    item.FileName = doc.Get("fileName");
                    item.Num = doc.Get("num");
                    item.Line = doc.Get("line");
                    item.Path = doc.Get("path");
                    results.Add(item);
                }
            }
            catch(Exception ex)
            {
                
                Debug.WriteLine(ex.Message);
            }

            Debug.WriteLine($"Query: {userQuery} Count: {results.Count} allowLeadingWildcard: {allowLeadingWildcard}");

            return results;
        }

        public void BuildIndex(List<Item> items)
        {
            try
            {
                Analyzer analyzer = new StandardAnalyzer(Version.LUCENE_30);
                using (var writer = new IndexWriter(indexPath, analyzer, true, IndexWriter.MaxFieldLength.UNLIMITED))
                {
                    writer.SetMaxFieldLength(5000000);
                    foreach (Item item in items)
                    {
                        for (var i = 0; i < item.Lines.Length; i++)
                        {
                            string line = item.Lines[i];
                            if (!string.IsNullOrEmpty(line))
                            {
                                writer.AddDocument(item.GetDocument(i, line));
                            }
                        }
                    }
                    writer.Optimize();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}