using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

namespace CrawlData
{
    public partial class DeviceUC : UserControl
    {
        private string urlDetail = "";
        public DeviceUC(Device device)
        {
            try
            {
                InitializeComponent();

                this.txtName.Text = device.Name;
                this.txtPrice.Text = device.Price;
                this.urlDetail = device.UrlDetail;

                WebRequest wq = WebRequest.Create(device.ImgUrl);
                using (var response = wq.GetResponse())
                {
                    using (var str = response.GetResponseStream())
                    {
                        this.pictureBox.Image = Bitmap.FromStream(str);
                    }
                }
            } catch(Exception ) { }
        }

        private void txtName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(this.urlDetail);
        }
    }
}
