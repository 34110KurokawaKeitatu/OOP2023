
namespace RssReader {
    partial class btGet {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btGetUlr = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.tbUlrBox = new System.Windows.Forms.TextBox();
            this.TheEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(62, 13);
            this.tbUrl.Multiline = true;
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(623, 53);
            this.tbUrl.TabIndex = 0;
            this.tbUrl.TextChanged += new System.EventHandler(this.tbUrl_TextChanged);
            // 
            // btGetUlr
            // 
            this.btGetUlr.Location = new System.Drawing.Point(691, 15);
            this.btGetUlr.Name = "btGetUlr";
            this.btGetUlr.Size = new System.Drawing.Size(72, 51);
            this.btGetUlr.TabIndex = 1;
            this.btGetUlr.Text = "取得";
            this.btGetUlr.UseVisualStyleBackColor = true;
            this.btGetUlr.Click += new System.EventHandler(this.btGetUlr_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(62, 91);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(686, 112);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(62, 210);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(686, 325);
            this.wbBrowser.TabIndex = 3;
            // 
            // tbUlrBox
            // 
            this.tbUlrBox.Location = new System.Drawing.Point(62, 551);
            this.tbUlrBox.Name = "tbUlrBox";
            this.tbUlrBox.Size = new System.Drawing.Size(686, 19);
            this.tbUlrBox.TabIndex = 4;
            // 
            // TheEnd
            // 
            this.TheEnd.Location = new System.Drawing.Point(652, 29);
            this.TheEnd.Name = "TheEnd";
            this.TheEnd.Size = new System.Drawing.Size(22, 23);
            this.TheEnd.TabIndex = 5;
            this.TheEnd.Text = "button1";
            this.TheEnd.UseVisualStyleBackColor = true;
            // 
            // btGet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 589);
            this.Controls.Add(this.TheEnd);
            this.Controls.Add(this.tbUlrBox);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGetUlr);
            this.Controls.Add(this.tbUrl);
            this.Name = "btGet";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btGetUlr;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.TextBox tbUlrBox;
        private System.Windows.Forms.Button TheEnd;
    }
}

