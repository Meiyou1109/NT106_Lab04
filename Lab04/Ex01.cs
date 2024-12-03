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
    public partial class Ex01 : Form
    {
        public Ex01()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if URL textbox is not empty
                if (string.IsNullOrWhiteSpace(txtURL.Text))
                {
                    MessageBox.Show("Please enter a valid URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Call the getHTML method with the URL from the textbox
                string webContent = getHTML(txtURL.Text);

                // Display the retrieved HTML content in the RichTextBox
                richTextBoxDisplay.Text = webContent;
            }
            catch (WebException webEx)
            {
                // Handle web-related exceptions
                MessageBox.Show($"Web Error: {webEx.Message}", "Web Request Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Handle any other unexpected exceptions
                MessageBox.Show($"Error: {ex.Message}", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string getHTML(string szURL)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szURL);

            // Get the response.
            WebResponse response = request.GetResponse();

            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);

            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            // Close the response.
            response.Close();

            return responseFromServer;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            richTextBoxDisplay.Clear();
            txtURL.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }
    }
}
