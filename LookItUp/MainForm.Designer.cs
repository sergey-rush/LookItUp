
namespace LookItUp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.txbQuery = new System.Windows.Forms.TextBox();
            this.lblSuggestions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblItemCount = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listViewResult = new System.Windows.Forms.ListView();
            this.columnHeaderNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewcontextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tblMain = new System.Windows.Forms.TabControl();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.chbSearchMode = new System.Windows.Forms.CheckBox();
            this.tabIndex = new System.Windows.Forms.TabPage();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbExtension = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuildIndex = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSourcePath = new System.Windows.Forms.TextBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewcontextMenu.SuspendLayout();
            this.tblMain.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.tabIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(921, 694);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txbQuery
            // 
            this.txbQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbQuery.Enabled = false;
            this.txbQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbQuery.Location = new System.Drawing.Point(62, 23);
            this.txbQuery.Name = "txbQuery";
            this.txbQuery.Size = new System.Drawing.Size(788, 22);
            this.txbQuery.TabIndex = 2;
            this.txbQuery.TextChanged += new System.EventHandler(this.txbQuery_TextChanged);
            // 
            // lblSuggestions
            // 
            this.lblSuggestions.AutoSize = true;
            this.lblSuggestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuggestions.Location = new System.Drawing.Point(59, 56);
            this.lblSuggestions.Name = "lblSuggestions";
            this.lblSuggestions.Size = new System.Drawing.Size(0, 15);
            this.lblSuggestions.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Query:";
            // 
            // lblItemCount
            // 
            this.lblItemCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblItemCount.AutoSize = true;
            this.lblItemCount.Location = new System.Drawing.Point(18, 610);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(62, 13);
            this.lblItemCount.TabIndex = 7;
            this.lblItemCount.Text = "Items count";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(868, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // listViewResult
            // 
            this.listViewResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNum,
            this.columnHeaderLine,
            this.columnHeaderPath});
            this.listViewResult.ContextMenuStrip = this.listViewcontextMenu;
            this.listViewResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewResult.FullRowSelect = true;
            this.listViewResult.HideSelection = false;
            this.listViewResult.Location = new System.Drawing.Point(21, 84);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(916, 507);
            this.listViewResult.TabIndex = 10;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.View = System.Windows.Forms.View.Details;
            this.listViewResult.SelectedIndexChanged += new System.EventHandler(this.listViewResult_SelectedIndexChanged);
            this.listViewResult.DoubleClick += new System.EventHandler(this.listViewResult_DoubleClick);
            // 
            // columnHeaderNum
            // 
            this.columnHeaderNum.Text = "#";
            this.columnHeaderNum.Width = 40;
            // 
            // columnHeaderLine
            // 
            this.columnHeaderLine.Text = "Line";
            this.columnHeaderLine.Width = 600;
            // 
            // columnHeaderPath
            // 
            this.columnHeaderPath.Text = "Path";
            this.columnHeaderPath.Width = 300;
            // 
            // listViewcontextMenu
            // 
            this.listViewcontextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.copyToolStripMenuItem});
            this.listViewcontextMenu.Name = "listViewcontextMenu";
            this.listViewcontextMenu.Size = new System.Drawing.Size(181, 70);
            this.listViewcontextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.listViewcontextMenu_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeyDisplayString = "";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Open";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tblMain
            // 
            this.tblMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblMain.Controls.Add(this.tabSearch);
            this.tblMain.Controls.Add(this.tabIndex);
            this.tblMain.Location = new System.Drawing.Point(12, 12);
            this.tblMain.Name = "tblMain";
            this.tblMain.SelectedIndex = 0;
            this.tblMain.Size = new System.Drawing.Size(984, 665);
            this.tblMain.TabIndex = 11;
            this.tblMain.SelectedIndexChanged += new System.EventHandler(this.tblMain_SelectedIndexChanged);
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.chbSearchMode);
            this.tabSearch.Controls.Add(this.label1);
            this.tabSearch.Controls.Add(this.btnSearch);
            this.tabSearch.Controls.Add(this.lblItemCount);
            this.tabSearch.Controls.Add(this.listViewResult);
            this.tabSearch.Controls.Add(this.txbQuery);
            this.tabSearch.Controls.Add(this.lblSuggestions);
            this.tabSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(976, 639);
            this.tabSearch.TabIndex = 0;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // chbSearchMode
            // 
            this.chbSearchMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbSearchMode.AutoSize = true;
            this.chbSearchMode.Location = new System.Drawing.Point(743, 56);
            this.chbSearchMode.Name = "chbSearchMode";
            this.chbSearchMode.Size = new System.Drawing.Size(107, 17);
            this.chbSearchMode.TabIndex = 11;
            this.chbSearchMode.Text = "Нечеткий поиск";
            this.chbSearchMode.UseVisualStyleBackColor = true;
            // 
            // tabIndex
            // 
            this.tabIndex.Controls.Add(this.lblFileCount);
            this.tabIndex.Controls.Add(this.label6);
            this.tabIndex.Controls.Add(this.label5);
            this.tabIndex.Controls.Add(this.label4);
            this.tabIndex.Controls.Add(this.txbExtension);
            this.tabIndex.Controls.Add(this.label3);
            this.tabIndex.Controls.Add(this.btnBuildIndex);
            this.tabIndex.Controls.Add(this.label2);
            this.tabIndex.Controls.Add(this.txbSourcePath);
            this.tabIndex.Location = new System.Drawing.Point(4, 22);
            this.tabIndex.Name = "tabIndex";
            this.tabIndex.Padding = new System.Windows.Forms.Padding(3);
            this.tabIndex.Size = new System.Drawing.Size(976, 639);
            this.tabIndex.TabIndex = 1;
            this.tabIndex.Text = "Index";
            this.tabIndex.UseVisualStyleBackColor = true;
            // 
            // lblFileCount
            // 
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.Location = new System.Drawing.Point(22, 247);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(0, 13);
            this.lblFileCount.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "File extension:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Build index before you start searching";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Use the following file extension:";
            // 
            // txbExtension
            // 
            this.txbExtension.Location = new System.Drawing.Point(102, 148);
            this.txbExtension.Name = "txbExtension";
            this.txbExtension.Size = new System.Drawing.Size(100, 20);
            this.txbExtension.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Directory path to the files to be indexed:";
            // 
            // btnBuildIndex
            // 
            this.btnBuildIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuildIndex.Location = new System.Drawing.Point(862, 79);
            this.btnBuildIndex.Name = "btnBuildIndex";
            this.btnBuildIndex.Size = new System.Drawing.Size(93, 23);
            this.btnBuildIndex.TabIndex = 2;
            this.btnBuildIndex.Text = "Build index";
            this.btnBuildIndex.UseVisualStyleBackColor = true;
            this.btnBuildIndex.Click += new System.EventHandler(this.btnBuildIndex_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Source path:";
            // 
            // txbSourcePath
            // 
            this.txbSourcePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSourcePath.Location = new System.Drawing.Point(102, 81);
            this.txbSourcePath.Name = "txbSourcePath";
            this.txbSourcePath.Size = new System.Drawing.Size(698, 20);
            this.txbSourcePath.TabIndex = 0;
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tblMain);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Look It Up!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.listViewcontextMenu.ResumeLayout(false);
            this.tblMain.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            this.tabIndex.ResumeLayout(false);
            this.tabIndex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txbQuery;
        private System.Windows.Forms.Label lblSuggestions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblItemCount;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView listViewResult;
        private System.Windows.Forms.ColumnHeader columnHeaderPath;
        private System.Windows.Forms.ColumnHeader columnHeaderLine;
        private System.Windows.Forms.ContextMenuStrip listViewcontextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TabControl tblMain;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TabPage tabIndex;
        private System.Windows.Forms.Button btnBuildIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSourcePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbExtension;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFileCount;
        private System.Windows.Forms.CheckBox chbSearchMode;
        private System.Windows.Forms.ColumnHeader columnHeaderNum;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    }
}


