using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawlData
{
    public partial class ResultUC : UserControl
    {
        private List<Device> lstDevice = new List<Device>();
        public ResultUC()
        {

        }
        public ResultUC(List<Device> lists)
        {
            InitializeComponent();
            lstDevice = lists;
        }

        private void ResultUC_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            for (int i=0;i< lstDevice.Count;i++)
            {
                this.tblResult.Controls.Add(new DeviceUC(lstDevice[i]));

            }
        }
    }
}
