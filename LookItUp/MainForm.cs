using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using LookItUp.Properties;
using Lucene.Net.Store;
using Directory = System.IO.Directory;

namespace LookItUp
{
    public partial class MainForm : Form
    {
        private bool allowLeadingWildcard;
        private IndexManager indexManager;
        private List<Item> resultItems = new List<Item>();
        private List<Item> itemList = new List<Item>();
        private string searchPattern = "*";
        private Lucene.Net.Store.Directory indexPath;

        public MainForm()
        {
            SplashForm splashForm = new SplashForm();
            ThreadPool.QueueUserWorkItem(StartSplash, splashForm);
            InitializeComponent();
            indexManager = IndexManager.Current;
            WindowState = FormWindowState.Minimized;
            txbSourcePath.Text = Settings.Default.SourcePath;
            txbExtension.Text = Settings.Default.SearchPattern;
            string indexFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Index");
            indexPath = new MMapDirectory(new DirectoryInfo(indexFolder));
            InitIndex();
            splashForm.BeginInvoke(new Action(() => splashForm.Close()));
            Show();
            WindowState = FormWindowState.Normal;
            txbQuery.Focus();
        }

        private void StartSplash(object state)
        {
            SplashForm splashForm = (SplashForm)state;
            Application.Run(splashForm);
        }

        private void txbQuery_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            Search();
        }

        private string keyword = string.Empty;
        private List<Item> results;

        private void Search()
        {
            allowLeadingWildcard = chbSearchMode.Checked;
            listViewResult.Items.Clear();
            lblItemCount.Text = String.Empty;
            
            lblSuggestions.Text = String.Empty;
            string userQuery = txbQuery.Text.Trim();

            if (userQuery.Length > 1)
            {
                string[] fields = userQuery.Split(new[] { ' ', ',', '(', ')', '&', '*', '#', '@', '!' }, StringSplitOptions.RemoveEmptyEntries);

                if (keyword == fields[0])
                {
                    if (fields.Length > 1)
                    {
                        results = new List<Item>();

                        results = resultItems;
                        for (int i = 0; i < fields.Length; i++)
                        {
                            if (i > 0)
                            {
                                string term = fields[i];
                                results = results.Where(x => x.Line.ToLower().Contains(term.ToLower())).ToList();
                                Debug.WriteLine($"term: {term} Count: {results.Count} of {resultItems.Count}");
                            }
                        }
                    }
                }
                else
                {
                    keyword = fields[0];
                    results = new List<Item>();

                    if (allowLeadingWildcard)
                    {
                        results = indexManager.SearchIndex(userQuery, allowLeadingWildcard);
                    }
                    else
                    {
                        results = indexManager.SearchIndex(userQuery, allowLeadingWildcard);
                    }

                    resultItems = results;

                    Display(results);
                }

                Display(results);
            }
        }

        private void Display(List<Item> results)
        {
            foreach (Item item in results)
            {

                ListViewItem listViewItem = new ListViewItem(item.Num);
                listViewItem.Name = "columnHeaderNum";
                listViewItem.SubItems.Add(item.Line);
                listViewItem.SubItems.Add(item.Path);
                listViewResult.Items.Add(listViewItem);
            }

            lblItemCount.Text = String.Format("{0} items found", results.Count);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void listViewcontextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string сlickedItemText = e.ClickedItem.Text;
            ListView.SelectedListViewItemCollection col = listViewResult.SelectedItems;
            if (col.Count == 0)
            {
                return;
            }

            var selectedItem = col[0].SubItems[2];
            Item item = results.FirstOrDefault(x => x.Path == selectedItem.Text);
            if (item != null && !string.IsNullOrEmpty(item.Path))
            {
                Debug.WriteLine(item.Path);
                new Process
                {
                    StartInfo = new ProcessStartInfo(item.Path)
                    {
                        UseShellExecute = true
                    }
                }.Start();
            }
        }

        private void btnBuildIndex_Click(object sender, EventArgs e)
        {
            string sourcePath = txbSourcePath.Text;
            Settings.Default.SourcePath = sourcePath;
            searchPattern = txbExtension.Text;
            Settings.Default.SearchPattern = searchPattern;
            Settings.Default.Save();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            EnlistFiles(sourcePath);

            indexManager.BuildIndex(itemList);

            sw.Stop();
            string msg = $"{itemList.Count} files added to index for {sw.Elapsed.ToLongReadable()}";
            lblFileCount.Text = msg;
            MessageBox.Show(msg, "Index built", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        
        private void EnlistFiles(string dirPath)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(dirPath))
                {
                    DirectoryInfo di = new DirectoryInfo(d);

                    foreach (var fileInfo in di.GetFiles(searchPattern, SearchOption.TopDirectoryOnly))
                    {
                        Debug.WriteLine(fileInfo.Name);
                        Item item = new Item();
                        item.FileInfo = fileInfo;
                        item.Lines = File.ReadAllLines(fileInfo.FullName);
                        item.FileName = fileInfo.Name;
                        itemList.Add(item);
                    }
                    EnlistFiles(d);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("EnlistFiles");
            }
        }

        private void listViewResult_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void tblMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitIndex();
        }

        private void InitIndex()
        {
            bool output = indexManager.OpenIndex();
            txbQuery.Enabled = output;
            btnSearch.Enabled = output;
        }

        private void listViewResult_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection col = listViewResult.SelectedItems;

            if (col.Count == 0)
            {
                return;
            }

            var selectedItem = col[0].SubItems[2];
            Item item = results.FirstOrDefault(x => x.Path == selectedItem.Text);
            if (item != null && !string.IsNullOrEmpty(item.Path))
            {
                Debug.WriteLine(item.Path);

                new Process
                {
                    StartInfo = new ProcessStartInfo(item.Path)
                    {
                        UseShellExecute = true
                    }
                }.Start();
            }
        }
    }
}
