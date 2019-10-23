using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlData
{
    public class Device
    {
        private string name;
        private string price;
        private string imgUrl;
        private string urlDetail;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public string ImgUrl
        {
            get
            {
                return imgUrl;
            }

            set
            {
                imgUrl = value;
            }
        }

        public string UrlDetail
        {
            get
            {
                return urlDetail;
            }

            set
            {
                urlDetail = value;
            }
        }
    }
}
