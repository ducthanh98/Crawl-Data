namespace CrawlData
{
    partial class ResultUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblResult = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tblResult
            // 
            this.tblResult.AutoScroll = true;
            this.tblResult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblResult.ColumnCount = 4;
            this.tblResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblResult.Location = new System.Drawing.Point(0, 0);
            this.tblResult.MaximumSize = new System.Drawing.Size(0, 720);
            this.tblResult.Name = "tblResult";
            this.tblResult.RowCount = 5;
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tblResult.Size = new System.Drawing.Size(800, 700);
            this.tblResult.TabIndex = 0;
            // 
            // ResultUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblResult);
            this.Name = "ResultUC";
            this.Size = new System.Drawing.Size(800, 700);
            this.Load += new System.EventHandler(this.ResultUC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblResult;
    }
}
