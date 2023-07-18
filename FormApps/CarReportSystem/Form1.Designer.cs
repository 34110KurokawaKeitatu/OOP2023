
namespace CarReportSystem {
    partial class Form1 {
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.記録者 = new System.Windows.Forms.Label();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbMaker = new System.Windows.Forms.GroupBox();
            this.rbAUDI = new System.Windows.Forms.RadioButton();
            this.rbBMW = new System.Windows.Forms.RadioButton();
            this.rbSUBARU = new System.Windows.Forms.RadioButton();
            this.rbSUZUKI = new System.Windows.Forms.RadioButton();
            this.rbMAZDA = new System.Windows.Forms.RadioButton();
            this.rbNISSAN = new System.Windows.Forms.RadioButton();
            this.rbTOYOTA = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRP = new System.Windows.Forms.TextBox();
            this.dgvCarReports = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btImageOpenReport = new System.Windows.Forms.Button();
            this.btDeleteReport = new System.Windows.Forms.Button();
            this.btAddReport = new System.Windows.Forms.Button();
            this.btModyfiReport = new System.Windows.Forms.Button();
            this.btImageDeleteReport = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存CtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsInfoText = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbCarImage = new System.Windows.Forms.PictureBox();
            this.cdColor = new System.Windows.Forms.ColorDialog();
            this.gbMaker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReports)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(90, 43);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(230, 19);
            this.dtpDate.TabIndex = 1;
            // 
            // 記録者
            // 
            this.記録者.AutoSize = true;
            this.記録者.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.記録者.Location = new System.Drawing.Point(39, 79);
            this.記録者.Name = "記録者";
            this.記録者.Size = new System.Drawing.Size(46, 13);
            this.記録者.TabIndex = 2;
            this.記録者.Text = "記録者";
            // 
            // cbAuthor
            // 
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(91, 72);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(229, 20);
            this.cbAuthor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "メーカー";
            // 
            // gbMaker
            // 
            this.gbMaker.Controls.Add(this.rbAUDI);
            this.gbMaker.Controls.Add(this.rbBMW);
            this.gbMaker.Controls.Add(this.rbSUBARU);
            this.gbMaker.Controls.Add(this.rbSUZUKI);
            this.gbMaker.Controls.Add(this.rbMAZDA);
            this.gbMaker.Controls.Add(this.rbNISSAN);
            this.gbMaker.Controls.Add(this.rbTOYOTA);
            this.gbMaker.Location = new System.Drawing.Point(91, 100);
            this.gbMaker.Name = "gbMaker";
            this.gbMaker.Size = new System.Drawing.Size(229, 83);
            this.gbMaker.TabIndex = 5;
            this.gbMaker.TabStop = false;
            // 
            // rbAUDI
            // 
            this.rbAUDI.AutoSize = true;
            this.rbAUDI.Location = new System.Drawing.Point(7, 57);
            this.rbAUDI.Name = "rbAUDI";
            this.rbAUDI.Size = new System.Drawing.Size(50, 16);
            this.rbAUDI.TabIndex = 6;
            this.rbAUDI.TabStop = true;
            this.rbAUDI.Tag = "6";
            this.rbAUDI.Text = "AUDI";
            this.rbAUDI.UseVisualStyleBackColor = true;
            // 
            // rbBMW
            // 
            this.rbBMW.AutoSize = true;
            this.rbBMW.Location = new System.Drawing.Point(153, 35);
            this.rbBMW.Name = "rbBMW";
            this.rbBMW.Size = new System.Drawing.Size(49, 16);
            this.rbBMW.TabIndex = 5;
            this.rbBMW.TabStop = true;
            this.rbBMW.Tag = "5";
            this.rbBMW.Text = "BMW";
            this.rbBMW.UseVisualStyleBackColor = true;
            // 
            // rbSUBARU
            // 
            this.rbSUBARU.AutoSize = true;
            this.rbSUBARU.Location = new System.Drawing.Point(82, 35);
            this.rbSUBARU.Name = "rbSUBARU";
            this.rbSUBARU.Size = new System.Drawing.Size(70, 16);
            this.rbSUBARU.TabIndex = 4;
            this.rbSUBARU.TabStop = true;
            this.rbSUBARU.Tag = "4";
            this.rbSUBARU.Text = "SUBARU";
            this.rbSUBARU.UseVisualStyleBackColor = true;
            // 
            // rbSUZUKI
            // 
            this.rbSUZUKI.AutoSize = true;
            this.rbSUZUKI.Location = new System.Drawing.Point(7, 34);
            this.rbSUZUKI.Name = "rbSUZUKI";
            this.rbSUZUKI.Size = new System.Drawing.Size(63, 16);
            this.rbSUZUKI.TabIndex = 3;
            this.rbSUZUKI.TabStop = true;
            this.rbSUZUKI.Tag = "3";
            this.rbSUZUKI.Text = "SUZUKI";
            this.rbSUZUKI.UseVisualStyleBackColor = true;
            // 
            // rbMAZDA
            // 
            this.rbMAZDA.AutoSize = true;
            this.rbMAZDA.Location = new System.Drawing.Point(153, 12);
            this.rbMAZDA.Name = "rbMAZDA";
            this.rbMAZDA.Size = new System.Drawing.Size(63, 16);
            this.rbMAZDA.TabIndex = 2;
            this.rbMAZDA.TabStop = true;
            this.rbMAZDA.Tag = "2";
            this.rbMAZDA.Text = "MAZDA";
            this.rbMAZDA.UseVisualStyleBackColor = true;
            // 
            // rbNISSAN
            // 
            this.rbNISSAN.AutoSize = true;
            this.rbNISSAN.Location = new System.Drawing.Point(82, 12);
            this.rbNISSAN.Name = "rbNISSAN";
            this.rbNISSAN.Size = new System.Drawing.Size(64, 16);
            this.rbNISSAN.TabIndex = 1;
            this.rbNISSAN.TabStop = true;
            this.rbNISSAN.Tag = "1";
            this.rbNISSAN.Text = "NISSAN";
            this.rbNISSAN.UseVisualStyleBackColor = true;
            // 
            // rbTOYOTA
            // 
            this.rbTOYOTA.AutoSize = true;
            this.rbTOYOTA.Checked = true;
            this.rbTOYOTA.Location = new System.Drawing.Point(7, 12);
            this.rbTOYOTA.Name = "rbTOYOTA";
            this.rbTOYOTA.Size = new System.Drawing.Size(68, 16);
            this.rbTOYOTA.TabIndex = 0;
            this.rbTOYOTA.TabStop = true;
            this.rbTOYOTA.Tag = "0";
            this.rbTOYOTA.Text = "TOYOTA";
            this.rbTOYOTA.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "車名";
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(90, 207);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(230, 20);
            this.cbCarName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "レポート";
            // 
            // tbRP
            // 
            this.tbRP.Location = new System.Drawing.Point(91, 260);
            this.tbRP.Name = "tbRP";
            this.tbRP.Size = new System.Drawing.Size(229, 19);
            this.tbRP.TabIndex = 9;
            // 
            // dgvCarReports
            // 
            this.dgvCarReports.AllowUserToAddRows = false;
            this.dgvCarReports.AllowUserToDeleteRows = false;
            this.dgvCarReports.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvCarReports.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCarReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarReports.Location = new System.Drawing.Point(91, 314);
            this.dgvCarReports.MultiSelect = false;
            this.dgvCarReports.Name = "dgvCarReports";
            this.dgvCarReports.ReadOnly = true;
            this.dgvCarReports.RowTemplate.Height = 21;
            this.dgvCarReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarReports.Size = new System.Drawing.Size(678, 181);
            this.dgvCarReports.TabIndex = 10;
            this.dgvCarReports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarReports_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "記事一覧";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "画像";
            // 
            // btImageOpenReport
            // 
            this.btImageOpenReport.BackColor = System.Drawing.Color.Silver;
            this.btImageOpenReport.Location = new System.Drawing.Point(393, 36);
            this.btImageOpenReport.Name = "btImageOpenReport";
            this.btImageOpenReport.Size = new System.Drawing.Size(75, 23);
            this.btImageOpenReport.TabIndex = 13;
            this.btImageOpenReport.Text = "開く...";
            this.btImageOpenReport.UseVisualStyleBackColor = false;
            this.btImageOpenReport.Click += new System.EventHandler(this.btImageOpenReport_Click);
            // 
            // btDeleteReport
            // 
            this.btDeleteReport.BackColor = System.Drawing.Color.Silver;
            this.btDeleteReport.Location = new System.Drawing.Point(555, 285);
            this.btDeleteReport.Name = "btDeleteReport";
            this.btDeleteReport.Size = new System.Drawing.Size(75, 23);
            this.btDeleteReport.TabIndex = 14;
            this.btDeleteReport.Text = "削除";
            this.btDeleteReport.UseVisualStyleBackColor = false;
            this.btDeleteReport.Click += new System.EventHandler(this.btDeleteReport_Click);
            // 
            // btAddReport
            // 
            this.btAddReport.BackColor = System.Drawing.Color.DarkGray;
            this.btAddReport.Location = new System.Drawing.Point(393, 285);
            this.btAddReport.Name = "btAddReport";
            this.btAddReport.Size = new System.Drawing.Size(75, 23);
            this.btAddReport.TabIndex = 16;
            this.btAddReport.Text = "追加";
            this.btAddReport.UseVisualStyleBackColor = false;
            this.btAddReport.Click += new System.EventHandler(this.btAddReport_Click);
            // 
            // btModyfiReport
            // 
            this.btModyfiReport.BackColor = System.Drawing.Color.Silver;
            this.btModyfiReport.Location = new System.Drawing.Point(474, 37);
            this.btModyfiReport.Name = "btModyfiReport";
            this.btModyfiReport.Size = new System.Drawing.Size(75, 23);
            this.btModyfiReport.TabIndex = 17;
            this.btModyfiReport.Text = "修正";
            this.btModyfiReport.UseVisualStyleBackColor = false;
            this.btModyfiReport.Click += new System.EventHandler(this.btModyfiReport_Click);
            // 
            // btImageDeleteReport
            // 
            this.btImageDeleteReport.BackColor = System.Drawing.Color.Silver;
            this.btImageDeleteReport.Location = new System.Drawing.Point(474, 285);
            this.btImageDeleteReport.Name = "btImageDeleteReport";
            this.btImageDeleteReport.Size = new System.Drawing.Size(75, 23);
            this.btImageDeleteReport.TabIndex = 18;
            this.btImageDeleteReport.Text = "削除";
            this.btImageDeleteReport.UseVisualStyleBackColor = false;
            this.btImageDeleteReport.Click += new System.EventHandler(this.btImageDeleteReport_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.ヘルプHToolStripMenuItem,
            this.ヘルプHToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くToolStripMenuItem,
            this.保存CtrlSToolStripMenuItem,
            this.終了XToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル<&F>";
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.開くToolStripMenuItem.Text = "開く...<&O>";
            // 
            // 保存CtrlSToolStripMenuItem
            // 
            this.保存CtrlSToolStripMenuItem.Name = "保存CtrlSToolStripMenuItem";
            this.保存CtrlSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存CtrlSToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.保存CtrlSToolStripMenuItem.Text = "保存...<S>";
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.終了XToolStripMenuItem.Text = "終了(&X)";
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョン情報ToolStripMenuItem});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.ヘルプHToolStripMenuItem.Text = "編集&(F)";
            // 
            // バージョン情報ToolStripMenuItem
            // 
            this.バージョン情報ToolStripMenuItem.Name = "バージョン情報ToolStripMenuItem";
            this.バージョン情報ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.バージョン情報ToolStripMenuItem.Text = "バージョン情報";
            // 
            // ヘルプHToolStripMenuItem1
            // 
            this.ヘルプHToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョン情報ToolStripMenuItem1});
            this.ヘルプHToolStripMenuItem1.Name = "ヘルプHToolStripMenuItem1";
            this.ヘルプHToolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
            this.ヘルプHToolStripMenuItem1.Text = "ヘルプ &(H)";
            // 
            // バージョン情報ToolStripMenuItem1
            // 
            this.バージョン情報ToolStripMenuItem1.Name = "バージョン情報ToolStripMenuItem1";
            this.バージョン情報ToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.バージョン情報ToolStripMenuItem1.Text = "バージョン情報";
            this.バージョン情報ToolStripMenuItem1.Click += new System.EventHandler(this.バージョン情報ToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "ofdImageFileOpen";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsInfoText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 512);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsInfoText
            // 
            this.tsInfoText.Name = "tsInfoText";
            this.tsInfoText.Size = new System.Drawing.Size(118, 17);
            this.tsInfoText.Text = "toolStripStatusLabel1";
            // 
            // pbCarImage
            // 
            this.pbCarImage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbCarImage.Location = new System.Drawing.Point(393, 72);
            this.pbCarImage.Name = "pbCarImage";
            this.pbCarImage.Size = new System.Drawing.Size(376, 213);
            this.pbCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCarImage.TabIndex = 15;
            this.pbCarImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btImageDeleteReport);
            this.Controls.Add(this.btModyfiReport);
            this.Controls.Add(this.btAddReport);
            this.Controls.Add(this.pbCarImage);
            this.Controls.Add(this.btDeleteReport);
            this.Controls.Add(this.btImageOpenReport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvCarReports);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbMaker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.記録者);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRP);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "カーレポート管理システム";
            this.gbMaker.ResumeLayout(false);
            this.gbMaker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReports)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label 記録者;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbMaker;
        private System.Windows.Forms.RadioButton rbSUZUKI;
        private System.Windows.Forms.RadioButton rbMAZDA;
        private System.Windows.Forms.RadioButton rbNISSAN;
        private System.Windows.Forms.RadioButton rbTOYOTA;
        private System.Windows.Forms.RadioButton rbAUDI;
        private System.Windows.Forms.RadioButton rbBMW;
        private System.Windows.Forms.RadioButton rbSUBARU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRP;
        private System.Windows.Forms.DataGridView dgvCarReports;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btImageOpenReport;
        private System.Windows.Forms.Button btDeleteReport;
        private System.Windows.Forms.PictureBox pbCarImage;
        private System.Windows.Forms.Button btAddReport;
        private System.Windows.Forms.Button btModyfiReport;
        private System.Windows.Forms.Button btImageDeleteReport;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存CtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsInfoText;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報ToolStripMenuItem1;
        private System.Windows.Forms.ColorDialog cdColor;
    }
}

