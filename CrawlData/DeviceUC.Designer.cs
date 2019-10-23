namespace CrawlData
{
    partial class DeviceUC
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.LinkLabel();
            this.txtPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(223, 200);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.WaitOnLoad = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(0, 203);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(223, 32);
            this.txtName.TabIndex = 1;
            this.txtName.TabStop = true;
            this.txtName.Text = "Name";
            this.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtName_LinkClicked);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(0, 235);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(223, 34);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.Text = "txtPrice";
            this.txtPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeviceUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pictureBox);
            this.Name = "DeviceUC";
            this.Size = new System.Drawing.Size(223, 269);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.LinkLabel txtName;
        private System.Windows.Forms.Label txtPrice;
    }
}
