
namespace CalendarApp {
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btDayCalc = new System.Windows.Forms.Button();
            this.tbMeesge = new System.Windows.Forms.TextBox();
            this.PlusYear = new System.Windows.Forms.Button();
            this.MinusYear = new System.Windows.Forms.Button();
            this.PlusMonth = new System.Windows.Forms.Button();
            this.MinusMonth = new System.Windows.Forms.Button();
            this.PlusDay = new System.Windows.Forms.Button();
            this.MinusDay = new System.Windows.Forms.Button();
            this.now = new System.Windows.Forms.TextBox();
            this.btAge = new System.Windows.Forms.Button();
            this.tmTimeDisp = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpDate.Location = new System.Drawing.Point(164, 21);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(377, 55);
            this.dtpDate.TabIndex = 1;
            // 
            // btDayCalc
            // 
            this.btDayCalc.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDayCalc.Location = new System.Drawing.Point(164, 84);
            this.btDayCalc.Margin = new System.Windows.Forms.Padding(4);
            this.btDayCalc.Name = "btDayCalc";
            this.btDayCalc.Size = new System.Drawing.Size(133, 79);
            this.btDayCalc.TabIndex = 2;
            this.btDayCalc.Text = "日数計算";
            this.btDayCalc.UseVisualStyleBackColor = true;
            this.btDayCalc.Click += new System.EventHandler(this.btDayCalc_Click);
            // 
            // tbMeesge
            // 
            this.tbMeesge.Location = new System.Drawing.Point(304, 220);
            this.tbMeesge.Name = "tbMeesge";
            this.tbMeesge.Size = new System.Drawing.Size(237, 22);
            this.tbMeesge.TabIndex = 3;
            // 
            // PlusYear
            // 
            this.PlusYear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PlusYear.Location = new System.Drawing.Point(304, 112);
            this.PlusYear.Name = "PlusYear";
            this.PlusYear.Size = new System.Drawing.Size(75, 49);
            this.PlusYear.TabIndex = 4;
            this.PlusYear.Text = "+年";
            this.PlusYear.UseVisualStyleBackColor = true;
            this.PlusYear.Click += new System.EventHandler(this.PlusYear_Click);
            // 
            // MinusYear
            // 
            this.MinusYear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MinusYear.Location = new System.Drawing.Point(304, 167);
            this.MinusYear.Name = "MinusYear";
            this.MinusYear.Size = new System.Drawing.Size(75, 47);
            this.MinusYear.TabIndex = 5;
            this.MinusYear.Text = "-年";
            this.MinusYear.UseVisualStyleBackColor = true;
            this.MinusYear.Click += new System.EventHandler(this.MinusYear_Click);
            // 
            // PlusMonth
            // 
            this.PlusMonth.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PlusMonth.Location = new System.Drawing.Point(385, 112);
            this.PlusMonth.Name = "PlusMonth";
            this.PlusMonth.Size = new System.Drawing.Size(75, 49);
            this.PlusMonth.TabIndex = 6;
            this.PlusMonth.Text = "+月";
            this.PlusMonth.UseVisualStyleBackColor = true;
            this.PlusMonth.Click += new System.EventHandler(this.PlusMonth_Click);
            // 
            // MinusMonth
            // 
            this.MinusMonth.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MinusMonth.Location = new System.Drawing.Point(385, 167);
            this.MinusMonth.Name = "MinusMonth";
            this.MinusMonth.Size = new System.Drawing.Size(75, 47);
            this.MinusMonth.TabIndex = 7;
            this.MinusMonth.Text = "-月";
            this.MinusMonth.UseVisualStyleBackColor = true;
            this.MinusMonth.Click += new System.EventHandler(this.MinusMonth_Click);
            // 
            // PlusDay
            // 
            this.PlusDay.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PlusDay.Location = new System.Drawing.Point(466, 112);
            this.PlusDay.Name = "PlusDay";
            this.PlusDay.Size = new System.Drawing.Size(75, 51);
            this.PlusDay.TabIndex = 8;
            this.PlusDay.Text = "+日";
            this.PlusDay.UseVisualStyleBackColor = true;
            this.PlusDay.Click += new System.EventHandler(this.PlusDay_Click);
            // 
            // MinusDay
            // 
            this.MinusDay.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MinusDay.Location = new System.Drawing.Point(466, 167);
            this.MinusDay.Name = "MinusDay";
            this.MinusDay.Size = new System.Drawing.Size(75, 47);
            this.MinusDay.TabIndex = 9;
            this.MinusDay.Text = "-日";
            this.MinusDay.UseVisualStyleBackColor = true;
            this.MinusDay.Click += new System.EventHandler(this.MinusDay_Click);
            // 
            // now
            // 
            this.now.BackColor = System.Drawing.SystemColors.MenuText;
            this.now.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.now.ForeColor = System.Drawing.Color.LawnGreen;
            this.now.Location = new System.Drawing.Point(304, 84);
            this.now.Name = "now";
            this.now.Size = new System.Drawing.Size(237, 23);
            this.now.TabIndex = 10;
            // 
            // btAge
            // 
            this.btAge.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAge.Location = new System.Drawing.Point(164, 171);
            this.btAge.Name = "btAge";
            this.btAge.Size = new System.Drawing.Size(133, 71);
            this.btAge.TabIndex = 11;
            this.btAge.Text = "年齢";
            this.btAge.UseVisualStyleBackColor = true;
            this.btAge.Click += new System.EventHandler(this.btAge_Click);
            // 
            // tmTimeDisp
            // 
            this.tmTimeDisp.Interval = 500;
            this.tmTimeDisp.Tick += new System.EventHandler(this.tmTimeDisp_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 260);
            this.Controls.Add(this.btAge);
            this.Controls.Add(this.now);
            this.Controls.Add(this.MinusDay);
            this.Controls.Add(this.PlusDay);
            this.Controls.Add(this.MinusMonth);
            this.Controls.Add(this.PlusMonth);
            this.Controls.Add(this.MinusYear);
            this.Controls.Add(this.PlusYear);
            this.Controls.Add(this.tbMeesge);
            this.Controls.Add(this.btDayCalc);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CalendarApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btDayCalc;
        private System.Windows.Forms.TextBox tbMeesge;
        private System.Windows.Forms.Button PlusYear;
        private System.Windows.Forms.Button MinusYear;
        private System.Windows.Forms.Button PlusMonth;
        private System.Windows.Forms.Button MinusMonth;
        private System.Windows.Forms.Button PlusDay;
        private System.Windows.Forms.Button MinusDay;
        private System.Windows.Forms.TextBox now;
        private System.Windows.Forms.Button btAge;
        private System.Windows.Forms.Timer tmTimeDisp;
    }
}

