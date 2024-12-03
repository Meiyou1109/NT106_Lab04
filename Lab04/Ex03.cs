using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Lab04
{
    public partial class Ex03 : Form
    {


        public Ex03()
        {
            InitializeComponent();
            InitializeContextMenu();
            webBrowser.ScriptErrorsSuppressed = true; 
        }

        private void InitializeContextMenu()
        {
            contextMenuDownload = new ContextMenuStrip();

            menuItemDownloadHtml = new ToolStripMenuItem("Download HTML");
            menuItemDownloadHtml.Click += new EventHandler(this.menuItemDownloadHtml_Click);

            menuItemDownloadFullSource = new ToolStripMenuItem("Download Full Source");
            menuItemDownloadFullSource.Click += new EventHandler(this.menuItemDownloadFullSource_Click);

            contextMenuDownload.Items.Add(menuItemDownloadHtml);
            contextMenuDownload.Items.Add(menuItemDownloadFullSource);

            btnDownloadHtml.ContextMenuStrip = contextMenuDownload;
            btnDownloadHtml.MouseDown += new MouseEventHandler(this.btnDownloadHtml_MouseDown);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtURL.Text))
            {
                webBrowser.Navigate(txtURL.Text);
            }
            else
            {
                MessageBox.Show("Please enter a valid URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menuItemDownloadHtml_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtURL.Text))
                {
                    MessageBox.Show("Please enter a valid URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "HTML Files (*.html)|*.html|All files (*.*)|*.*",
                    DefaultExt = "html",
                    FileName = "downloaded_page.html"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string url = txtURL.Text;
                    string savePath = saveFileDialog.FileName;

                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(url, savePath);
                        MessageBox.Show($"HTML file downloaded to {savePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Download Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuItemDownloadFullSource_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtURL.Text))
            {
                MessageBox.Show("Please enter a valid URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string url = txtURL.Text;
                    string saveFolder = folderDialog.SelectedPath;
                    DownloadFullSource(url, saveFolder);
                }
            }
        }

        private void btnDownloadHtml_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                contextMenuDownload.Show(btnDownloadHtml, e.Location);
            }
        }

        private void DownloadFullSource(string url, string saveFolder)
        {
            try
            {
                var web = new HtmlWeb();
                var doc = web.Load(url);

                if (!Directory.Exists(saveFolder))
                {
                    Directory.CreateDirectory(saveFolder);
                }

                var nodes = doc.DocumentNode.SelectNodes("//img[@src]|//link[@href]|//script[@src]");
                if (nodes != null)
                {
                    foreach (var node in nodes)
                    {
                        string src = string.Empty;

                        if (node.Name == "img")
                        {
                            src = node.GetAttributeValue("src", string.Empty);
                        }
                        else if (node.Name == "link")
                        {
                            src = node.GetAttributeValue("href", string.Empty);
                        }
                        else if (node.Name == "script")
                        {
                            src = node.GetAttributeValue("src", string.Empty);
                        }

                        if (!string.IsNullOrEmpty(src))
                        {
                            Uri baseUri = new Uri(url);
                            Uri resourceUri = new Uri(baseUri, src);

                            string fileName = Path.GetFileName(resourceUri.LocalPath);
                            string savePath = Path.Combine(saveFolder, fileName);

                            using (WebClient client = new WebClient())
                            {
                                client.DownloadFile(resourceUri, savePath);
                            }

                            if (node.Name == "img" || node.Name == "script")
                            {
                                node.SetAttributeValue("src", fileName);
                            }
                            else if (node.Name == "link")
                            {
                                node.SetAttributeValue("href", fileName);
                            }
                        }
                    }
                }

                string htmlFilePath = Path.Combine(saveFolder, "index.html");
                File.WriteAllText(htmlFilePath, doc.DocumentNode.OuterHtml);

                MessageBox.Show($"Download complete! Files saved to {saveFolder}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Download Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewSource_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtURL.Text))
                {
                    MessageBox.Show("Please enter a valid URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string htmlContent = getHTML(txtURL.Text);

                SourceViewer sourceViewer = new SourceViewer(htmlContent);
                sourceViewer.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string getHTML(string url)
        {
            WebRequest request = WebRequest.Create(url);
            using (WebResponse response = request.GetResponse())
            using (Stream dataStream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(dataStream))
            {
                return reader.ReadToEnd();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            new Dashboard().Show();
        }
    }
}