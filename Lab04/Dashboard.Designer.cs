
namespace Lab04
{
    partial class Dashboard
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEx02 = new System.Windows.Forms.Button();
            this.btnEx03 = new System.Windows.Forms.Button();
            this.btnEx01 = new System.Windows.Forms.Button();
            this.lblDieuhuong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(445, 279);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(199, 64);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEx02
            // 
            this.btnEx02.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx02.Location = new System.Drawing.Point(445, 159);
            this.btnEx02.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEx02.Name = "btnEx02";
            this.btnEx02.Size = new System.Drawing.Size(199, 64);
            this.btnEx02.TabIndex = 2;
            this.btnEx02.Text = "Exercise02";
            this.btnEx02.UseVisualStyleBackColor = true;
            this.btnEx02.Click += new System.EventHandler(this.btnEx02_Click);
            // 
            // btnEx03
            // 
            this.btnEx03.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx03.Location = new System.Drawing.Point(97, 279);
            this.btnEx03.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEx03.Name = "btnEx03";
            this.btnEx03.Size = new System.Drawing.Size(199, 64);
            this.btnEx03.TabIndex = 3;
            this.btnEx03.Text = "Exercise03";
            this.btnEx03.UseVisualStyleBackColor = true;
            this.btnEx03.Click += new System.EventHandler(this.btnEx03_Click);
            // 
            // btnEx01
            // 
            this.btnEx01.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx01.Location = new System.Drawing.Point(97, 159);
            this.btnEx01.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEx01.Name = "btnEx01";
            this.btnEx01.Size = new System.Drawing.Size(199, 64);
            this.btnEx01.TabIndex = 1;
            this.btnEx01.Text = "Exercise01";
            this.btnEx01.UseVisualStyleBackColor = true;
            this.btnEx01.Click += new System.EventHandler(this.btnEx01_Click);
            // 
            // lblDieuhuong
            // 
            this.lblDieuhuong.AutoSize = true;
            this.lblDieuhuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDieuhuong.ForeColor = System.Drawing.Color.Red;
            this.lblDieuhuong.Location = new System.Drawing.Point(222, 49);
            this.lblDieuhuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDieuhuong.Name = "lblDieuhuong";
            this.lblDieuhuong.Size = new System.Drawing.Size(300, 39);
            this.lblDieuhuong.TabIndex = 15;
            this.lblDieuhuong.Text = "Trang điều hướng";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 411);
            this.Controls.Add(this.lblDieuhuong);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEx02);
            this.Controls.Add(this.btnEx03);
            this.Controls.Add(this.btnEx01);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEx02;
        private System.Windows.Forms.Button btnEx03;
        private System.Windows.Forms.Button btnEx01;
        private System.Windows.Forms.Label lblDieuhuong;
    }
}