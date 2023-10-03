
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
            this.btUp = new System.Windows.Forms.Button();
            this.btDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(62, 31);
            this.tbUrl.Multiline = true;
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(623, 37);
            this.tbUrl.TabIndex = 0;
            this.tbUrl.TextChanged += new System.EventHandler(this.tbUrl_TextChanged);
            // 
            // btGetUlr
            // 
            this.btGetUlr.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.btGetUlr.Location = new System.Drawing.Point(628, 31);
            this.btGetUlr.Name = "btGetUlr";
            this.btGetUlr.Size = new System.Drawing.Size(57, 37);
            this.btGetUlr.TabIndex = 1;
            this.btGetUlr.Text = "🔍";
            this.btGetUlr.UseVisualStyleBackColor = true;
            this.btGetUlr.Click += new System.EventHandler(this.btGetUlr_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(62, 74);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(623, 112);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(62, 192);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(623, 325);
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
            this.TheEnd.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TheEnd.ForeColor = System.Drawing.Color.Red;
            this.TheEnd.Location = new System.Drawing.Point(602, 31);
            this.TheEnd.Name = "TheEnd";
            this.TheEnd.Size = new System.Drawing.Size(35, 37);
            this.TheEnd.TabIndex = 5;
            this.TheEnd.Text = "×";
            this.TheEnd.UseVisualStyleBackColor = true;
            this.TheEnd.Click += new System.EventHandler(this.TheEnd_Click);
            // 
            // btUp
            // 
            this.btUp.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.btUp.Location = new System.Drawing.Point(691, 74);
            this.btUp.Name = "btUp";
            this.btUp.Size = new System.Drawing.Size(57, 49);
            this.btUp.TabIndex = 6;
            this.btUp.Text = "⇑";
            this.btUp.UseVisualStyleBackColor = true;
            this.btUp.Click += new System.EventHandler(this.btUp_Click);
            // 
            // btDown
            // 
            this.btDown.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.btDown.Location = new System.Drawing.Point(691, 142);
            this.btDown.Name = "btDown";
            this.btDown.Size = new System.Drawing.Size(57, 44);
            this.btDown.TabIndex = 7;
            this.btDown.Text = "⇓";
            this.btDown.UseVisualStyleBackColor = true;
            this.btDown.Click += new System.EventHandler(this.btDown_Click);
            // 
            // btGet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 589);
            this.Controls.Add(this.btDown);
            this.Controls.Add(this.btUp);
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
        private System.Windows.Forms.Button btUp;
        private System.Windows.Forms.Button btDown;
    }
}

