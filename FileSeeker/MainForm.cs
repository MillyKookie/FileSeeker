namespace FileSeeker
{
    public partial class MainForm : Form
    {
        bool IsClosing = false;
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void tbPath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (tbPath.Text.Length == 0) return;
                lvPaths.Items.Add(new ListViewItem(tbPath.Text));
                tbPath.Clear();
            }
        }
        private void tbPattern_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (tbPattern.Text.Length == 0) return;
                lvPatterns.Items.Add(new ListViewItem(tbPattern.Text));
                tbPattern.Clear();
            }
        }
        private void lvPaths_KeyDown(object sender, KeyEventArgs e)
        {
            ListView lvSender = (ListView)sender;
            if(e.KeyCode == Keys.Delete)
            {
                var Selecteds = lvSender.SelectedItems;
                foreach (ListViewItem lvi in Selecteds)
                    lvSender.Items.Remove(lvi);
            }
        }
        private void worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            gbPaths.Enabled = true;
            gbPatterns.Enabled = true;
            Run.Enabled = true;
            lbStatus.Text = "Waiting...";
        }
        private void Run_Click(object sender, EventArgs e)
        {
            lvResults.Items.Clear();
            gbPaths.Enabled = false;
            gbPatterns.Enabled = false;
            Run.Enabled = false;
            worker.RunWorkerAsync();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsClosing = true;
            Thread.Sleep(2000);
        }


        private void worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            foreach(ListViewItem lviPath in lvPaths.Items)
            {
                if (IsClosing) return;
                string TheoricalURI = lviPath.SubItems[0].Text;
                DirectoryInfo parent = new(TheoricalURI);
                List<string> Patterns = new();
                foreach (ListViewItem lviPattern in lvPatterns.Items) Patterns.Add(lviPattern.SubItems[0].Text);

                GetFiles(parent, Patterns.ToArray());
            }
        }
        public void GetFiles(DirectoryInfo parent, params string[] patterns)
        {
            if (IsClosing) return;
            lbStatus.Text = $"Searching... {parent.FullName}";
            try
            {
                foreach(string pattern in patterns)
                {
                    foreach(FileInfo fi in parent.GetFiles(pattern))
                    {
                        ListViewItem lvi = new(fi.Name);
                        lvi.SubItems.Add($"{fi.Length}");
                        lvi.SubItems.Add(fi.FullName);
                        lvResults.Items.Add(lvi);
                    }
                }
                foreach (DirectoryInfo child in parent.GetDirectories())
                    GetFiles(child, patterns);
            } catch { }
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            cpaths.Width = lvPaths.Width - 35;
            cpatterns.Width = lvPatterns.Width - 35;
        }
        private void CopyURI_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvResults.SelectedItems)
                Clipboard.SetText(lvi.SubItems[2].Text);
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvResults.SelectedItems)
                System.Diagnostics.Process.Start("explorer.exe", lvi.SubItems[2].Text);
        }

        private void OpenIntoExplorer_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem lvi in lvResults.SelectedItems)
            {
                FileInfo fi = new(lvi.SubItems[2].Text);
                DirectoryInfo di = fi.Directory;
                System.Diagnostics.Process.Start("explorer.exe", di.FullName);
            }
                    
        }

        private void lvResults_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenIntoExplorer_Click(lvResults, new());
        }
    }
}