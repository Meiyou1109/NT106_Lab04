namespace Lab04
{
    partial class Ex03
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnDownloadHtml;
        private System.Windows.Forms.Button btnViewSource;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ContextMenuStrip contextMenuDownload;
        private System.Windows.Forms.ToolStripMenuItem menuItemDownloadHtml;
        private System.Windows.Forms.ToolStripMenuItem menuItemDownloadFullSource;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnDownloadHtml = new System.Windows.Forms.Button();
            this.btnViewSource = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.contextMenuDownload = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemDownloadHtml = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDownloadFullSource = new System.Windows.Forms.ToolStripMenuItem();

            this.SuspendLayout();

            // txtURL
            this.txtURL.Location = new System.Drawing.Point(12, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(600, 22);
            this.txtURL.TabIndex = 0;

            // btnGo
            this.btnGo.Location = new System.Drawing.Point(620, 12);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);

            // btnDownloadHtml
            this.btnDownloadHtml = new System.Windows.Forms.Button();
            this.btnDownloadHtml.Location = new System.Drawing.Point(700, 12);
            this.btnDownloadHtml.Name = "btnDownloadHtml";
            this.btnDownloadHtml.Size = new System.Drawing.Size(150, 23);
            this.btnDownloadHtml.TabIndex = 2;
            this.btnDownloadHtml.Text = "Download HTML ▼";
            this.btnDownloadHtml.UseVisualStyleBackColor = true;
            this.btnDownloadHtml.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDownloadHtml_MouseDown);


            // btnViewSource
            this.btnViewSource.Location = new System.Drawing.Point(860, 12);
            this.btnViewSource.Name = "btnViewSource";
            this.btnViewSource.Size = new System.Drawing.Size(120, 23);
            this.btnViewSource.TabIndex = 3;
            this.btnViewSource.Text = "View Source";
            this.btnViewSource.UseVisualStyleBackColor = true;
            this.btnViewSource.Click += new System.EventHandler(this.btnViewSource_Click);

            // webBrowser
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webBrowser.Location = new System.Drawing.Point(0, 50);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1000, 600);
            this.webBrowser.TabIndex = 4;

            // contextMenuDownload
            this.contextMenuDownload.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuItemDownloadHtml,
                this.menuItemDownloadFullSource
            });

            // menuItemDownloadHtml
            this.menuItemDownloadHtml.Name = "menuItemDownloadHtml";
            this.menuItemDownloadHtml.Size = new System.Drawing.Size(210, 24);
            this.menuItemDownloadHtml.Text = "Download HTML";
            this.menuItemDownloadHtml.Click += new System.EventHandler(this.menuItemDownloadHtml_Click);

            // menuItemDownloadFullSource
            this.menuItemDownloadFullSource.Name = "menuItemDownloadFullSource";
            this.menuItemDownloadFullSource.Size = new System.Drawing.Size(210, 24);
            this.menuItemDownloadFullSource.Text = "Download Full Source";
            this.menuItemDownloadFullSource.Click += new System.EventHandler(this.menuItemDownloadFullSource_Click);

            // Ex03
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.btnViewSource);
            this.Controls.Add(this.btnDownloadHtml);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtURL);
            this.Name = "Ex03";
            this.Text = "Web Browser";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
