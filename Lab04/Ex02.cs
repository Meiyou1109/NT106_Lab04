using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Lab04
{
    public partial class Ex02 : Form
    {
        public Ex02()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate URL input
                if (string.IsNullOrWhiteSpace(txtURL.Text))
                {
                    MessageBox.Show("Please enter a valid URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate save file path
                if (string.IsNullOrWhiteSpace(txtSavePath.Text))
                {
                    // Open file save dialog if no path specified
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "HTML Files (*.html)|*.html|All files (*.*)|*.*",
                        DefaultExt = "html",
                        FileName = "downloaded_page.html"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        txtSavePath.Text = saveFileDialog.FileName;
                    }
                    else
                    {
                        return; // User cancelled file selection
                    }
                }

                // Create WebClient instance
                using (WebClient myClient = new WebClient())
                {
                    // Download file from specified URL to specified path
                    myClient.DownloadFile(txtURL.Text, txtSavePath.Text);

                    // Optional: Read and display file contents in RichTextBox
                    string downloadedContent = File.ReadAllText(txtSavePath.Text);
                    richTextBoxDisplay.Text = downloadedContent;

                    // Show success message
                    MessageBox.Show($"File successfully downloaded to {txtSavePath.Text}",
                                    "Download Complete",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (WebException webEx)
            {
                // Handle web-related errors
                MessageBox.Show($"Download Error: {webEx.Message}",
                                "Web Download Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access denied. Unable to save file to the specified location.",
                                "Access Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Catch-all for any other unexpected errors
                MessageBox.Show($"Unexpected Error: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtSavePath.Clear();
            txtURL.Clear();
            richTextBoxDisplay.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }
    }
}
