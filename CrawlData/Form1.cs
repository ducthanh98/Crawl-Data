using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawlData
{
    public partial class Form1 : Form
    {
        private ResultUC resultUc = new ResultUC();
        public Form1()
        {
            InitializeComponent();

        }
        private String CrawlDataFromUrl(String url)
        {
            string html = "";
            HttpClient http = new HttpClient();
            Cursor.Current = Cursors.WaitCursor;
            html = http.GetStringAsync(url).Result;
            Cursor.Current = Cursors.Default;
            return html;
        }
        private List<Device> FilterData(String html)
        {
            var deviceLists = Regex.Matches(html, @"(<li>\n*\s*\n\s*<a href=.*?)(</li>)", RegexOptions.Singleline);
            List<Device> lists = new List<Device>();
            foreach (var device in deviceLists)
            {
                Device dv = new Device();
                dv.Name = Regex.Match(device.ToString(), @"<h3>[\w\s]*").Value.Replace("<h3>", "");
                string price = Regex.Match(device.ToString(), @"(<div class=""price"">[\n\s]*<strong>Gi&#225; mới: [\d\.₫]*)|(<div class=""price"">[\n\s]*<strong>[\d\.₫]*)").Value; //.Replace(@"<div class=""price""><strong>Gi&#225; mới: ","").Replace(@"<div class=""price""><strong>", "");
                string imgUrl = Regex.Match(device.ToString(), @"(src|data-original)=""[\w\:\/\.\-]*").Value;
                dv.ImgUrl = Regex.Replace(imgUrl, @"(src|data-original)=""", "");
                dv.Price = Regex.Replace(price, @"(<div class=""price"">[\n\s]*<strong>Gi&#225; mới: [\d\.₫]*)|(<div class=""price"">[\n\s]*<strong>)", "");
                dv.UrlDetail = "https://www.thegioididong.com" + Regex.Match(device.ToString(), @"<a href=""[\w/-]*").Value.Replace(@"<a href=""", "");

                lists.Add(dv);
            }
            return lists;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String html = this.CrawlDataFromUrl(this.txtUrl.Text);
                List<Device> lstDevices = this.FilterData(html);
                this.tblForm.Controls.Remove(this.resultUc);
                if(lstDevices.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy giá trị hợp lệ !");
                    return;

                }
                this.resultUc = new ResultUC(lstDevices);
                this.tblForm.Controls.Add(resultUc);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
