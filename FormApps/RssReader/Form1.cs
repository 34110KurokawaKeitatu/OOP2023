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
        Dictionary<string, string> ItemDatas = new Dictionary<string, string>();
        Dictionary<int, string> UrlsDatas = new Dictionary<int, string>();
        int flg = 0;
        int plus = 0;
        class favoriteSet {
            public string Urls { get; set; }
            public string Titles { get; set; }
            public favoriteSet(string Urls,string Titles) {
                this.Urls = Urls;
                this.Titles = Titles;
            }
            public override string ToString() {
                return Titles;
            }
        }
        int num = 0;
        ToolTip ToolTips;
        private void btGet_Load(object sender, EventArgs e) {
            ToolTips = new ToolTip();

            ToolTips.InitialDelay = 0;
            ToolTips.ReshowDelay = 0;
            ToolTips.AutoPopDelay = 10000;

            ToolTips.ShowAlways = true;

           
            ToolTips.SetToolTip(btFavorite, "現在選択している記事をお気に入りに入れます");
            ToolTips.SetToolTip(btGetUlr, "検索");
            ToolTips.SetToolTip(btIt, "ITの記事を表示します");
            ToolTips.SetToolTip(btSport, "スポーツの記事を表示します");
            ToolTips.SetToolTip(btScience, "科学関連の記事を表示します");
            ToolTips.SetToolTip(btBusiness, "経済関連の記事を表示します");
            ToolTips.SetToolTip(btUp, "現在表示している記事の一つ上の記事を表示します");
            ToolTips.SetToolTip(btDown, "現在表示している記事の一つ下の記事を表示します");
            ToolTips.SetToolTip(btFF10, "お気に入りに登録した記事を表示します");
        }
        public btGet() {
            
            InitializeComponent();
        }

        private void btGetUlr_Click(object sender, EventArgs e) {
            Summarize(tbUrl.Text);
            flg = 0;
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            // wbBrowser.Navigate(lbRssTitle.Items.ToString()); 
            //num = lbRssTitle.SelectedIndex;
            //wbBrowser.Navigate(ToLink[num].link);
            if (flg == 0)
            {
                Viewarticle();
            }
            else
            {
                Favoritearticledisplay();
            }
        }

        private void TheEnd_Click(object sender, EventArgs e) {
            tbUrl.ResetText();
        }

        private void btUp_Click(object sender, EventArgs e) {
            try
            {
                num -= 1;
                lbRssTitle.SelectedIndex -= 1;
            }
            catch { }
        }

        private void btDown_Click(object sender, EventArgs e) {
            try
            {
                num += 1;

                lbRssTitle.SelectedIndex += 1;
            }
            catch { }
        }

        private void btFavorite_Click(object sender, EventArgs e) {
            if (!ItemDatas.ContainsKey(ToLink[num].link) || !ItemDatas.ContainsValue(ToLink[num].Title))
            {
                wbBrowser.Navigate(ToLink[lbRssTitle.SelectedIndex].link);
                ItemDatas.Add(wbBrowser.Url.ToString(), lbRssTitle.SelectedItem.ToString());
            }
            else
            {
                return;
            }
            

        }
        private void btIt_Click(object sender, EventArgs e) {
            Summarize("https://news.yahoo.co.jp/rss/topics/it.xml");
            flg = 0;
        }

        private void btSport_Click(object sender, EventArgs e) {
            Summarize("https://news.yahoo.co.jp/rss/topics/sports.xml");
            flg = 0;
        }

        private void btBusiness_Click(object sender, EventArgs e) {
            Summarize("https://news.yahoo.co.jp/rss/categories/business.xml");
            flg = 0;
        }
        public void Summarize(string urls) {
            using (var wc = new WebClient())
            {
                lbRssTitle.Items.Clear();
                try
                {
                    var ulr = wc.OpenRead(urls);
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
                catch (Exception) { }

            }
        }

        private void btScience_Click(object sender, EventArgs e) {
            Summarize("https://news.yahoo.co.jp/rss/categories/science.xml");
            flg = 0;
        }

        //登録した記事をlbRssTitleに表示
        private void btFF10_Click(object sender, EventArgs e) {

            lbRssTitle.Items.Clear();
            foreach (var item in ItemDatas)
            {
                lbRssTitle.Items.Add(item.Value);
                
            }
            flg = 1;
        }

        //記事を表示
        public void Viewarticle() {
            num = lbRssTitle.SelectedIndex;
            wbBrowser.Navigate(ToLink[num].link);
        }

        //お気に入りに居れた記事をwebBrowserに表示
        public void Favoritearticledisplay() {

            foreach (var item in ItemDatas)
            {

                UrlsDatas.Add(plus,item.Key);
                plus++;
            }
            wbBrowser.Navigate(UrlsDatas[lbRssTitle.SelectedIndex]);
            UrlsDatas.Clear();
            plus = 0;
        }
    }
}
