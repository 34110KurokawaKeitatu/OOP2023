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
        List<ItemData> ToLink = new List<ItemData>();
        int num = 0;
        public btGet() {
            
            InitializeComponent();
        }

        private void tbUrl_TextChanged(object sender, EventArgs e) {

        }

        private void btGetUlr_Click(object sender, EventArgs e) {
            using (var wc = new WebClient())
            {
                lbRssTitle.Items.Clear();
                try
                {
                    var ulr = wc.OpenRead(tbUrl.Text);
                    XDocument xdoc = XDocument.Load(ulr);

                    ToLink = xdoc.Root.Descendants("item")
                        .Select(x => new ItemData
                        {
                            Title = (string)x.Element("title"),
                            link = (string)x.Element("link"),
                        }
                            ).ToList();

                    foreach (var item in ToLink)
                    {
                        lbRssTitle.Items.Add(item.Title);
                    }
                }
                catch (Exception ){ }
            }
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            // wbBrowser.Navigate(lbRssTitle.Items.ToString()); 
            num = lbRssTitle.SelectedIndex;
            wbBrowser.Navigate(ToLink[num].link);


        }

        private void TheEnd_Click(object sender, EventArgs e) {
            tbUrl.ResetText();
        }

        private void btUp_Click(object sender, EventArgs e) {
            num -= 1;
            lbRssTitle.SelectedIndex -= 1;
        }

        private void btDown_Click(object sender, EventArgs e) {
            num += 1;
            lbRssTitle.SelectedIndex += 1;
        }
    }
}
