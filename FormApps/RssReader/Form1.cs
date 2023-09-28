using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class btGet : Form {
        public btGet() {
            InitializeComponent();
        }

        private void tbUrl_TextChanged(object sender, EventArgs e) {

        }

        private void btGetUlr_Click(object sender, EventArgs e) {
            using (var wc = new WebClient())
            {
                var ulr = wc.OpenRead(tbUrl.Text);
                XDocument xdoc = XDocument.Load(ulr);
                var nodes = xdoc.Root.Descendants("item")
                    .Select(x => new ItemData
                    {
                        Title = (string)x.Element("title")
                    }
                        );

                foreach (var node in nodes)
                {
                    lbRssTitle.Items.Add(node.Title);

                }
            }
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            // wbBrowser.Navigate(lbRssTitle.Items.ToString()); 
            using (var wc = new WebClient())
            {
                var ulr = wc.OpenRead(tbUrl.Text);
                XDocument xdoc = XDocument.Load(ulr);
                var nodes = xdoc.Root.Descendants("item")
                    .Select(x => new ItemData
                    {
                     
                        link = (string)x.Element("link"),
                    }
                        );
            }
        }
    }
}
