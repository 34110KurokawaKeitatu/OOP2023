﻿
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
            this.btFavorite = new System.Windows.Forms.Button();
            this.btIt = new System.Windows.Forms.Button();
            this.btSport = new System.Windows.Forms.Button();
            this.btBusiness = new System.Windows.Forms.Button();
            this.btScience = new System.Windows.Forms.Button();
            this.btFF10 = new System.Windows.Forms.Button();
            this.btLocal = new System.Windows.Forms.Button();
            this.btEntertainment = new System.Windows.Forms.Button();
            this.btCar = new System.Windows.Forms.Button();
            this.btGrandPegasus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.BackColor = System.Drawing.Color.White;
            this.tbUrl.Font = new System.Drawing.Font("BIZ UDPゴシック", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.ForeColor = System.Drawing.Color.Black;
            this.tbUrl.Location = new System.Drawing.Point(49, 12);
            this.tbUrl.Multiline = true;
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(1207, 37);
            this.tbUrl.TabIndex = 0;
            // 
            // btGetUlr
            // 
            this.btGetUlr.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.btGetUlr.Location = new System.Drawing.Point(1288, 12);
            this.btGetUlr.Name = "btGetUlr";
            this.btGetUlr.Size = new System.Drawing.Size(39, 37);
            this.btGetUlr.TabIndex = 1;
            this.btGetUlr.Text = "🔍";
            this.btGetUlr.UseVisualStyleBackColor = true;
            this.btGetUlr.Click += new System.EventHandler(this.btGetUlr_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.Font = new System.Drawing.Font("BIZ UDPゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 16;
            this.lbRssTitle.Location = new System.Drawing.Point(49, 89);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(1278, 132);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(49, 231);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(1278, 404);
            this.wbBrowser.TabIndex = 3;
            // 
            // tbUlrBox
            // 
            this.tbUlrBox.Location = new System.Drawing.Point(49, 641);
            this.tbUlrBox.Name = "tbUlrBox";
            this.tbUlrBox.Size = new System.Drawing.Size(1278, 19);
            this.tbUlrBox.TabIndex = 4;
            // 
            // TheEnd
            // 
            this.TheEnd.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TheEnd.ForeColor = System.Drawing.Color.Red;
            this.TheEnd.Location = new System.Drawing.Point(1252, 12);
            this.TheEnd.Name = "TheEnd";
            this.TheEnd.Size = new System.Drawing.Size(36, 37);
            this.TheEnd.TabIndex = 5;
            this.TheEnd.Text = "×";
            this.TheEnd.UseVisualStyleBackColor = true;
            this.TheEnd.Click += new System.EventHandler(this.TheEnd_Click);
            // 
            // btUp
            // 
            this.btUp.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.btUp.Location = new System.Drawing.Point(1333, 89);
            this.btUp.Name = "btUp";
            this.btUp.Size = new System.Drawing.Size(43, 57);
            this.btUp.TabIndex = 6;
            this.btUp.Text = "▲";
            this.btUp.UseVisualStyleBackColor = true;
            this.btUp.Click += new System.EventHandler(this.btUp_Click);
            // 
            // btDown
            // 
            this.btDown.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.btDown.Location = new System.Drawing.Point(1333, 168);
            this.btDown.Name = "btDown";
            this.btDown.Size = new System.Drawing.Size(43, 57);
            this.btDown.TabIndex = 7;
            this.btDown.Text = "▼";
            this.btDown.UseVisualStyleBackColor = true;
            this.btDown.Click += new System.EventHandler(this.btDown_Click);
            // 
            // btFavorite
            // 
            this.btFavorite.BackColor = System.Drawing.Color.Orange;
            this.btFavorite.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btFavorite.Location = new System.Drawing.Point(1195, 55);
            this.btFavorite.Name = "btFavorite";
            this.btFavorite.Size = new System.Drawing.Size(61, 37);
            this.btFavorite.TabIndex = 8;
            this.btFavorite.Text = "★";
            this.btFavorite.UseVisualStyleBackColor = false;
            this.btFavorite.Click += new System.EventHandler(this.btFavorite_Click);
            // 
            // btIt
            // 
            this.btIt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btIt.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btIt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btIt.Location = new System.Drawing.Point(219, 55);
            this.btIt.Name = "btIt";
            this.btIt.Size = new System.Drawing.Size(61, 37);
            this.btIt.TabIndex = 13;
            this.btIt.Text = "💻";
            this.btIt.UseVisualStyleBackColor = false;
            this.btIt.Click += new System.EventHandler(this.btIt_Click);
            // 
            // btSport
            // 
            this.btSport.BackColor = System.Drawing.Color.Blue;
            this.btSport.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.btSport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSport.Location = new System.Drawing.Point(164, 55);
            this.btSport.Name = "btSport";
            this.btSport.Size = new System.Drawing.Size(61, 37);
            this.btSport.TabIndex = 14;
            this.btSport.Text = "🏀";
            this.btSport.UseVisualStyleBackColor = false;
            this.btSport.Click += new System.EventHandler(this.btSport_Click);
            // 
            // btBusiness
            // 
            this.btBusiness.BackColor = System.Drawing.Color.Magenta;
            this.btBusiness.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btBusiness.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBusiness.Location = new System.Drawing.Point(107, 55);
            this.btBusiness.Name = "btBusiness";
            this.btBusiness.Size = new System.Drawing.Size(61, 37);
            this.btBusiness.TabIndex = 15;
            this.btBusiness.Text = "💰";
            this.btBusiness.UseVisualStyleBackColor = false;
            this.btBusiness.Click += new System.EventHandler(this.btBusiness_Click);
            // 
            // btScience
            // 
            this.btScience.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btScience.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btScience.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btScience.Location = new System.Drawing.Point(49, 55);
            this.btScience.Name = "btScience";
            this.btScience.Size = new System.Drawing.Size(61, 37);
            this.btScience.TabIndex = 16;
            this.btScience.Text = "🧪";
            this.btScience.UseVisualStyleBackColor = false;
            this.btScience.Click += new System.EventHandler(this.btScience_Click);
            // 
            // btFF10
            // 
            this.btFF10.BackColor = System.Drawing.Color.Gold;
            this.btFF10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btFF10.Location = new System.Drawing.Point(1252, 55);
            this.btFF10.Name = "btFF10";
            this.btFF10.Size = new System.Drawing.Size(75, 37);
            this.btFF10.TabIndex = 17;
            this.btFF10.Text = "■";
            this.btFF10.UseVisualStyleBackColor = false;
            this.btFF10.Click += new System.EventHandler(this.btFF10_Click);
            // 
            // btLocal
            // 
            this.btLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btLocal.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btLocal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLocal.Location = new System.Drawing.Point(274, 55);
            this.btLocal.Name = "btLocal";
            this.btLocal.Size = new System.Drawing.Size(61, 37);
            this.btLocal.TabIndex = 18;
            this.btLocal.Text = "🗺";
            this.btLocal.UseVisualStyleBackColor = false;
            this.btLocal.Click += new System.EventHandler(this.btLocal_Click);
            // 
            // btEntertainment
            // 
            this.btEntertainment.BackColor = System.Drawing.Color.DarkViolet;
            this.btEntertainment.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btEntertainment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEntertainment.Location = new System.Drawing.Point(332, 55);
            this.btEntertainment.Name = "btEntertainment";
            this.btEntertainment.Size = new System.Drawing.Size(61, 37);
            this.btEntertainment.TabIndex = 19;
            this.btEntertainment.Text = "👥";
            this.btEntertainment.UseVisualStyleBackColor = false;
            this.btEntertainment.Click += new System.EventHandler(this.btEntertainment_Click);
            // 
            // btCar
            // 
            this.btCar.BackColor = System.Drawing.Color.Crimson;
            this.btCar.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCar.Location = new System.Drawing.Point(389, 55);
            this.btCar.Name = "btCar";
            this.btCar.Size = new System.Drawing.Size(61, 37);
            this.btCar.TabIndex = 20;
            this.btCar.Text = "🚙";
            this.btCar.UseVisualStyleBackColor = false;
            this.btCar.Click += new System.EventHandler(this.btCar_Click);
            // 
            // btGrandPegasus
            // 
            this.btGrandPegasus.BackColor = System.Drawing.Color.Blue;
            this.btGrandPegasus.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btGrandPegasus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btGrandPegasus.Location = new System.Drawing.Point(447, 55);
            this.btGrandPegasus.Name = "btGrandPegasus";
            this.btGrandPegasus.Size = new System.Drawing.Size(61, 37);
            this.btGrandPegasus.TabIndex = 21;
            this.btGrandPegasus.Text = "🐓";
            this.btGrandPegasus.UseVisualStyleBackColor = false;
            this.btGrandPegasus.Click += new System.EventHandler(this.btGrandPegasus_Click);
            // 
            // btGet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1406, 672);
            this.Controls.Add(this.btGrandPegasus);
            this.Controls.Add(this.btCar);
            this.Controls.Add(this.btEntertainment);
            this.Controls.Add(this.btLocal);
            this.Controls.Add(this.btFF10);
            this.Controls.Add(this.btScience);
            this.Controls.Add(this.btBusiness);
            this.Controls.Add(this.btSport);
            this.Controls.Add(this.btIt);
            this.Controls.Add(this.btFavorite);
            this.Controls.Add(this.btDown);
            this.Controls.Add(this.btUp);
            this.Controls.Add(this.TheEnd);
            this.Controls.Add(this.tbUlrBox);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGetUlr);
            this.Controls.Add(this.tbUrl);
            this.Name = "btGet";
            this.Text = "RSS";
            this.Load += new System.EventHandler(this.btGet_Load);
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
        private System.Windows.Forms.Button btFavorite;
        private System.Windows.Forms.Button btIt;
        private System.Windows.Forms.Button btSport;
        private System.Windows.Forms.Button btBusiness;
        private System.Windows.Forms.Button btScience;
        private System.Windows.Forms.Button btFF10;
        private System.Windows.Forms.Button btLocal;
        private System.Windows.Forms.Button btEntertainment;
        private System.Windows.Forms.Button btCar;
        private System.Windows.Forms.Button btGrandPegasus;
    }
}

