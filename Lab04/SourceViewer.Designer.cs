namespace Lab04
{
    partial class SourceViewer
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox txtSource;

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
            this.txtSource = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSource.Location = new System.Drawing.Point(0, 0);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(800, 450);
            this.txtSource.TabIndex = 0;
            this.txtSource.Text = "";
            // 
            // SourceViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSource);
            this.Name = "SourceViewer";
            this.Text = "HTML Source Viewer";
            this.ResumeLayout(false);
        }
    }
}
