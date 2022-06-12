namespace FileSeeker
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
            this.components = new System.ComponentModel.Container();
            this.Body = new System.Windows.Forms.TableLayoutPanel();
            this.Left = new System.Windows.Forms.TableLayoutPanel();
            this.gbPatterns = new System.Windows.Forms.GroupBox();
            this.lvPatterns = new System.Windows.Forms.ListView();
            this.cpatterns = new System.Windows.Forms.ColumnHeader();
            this.tbPattern = new System.Windows.Forms.TextBox();
            this.gbPaths = new System.Windows.Forms.GroupBox();
            this.lvPaths = new System.Windows.Forms.ListView();
            this.cpaths = new System.Windows.Forms.ColumnHeader();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.Run = new System.Windows.Forms.Button();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.lvResults = new System.Windows.Forms.ListView();
            this.cfilename = new System.Windows.Forms.ColumnHeader();
            this.csize = new System.Windows.Forms.ColumnHeader();
            this.curi = new System.Windows.Forms.ColumnHeader();
            this.cmResults = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyURI = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenIntoExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.Body.SuspendLayout();
            this.Left.SuspendLayout();
            this.gbPatterns.SuspendLayout();
            this.gbPaths.SuspendLayout();
            this.gbResults.SuspendLayout();
            this.cmResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // Body
            // 
            this.Body.ColumnCount = 2;
            this.Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.Body.Controls.Add(this.Left, 0, 0);
            this.Body.Controls.Add(this.lbStatus, 1, 1);
            this.Body.Controls.Add(this.Run, 0, 1);
            this.Body.Controls.Add(this.gbResults, 1, 0);
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(0, 0);
            this.Body.Name = "Body";
            this.Body.RowCount = 2;
            this.Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.Body.Size = new System.Drawing.Size(907, 513);
            this.Body.TabIndex = 0;
            // 
            // Left
            // 
            this.Left.ColumnCount = 1;
            this.Left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Left.Controls.Add(this.gbPatterns, 0, 1);
            this.Left.Controls.Add(this.gbPaths, 0, 0);
            this.Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Left.Location = new System.Drawing.Point(3, 3);
            this.Left.Name = "Left";
            this.Left.RowCount = 2;
            this.Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Left.Size = new System.Drawing.Size(175, 472);
            this.Left.TabIndex = 0;
            // 
            // gbPatterns
            // 
            this.gbPatterns.Controls.Add(this.lvPatterns);
            this.gbPatterns.Controls.Add(this.tbPattern);
            this.gbPatterns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPatterns.Location = new System.Drawing.Point(3, 239);
            this.gbPatterns.Name = "gbPatterns";
            this.gbPatterns.Size = new System.Drawing.Size(169, 230);
            this.gbPatterns.TabIndex = 1;
            this.gbPatterns.TabStop = false;
            this.gbPatterns.Text = "Patterns";
            // 
            // lvPatterns
            // 
            this.lvPatterns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cpatterns});
            this.lvPatterns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPatterns.FullRowSelect = true;
            this.lvPatterns.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvPatterns.Location = new System.Drawing.Point(3, 42);
            this.lvPatterns.Name = "lvPatterns";
            this.lvPatterns.Size = new System.Drawing.Size(163, 185);
            this.lvPatterns.TabIndex = 2;
            this.lvPatterns.UseCompatibleStateImageBehavior = false;
            this.lvPatterns.View = System.Windows.Forms.View.Details;
            this.lvPatterns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvPaths_KeyDown);
            // 
            // cpatterns
            // 
            this.cpatterns.Width = 160;
            // 
            // tbPattern
            // 
            this.tbPattern.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPattern.Location = new System.Drawing.Point(3, 19);
            this.tbPattern.Name = "tbPattern";
            this.tbPattern.Size = new System.Drawing.Size(163, 23);
            this.tbPattern.TabIndex = 0;
            this.tbPattern.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPattern_KeyDown);
            // 
            // gbPaths
            // 
            this.gbPaths.Controls.Add(this.lvPaths);
            this.gbPaths.Controls.Add(this.tbPath);
            this.gbPaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPaths.Location = new System.Drawing.Point(3, 3);
            this.gbPaths.Name = "gbPaths";
            this.gbPaths.Size = new System.Drawing.Size(169, 230);
            this.gbPaths.TabIndex = 0;
            this.gbPaths.TabStop = false;
            this.gbPaths.Text = "Paths";
            // 
            // lvPaths
            // 
            this.lvPaths.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cpaths});
            this.lvPaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPaths.FullRowSelect = true;
            this.lvPaths.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvPaths.Location = new System.Drawing.Point(3, 42);
            this.lvPaths.Name = "lvPaths";
            this.lvPaths.Size = new System.Drawing.Size(163, 185);
            this.lvPaths.TabIndex = 1;
            this.lvPaths.UseCompatibleStateImageBehavior = false;
            this.lvPaths.View = System.Windows.Forms.View.Details;
            this.lvPaths.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvPaths_KeyDown);
            // 
            // cpaths
            // 
            this.cpaths.Width = 160;
            // 
            // tbPath
            // 
            this.tbPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPath.Location = new System.Drawing.Point(3, 19);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(163, 23);
            this.tbPath.TabIndex = 0;
            this.tbPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPath_KeyDown);
            // 
            // lbStatus
            // 
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStatus.Location = new System.Drawing.Point(184, 478);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(720, 35);
            this.lbStatus.TabIndex = 1;
            this.lbStatus.Text = "Waiting...";
            // 
            // Run
            // 
            this.Run.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Run.Location = new System.Drawing.Point(3, 481);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(175, 29);
            this.Run.TabIndex = 2;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.lvResults);
            this.gbResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbResults.Location = new System.Drawing.Point(184, 3);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(720, 472);
            this.gbResults.TabIndex = 3;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Results";
            // 
            // lvResults
            // 
            this.lvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cfilename,
            this.csize,
            this.curi});
            this.lvResults.ContextMenuStrip = this.cmResults;
            this.lvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvResults.FullRowSelect = true;
            this.lvResults.GridLines = true;
            this.lvResults.Location = new System.Drawing.Point(3, 19);
            this.lvResults.Name = "lvResults";
            this.lvResults.Size = new System.Drawing.Size(714, 450);
            this.lvResults.TabIndex = 0;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.View = System.Windows.Forms.View.Details;
            this.lvResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvResults_MouseDoubleClick);
            // 
            // cfilename
            // 
            this.cfilename.Text = "FileName";
            this.cfilename.Width = 160;
            // 
            // csize
            // 
            this.csize.Text = "Size";
            this.csize.Width = 100;
            // 
            // curi
            // 
            this.curi.Text = "URI";
            this.curi.Width = 360;
            // 
            // cmResults
            // 
            this.cmResults.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyURI,
            this.OpenFile,
            this.OpenIntoExplorer});
            this.cmResults.Name = "cmResults";
            this.cmResults.Size = new System.Drawing.Size(174, 70);
            // 
            // CopyURI
            // 
            this.CopyURI.Name = "CopyURI";
            this.CopyURI.Size = new System.Drawing.Size(173, 22);
            this.CopyURI.Text = "Copy URI";
            this.CopyURI.Click += new System.EventHandler(this.CopyURI_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(173, 22);
            this.OpenFile.Text = "Open the File";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // OpenIntoExplorer
            // 
            this.OpenIntoExplorer.Name = "OpenIntoExplorer";
            this.OpenIntoExplorer.Size = new System.Drawing.Size(173, 22);
            this.OpenIntoExplorer.Text = "Open into Explorer";
            this.OpenIntoExplorer.Click += new System.EventHandler(this.OpenIntoExplorer_Click);
            // 
            // worker
            // 
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 513);
            this.Controls.Add(this.Body);
            this.Name = "MainForm";
            this.Text = "File Seeker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.Body.ResumeLayout(false);
            this.Left.ResumeLayout(false);
            this.gbPatterns.ResumeLayout(false);
            this.gbPatterns.PerformLayout();
            this.gbPaths.ResumeLayout(false);
            this.gbPaths.PerformLayout();
            this.gbResults.ResumeLayout(false);
            this.cmResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel Body;
        private TableLayoutPanel Left;
        private GroupBox gbPatterns;
        private ListView lvPatterns;
        private ColumnHeader cpatterns;
        private TextBox tbPattern;
        private GroupBox gbPaths;
        private ListView lvPaths;
        private ColumnHeader cpaths;
        private TextBox tbPath;
        private Label lbStatus;
        private Button Run;
        private GroupBox gbResults;
        private ListView lvResults;
        private ColumnHeader cfilename;
        private ColumnHeader csize;
        private ColumnHeader curi;
        private System.ComponentModel.BackgroundWorker worker;
        private ContextMenuStrip cmResults;
        private ToolStripMenuItem CopyURI;
        private ToolStripMenuItem OpenFile;
        private ToolStripMenuItem OpenIntoExplorer;
    }
}